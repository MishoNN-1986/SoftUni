using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        private const string ImportMessage = "Successfully imported {0}";

        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //[01]================================================================================

            //var usersJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Product Shop\ProductShop\Datasets\users.json");

            //var result = ImportUsers(context, usersJson);

            //Console.WriteLine(result);

            //[02]================================================================================

            //var productsJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Product Shop\ProductShop\Datasets\products.json");

            //var result = ImportProducts(context, productsJson);

            //Console.WriteLine(result);

            //[03]=================================================================================

            //var categoriesJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Product Shop\ProductShop\Datasets\categories.json");

            //var result = ImportCategories(context, categoriesJson);

            //Console.WriteLine(result);

            //[04]====================================================================================

            //var categoriesProductsJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Product Shop\ProductShop\Datasets\categories-products.json");

            //var result = ImportCategoryProducts(context, categoriesProductsJson);

            //Console.WriteLine(result);

            //[05]=========================================================================================

            //var result = GetProductsInRange(context);

            //Console.WriteLine(result);

            //[06]=========================================================================================

            //var result = GetSoldProducts(context);

            //Console.WriteLine(result);

            //[07]=========================================================================================

            //var result = GetCategoriesByProductsCount(context);

            //Console.WriteLine(result);

            //[08]=========================================================================================

            var result = GetUsersWithProducts(context);

            Console.WriteLine(result);

        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<User[]>(inputJson)
                .Where(u => u.LastName != null && u.LastName.Length >= 3) //добавяме валидация, за да не вкараме невалидни данни в базата
                .ToArray();

            context.Users.AddRange(users);
            var countOfSavedEntities = context.SaveChanges();

            return string.Format(ImportMessage, countOfSavedEntities);
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<Product[]>(inputJson)
                .Where(p => !string.IsNullOrEmpty(p.Name) && p.Name.Length >= 3)
                .ToArray();

            context.Products.AddRange(products);
            context.SaveChanges();

            return string.Format(ImportMessage, products.Length);
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<Category[]>(inputJson)
                .Where(c => !string.IsNullOrEmpty(c.Name) &&
                            c.Name.Length >= 3 &&
                            c.Name.Length <= 15)
                .ToArray();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return string.Format(ImportMessage, categories.Length);
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoryIds =
                context.Categories
                .Select(x => x.Id)
                .ToList();

            var productIds =
                context.Products
                .Select(x => x.Id)
                .ToList();

            var categoryProducts = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson)
                .Where(cp => categoryIds.Contains(cp.CategoryId)
                            && productIds.Contains(cp.ProductId))
                .ToArray();

            context.AddRange(categoryProducts);
            context.SaveChanges();

            return string.Format(ImportMessage, categoryProducts.Length);

        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var productsInRange = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p =>
                new ProductDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    Seller = $"{p.Seller.FirstName} {p.Seller.LastName}".Trim()
                })
                .OrderBy(p => p.Price)
                .ToArray();

            var json = JsonConvert.SerializeObject(productsInRange, Formatting.Indented);

            return json;
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var filteredUsers = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold
                    .Where(ps => ps.Buyer != null)
                    .Select(ps => new
                    {
                        Name = ps.Name,
                        Price = ps.Price,
                        BuyerFirstName = ps.Buyer.FirstName,
                        BuyerLastName = ps.Buyer.LastName
                    })
                    .ToArray()
                })
                .ToArray();

            DefaultContractResolver contractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };


            var json = JsonConvert.SerializeObject(filteredUsers,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = contractResolver
                });

            return json;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var filteredCategories = context.Categories
                .OrderByDescending(c => c.CategoryProducts.Count)
                .Select(c => new
                {
                    Name = c.Name,
                    NumberOfProducts = c.CategoryProducts.Count,
                    AveragePrice = $"{c.CategoryProducts.Average(cp => cp.Product.Price):F2}",
                    TotalRevenue = $"{c.CategoryProducts.Sum(cp => cp.Product.Price):F2}"
                })
                .ToArray();

            DefaultContractResolver contractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };


            var json = JsonConvert.SerializeObject(filteredCategories,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = contractResolver
                });

            return json;
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var filteredUsers = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderByDescending(u => u.ProductsSold.Count(ps => ps.Buyer != null))
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new
                    {
                        Count = u.ProductsSold
                        .Count(ps => ps.Buyer != null),
                        Product = u.ProductsSold
                    .Where(ps => ps.Buyer != null)
                    .Select(ps => new
                    {
                        Name = ps.Name,
                        Price = ps.Price
                    })
                    .ToArray()
                    }
                })
                .ToArray();

            var result = new
            {
                UsersCount = filteredUsers.Length,
                Users = filteredUsers
            };

            DefaultContractResolver contractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var json = JsonConvert.SerializeObject(result, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver,
                NullValueHandling = NullValueHandling.Ignore
            });

            return json;
        }
    }
}