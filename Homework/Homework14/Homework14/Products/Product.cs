using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14.Products
{
    public class Product
    {
        protected string Name { get; set; }
        protected decimal BasePrice { get; set; }


        public Product(string name, decimal price)
        {
            Name = name;
            BasePrice = price;
        }

        public virtual decimal FinalPrice
        {
            get
            {
                return BasePrice;
            }
        }

    }
}
