using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifa_Dev_V2
{
    public partial class FormMain : Form
    {
        FormPredictionHistory formPred = new FormPredictionHistory();
        Predictions pred = new Predictions();
        
        public FormMain()
        {
            InitializeComponent();

            lblCurrenttime.Text = DateTime.Now.ToString();

            btnBets.Enabled = DateTime.Now < new DateTime(2014, 06, 12);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBetHistory_Click(object sender, EventArgs e)
        {
            formPred.Show();
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            pred.Predict(int.Parse(txtGame.Text), int.Parse(txtTeam1.Text), int.Parse(txtTeam1.Text));
        }
    }
}
