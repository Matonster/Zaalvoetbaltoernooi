using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifa_Dev_V2
{
    public partial class FormMain : Form
    {
<<<<<<< HEAD
        FormPredictionHistory formPred = new FormPredictionHistory();
        Predictions pred = new Predictions();
        DatabaseHandler dbh = new DatabaseHandler();
        DataTable dt = new DataTable();
        SqlCeDataAdapter da;
        SqlCeCommandBuilder cb;
        
=======
>>>>>>> 52e44c3038e509cb91a951b3810e9dda82c8d1df
        public FormMain()
        {
            InitializeComponent();

            lblCurrenttime.Text = DateTime.Now.ToString();
            btnBets.Enabled = DateTime.Now < new DateTime(2014, 06, 12);
            SetLeaderboards();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBetHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            Predictions.Predict(txtGame.Text, int.Parse(txtTeam1.Text), int.Parse(txtTeam1.Text));
        }

        private void SetLeaderboards()
        {
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM tblUsers"))
            {
                dt.Clear();
                dbh.OpenConnectionToDB();
                cmd.Connection = dbh.GetCon();
                da = new SqlCeDataAdapter(cmd);
                cb = new SqlCeCommandBuilder(da);
                da.Fill(dt);
                dbh.CloseConnectionToDB();
                dtgLeaderboard.DataSource = dt;
            }
        }
    }
}
