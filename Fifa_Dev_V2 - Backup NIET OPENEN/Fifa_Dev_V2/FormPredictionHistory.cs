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
    public partial class FormPredictionHistory : Form
    {
        DatabaseHandler dbh = new DatabaseHandler();
        DataTable dt = new DataTable();
        SqlCeDataAdapter da;
        SqlCeCommandBuilder cb;

        public FormPredictionHistory()
        {
            InitializeComponent();
            SetData();
        }

        private void SetData()
        {
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM tblPredictions"))
            {
                dt.Clear();
                dbh.OpenConnectionToDB();
                cmd.Connection = dbh.GetCon();
                da = new SqlCeDataAdapter(cmd);
                cb = new SqlCeCommandBuilder(da);
                da.Fill(dt);
                dbh.CloseConnectionToDB();
                this.dataGridView1.DataSource = dt;
            }
        }
    }
}
