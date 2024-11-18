using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;
using System.Text.Json;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext context = new ProductShopContext();

            //1. Import users
            //string userJson = File.ReadAllText("../../../Datasets/users.json");
            //Console.WriteLine(ImportUsers(context, userJson));


            // 2.Import products
            //string productJson = File.ReadAllText("../../../Datasets/products.json");
            //Console.WriteLine(ImportProducts(context, productJson));

            // 3. Import Categories
            //string categoriesJason = File.ReadAllText("../../../Datasets/categories.json");
            //Console.WriteLine(ImportCategories(context, categoriesJason));

            //4.Import Categories and Products
            //string productCategoriesJson = File.ReadAllText("../../../Datasets/categories-products.json");
            //Console.WriteLine(ImportCategoryProducts(context, productCategoriesJson));

            //5. Export Products in Range
            // Console.WriteLine(GetProductsInRange(context));

            //6.Export Sold Products
            // Console.WriteLine(GetSoldProducts(context));

            //7.Export Categories by Products Count
            // Console.WriteLine(GetCategoriesByProductsCount
            //(context));

            //8.Export Users and Products
            Console.WriteLine(GetUsersWithProducts(context));
        }
        //1.Import users
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<User[]>(inputJson);

            context.Users.AddRange(users);

            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }
        //2.Import products
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<Product[]>(inputJson);
            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }
        //3. Import Categories
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<List<Category>>(inputJson);

            var validCategories = categories.Where(c => c.Name is not null).ToList();

            context.Categories.AddRange(validCategories);
            context.SaveChanges();

            return $"Successfully imported {validCategories.Count}";
        }
        //4. Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoryProducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(inputJson);

            context.CategoriesProducts.AddRange(categoryProducts);
            context.SaveChanges();
            return $"Successfully imported {categoryProducts.Count}";
        }
        //5. Export Products in Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = p.Seller.FirstName + " " + p.Seller.LastName

                })
                .ToList();

            string productsInRangeJson = JsonConvert.SerializeObject(products, Formatting.Indented);

            //File.WriteAllText("../../../Datasets/products-in-range.json", productsInRangeJson);

            return productsInRangeJson;

        }
        //6. Export Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                            buyerFirstName = p.Buyer.FirstName,
                            buyerLastName = p.Buyer.LastName
                        }).ToArray()
                }).ToArray();

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);

            return json;
        }
        //7. Export Categories by Products Count
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .OrderByDescending(c => c.CategoriesProducts.Count)
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoriesProducts.Count,
                    averagePrice = c.CategoriesProducts
                                    .Average(cp => cp.Product.Price)
                                    .ToString("f2"),
                    totalRevenue = c.CategoriesProducts
                                    .Sum(cp => cp.Product.Price)
                                    .ToString("f2")
                })
                .ToList();

            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);

            return json;
        }
        //8.Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Include(x => x.ProductsSold)
                .ToList()
                .Where(x => x.ProductsSold.Any(b => b.BuyerId != null))
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    age = x.Age,
                    soldProducts = new
                    {
                        count = x.ProductsSold.Where(b => b.BuyerId != null).Count(),
                        products = x.ProductsSold.Where(b => b.BuyerId != null).Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })
                            .ToList()
                    }
                })
                .ToList()
                .OrderByDescending(x => x.soldProducts.products.Count())
                .ToList();

            var resultObject = new
            {
                usersCount = users.Count(),
                users = users
            };

            var jsonSerializingOptions = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            var resultJson = JsonConvert.SerializeObject(resultObject, Formatting.Indented, jsonSerializingOptions);

            return resultJson;
        }
    }
}