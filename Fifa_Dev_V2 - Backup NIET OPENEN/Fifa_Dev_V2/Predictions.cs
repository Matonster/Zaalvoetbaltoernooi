using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa_Dev_V2
{
    class Predictions
    {
        public static void Predict(string match, int score1, int score2)
        {
            // Add user id, matchid, score1, score2 to tblPredictions
<<<<<<< HEAD
            using (SqlCeCommand cmd = new SqlCeCommand("INSERT INTO [tblPredictions] ([User_ID], [Game_ID], [PredictionHomeScore], [PredictionAwayScore]) VALUES (@User_ID, @Game_ID, @PredictionHomeScore, @PredictionAwayScore)"))
            {
                cmd.Parameters.AddWithValue("User_ID", formLogin.userID);
                cmd.Parameters.AddWithValue("Game_ID", match);
                cmd.Parameters.AddWithValue("PredictionHomeScore", score1);
                cmd.Parameters.AddWithValue("PredictionAwayScore", score2);
                cmd.Connection = dbh.GetCon();
                dbh.OpenConnectionToDB();
                cmd.ExecuteNonQuery();
                dbh.CloseConnectionToDB();
            }
=======
>>>>>>> 52e44c3038e509cb91a951b3810e9dda82c8d1df
        }
    }
}
