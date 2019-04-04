using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Order Order = new Order();
            Order.Title = "Bread";
            Order.SetPriceIn(10.5);
            string price = "";
            double priceD = 0;
            do
             {
                 Console.WriteLine("Input price");
                 try
                 {
                     price = Console.ReadLine();
                     priceD = Convert.ToDouble(price);
                 }
                 catch (Exception e)
                 {
                     Console.WriteLine("Error!");
                 }
             } while (Order.SetPriceOut(priceD));
             Console.WriteLine(Order.PrintOrder());
           /* do
            {
                Console.WriteLine("Input price");
                price = Console.ReadLine();
            } while (Order.SetPriceOut(priceD) != true);*/
        }
    }
}
