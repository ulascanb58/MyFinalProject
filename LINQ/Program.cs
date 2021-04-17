using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategoryName = "Bilgisayar";
            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.CategoryName = "Telefon";
            List<Category> categories = new List<Category>{category1,category2};

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Acer Laptop", QuantityPerUnit = "32 Gb Ram", UnitPrice = 10000, UnitsInStock = 5},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "Asus Laptop", QuantityPerUnit = "16 Gb Ram", UnitPrice = 8000, UnitsInStock = 3},
                new Product{ProductId = 3,CategoryId = 1,ProductName = "Hp Laptop", QuantityPerUnit = "8 Gb Ram", UnitPrice = 6000, UnitsInStock = 2},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "Samsung Laptop", QuantityPerUnit = "4 Gb Ram", UnitPrice = 5000, UnitsInStock = 15},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "Apple Laptop", QuantityPerUnit = "4 Gb Ram", UnitPrice = 8000, UnitsInStock = 0}
            };
    
          //  NewMethod(products);
            //AnyTest(products);
            //FindTest(products);
         //  FindAllTest(products);

           // AscDescTEST(products);
         //  ClassLNQ(products); 

         var result = from p in products
                      
             join c in categories on p.CategoryId equals c.CategoryId
                      where p.UnitPrice>5000
             select new ProductDTO
             {
                 ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName,
                 UnitPrice = p.UnitPrice
             };

          foreach (var productDto in result)
          {
              Console.WriteLine("{0} ---- {1}",productDto.ProductName,productDto.CategoryName);
          }
          Console.Read();

        }

        private static void ClassLNQ(List<Product> products)
        {
            var result = from p in products
                where p.UnitPrice > 6000
                orderby p.UnitPrice, p.ProductName ascending
                select new ProductDTO {ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice};
            foreach (var itemProduct in products)
            {
                Console.WriteLine(itemProduct.ProductName);
            }
        }

        private static void AscDescTEST(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitsInStock)
                .ThenByDescending(p => p.ProductName);
            foreach (var x in result)
            {
                Console.WriteLine(x.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));

            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");

            Console.WriteLine(result);
        }

        private static void NewMethod(List<Product> products)
        {
            foreach (var items in products)
            {
                if (items.UnitPrice > 5000 && items.UnitsInStock > 3)
                {
                    Console.WriteLine(items.ProductName);
                }
            }

            Console.WriteLine("--------------LINQ-------------");


            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
            foreach (var items in result)
            {
                Console.WriteLine(items.ProductName);
            }

            Console.Read();

            Console.WriteLine("----------------");
        }
    }

    class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
