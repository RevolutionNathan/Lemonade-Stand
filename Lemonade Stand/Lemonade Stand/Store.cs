using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        public Lemons lemonItem = new Lemons(3, "lemons", .25);
        public Ice iceItem = new Ice(1, "ice", .15);
        public Sugar sugarItem = new Sugar(7, "sugar", .35);
        public Cups cupsItem = new Cups(22, "cups", .02);
        

        public string storeOption;

        public void RunStore(HumanPlayer humanPlayer)
        {
            UserInterface.LineBreak();
            UserInterface.WelcomeToStore();
            Console.WriteLine("You have " + humanPlayer.accounting.wallet + " money\n");
            UserInterface.DisplayCurrentInventory(humanPlayer.inventory);

            UserInterface.DisplayStoreMenu();
            storeOption = Console.ReadLine();
            switch (storeOption)
            {
                case "lemons":
                    SellLemons(humanPlayer.inventory.lemons, humanPlayer.accounting);
                    RunStore(humanPlayer);
                    break;
                case "ice":
                    SellIce(humanPlayer.inventory.ice, humanPlayer.accounting);
                    RunStore(humanPlayer);
                    break;
                case "sugar":
                    SellSugar(humanPlayer.inventory.sugar, humanPlayer.accounting);
                    RunStore(humanPlayer);
                    break;
                case "cups":
                    SellCups(humanPlayer.inventory.cups, humanPlayer.accounting);
                    RunStore(humanPlayer);
                    break;
                case "start":
                    break;
                default:
                    RunStore(humanPlayer);
                    break;
            }

        }

        public void SellLemons(List<Lemons> lemons, Accounting accounting)
        {
            UserInterface.HowManyLemons();
            try
            {
                int lemonsRequested = int.Parse(Console.ReadLine());
                if (lemonItem.price * lemonsRequested > accounting.wallet)
                {
                    UserInterface.InsufficentFunds();
                }
                else
                {
                    accounting.wallet -= (lemonItem.price * lemonsRequested);
                    accounting.expeditures = (accounting.expeditures + lemonItem.price);
                    for (int i = 0; i < lemonsRequested; i++)
                    {
                        lemons.Add(lemonItem);
                    }

                }
            }
            catch(Exception e)
            {
                UserInterface.WholeIntException();
            } 
        }


        public void SellIce(List<Ice> ice, Accounting accounting)
        {
            try
            {
                UserInterface.HowManyIce();
                int iceRequested = int.Parse(Console.ReadLine());
                if (iceItem.price * iceRequested > accounting.wallet)
                {
                    UserInterface.InsufficentFunds();
                }
                else
                {
                    accounting.wallet -= (iceItem.price * iceRequested);
                    accounting.expeditures = (accounting.expeditures + iceItem.price);
                    for (int i = 0; i < iceRequested; i++)
                    {
                        ice.Add(iceItem);
                    }
                }
            }
            catch (Exception a)
            {
                UserInterface.WholeIntException();
            }
                
        }
        public void SellSugar(List<Sugar> sugar, Accounting accounting)
        {
            try
            {
                UserInterface.HowManySugar();
                int sugarRequested = int.Parse(Console.ReadLine());
                if (sugarItem.price * sugarRequested > accounting.wallet)
                {
                    UserInterface.InsufficentFunds();
                }
                else
                {
                    accounting.wallet -= (sugarItem.price * sugarRequested);
                    accounting.expeditures = (accounting.expeditures + sugarItem.price);
                    for (int i = 0; i < sugarRequested; i++)
                    {
                        sugar.Add(sugarItem);
                    }
                }
            }
            catch (Exception a)
            {
                UserInterface.WholeIntException();
            }
                
        }

        public void SellCups(List<Cups> cups, Accounting accounting)
        {
            try
            {
                UserInterface.HowManyCups();
                int cupsRequested = int.Parse(Console.ReadLine());
                if (cupsItem.price * cupsRequested > accounting.wallet)
                {
                    UserInterface.InsufficentFunds();
                }
                else
                {
                    accounting.wallet -= (cupsItem.price * cupsRequested);
                    accounting.expeditures = (accounting.expeditures + cupsItem.price);
                    for (int i = 0; i < cupsRequested; i++)
                    {
                        cups.Add(cupsItem);
                    }
                }
            }
            catch
            {
                UserInterface.WholeIntException();
            }
            

        }

        
    }
}
