using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        Inventory inventory = new Inventory();
        public string name;

        public virtual string GetName()
        {
            name = Console.ReadLine();
            return name;
        }

       

    }
}


