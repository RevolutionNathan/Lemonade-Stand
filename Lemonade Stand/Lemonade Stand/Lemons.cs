using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Lemons : Ingredient
    {
        public Lemons(int lifetime, string name, double price):base(lifetime,name,price)
        {
            lifetime = 7;
            name = "lemons";
            price = .25;
        }
       
    }
}
