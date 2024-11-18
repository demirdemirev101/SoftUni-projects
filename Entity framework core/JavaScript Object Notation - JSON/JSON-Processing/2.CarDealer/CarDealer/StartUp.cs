using AutoMapper;
using AutoMapper.Execution;
using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new CarDealerContext();

            //9.Import Suppliers
            //string jsonSuppliers = File.ReadAllText("../../../Datasets/suppliers.json");
            //Console.WriteLine(ImportSuppliers(context,jsonSuppliers));

            //10. Import Parts
            //string jsonParts = File.ReadAllText("../../../Datasets/parts.json");
            //Console.WriteLine(ImportParts(context, jsonParts));
            //11. Import Cars
            //string jsonCars = File.ReadAllText("../../../Datasets/cars.json");
            // Console.WriteLine(ImportCars(context, jsonCars));
            //12. Import Customers
            //string jsonCustomers = File.ReadAllText("../../../Datasets/customers.json");
            // Console.WriteLine(ImportCustomers(context, jsonCustomers));
            //13. Import Sales
            //string sales=File.ReadAllText("../../../Datasets/sales.json");
            // Console.WriteLine(ImportSales( context, sales));
            //14.Export Ordered Customers
            //Console.WriteLine(GetOrderedCustomers(context));
            //15. Export Cars From Make Toyota
            //Console.WriteLine(GetCarsFromMakeToyota(context));
            //16.Export Local Suppliers
            //Console.WriteLine(GetLocalSuppliers(context));
            //17.Export Cars With Their List Of Parts
            //Console.WriteLine(GetCarsWithTheirListOfParts(context));
            //18.Export Total Sales by Customer
            //Console.WriteLine(GetTotalSalesByCustomer(context));
            //19.Export Sales with Applied Discount
            Console.WriteLine(GetSalesWithAppliedDiscount(context));
        }
        //9. Import Suppliers
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<CarDealerProfile>());
            IMapper mapper = new Mapper(config);

            SupplierDTO[] supplierDTOs = JsonConvert.DeserializeObject<SupplierDTO[]>(inputJson);

            Supplier[] suppliers = mapper.Map<Supplier[]>(supplierDTOs);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Length}.";
        }
        //10. Import Parts
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<CarDealerProfile>());
            IMapper mapper = new Mapper(config);

            PartsDTO[] partsDTOs = JsonConvert.DeserializeObject<PartsDTO[]>(inputJson);
            Part[] parts = mapper.Map<Part[]>(partsDTOs);

            var validSuppliersIds = context.Suppliers
                .Select(s => s.Id)
                .ToArray();

            var filtererParts = parts.Where(p => validSuppliersIds.Contains(p.SupplierId)).ToArray();

            context.Parts.AddRange(filtererParts);
            context.SaveChanges();

            return $"Successfully imported {filtererParts.Length}.";
        }
        //11. Import Cars
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var cars = JsonConvert.DeserializeObject<Car[]>(inputJson);

            var parts = context.Parts.ToList();
            var partsCars = context.PartsCars.ToList();

            foreach (var car in cars)
            {
                foreach (var part in parts)
                {
                    PartCar partCar = new PartCar
                    {
                        CarId = car.Id,
                        PartId = part.Id
                    };
                    partsCars.Add(partCar);
                }
            }

            context.Cars.AddRange(cars);
            context.PartsCars.AddRange(partsCars);
            context.SaveChanges();

            return $"Successfully imported {cars.Length}.";
        }
        //12. Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customers = JsonConvert.DeserializeObject<Customer[]>(inputJson);

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Length}.";
        }
        //13. Import Sales
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var sales = JsonConvert.DeserializeObject<Sale[]>(inputJson);
            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Length}.";
        }
        //14. Export Ordered Customers
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(x => x.BirthDate)
                .ThenBy(x => x.IsYoungDriver)
                .Select(x => new
                {
                    x.Name,
                    BirthDate = x.BirthDate.ToString("dd/MM/yyyy"),
                    x.IsYoungDriver
                })
                .ToList();

            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);

            return json;
        }
        //15. Export Cars From Make Toyota
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(x => x.Model)
                .ThenByDescending(x => x.TraveledDistance)
                .Select(c => new
                {
                    c.Id,
                    c.Make,
                    c.Model,
                    c.TraveledDistance
                })
                .ToList();

            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);

            return json;
        }
        //16. Export Local Suppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToList();

            string json = JsonConvert.SerializeObject(suppliers, Formatting.Indented);

            return json;
        }
        //17. Export Cars With Their List Of Parts
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        c.Make,
                        c.Model,
                        c.TraveledDistance
                    },
                    parts =
                        c.PartsCars.
                        Select(x => new
                        {
                            x.Part.Name,
                            Price = x.Part.Price.ToString("f2")
                        })
                        .ToList()
                })
                .ToList();

            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);

            return json;
        }
        //18. Export Total Sales by Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {

            var customerSales = context.Customers
               .Where(c => c.Sales.Any())
               .Select(c => new
               {
                   fullName = c.Name,
                   boughtCars = c.Sales.Count(),
                   salePrices = c.Sales.SelectMany(x => x.Car.PartsCars.Select(x => x.Part.Price))
               })
               .ToArray();

            var totalSalesByCustomer = customerSales.Select(t => new
            {
                t.fullName,
                t.boughtCars,
                spentMoney = t.salePrices.Sum()
            })
            .OrderByDescending(t => t.spentMoney)
            .ThenByDescending(t => t.boughtCars)
            .ToArray();

            return JsonConvert.SerializeObject(totalSalesByCustomer, Formatting.Indented);
        }
        //19. Export Sales with Applied Discount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var salesWithDiscount = context.Sales
                .Take(10)
                .Select(s => new
                {
                    car = new
                    {
                        s.Car.Make,
                        s.Car.Model,
                        s.Car.TraveledDistance
                    },
                    customerName = s.Customer.Name,
                    discount = $"{s.Discount:f2}",
                    price = $"{s.Car.PartsCars.Sum(p => p.Part.Price):f2}",
                    priceWithDiscount = $"{s.Car.PartsCars.Sum(p => p.Part.Price) * (1 - s.Discount / 100):f2}"
                })
                .ToArray();

            return JsonConvert.SerializeObject(salesWithDiscount, Formatting.Indented);
        }
    }
}