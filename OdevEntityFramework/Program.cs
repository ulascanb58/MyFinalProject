using System;
using System.Linq;

namespace OdevEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
           // GetAll();
          // GetProductsByCategory(1);

            Console.Read();
        }

        private static void GetAll()
        {
            NorthwindContext context2 = new NorthwindContext();
            foreach (var items in context2.Products)
            {
                Console.WriteLine(items.ProductName);
            }
        }

        private static void GetProductsByCategory(int id)
        {
            NorthwindContext context2 = new NorthwindContext();
            var result = context2.Products.Where(p => p.CategoryId == id);
            foreach (var items in result)
            {
                Console.WriteLine(items.ProductName);
            }
        }
    }
}
