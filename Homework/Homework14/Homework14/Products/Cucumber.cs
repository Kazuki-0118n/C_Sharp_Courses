using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14.Products
{
    internal class Cucumber : Product
    {
        public double Weight { get; set; }

        public Cucumber(decimal price, double weight = 1) : base("Cucumber", price)
        {
            Weight = weight;
        }

        public override decimal FinalPrice
        {
            get
            {
                return BasePrice * (decimal)Weight;
            }
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price per kilogram: {BasePrice},Weight: {Weight}, Total price: {FinalPrice}";
        }
    }
}

