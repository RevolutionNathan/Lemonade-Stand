using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        public List<Lemons> lemons = new List<Lemons>();
        public List<Ice> ice = new List<Ice>();
        public List<Cups> cups = new List<Cups>();
        public List<Sugar> sugar = new List<Sugar>();

        public static int lemonsCount;
        public static int iceCount;
        public static int cupsCount;
        public static int sugarCount;

      
        public int GetLemonsCount
        {
            get
            {
                lemonsCount = lemons.Count;
                return lemonsCount;
            }
            
        }

        public int GetCupsCount
        {
            get
            {
                cupsCount = cups.Count;
                return cupsCount;
            }
        }

        public int GetSugarCount
        {
            get
            {
                sugarCount = sugar.Count;
                return sugar.Count;
            }
        }
        public int GetIceCount
        {
            get
            {
                iceCount = ice.Count;
                return iceCount;
            }
        }

public void PrintInventory()
        {
            UserInterface.DisplayCurrentInventory(this);
        }
        
    }
}
