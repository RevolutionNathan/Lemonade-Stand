using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
     class Ingredient
    { 
        public int lifetime = 0;
        public string name = "ingredient";
        public double price = 0;

     public Ingredient(int lifetime, string name, double price)
        {
            this.lifetime = lifetime;
            this.name = name;
            this.price = price;
        }

    }
}
