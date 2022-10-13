using AutoMapper;
using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //[01]===================================================================

            //var usersXml = File.ReadAllText("../../../Datasets/users.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<ProductShopProfile>();
            //});

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportUsers(context, usersXml));
            //}

            //[02]======================================================================

            //var productsXml = File.ReadAllText("../../../Datasets/products.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<ProductShopProfile>();
            //});

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportProducts(context, productsXml));
            //}

            //[03]=======================================================================

            //var categoriesXml = File.ReadAllText("../../../Datasets/categories.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<ProductShopProfile>();
            //});

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportCategories(context, categoriesXml));
            //}

            //[04]========================================================================

            //var categoryProductsXml = File.ReadAllText("../../../Datasets/categories-products.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<ProductShopProfile>();
            //});

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportCategoryProducts(context, categoryProductsXml));
            //}

            //[05]=============================================================================

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    Console.WriteLine(GetProductsInRange(context));
            //}

            //[06]============================================================================

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    Console.WriteLine(GetSoldProducts(context));
            //}

            //[07]=============================================================================

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    Console.WriteLine(GetCategoriesByProductsCount(context));
            //}

            //[08]=============================================================================

            //using (ProductShopContext context = new ProductShopContext())
            //{
            //    var userResult = GetUsersWithProducts(context);
            //    File.WriteAllText("../../../result.xml", userResult);
            //}

        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportUserDto[]), new XmlRootAttribute("Users")); //описваме кой обект искаме да deserialize, и посочваме как да го достъпи (root-a)

            var usersDto = (ImportUserDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var users = new List<User>();

            foreach (var userDto in usersDto)
            {
                var user = Mapper.Map<User>(userDto);
                users.Add(user);
            }

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportProductDto[]), new XmlRootAttribute("Products")); //описваме кой обект искаме да deserialize, и посочваме как да го достъпи (root-a)

            var productsDto = (ImportProductDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var products = new List<Product>();

            foreach (var productDto in productsDto)
            {
                var product = Mapper.Map<Product>(productDto); //автоматично мапване

                //var product = new Product // автоматично мапване
                //{
                //    Name = productDto.Name,
                //    Price = productDto.Price,
                //    SellerId = productDto.SellerId,
                //    BuyerId = productDto.BuyerId
                //};
                products.Add(product);
            }

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";
        }

        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCategoryDto[]), new XmlRootAttribute("Categories"));

            var categoriesDto = (ImportCategoryDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var categories = new List<Category>();

            foreach (var categoryDto in categoriesDto)
            {
                if (categoryDto.Name == null)
                {
                    continue;
                }
                var category = Mapper.Map<Category>(categoryDto);
                categories.Add(category);
            }

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCategoryProductDto[]), new XmlRootAttribute("CategoryProducts"));

            var categoryProductsDto = (ImportCategoryProductDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var categoryProducts = new List<CategoryProduct>();

            foreach (var categoryProductDto in categoryProductsDto)
            {
                var product = context.Products.Find(categoryProductDto.ProductId);
                var category = context.Categories.Find(categoryProductDto.CategoryId);

                if (product == null || category == null)
                {
                    continue;
                }

                var categoryProduct = Mapper.Map<CategoryProduct>(categoryProductDto);
                categoryProducts.Add(categoryProduct);
            }

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Count}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context
                .Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ExportProductInRangeDto //не можем да правим анонимни обекти
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
            .OrderBy(p => p.Price)
            .Take(10)
            .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportProductInRangeDto[]), new XmlRootAttribute("Products"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("","")
            });

            xmlSerializer.Serialize(new StringWriter(sb), products, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context
                .Users
                .Where(u => u.ProductsSold.Any(ps => ps != null))
                .Select(u => new ExportUserSoldProductDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    ProductsDto = u.ProductsSold.Select(ps => new ProductDto
                    {
                        Name = ps.Name,
                        Price = ps.Price
                    })
                    .ToArray()
                })
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Take(5)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportUserSoldProductDto[]), new XmlRootAttribute("Users"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), users, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context
                .Categories
                .Select(c => new ExportCategoryDto
                {
                    Name = c.Name,
                    Count = c.CategoryProducts.Count,
                    AveragePrice = decimal.Parse($"{c.CategoryProducts.Average(cp => cp.Product.Price):F2}"),
                    TotalRevenue = decimal.Parse($"{c.CategoryProducts.Sum(cp => cp.Product.Price):F2}")
                })
                .OrderByDescending(c => c.Count)
                .ThenBy(c => c.TotalRevenue)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCategoryDto[]), new XmlRootAttribute("Categories"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), categories, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context
                .Users
                .Where(u => u.ProductsSold.Any())
                .Select(u => new ExportUserAndProductDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProductDto = new SoldProductDto
                    {
                        Count = u.ProductsSold.Count,
                        ProductDtos = u.ProductsSold.Select(p => new ProductDto()
                        {
                            Name = p.Name,
                            Price = p.Price
                        })
                        .OrderByDescending(p => p.Price)
                        .ToArray()
                    }
                })
                .OrderByDescending(u => u.SoldProductDto.Count)
                .Take(10)
                .ToArray();

            var customExport = new ExportCustomUserProductDto
            {
                Count = context
                .Users
                .Count(x => x.ProductsSold.Any()),
                ExportUserAndProductDto = users
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCustomUserProductDto), new XmlRootAttribute("Users"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), customExport, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}