using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fifa_Dev_V2
{
    class Predictions
    {
        SqlConnection dbConnection = new SqlConnection(@".\ProjectFifaV2\ProjectFifaV2\DB.sdf");
        SqlCommand dbCommand;
        SqlDataAdapter dbAdapter;
        SqlCommandBuilder dbBuilder;
        DataTable dbTable;

        public void Predict(string match, int score1, int score2)
        {
            dbConnection.Open();

            // Add user id, matchid, score1, score2 to tblPredictions
        }
    }
}
