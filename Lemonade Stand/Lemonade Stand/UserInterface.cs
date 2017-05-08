using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    static class UserInterface
    {
        public static void StartNewOrMainPrompt()
        {
            Console.WriteLine("Are you ready to start the game or do you want to go back to the Main Menu? Start or Main. \n");
        }
        public static void PrintMenuOptions()
        {
            Console.WriteLine("Main Menu: \nNew Game\nSaved Game\nHigh Sores\n");
        }

        public static void GameDifficultyPrompt()
        {
            Console.WriteLine("Choose difficulty: Easy, Normal, Hard \n");
        }

        public static void PlayerNamePrompt()
        {
            Console.WriteLine("What's you name, stranger? \n");
        }
        public static void NumberTurnsPrompt()
        {
            Console.Write("You can play for as few or as many days as you wish, but be warned, Lemonade Stand never fails to exact it's toll. \nHow days do you wish to play.\n");
        }

        public static void GameEnded(int dayNumber)
        {
            Console.Write("After " + dayNumber + " days, your watch has ended. Your net profits (money earned - starting money) are:");
        }
        public static void PrintTurnWelcomeDayNumber(int dayNumber)
        {
            Console.Write("Welcome to day " + dayNumber + "\n");
        }

        public static void Restart()
        {
            Console.Write("Press any key to restart Lemonade Stand\n");
        }

        public static void PrintWeekDay(string weekday)
        {
            Console.WriteLine("Today is " + weekday + "\n");
        }

        public static void PrintWeather(int dailyTemp, string dailyCondition)
        {

            Console.WriteLine("Todays's weather is: " + dailyTemp + " degrees and " + dailyCondition + "\n");
        }

        public static void PrintTomorrowWeather(int tomorrowTemp, string tomorrowCondition)
        {

            Console.WriteLine("Tomorrow's weather is: " + tomorrowTemp + " degrees and " + tomorrowCondition + "\n");
        }

        public static void WelcomeToStore()
        {
            Console.WriteLine("Welcome to the store.\n");
        }

        
        public static void LineBreak()
        {
            Console.WriteLine("\n_____________________________________________________________\n");
        }
        public static void DisplayCurrentInventory(Inventory inventory)
        {
            Console.WriteLine("You have\n" + inventory.lemons.Count + " lemons\n" + inventory.ice.Count + " Ice\n" + inventory.sugar.Count + " Sugar\n" + inventory.cups.Count + " Cups");
        }

        public static void StartNextTurn()
        {
            Console.WriteLine("Press any key to start next turn.\n");
        }
        public static void NetProfit(DayTurn dayTurn)
        {
            Console.WriteLine("\nNet Profits to-date: " + dayTurn.netProfit + "\n");
        }
        public static void DisplayStoreMenu()
        {
            Console.WriteLine("Do you want to buy more lemons, ice, sugar, or cups? Or do you want to start?\n");
        }

        public static void OutOfLemons()
        {
            Console.Write("Not enough Lemons.\n");
        }

        public static void OutOfIce()
        {
            Console.Write("Not enough ice.\n");
        }

        public static void OutOfSugar()
        {
            Console.Write("Not enough Sugar.\n");
        }
        public static void HowManyLemons()
        {
            Console.WriteLine("Lemons cost .25 cents each. How many lemons do you want to buy?\n");
        }

        public static void HowManyLemonsRecipe()
        {
            Console.WriteLine("How many lemons do you want to use per pitcher of lemonade\n");
        }

        public static void HowManyIceRecipe()
        {
            Console.WriteLine("How much ice do you want to use per pitcher of lemonade\n");
        }

        public static void AskPricePerCup()
        {
            Console.WriteLine("How much do you want to charge for each cup?\n");
        }
        
        public static void EnterStringException()
        {
            Console.Write("Please enter a string in whole numbers.\n");
        }
        public static void HowManySugarRecipe()
        {
            Console.WriteLine("How much sugar do you want to use per pitcher of lemonade.\n");
        }

        public static void RecipeBuilderPrompt(Recipe recipe)
        {
            Console.WriteLine("Let's make a recipe/n");
            Console.WriteLine("1 pitcher of Lemonde is currently made with:\n" + recipe.lemonsPerPitcher + "lemons \n" + recipe.icePerPitcher + "ice \n" + recipe.sugarPerPitcher + "sugar");
        }

        public static void PrintCurrentRecipe(Recipe recipe)
        {
            Console.WriteLine("1 pitcher of Lemonde is currently made with:\n" + recipe.lemonsPerPitcher + "lemons \n" + recipe.icePerPitcher + "ice \n" + recipe.sugarPerPitcher + "sugar");
        }
        public static void OutOfIngredients()
        {
            Console.Write("You ran out of ingredients and can't make any more pitchers. Today's turn is over.\n");
        }
        public static void HowManyIce()
        {
            Console.WriteLine("Ice costs .15 cents. How much ice do you want to buy?\n");
        }

        public static void TurnCupsSold(DayTurn dayTurn)
        {
            Console.Write("You sold " + dayTurn.cupsSold + " cups today.\n");
        }
        public static void TurnProfits(DayTurn dayTurn)
        {
            Console.Write("You earned " + dayTurn.turnProfits + " dollars today. \n");
        }

        public static void WholeIntException()
        {
            Console.Write("you must enter a whole int. try again\n");
        }
            

        public static void HowManySugar()
        {
            Console.WriteLine("Sugar cost .35 cents. How much sugar do you want to buy?\n");
        }

        public static void HowManyCups()
        {
            Console.WriteLine("Cups cost .01 cents each. How many cups do you want to buy?\n");
        }

        public static  void InsufficentFunds()
        {
            Console.WriteLine("Insufficient Funds\n");
        }

        public static void PrintWalletContents()
        {

        }
            




    }
}



//public void PrintSunny()
//{
//    Console.WriteLine("Sunny");
//}

//public void PrintCloudy()
//{
//    Console.WriteLine("Cloudy");
//}

//public void PrintRainy()
//{
//    Console.WriteLine("Rainy");
//}