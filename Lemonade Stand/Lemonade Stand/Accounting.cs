using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Accounting
    {
        public double wallet;
        public double walletEasy = 50;
        public double walletNormal = 35;
        public double walletHard = 20;
        public double expeditures;
        public double startingWallet;
        public string difficultyChoice;

        public string SaveDifficulty()
        {
            difficultyChoice = Console.ReadLine();
            return difficultyChoice;
        }
        public double SetWallet()
        {
            UserInterface.LineBreak();
            UserInterface.GameDifficultyPrompt();
            SaveDifficulty();
            switch (difficultyChoice)
            {
                case "easy":
                    wallet = walletEasy;
                    startingWallet = walletEasy;
                    return wallet;
                case "normal":
                    wallet = walletNormal;
                    startingWallet = walletNormal;
                    return wallet;
                case "hard":
                    wallet = walletHard;
                    startingWallet = walletHard;
                    return wallet;
                default:
                    SetWallet();
                    return wallet;
            }
        }

        
        //
    }
}
