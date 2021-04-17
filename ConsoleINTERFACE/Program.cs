using System;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.InMemory;

namespace ConsoleINTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager=new ProductManager(new InMemoryProductDAL());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }

            Console.Read();
        }
    }
}
