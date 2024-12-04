using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new CarDealerContext();
            //9.
            //string inputSuppXml = File.ReadAllText("../../../Datasets/suppliers.xml");
            //Console.WriteLine(ImportSuppliers(context, inputSuppXml));
            //10.
            //string inputPartsXml = File.ReadAllText("../../../Datasets/parts.xml");
            //Console.WriteLine(ImportParts(context, inputPartsXml));
            //11.
            //string inputCarsXml = File.ReadAllText("../../../Datasets/cars.xml");
            //Console.WriteLine(ImportCars(context, inputCarsXml));
            //12. Import Customers
            //string inputCustomersXml = File.ReadAllText("../../../Datasets/customers.xml");
            //Console.WriteLine(ImportCustomers(context, inputCustomersXml));
            //13.Import Sales
            //string inputSalesXml = File.ReadAllText("../../../Datasets/sales.xml");
            //Console.WriteLine(ImportSales(context, inputSalesXml));
            //14.
            //Console.WriteLine(GetCarsWithDistance(context));
            //15.
            //Console.WriteLine(GetCarsFromMakeBmw(context));
            //16.
            // Console.WriteLine(GetLocalSuppliers(context));
            //17.
            // Console.WriteLine(GetCarsWithTheirListOfParts(context));
            //18. Export Total Sales by Customer
            //Console.WriteLine(GetTotalSalesByCustomer(context));
            //19.
            Console.WriteLine(GetSalesWithAppliedDiscount(context));
        }
        private static Mapper GetMapper()
        {
            var cfg = new MapperConfiguration(c => c.AddProfile<CarDealerProfile>());
            return new Mapper(cfg);
        }
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            // 1. Create XML serializer
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSupplierDto[]),
                new XmlRootAttribute("Suppliers"));

            //2.
            using var reader = new StringReader(inputXml);

            ImportSupplierDto[] importSupplierDtos = (ImportSupplierDto[])xmlSerializer.Deserialize(reader);

            //3.
            var mapper = GetMapper();

            Supplier[] suppliers = mapper.Map<Supplier[]>(importSupplierDtos);

            context.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}"; ;
        }
        //10. Import Parts
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPartDto[]),
                new XmlRootAttribute("Parts"));

            using var reader = new StringReader(inputXml);
            ImportPartDto[] importPartDtos = (ImportPartDto[])xmlSerializer.Deserialize(reader);

            var supplierIds = context.Suppliers
                .Select(x => x.Id)
                .ToArray();

            var mapper = GetMapper();

            Part[] parts = mapper
                .Map<Part[]>(importPartDtos
                                .Where(p => supplierIds.Contains(p.SupplierId)));

            context.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count()}";
        }
        //11. Import Cars
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCarDto[]), new XmlRootAttribute("Cars"));

            using var reader = new StringReader(inputXml);

            ImportCarDto[] importCarDtos = (ImportCarDto[])xmlSerializer.Deserialize(reader);

            var mapper = GetMapper();
            List<Car> cars = new List<Car>();
            foreach (var carDto in importCarDtos)
            {
                Car car = mapper.Map<Car>(carDto);
                int[] carPartIds = carDto.PartsIds
                    .Select(x => x.Id)
                    .Distinct()
                    .ToArray();

                var carParts = new List<PartCar>();

                foreach (var id in carPartIds)
                {
                    carParts.Add(new PartCar
                    {
                        Car = car,
                        PartId = id
                    });
                }

                car.PartsCars = carParts;
                cars.Add(car);
            }

            context.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count()}";
        }
        //12. Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCustomerDto[]), new XmlRootAttribute("Customers"));

            using var reader = new StringReader(inputXml);

            ImportCustomerDto[] importCustomerDtos = (ImportCustomerDto[])xmlSerializer.Deserialize(reader);

            var mapper = GetMapper();

            Customer[] customers = mapper.Map<Customer[]>(importCustomerDtos);

            context.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count()}";
        }
        //13.Import Sales
        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSaleDto[]), new XmlRootAttribute("Sales"));

            using var reader = new StringReader(inputXml);

            ImportSaleDto[] importSaleDtos = (ImportSaleDto[])xmlSerializer.Deserialize(reader);

            var mapper = GetMapper();

            int[] carIds = context.Cars
                .Select(car => car.Id)
                .ToArray();

            var sales = mapper.Map<Sale[]>(importSaleDtos)
                .Where(c => carIds.Contains(c.CarId))
                .ToArray();

            context.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count()}";
        }
        //14.
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var mapper = GetMapper();

            var carsWiithDistance = context.Cars
                .Where(car => car.TraveledDistance > 2_000_000)
                .OrderBy(car => car.Make)
                .ThenBy(car => car.Model)
                .Take(10)
                .ProjectTo<ExportCarsWithDistance>(mapper.ConfigurationProvider)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCarsWithDistance[]), new XmlRootAttribute("cars"));

            var xmlSN = new XmlSerializerNamespaces();
            xmlSN.Add(string.Empty, string.Empty);

            StringBuilder stringBuilder = new StringBuilder();

            using (StringWriter stringWriter = new StringWriter(stringBuilder))
            {
                xmlSerializer.Serialize(stringWriter, carsWiithDistance, xmlSN);
            }

            return stringBuilder.ToString().TrimEnd();
        }
        //15.
        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var mapper = GetMapper();

            var bmwCars = context.Cars
                    .Where(c => c.Make == "BMW")
                    .OrderBy(c => c.Model)
                    .ThenByDescending(c => c.TraveledDistance)
                    .ProjectTo<ExportBWMCars>(mapper.ConfigurationProvider)
                    .ToArray();

            XmlSerializer xmlSerializer =
                new XmlSerializer(typeof(ExportBWMCars[]), new XmlRootAttribute("cars"));

            var xmlSN = new XmlSerializerNamespaces();
            xmlSN.Add(string.Empty, string.Empty);

            StringBuilder stringBuilder = new StringBuilder();

            using (StringWriter stringWriter = new StringWriter(stringBuilder))
            {
                xmlSerializer.Serialize(stringWriter, bmwCars, xmlSN);
            }

            return stringBuilder.ToString().TrimEnd();
        }
        //16.
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var mapper = GetMapper();

            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .ProjectTo<ExportLocalSuppliers>(mapper.ConfigurationProvider)
                .ToArray();

            XmlSerializer xmlSerializer =
                new XmlSerializer(typeof(ExportLocalSuppliers[]), new XmlRootAttribute("suppliers"));

            var xmlSN = new XmlSerializerNamespaces();
            xmlSN.Add(string.Empty, string.Empty);

            StringBuilder stringBuilder = new StringBuilder();

            using (StringWriter stringWriter = new StringWriter(stringBuilder))
            {
                xmlSerializer.Serialize(stringWriter, suppliers, xmlSN);
            }

            return stringBuilder.ToString().TrimEnd();
        }
        //17.
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            //Finding the Cars
            ExportCarPartsDto[] carsPartsDtos = context.Cars
                .OrderByDescending(c => c.TraveledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .Select(c => new ExportCarPartsDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                    Parts = c.PartsCars.Select(pc => new PartsDto()
                    {
                        Name = pc.Part.Name,
                        Price = pc.Part.Price
                    })
                    .OrderByDescending(p => p.Price)
                    .ToArray()
                })
                .ToArray();

            var xmlSerializer =
               new XmlSerializer(typeof(ExportCarPartsDto[]), new XmlRootAttribute("cars"));

            var xmlSN = new XmlSerializerNamespaces();
            xmlSN.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();

            using (var stringWriter = new StringWriter(sb))
            {
                xmlSerializer.Serialize(stringWriter, carsPartsDtos, xmlSN);
            }
            return sb.ToString().TrimEnd();
        }
        //18. Export Total Sales by Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
              .Where(c => c.Sales.Any())
              .Select(c => new
              {
                  c.Name,
                  BoughtCars = c.Sales.Count,
                  SalesInfo = c.Sales.Select(s => new
                  {
                      Prices = c.IsYoungDriver
                            ? s.Car.PartsCars.Sum(p => Math.Round((double)p.Part.Price * 0.95, 2))
                            : s.Car.PartsCars.Sum(p => (double)p.Part.Price)
                  })

              })
              .ToArray();

            ExportCustomersDTO[] exportCustomersDTOs = customers
              .OrderByDescending(t => t.SalesInfo.Sum(s => s.Prices))
              .Select(cus => new ExportCustomersDTO
              {
                  Name = cus.Name,
                  BoughtCars = cus.BoughtCars,
                  MoneySpent = cus.SalesInfo.Sum(s => s.Prices).ToString("f2")
              })
              .ToArray();

            var serializer = new
                XmlSerializer(typeof(ExportCustomersDTO[]), new XmlRootAttribute("customers"));

            var xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();

            using (StringWriter writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, exportCustomersDTOs, xmlNamespaces);
            }

            return sb.ToString().TrimEnd();
        }
        //19.
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            SalesWithAppliedDiscountDto[] salesDtos = context
               .Sales
               .Select(s => new SalesWithAppliedDiscountDto()
               {
                   SingleCar = new SingleCar()
                   {
                       Make = s.Car.Make,
                       Model = s.Car.Model,
                       TraveledDistance = s.Car.TraveledDistance
                   },
                   Discount = (int)s.Discount,
                   CustomerName = s.Customer.Name,
                   Price = s.Car.PartsCars.Sum(p => p.Part.Price),
                   PriceWithDiscount = Math.Round((double)(s.Car.PartsCars.Sum(p => p.Part.Price) * (1 - (s.Discount / 100))), 4)
               })
               .ToArray();

            var serializer = new
                XmlSerializer(typeof(SalesWithAppliedDiscountDto[]), new XmlRootAttribute("sales"));

            var xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();

            using (StringWriter writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, salesDtos, xmlNamespaces);
            }

            return sb.ToString().TrimEnd();
        }
    }
}