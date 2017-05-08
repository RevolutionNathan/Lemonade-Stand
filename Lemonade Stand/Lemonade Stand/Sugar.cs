using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Sugar : Ingredient
    {
        public Sugar(int lifetime, string name, double price): base(lifetime, name, price)
        {
            lifetime = 7;
            name = "sugar";
            price = .25;
        }

    }
}
