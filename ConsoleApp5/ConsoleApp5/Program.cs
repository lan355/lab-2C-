using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class My
    {
        public string avtor { get; set; }
        public string zhanr { get; set; }
        public int tirazh { get; set; }
        public string nazvanie { get; set; }

        public My(string avtor, string zhanr, int tirazh, string nazvanie)
        {
            this.avtor = avtor;
            this.zhanr = zhanr;
            this.tirazh = tirazh;
            this.nazvanie = nazvanie;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<My> structures = new List<My>();

            structures.Add(new My("Дмитрий Емец", "Фэнтези", 9000, "Мефодий Буслаев"));
            structures.Add(new My("Филип Пулман", "Детектив", 15000, "Полярная звезда"));
            structures.Add(new My("Рекс Стаут", "Детектив", 7000, "Звонок в дверь"));
            structures.Add(new My("Ганс Христиан Андерсен", "Сказки", 20000, "Русалочка"));

            string structureAvtor = "";
            string structureNazvanie = "";
            string structureZhanr = "";

            int ResTirazh = 10000;

            foreach (My structure in structures)
            {
                if (structure.tirazh <= ResTirazh)
                {
                    Console.WriteLine("Avtor: " + structure.avtor);
                    Console.WriteLine("Zhanr: " + structure.zhanr);
                    Console.WriteLine("Tirazh: " + structure.tirazh);
                    Console.WriteLine("nazvanie: " + structure.nazvanie);
                    Console.WriteLine("************************************");
                }
            }



            Console.ReadKey();
        }

    }
}
