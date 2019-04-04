using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class kompleksnoe_chislo
    {
        double ro;
        double fi;


        public kompleksnoe_chislo(double ro, double fi)
        {
            this.ro = ro;
            this.fi = fi;
        }


        public double RO
        {
            get { return ro; }
            set { ro = value; }
        }
        public double FI
        {
            get { return fi; }
            set { fi = value; }
        }

        public new string ToString()
        {
            return "Тригонометрическая форма: " + ro.ToString() + "*(Cos(" + fi.ToString() + ")+i*Sin(" + fi.ToString() + "))" + "\n" +
                "Алгебраическая форма: " + Math.Round(this.ro * Math.Cos(this.fi), 2) + "+" + Math.Round(this.ro * Math.Sin(this.fi), 2) + "i";

        }
        public kompleksnoe_chislo Koren()
        {
            kompleksnoe_chislo k1 = new kompleksnoe_chislo(this.ro = Math.Round(Math.Sqrt(this.ro), 2), this.fi /= 2);
            return k1;
        }

        public static kompleksnoe_chislo operator *(kompleksnoe_chislo k1, kompleksnoe_chislo k2)
        {
            return new kompleksnoe_chislo(k1.RO * k2.RO, k1.FI + k2.FI);
        }

        public static kompleksnoe_chislo operator /(kompleksnoe_chislo k1, kompleksnoe_chislo k2)
        {
            return new kompleksnoe_chislo(Math.Round(k1.RO / k2.RO, 2), k1.FI - k2.FI);
        }

        public static kompleksnoe_chislo operator +(kompleksnoe_chislo k1, kompleksnoe_chislo k2)
        {
            return new kompleksnoe_chislo(Math.Round(k1.RO * Math.Cos(k1.FI), 2) + Math.Round(k2.RO * Math.Cos(k2.FI), 2), Math.Round(k1.RO * Math.Sin(k1.FI), 2) + Math.Round(k2.RO * Math.Sin(k2.FI), 2));
        }

        public static kompleksnoe_chislo operator -(kompleksnoe_chislo k1, kompleksnoe_chislo k2)
        {
            return new kompleksnoe_chislo(Math.Round(k1.RO * Math.Cos(k1.FI), 2) - Math.Round(k2.RO * Math.Cos(k2.FI), 2), Math.Round(k1.RO * Math.Sin(k1.FI), 2) - Math.Round(k2.RO * Math.Sin(k2.FI), 2));
        }

    }
}
