using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Ice: Ingredient
    {
        public Ice(int lifetime, string name, double price): base(lifetime, name, price)
        {
            lifetime = 1;
            name = "ice";
            price = .05;
        }

    }
}
