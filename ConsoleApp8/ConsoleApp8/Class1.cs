using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Order
    {
        private string title;
        private double priceIn;
        private double priceOut;

        public string Title { get => title; set => title = value; }
        public void SetPriceIn(double price)
        {
            if (price > 0)
                this.priceIn = price;
            else
                this.priceIn = 0.01;
        }
        public double getPriceIn()
        {
            return this.priceIn;
        }
        public bool SetPriceOut(double price)
        {
            bool result = false;
            if ((price > 0) && (price >= this.priceIn))
            {
                this.priceOut = price;
                result = true;
            }
            return result;
        }
        public double GetPriceOut()
        {
            return this.priceOut;
        }
        public String PrintOrder()
        {
            return this.title + "(" + this.priceIn + "/" + this.priceOut + ")\n";
        }
        private bool IsPrice(String price)
        {
            bool result = false;
            double priceCheked = -1;
            try
            {
                priceCheked = Convert.ToDouble(price);
            }
            catch (Exception e) { }
            if (priceCheked > 0)
                result = true;
            return result;
        }
        public bool SetPriceIn(String price)
        {
            bool result = false;
            if (this.IsPrice(price))
            {
                this.priceIn = Convert.ToDouble(price);
                result = true;
            }
            return result;
        }
    }
}
