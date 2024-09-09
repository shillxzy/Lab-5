using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Topping
    {
        private string topping;
        private float weight;

        public Topping(string topping, float weight)
        {
            TOPPING = topping;
            WEIGHT = weight;
        }

        public string TOPPING
        {
            get { return topping; }
            set
            {
                if (value == "Meat" || value == "Vegetables"
                    || value == "Cheese" || value == "Sauce" || value == "Veggies")
                {
                    topping = value;
                }
                else
                {
                    throw new($"Cannot place {topping} on top of your pizza");
                }
            }
        }

        public float WEIGHT
        {
            get { return weight; }

            set
            {
                if (value >= 1 && value <= 50)
                {
                    weight = value;
                }
                else
                {
                    throw new("Meat weight should be in the range [1..50].");
                }
            }
        }

        public float Calculation()
        {
            float total = 0;
            float weighttopping = 0;

            if (topping == "Meat")
            {
                weighttopping = 1.2f;
            }
            else if (topping == "Vegetables" || topping == "Veggies")
            {
                weighttopping = 0.3f;
            }
            else if (topping == "Cheese")
            {
                weighttopping = 1.1f;
            }
            else if (topping == "Sauce")
            {
                weighttopping = 0.9f;
            }

            total = (2 * weight) * weighttopping;

            return total;
        }


    }
}
