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


}
