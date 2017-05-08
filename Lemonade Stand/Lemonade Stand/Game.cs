using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        public string mainMenuChoice;
        public string difficultyChoice;
        public string numberTurns;
        public string newOrMainGameAnswer;
        public int numberTurnsInt;

        DayTurn dayTurn = new DayTurn();
        HumanPlayer humanPlayer = new HumanPlayer();
        SQL sql = new SQL();

        public void RunMainMenu()
        {
            UserInterface.LineBreak();
            UserInterface.PrintMenuOptions();
            SaveMainMenuChoice();
            MainMenuSwitchboard();
           
        }
        public void MainMenuSwitchboard()
        {
            switch (mainMenuChoice)
            {
                case "new":
                    RunNewGameMenu();
                    break;
                case "save":
                    SaveGameMenu();
                    break;
                case "scores":
                    sql.GetSaveGame(this);
                    break;
                default:
                    RunMainMenu();
                    break;
            }

        }
        public void RunNewGameMenu()
        {
            UserInterface.LineBreak();
            UserInterface.PlayerNamePrompt();
            SaveName();
            humanPlayer.accounting.SetWallet();
            UserInterface.LineBreak();
            UserInterface.NumberTurnsPrompt();
            SaveNumberTurns();
            ConvertTurnsToInt();
            StartGameOrMainMenu();
        }
        public void StartGameOrMainMenu()
        {
            UserInterface.LineBreak();
            UserInterface.StartNewOrMainPrompt();
            SaveNewOrMainPrompt();
            switch (newOrMainGameAnswer)
            {
                case "start":
                    dayTurn.Turn(humanPlayer, humanPlayer.recipe, humanPlayer.inventory, humanPlayer.accounting, numberTurnsInt);
                    RunMainMenu();
                    break;
                case "main":
                    RunMainMenu();
                    break;
                default:
                    StartGameOrMainMenu();
                    break;
            }
        }
        public void SaveGameMenu()
        {

        }

        public string SaveMainMenuChoice()
        {
            mainMenuChoice = Console.ReadLine();
            return mainMenuChoice;
        }

        public string SaveName()
        {
            humanPlayer.name = Console.ReadLine();
            return humanPlayer.name;
        }
        public string NumberTurnsStore()
        {
            numberTurns = Console.ReadLine();
            return numberTurns;
        }

        public string SaveDifficulty()
        {
            difficultyChoice = Console.ReadLine();
            return difficultyChoice;
        }
        public string SaveNewOrMainPrompt()
        {
            newOrMainGameAnswer = Console.ReadLine();
            return newOrMainGameAnswer;
        }

        public string SaveNumberTurns()
        {
            numberTurns = "0";
            try
            {
                numberTurns = Console.ReadLine();
                return numberTurns;
            }
            catch
            {
                UserInterface.EnterStringException();
            }
            return numberTurns;
            
        }

        public int ConvertTurnsToInt()
        {
            try
            {
                numberTurnsInt = int.Parse(numberTurns);
                return numberTurnsInt;
            }
            catch
            {
                UserInterface.NumberTurnsPrompt();
                SaveNumberTurns();
                ConvertTurnsToInt();
            }
            return numberTurnsInt;
        }
    }
}

