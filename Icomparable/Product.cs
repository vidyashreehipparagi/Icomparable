using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable
{
    public class Product : IEnumerable<Product>
    {
        private string name;
        private double price;


        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public int CompareTo(Product other)
        {
            if (this.price < other.price)
            {
                return -1;
            }
            else if (this.price > other.price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerator<Product> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{price}---->{name}";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
