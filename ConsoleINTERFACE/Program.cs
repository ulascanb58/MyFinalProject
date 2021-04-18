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
            ProductManager productManager=new ProductManager(new EfProductDal());
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
            foreach (var item in productManager.GetByUnitPrice(0,10))
            {
                Console.WriteLine(item.ProductName);
            }


            Console.Read();
        }
    }
}
