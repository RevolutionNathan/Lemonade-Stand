using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Cups : Ingredient
    {
        public Cups(int lifetime, string name, double price): base(lifetime, name, price)
        {
            lifetime = 22;
            name = "cups";
            price = .02;
        }

    }
}
