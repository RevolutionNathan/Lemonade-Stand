using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class HumanPlayer : Player
    {
        public Inventory inventory = new Inventory();
        public Accounting accounting = new Accounting();
        public Recipe recipe = new Recipe();
        public override string GetName()
        {
            name = Console.ReadLine();
            return name;
        }



    }
}
