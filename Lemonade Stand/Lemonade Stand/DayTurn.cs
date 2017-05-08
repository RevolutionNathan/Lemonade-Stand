using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class DayTurn
    {
        
        Weather weather = new Weather();
        Store store = new Store();
        Random rnd = new Random();
        public List<Customer> customers = new List<Customer>();
        SQL sql = new SQL();

       
        public int dayNumber = 0;
        public int gameLength;
        public int cupsSold;
        public double pricePerCup;
        public int nCustomers;
        public string gameLengthString;
        public string weekday;
        public int dailyTemp;
        public string dailyCondition;
        public int tomorrowTemp;
        public string tomorrowCondition;
        public double turnProfits;
        public double netProfit;

        public void Turn(HumanPlayer humanPlayer, Recipe recipe, Inventory inventory, Accounting accounting, int numberTurnsInt)
        {
            for (int i = 0; i < numberTurnsInt; i++)
            {
                UserInterface.LineBreak();
                ResetCounts();
                DayNamer();
                UserInterface.PrintTurnWelcomeDayNumber(dayNumber);
                UserInterface.PrintWeekDay(weekday);
                dailyCondition = weather.RollConditions();
                dailyTemp = weather.TemperatureRoll();
                UserInterface.PrintWeather(dailyTemp, dailyCondition);
                tomorrowTemp = weather.TemperatureRoll();
                tomorrowCondition = weather.RollConditions();
                UserInterface.PrintTomorrowWeather(tomorrowTemp, tomorrowCondition);
                store.RunStore(humanPlayer);
                humanPlayer.recipe.RecipeBuilder(inventory);
                CustomerGenerator();
                WeatherImpactsDesire();
                SetPricePerCup();
                PointOfSale(humanPlayer, recipe, inventory);
                CalculateNetProfit(accounting);
                EndOfTurnReport();
                sql.InsertIntoDatabase(humanPlayer, accounting, this, numberTurnsInt);
                dayNumber++;
                UserInterface.StartNextTurn();
                Console.ReadKey();
                UserInterface.LineBreak();
            }
            EndOfGameReport();
            ClearVariables(inventory, recipe);
        }

        public void EndOfGameReport()
        {
            UserInterface.LineBreak();
            UserInterface.GameEnded(dayNumber);
            UserInterface.NetProfit(this);
            UserInterface.Restart();
            UserInterface.LineBreak();
            Console.ReadKey();
            
        }

        public void ClearVariables(Inventory inventory, Recipe recipe)
        {
            inventory.lemons.Clear();
            inventory.cups.Clear();
            inventory.ice.Clear();
            inventory.sugar.Clear();
            recipe.lemonsPerPitcher = 0;
            recipe.icePerPitcher = 0;
            recipe.sugarPerPitcher = 0;

        }
        public void ResetCounts()
        {
            cupsSold = 0;
            turnProfits = 0;

        }
       public double SetPricePerCup()
        {
            UserInterface.AskPricePerCup();
            pricePerCup = double.Parse(Console.ReadLine());
            return pricePerCup;
        }
        public int CustomerGenerator()
        {
            nCustomers = rnd.Next(80, 100);
            for (int i = 0; i < nCustomers; i++)
            {
                customers.Add(new Customer(rnd));
            }
            return nCustomers;
        }
        public void WeatherImpactsDesire()
        {
            for (int i =0; i < nCustomers; i++)
            {
                customers[i].desire = customers[i].desire + weather.conditionsRoll;
            }
        }
        public void PointOfSale(HumanPlayer humanPlayer, Recipe recipe, Inventory inventory)
        {
            MakeAPitcher(recipe, inventory);
            for (int i = 0; i < nCustomers; i++)
            {
                if (customers[i].desire < recipe.desireability - pricePerCup)
                {
                    if ((cupsSold % 10) == 0 && cupsSold != 0)
                    {
                        MakeAPitcher(recipe, inventory);
                    }
                    if (inventory.cups.Count > 0)
                    {
                        inventory.cups.RemoveAt(0);
                        cupsSold = cupsSold + 1;
                        humanPlayer.accounting.wallet = humanPlayer.accounting.wallet + pricePerCup;
                        turnProfits += pricePerCup;
                    }
                }
            }
        }
        
        public double CalculateNetProfit(Accounting accounting)
        {
            netProfit = accounting.wallet - accounting.startingWallet;
            return netProfit;
        }
        public void EndOfTurnReport()
        {
            UserInterface.TurnCupsSold(this);
            UserInterface.TurnProfits(this);
            UserInterface.NetProfit(this);
        }

        public void MakeAPitcher(Recipe recipe, Inventory inventory)
        {
            if (SubtractSugar(recipe, inventory) == true && SubtractLemons(recipe, inventory) == true && SubtractIce(recipe, inventory) == true)
            {
                Console.Write("sold one pitcher");

            }
            else
            {
                UserInterface.OutOfIngredients();
            }
        }
        public bool SubtractLemons(Recipe recipe, Inventory inventory)
        {
            if (inventory.lemons.Count > recipe.lemonsPerPitcher)
            {
                for (int i = 0; i < recipe.lemonsPerPitcher; i++)
                {
                    inventory.lemons.RemoveAt(0);
                }
                return true;
            }
            else
            {
                UserInterface.OutOfLemons();
                return false;

            }
            
        }
        public bool SubtractIce(Recipe recipe, Inventory inventory)
        {
            if (inventory.ice.Count > recipe.icePerPitcher)
            {
                for (int i = 0; i < recipe.icePerPitcher; i++)
                {
                    inventory.ice.RemoveAt(0);
                }
                return true;
            }
            else
            {
                UserInterface.OutOfIce();
                return false;
            }
           
        }

        public bool SubtractSugar(Recipe recipe, Inventory inventory)
        {
            if (inventory.sugar.Count > recipe.sugarPerPitcher)
            {
                for (int i = 0; i < recipe.sugarPerPitcher; i++)
                {
                    inventory.sugar.RemoveAt(0);
                }
                return true;
            }
            else
            {
                UserInterface.OutOfSugar();
                return false;
            }
            
        }

        public void SubtractCups(Recipe recipe, Inventory inventory)
        {
            for (int i = 0; i < recipe.cupsPerPitcher; i++)
            {
                inventory.cups.RemoveAt(0);
            }
        }
        public string GetGameLength()
        {
            gameLengthString = Console.ReadLine();
            return gameLengthString;
        }

        public int ConvertGameLength()
        {
            gameLength = int.Parse(gameLengthString);
            return gameLength;
        }

        public int TurnCounter()
        {
            dayNumber = dayNumber++;
            return dayNumber;
        }
        public string DayNamer()
        {
            if (dayNumber % 7  == 0)
            {
                weekday = "Sunday";
                return weekday;
            }
            else if (dayNumber % 7 == 1)
            {
                weekday = "Monday";
                return weekday;
            }
            else if (dayNumber % 7 == 2)
            {
                weekday = "Tuesday";
                return weekday;
            }
            else if (dayNumber % 7 == 3)
            {
                weekday = "Wednesday";
                return weekday;
            }
            else if (dayNumber % 7 == 4)
            {
                weekday = "Thursday";
                return weekday;
            }
            else if (dayNumber % 7 == 5)
            {
                weekday = "Friday";
                return weekday;
            }
            else if (dayNumber % 7 == 6)
            {
                weekday = "Saturday";
                return weekday;
            }
            else
            { return weekday;
            }

        }
    }
}
