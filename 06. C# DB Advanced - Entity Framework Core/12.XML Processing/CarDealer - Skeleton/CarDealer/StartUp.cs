using AutoMapper;
using CarDealer.Data;
using CarDealer.Dtos.Export;
using CarDealer.Dtos.Import;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //[09]=========================================================================

            //var suppliersXml = File.ReadAllText("../../../Datasets/suppliers.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<CarDealerProfile>();
            //});

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportSuppliers(context, suppliersXml));
            //}

            //[10]==========================================================================

            //var partsXml = File.ReadAllText("../../../Datasets/parts.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<CarDealerProfile>();
            //});

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportParts(context, partsXml));
            //}

            //[11]==========================================================================

            //var carsXml = File.ReadAllText("../../../Datasets/cars.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<CarDealerProfile>();
            //});

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportCars(context, carsXml));
            //}

            //[12]===========================================================================

            //var customersXml = File.ReadAllText("../../../Datasets/customers.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<CarDealerProfile>();
            //});

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportCustomers(context, customersXml));
            //}

            //[13]============================================================================

            //var salesXml = File.ReadAllText("../../../Datasets/sales.xml");

            //Mapper.Initialize(x =>
            //{
            //    x.AddProfile<CarDealerProfile>();
            //});

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    //context.Database.EnsureCreated();

            //    Console.WriteLine(ImportSales(context, salesXml));
            //}

            //[14]============================================================================

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    Console.WriteLine(GetCarsWithDistance(context));
            //}

            //[15]===========================================================================

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    Console.WriteLine(GetCarsFromMakeBmw(context));
            //}

            //[16]===========================================================================

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    Console.WriteLine(GetLocalSuppliers(context));
            //}

            //[17]===========================================================================

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    Console.WriteLine(GetCarsWithTheirListOfParts(context));
            //}

            //[18]===========================================================================

            //using (CarDealerContext context = new CarDealerContext())
            //{
            //    Console.WriteLine(GetTotalSalesByCustomer(context));
            //}

            //[19]==========================================================================

            using (CarDealerContext context = new CarDealerContext())
            {
                //Console.WriteLine(GetSalesWithAppliedDiscount(context));
                var salesResult = GetSalesWithAppliedDiscount(context);
                File.WriteAllText("../../../result.xml", salesResult);
            }
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSupplierDto[]), new XmlRootAttribute("Suppliers")); //описваме кой обект искаме да deserialize, и посочваме как да го достъпи (root-a)

            var suppliersDto = (ImportSupplierDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var suppliers = new List<Supplier>();

            foreach (var supplierDto in suppliersDto)
            {
                var supplier = Mapper.Map<Supplier>(supplierDto);
                suppliers.Add(supplier);
            }

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPartDto[]), new XmlRootAttribute("Parts"));

            var partsDto = (ImportPartDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var parts = new List<Part>();

            var supplierID = context.Suppliers.Select(x => x.Id).ToList();

            foreach (var partDto in partsDto)
            {
                if (supplierID.Contains(partDto.SupplierId))
                {
                    var part = Mapper.Map<Part>(partDto);
                    parts.Add(part);
                }
            }

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var carsParsed = XDocument.Parse(inputXml)
                .Root
                .Elements()
                .ToList();

            var cars = new List<Car>();

            var existingPartsIds = context.Parts
                .Select(x => x.Id)
                .ToArray();

            foreach (var x in carsParsed)
            {
                Car currentCar = new Car()
                {
                    Make = x.Element("make").Value,
                    Model = x.Element("model").Value,
                    TravelledDistance = Convert.ToInt64(x.Element("TraveledDistance").Value)
                };

                var partIds = new HashSet<int>();

                foreach (var id in x.Element("parts").Elements())
                {
                    var pid = Convert.ToInt32(id.Attribute("id").Value);
                    partIds.Add(pid);
                }

                foreach (var pid in partIds)
                {
                    PartCar currentPair = new PartCar()
                    {
                        Car = currentCar,
                        PartId = pid
                    };

                    if (existingPartsIds.Contains(pid) == false)
                        continue;

                    currentCar.PartCars.Add(currentPair);
                }

                cars.Add(currentCar);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count()}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCustomerDto[]), new XmlRootAttribute("Customers"));

            var customersDto = (ImportCustomerDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var customers = new List<Customer>();

            foreach (var customerDto in customersDto)
            {
                    var customer = Mapper.Map<Customer>(customerDto);
                    customers.Add(customer);
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}";
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSaleDto[]), new XmlRootAttribute("Sales"));

            var salesDto = (ImportSaleDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var sales = new List<Sale>();

            var carID = context.Cars.Select(x => x.Id).ToList();

            foreach (var saleDto in salesDto)
            {
                if (carID.Contains(saleDto.CarId))
                {
                    var sale = Mapper.Map<Sale>(saleDto);
                    sales.Add(sale);
                }
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}";
        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var cars = context
                .Cars
                .Where(c => c.TravelledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Select(c => new ExportCarWithDistance
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .Take(10)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCarWithDistance[]), new XmlRootAttribute("cars"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var cars = context
                .Cars
                .Where(c => c.Make == "BMW")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .Select(c => new ExportCarsFromMakeBMW
                {
                    Id = c.Id,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCarsFromMakeBMW[]), new XmlRootAttribute("cars"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context
                .Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new ExportLocalSuppliers
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportLocalSuppliers[]), new XmlRootAttribute("suppliers"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), suppliers, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context
                .Cars
                .Select(c => new ExportCarsWithTheirListOfParts
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                    //Parts = c.PartCars.Select(pc => new PartDto
                    //{
                    //    Name = pc.Part.Name,
                    //    Price = pc.Part.Price
                    //})
                    Parts = context.PartCars.Where(s => s.CarId == c.Id).Select(p => new PartDto()
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price
                    })
                    .OrderByDescending(pc => pc.Price)
                    .ToArray()
                })
                .OrderByDescending(c => c.TravelledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCarsWithTheirListOfParts[]), new XmlRootAttribute("cars"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var sales = context
                .Customers
                .Where(c => c.Sales.Any())
                .Select(c => new ExportTotalSalesByCustomer
                {
                    Name = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpentMoney = decimal.Parse($"{c.Sales.Sum(s => s.Car.PartCars.Sum(pc => pc.Part.Price)):F2}")
                })
                .OrderByDescending(c => c.SpentMoney)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportTotalSalesByCustomer[]), new XmlRootAttribute("customers"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), sales, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context
                .Sales
                .Select(s => new ExportSalesWithAppliedDiscount
                {
                    Car = new ExportCarWithDistance
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    },
                    Discount = s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = decimal.Parse($"{s.Car.PartCars.Sum(pc => pc.Part.Price):F2}"),
                    PriceWithDiscount = decimal.Parse($"{(s.Car.PartCars.Sum(pc => pc.Part.Price) * ((100 - s.Discount) / 100)):F2}")
                })
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportSalesWithAppliedDiscount[]), new XmlRootAttribute("sales"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            xmlSerializer.Serialize(new StringWriter(sb), sales, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}