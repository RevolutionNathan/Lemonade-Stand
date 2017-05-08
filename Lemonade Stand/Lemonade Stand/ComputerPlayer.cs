using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class ComputerPlayer : Player
    {
        public override string GetName()
        {
            name = "Computer";
            return name;
        }
    }
}
