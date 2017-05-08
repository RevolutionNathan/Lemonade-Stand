using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int cupsPerPitcher = 10;
        public int icePerPitcher;
        public int desireability;

        public void RecipeBuilder(Inventory inventory)
        {
            UserInterface.LineBreak();
            UserInterface.RecipeBuilderPrompt(this);
            AddLemons(inventory);
            AddSugar(inventory);
            AddIce(inventory);
            
            CalulateDesireability();
        }

        public int AddIce(Inventory inventory)
        {
            int iceWanted = 0;
            try
            {
                UserInterface.HowManyIceRecipe();
                iceWanted = int.Parse(Console.ReadLine());
                if (iceWanted <= inventory.ice.Count)
                {
                    icePerPitcher = iceWanted;
                }
                else
                {
                    UserInterface.OutOfIce();
                    AddIce(inventory);
                }
                return iceWanted;
            }
            catch (Exception b)
            {
                UserInterface.WholeIntException();
                AddIce(inventory);
            }
            return iceWanted;
        }
            
        public int AddLemons(Inventory inventory)
        {
            int lemonsWanted = 0;
            try
            {
                UserInterface.HowManyLemonsRecipe();
                lemonsWanted = int.Parse(Console.ReadLine());
                if (lemonsWanted <= inventory.lemons.Count)
                {
                    lemonsPerPitcher = lemonsWanted;
                }
                else
                {
                    UserInterface.OutOfLemons();
                    AddLemons(inventory);
                }
                return lemonsPerPitcher;
            }
            catch
            {
                UserInterface.WholeIntException();
                AddLemons(inventory);
            }
            return lemonsWanted;
        }

        public int AddSugar(Inventory inventory)
        {
            int sugarWanted = 0;
            try
            {
                UserInterface.HowManySugarRecipe();
                sugarWanted = int.Parse(Console.ReadLine());
                if (sugarWanted <= inventory.sugar.Count)
                {
                    sugarPerPitcher = sugarWanted;
                }
                else
                {
                    UserInterface.OutOfSugar();
                    AddSugar(inventory);
                }
                return sugarPerPitcher;
            }
            catch
            {
                UserInterface.WholeIntException();
                AddSugar(inventory);
            }
            return sugarWanted;
        }



        public int CalulateDesireability()
        {
            desireability = lemonsPerPitcher + icePerPitcher + sugarPerPitcher;
            return desireability;
        }
      
       
    }
}
