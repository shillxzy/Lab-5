using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingShopping
{
    internal class Product
    {
        private string ProductName;
        private float cost;

        public Product(string name, float cost)
        {
            this.ProductName = name;
            this.cost = cost;
        }

        public string getProductName()
        {
            return this.ProductName;
        }

        public float Cost 
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
            }

        }

    }
}
