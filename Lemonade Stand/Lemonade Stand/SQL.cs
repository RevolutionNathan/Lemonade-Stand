using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lemonade_Stand
{
    class SQL
    {
        public string searchName;
     
        public void InsertIntoDatabase(HumanPlayer humanPlayer, Accounting accounting, DayTurn dayTurn, int numberTurnsInt)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = "Server=localhost;Database=LemonadeStand;Trusted_Connection=True";
                connect.Open();
                string query = "INSERT INTO SavedGamesLemonade (Player_Name, Current_Wallet, Current_Day, Length_Of_Game, Cup_Inventory, Lemon_Inventory, Sugar_Inventory, Net_Money) VALUES (@Player_Name, @Current_Wallet, @Current_Day, @Length_Of_Game, @Cup_Inventory, @Lemon_Inventory, @Sugar_Inventory, @Net_Money)";
                SqlCommand insertCommand = new SqlCommand(query, connect);
                insertCommand.Parameters.AddWithValue("@Player_Name", humanPlayer.name);
                insertCommand.Parameters.AddWithValue("@Current_Wallet", accounting.wallet);
                insertCommand.Parameters.AddWithValue("@Current_Day", dayTurn.dayNumber);
                insertCommand.Parameters.AddWithValue("@Length_Of_Game", numberTurnsInt);
                insertCommand.Parameters.AddWithValue("@Cup_Inventory", humanPlayer.inventory.cups.Count);
                insertCommand.Parameters.AddWithValue("@Lemon_Inventory", humanPlayer.inventory.lemons.Count);
                insertCommand.Parameters.AddWithValue("@Sugar_Inventory", humanPlayer.inventory.sugar.Count);
                insertCommand.Parameters.AddWithValue("@Net_Money", dayTurn.netProfit);
                insertCommand.ExecuteNonQuery();
            }
        }

        public void GetSaveGame(Game game)
        {   
            //using (SqlConnection connect = new SqlConnection())
            //{
            //    connect.ConnectionString = "Server=NATHANWHITCC91E;Database=RockSpock;Trusted_Connection=true";
            //    connect.Open();

            //    SqlCommand command = new SqlCommand("SELECT * FROM SavedGamesLemonade WHERE @Player_Name LIKE searchName", connect);
            //    command.Parameters.Add(new SqlParameter("Player_Name", searchName));
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {

            //        while (reader.Read())
            //        {
            //            string game.humanPlayer.name = reader.GetString(1);
            //            int game.humanPlayer.wallet = reader.GetInt32(2);


            //        }
            //    }
            //}
        }

    }
}


