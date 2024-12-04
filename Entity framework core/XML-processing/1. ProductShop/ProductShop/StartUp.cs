using AutoMapper;
using AutoMapper.QueryableExtensions;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new ProductShopContext();

            //1.
            //string xml = File.ReadAllText("../../../Datasets/users.xml");
            //Console.WriteLine(ImportUsers(context, xml));
            //2.
            //string xml = File.ReadAllText("../../../Datasets/products.xml");
            //Console.WriteLine(ImportProducts(context, xml));
            //3.
            //string xml = File.ReadAllText("../../../Datasets/categories.xml");
            //Console.WriteLine(ImportCategories(context, xml));
            //4.
            //string xml = File.ReadAllText("../../../Datasets/categories-products.xml");
            //Console.WriteLine(ImportCategoryProducts(context, xml));
            //5.
            //Console.WriteLine(GetProductsInRange(context));
            //6.
            //Console.WriteLine(GetSoldProducts(context));
            //7.
            //Console.WriteLine(GetCategoriesByProductsCount(context));
            //8.
            Console.WriteLine(GetUsersWithProducts(context));

        }
        private static Mapper GetMapper()
        {
            var cfg = new MapperConfiguration(c => c.AddProfile<ProductShopProfile>());
            return new Mapper(cfg);
        }
        //1.
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            // 1. Create XML serializer
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportUserDto[]),
                new XmlRootAttribute("Users"));

            //2.
            using var reader = new StringReader(inputXml);

            ImportUserDto[] importUserDtos = (ImportUserDto[])xmlSerializer.Deserialize(reader);

            //3.
            var mapper = GetMapper();

            User[] users = mapper.Map<User[]>(importUserDtos);

            context.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count()}"; ;
        }
        //2.
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var serializer =
                new XmlSerializer(typeof(ImportProductDto[]), new XmlRootAttribute("Products"));

            using var reader = new StringReader(inputXml);
            ImportProductDto[] importproductDtos = (ImportProductDto[])serializer.Deserialize(reader);

            var mapper = GetMapper();
            var products = mapper.Map<Product[]>(importproductDtos);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count()}";
        }
        //3.
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var serializer =
               new XmlSerializer(typeof(ImportCategoryDTO[]), new XmlRootAttribute("Categories"));

            using var reader = new StringReader(inputXml);
            ImportCategoryDTO[] importCategoryDTOs =
                (ImportCategoryDTO[])serializer.Deserialize(reader);

            var mapper = GetMapper();
            var categories = mapper.Map<Category[]>(importCategoryDTOs)
                .Where(c => c.Name != null)
                .ToArray();

            context.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count()}";
        }
        //4.
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCategoryProduct[]), new XmlRootAttribute("CategoryProducts"));

            using var reader = new StringReader(inputXml);

            Mapper mapper = GetMapper();
            var importCategoryProducts = (ImportCategoryProduct[])serializer.Deserialize(reader);

            int[] categoryIds = context.Categories.Select(c => c.Id).ToArray();
            int[] productIds = context.Products.Select(p => p.Id).ToArray();

            var categoryProducts = mapper
                .Map<CategoryProduct[]>(importCategoryProducts)
                .Where(cp => productIds.Contains(cp.ProductId) && categoryIds.Contains(cp.CategoryId));

            context.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Count()}";
        }
        //5.
        public static string GetProductsInRange(ProductShopContext context)
        {
            var mapper = GetMapper();

            var products =
                context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new ProductsPrice500to1000
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName,
                })
                .Take(10)
                .ToArray();

            XmlSerializer serializer = new XmlSerializer(typeof(ProductsPrice500to1000[]), new XmlRootAttribute("Products"));

            XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
            xmlns.Add(string.Empty, string.Empty);

            StringBuilder sb = new StringBuilder();
            using (var writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, products, xmlns);
            }

            return sb.ToString().TrimEnd();
        }
        //6.
        public static string GetSoldProducts(ProductShopContext context)
        {

            var users = context.Users
           .Where(u => u.ProductsSold.Any()) // Filter users with sold products
           .OrderBy(u => u.LastName) // Order by last name
           .ThenBy(u => u.FirstName) // Then by first name
           .Take(5) // Take top 5 users
           .Select(u => new ExportUsersAndProductsSold
           {
               FirstName = u.FirstName,
               LastName = u.LastName,
               ProductsSold = u.ProductsSold
                   .Select(p => new ExportProductsSold
                   {
                       Name = p.Name,
                       Price = p.Price,
                   })
                   .ToArray() // Convert to array
               })
           .ToArray(); // Convert to array

            var serializer =
                new XmlSerializer(typeof(ExportUsersAndProductsSold[]), new XmlRootAttribute("Users"));

            var xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add(string.Empty, string.Empty); // Remove default namespaces

            var sb = new StringBuilder();
            using (var writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, users, xmlNamespaces); // Serialize to XML
            }

            return sb.ToString().TrimEnd();
        }
        //7.
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(c => new CategoriesByProductsCount
                {
                    Name = c.Name,
                    NumberOfProducts=c.CategoryProducts.Count(),
                    AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
                    TotalRevenue=c.CategoryProducts.Sum(cp=>cp.Product.Price)
                })
                .OrderByDescending(x => x.NumberOfProducts)
                .ThenBy(x => x.TotalRevenue)
                .ToArray();

            var serializer =
                new XmlSerializer(typeof(CategoriesByProductsCount[]), new XmlRootAttribute("Categories"));

            var xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add(string.Empty, string.Empty); 

            var sb = new StringBuilder();
            using (var writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, categories, xmlNamespaces);
            }

            return sb.ToString().TrimEnd();
        }
        //8.
        private static string Serializer<T>(T dataTransferObjects, string xmlRootAttributeName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootAttributeName));

            StringBuilder sb = new StringBuilder();
            using var write = new StringWriter(sb);

            XmlSerializerNamespaces xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add(string.Empty, string.Empty);

            serializer.Serialize(write, dataTransferObjects, xmlNamespaces);

            return sb.ToString();
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var usersInfo = context
                .Users
                .Where(u => u.ProductsSold.Any())
                .OrderByDescending(u => u.ProductsSold.Count)
                .Select(u => new UserInfo()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductsCount()
                    {
                        Count = u.ProductsSold.Count,
                        Products = u.ProductsSold.Select(p => new SoldProduct()
                        {
                            Name = p.Name,
                            Price = p.Price
                        })
                        .OrderByDescending(p => p.Price)
                        .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

            ExportUserCountDto exportUserCountDto = new ExportUserCountDto()
            {
                Count = context.Users.Count(u => u.ProductsSold.Any()),
                Users = usersInfo
            };

            return Serializer<ExportUserCountDto>(exportUserCountDto, "Users");
        }
    }
}