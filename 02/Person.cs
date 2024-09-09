using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingShopping
{
    internal class Person
    {
        private string PersonName;
        private float money;
        private List<Product> bag;

        public Person(string PersonName, float Money)
        {
            this.PersonName = PersonName;
            this.money = Money;
            this.bag = new List<Product>();
        }

        public string getName()
        {
            return this.PersonName;
        }

        public float Money
        {
            get
            {
                return this.money;
            }
            set
            {
                this.money = value;
            }
        }

        public string AddProductToBag(Product product)
        {
            
            if (this.Money < 0)
            {
                throw new("Money cannot be negative");
            }
            else if (this.Money == 0)
            {
                throw new($"{this.getName()} can't afford Kafence");
            }
            else if (this.Money < product.Cost)
            {
                throw new($"{this.getName()} can't afford {product.Cost}");
            }

            this.Money -= product.Cost;
            this.bag.Add(product);
            return $"{this.getName()} bought {product.getProductName()}";

            
        }

    }
}
