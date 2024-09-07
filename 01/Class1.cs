using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFerm
{
    internal class Chicken
    {
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string setName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public double ProductPerDay()
        {
            double eggsPerDay = 0;
            if (this.age <= 5)
            {
                eggsPerDay = 2;
            }
            else if (this.age <= 11)
            {
                eggsPerDay = 1;
            }
            else if (this.age <= 15)
            {
                eggsPerDay = 0.75;
            }

            return eggsPerDay;

        }
    }

}
