using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Dough
    {
        private string TypeOfFlour;
        private string BakingTechnique;
        private float weight;

        public Dough(string typeofflour, string BakingTechnique, float weight)
        {
            TYPE = typeofflour;
            BAKING = BakingTechnique;
            Weight = weight;
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
                if (value == "Crispy" || value == "Chewy" || value == "Home" || value == "Homemade")
                {
                    BakingTechnique = value;
                }
                else
                {
                    throw new($"Don't know about {BakingTechnique} baking technique");
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
                    throw new("Dough weight should be in the range [1..200].");
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
            else if (BakingTechnique == "Home" || BakingTechnique == "Homemade")
            {
                baking = 1.0f;
            }

            total = (2 * weight) * typeflour * baking;

            return total;

        }

    }
}
