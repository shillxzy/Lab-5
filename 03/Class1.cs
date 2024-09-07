using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Pizza
    {
        private string name;
        private Dough dough;
        private Topping fillings;

        public Pizza(string name)
        {
            this.name = name;
        }
        public Pizza (string name, Dough dough, Topping fillingsame)
        {
            this.name = name;
            this.dough = dough;
            this.fillings = fillings;
        }

    }

    class Dough
    {
        private string TypeOfFlour;
        private string BakingTechnique;
        private float weight;

        public Dough(string typeofflour, string BakingTechnique, float weight)
        {
            this.TypeOfFlour = typeofflour;
            this.BakingTechnique = BakingTechnique;
            this.weight = weight;
        }

        public string TYPE
        {
            get { return TypeOfFlour; }

            set
            {
                if (value == "White" || value == "Wholegrain")
                {
                    TypeOfFlour = value;
                }
                else
                {
                    throw new("Not that kind of dough technique!");
                }
            }
        }

        public string BAKING
        {
            get { return BakingTechnique; }

            set
            {
                if (value == "Crispy" || value == "Chewy" || value == "Home")
                {
                    BakingTechnique = value;
                }
                else
                {
                    throw new("Don't know about this baking technique");
                }
            }
        }

        public float Weight
        {
            get { return weight; }
            set
            {
                if (value >= 1 && value <= 200)
                {
                    weight = value;
                }
                else
                {
                    throw new ("Dough weight should be in the range [1..200].");
                }
            }
        }

        public float CaloriesToGram()
        {
            float typeflour = 0;
            float baking = 0;
            float total = 0;

            if (TypeOfFlour == "White")
            {
                typeflour = 1.5f;
            }
            else if (TypeOfFlour == "Wholegrain")
            {
                typeflour = 1.0f;
            }

            if (BakingTechnique == "Crispy")
            {
                baking = 0.9f;
            }
            else if (BakingTechnique == "Chewy")
            {
                baking = 1.1f;
            }
            else if (BakingTechnique == "Home")
            {
                baking = 1.0f;
            }

            total = (2 * weight) * typeflour * baking; 

            return total;
 
        }

    }

    class Topping
    {
        private string topping;
        private float weight;

        public Topping(string topping, float weight)
        {
            this.topping = topping;
            this.weight = weight;
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

            if(topping == "Meat")
            {
                weighttopping = 1.2f;
            }
            else if (topping == "Vegetables" || topping == "Veggies")
            {
                weighttopping = 0.3f;
            }
            else if(topping == "Cheese")
            {
                weighttopping = 1.1f;
            }
            else if(topping == "Sauce")
            {
                weighttopping = 0.9f;
            }

            total = (2 * weight) * weighttopping;

            return total;
        }


    }

}
