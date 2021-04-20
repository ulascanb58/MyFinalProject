using System;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;

namespace ConsoleINTERFACE
{
    class Program
    {
        //SOLID
        //Open closed : Yeni özellik mevcuttaki koda değişiklik yapmamasını sağlar
        static void Main(string[] args)
        {
            // ProductTest();

           // CategoryTest();
           ProductTest2();

            Console.Read();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var items in categoryManager.GetAll())
            {
                Console.WriteLine(items.CategoryName);
            }
        }

        private static void ProductTest2()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+ "/" + item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(0, 10))
            {
                Console.WriteLine(item.ProductName);
            }
            /*
           foreach (var item in productManager.GetAll())
           {
               Console.WriteLine(item.ProductName);
           }
           */

            /*
            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }
            */
        }
    }
}
