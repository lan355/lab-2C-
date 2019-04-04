using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double ro2;
            Console.WriteLine("Введите R1= ");
            double ro1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите FI1= ");
            int fi1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Введите R2= ");
                ro2 = Convert.ToDouble(Console.ReadLine());
                if (ro2 == 0) Console.WriteLine("На ноль делить нельзя, введите заново");
            }
            while (ro2 == 0);
            Console.WriteLine("Введите FI2= ");
            int fi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            kompleksnoe_chislo k1 = new kompleksnoe_chislo(ro1, fi1);
            kompleksnoe_chislo k2 = new kompleksnoe_chislo(ro2, fi2);
            kompleksnoe_chislo um = k1 * k2;
            kompleksnoe_chislo del = k1 / k2;
            kompleksnoe_chislo pl = k1 + k2;
            kompleksnoe_chislo min = k1 - k2;
            kompleksnoe_chislo k = new kompleksnoe_chislo(ro1, fi1);

            Console.WriteLine("k1=" + k1.RO + "(Cos(" + k1.FI + ")+iSin(" + k1.FI + ")");
            Console.WriteLine("k2=" + k2.RO + "(Cos(" + k2.FI + ")+iSin(" + k2.FI + ")");
            kompleksnoe_chislo f = k1.Koren();
            Console.WriteLine("Корень " + "\n" + f.ToString());
            Console.WriteLine("Умножение " + "\n" + um.ToString());
            Console.WriteLine("Деление " + "\n" + del.ToString());
            Console.WriteLine("Сложение " + "\n" + pl.ToString());
            Console.WriteLine("Вычитание " + "\n" + min.ToString());

            Console.ReadLine();
        }
    }
}
