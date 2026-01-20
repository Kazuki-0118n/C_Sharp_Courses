using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14.Products
{
    public class VegetableShop
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(List<Product> products)
        {
            _products.AddRange(products);
        }


        public void PrintProductsInfo()
        {
            decimal grandTotal = 0;
            foreach (var product in _products)
            {
                Console.WriteLine(product.ToString());

                grandTotal += product.FinalPrice;
            }
            Console.WriteLine($"Total products price: {grandTotal}");
        }
    }
}


