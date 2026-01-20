using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14.Products
{
    internal class Carrot : Product
    {
        public Carrot() : base("Carrot", 11)
        {
        
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {BasePrice}";
        }
    }
}
