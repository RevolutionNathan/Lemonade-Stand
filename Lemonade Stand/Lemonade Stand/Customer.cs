using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        Random random;
        public int desire;

        public Customer(Random rnd)
        {
            random = rnd;
            desire = random.Next(10, 15);
        } 
        
    }
}
