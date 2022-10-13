using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        private const string ImportMessage = "Successfully imported {0}";

        public static void Main(string[] args)
        {
            var context = new CarDealerContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //[09]==========================================================================

            //var suppliersJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Car Dealer\CarDealer\Datasets\suppliers.json");

            //var result = ImportSuppliers(context, suppliersJson);

            //Console.WriteLine(result);

            //[10]==========================================================================

            //var partsJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Car Dealer\CarDealer\Datasets\parts.json");

            //var result = ImportParts(context, partsJson);

            //Console.WriteLine(result);

            //[11]==========================================================================

            //var carsJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Car Dealer\CarDealer\Datasets\cars.json");

            //var result = ImportCars(context, carsJson);

            //Console.WriteLine(result);

            //[12]===========================================================================

            //var customersJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Car Dealer\CarDealer\Datasets\customers.json");

            //var result = ImportCustomers(context, customersJson);

            //Console.WriteLine(result);

            //[13]============================================================================

            //var salesJson = File.ReadAllText(@"C:\SoftUni\Databases Advanced - Entity Framework\11.JSON Processing\01._Import Users_Car Dealer\CarDealer\Datasets\sales.json");

            //var result = ImportSales(context, salesJson);

            //Console.WriteLine(result);

            //[14]============================================================================

            //var result = GetOrderedCustomers(context);

            //Console.WriteLine(result);

            //[15]============================================================================

            //var result = GetCarsFromMakeToyota(context);

            //Console.WriteLine(result);

            //[16]===========================================================================

            //var result = GetLocalSuppliers(context);

            //Console.WriteLine(result);

            //[17]===========================================================================

            //var result = GetCarsWithTheirListOfParts(context);

            //Console.WriteLine(result);

            //[18]===========================================================================

            //var result = GetTotalSalesByCustomer(context);

            //Console.WriteLine(result);

            //[19]==========================================================================

            var result = GetSalesWithAppliedDiscount(context);

            Console.WriteLine(result);
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliers = JsonConvert.DeserializeObject<Supplier[]>(inputJson)
                .ToArray();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return string.Format(ImportMessage, suppliers.Length);
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var suppliersId = context.Suppliers
                .Select(s => s.Id)
                .ToList();

            var parts = JsonConvert.DeserializeObject<Part[]>(inputJson)
                .Where(p => suppliersId.Contains(p.SupplierId))
                .ToArray();

            context.Parts.AddRange(parts);

            context.SaveChanges();

            return string.Format(ImportMessage, parts.Length);
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var cars = JsonConvert.DeserializeObject<Car[]>(inputJson)
                .ToArray();

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return string.Format(ImportMessage, cars.Length);
        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customers = JsonConvert.DeserializeObject<Customer[]>(inputJson)
                .ToArray();

            context.Customers.AddRange(customers);

            context.SaveChanges();

            return string.Format(ImportMessage, customers.Length);
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            //var carsId = context.Cars.Select(c => c.Id).ToList();

            var sales = JsonConvert.DeserializeObject<Sale[]>(inputJson)
                //.Where(s => carsId.Contains(s.CarId))
                .ToArray();

            context.Sales.AddRange(sales);

            context.SaveChanges();

            return string.Format(ImportMessage, sales.Length);
        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var orderedCustomers = context.Customers
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver
                })
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .ToArray();

            var json = JsonConvert.SerializeObject(orderedCustomers, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatString = "dd/MM/yyyy",
                Formatting = Formatting.Indented
            });

            return json;
        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var filteredCars = context.Cars
                .Where(c => c.Make == "Toyota")
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .ToArray();

            var json = JsonConvert.SerializeObject(filteredCars, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            });

            return json;
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var localSuppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count(pc => pc != null)
                })
                .ToArray();

            var json = JsonConvert.SerializeObject(localSuppliers, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            });

            return json;
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TravelledDistance = c.TravelledDistance
                    },
                    parts = c.PartCars.Select(cp => new
                    {
                        Name = cp.Part.Name,
                        Price = $"{cp.Part.Price:F2}"
                    }).ToArray()
                })
                .ToArray();

            var json = JsonConvert.SerializeObject(cars, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            });

            return json;
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var filteredCustomers = context.Customers
                .Where(c => c.Sales.Any(cs => cs != null))
                .Select(c => new
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpendMoney = c.Sales.Sum(cs => cs.Car.PartCars.Sum(pc => pc.Part.Price))
                })
                .OrderByDescending(c => c.SpendMoney)
                .ThenByDescending(c => c.BoughtCars)
                .ToArray();

            DefaultContractResolver contractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var json = JsonConvert.SerializeObject(filteredCustomers, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            });

            return json;
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var filteredSales = context.Sales
                .Take(10)
                .Select(s => new
                {
                    car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    },
                    customerName = s.Customer.Name,
                    Discount = $"{s.Discount:F2}",
                    price = $"{s.Car.PartCars.Sum(cp => cp.Part.Price):F2}",
                    priceWithDiscount = $"{s.Car.PartCars.Sum(cp => cp.Part.Price) * ((100 - s.Discount) / 100):F2}"
                })
                .ToArray();

            var json = JsonConvert.SerializeObject(filteredSales, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            });

            return json;
        }
    }
}