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
    public partial class FormLogin : Form
    {
        private DatabaseHandler dbh;
        private Form frmAdmin;
        private FormMain formMain;

        public FormLogin()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
<<<<<<< HEAD
            //formAdmin = new FormAdmin();
            //formMain = new FormMain();
=======
            //frmAdmin = new frmAdmin();
            //frmRanking = new frmRanking();
            //frmPlayer = new frmPlayer(frmRanking);
>>>>>>> 52e44c3038e509cb91a951b3810e9dda82c8d1df
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Both fields are required");
            }
            else
            {
                dbh.TestConnection();
                dbh.OpenConnectionToDB();
                bool exist = false;

                using (SqlCeCommand cmd = new SqlCeCommand("SELECT COUNT(*) FROM [tblUsers] WHERE Username = @Username", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                    exist = (int)cmd.ExecuteScalar() > 0;
                }

                if (exist)
                {
                    MessageHandler.ShowMessage("This user already exists.");
                }
                else
                {
                    using (SqlCeCommand cmd = new SqlCeCommand("INSERT INTO [tblUsers] ([Username], [Password], [IsAdmin]) VALUES (@Username, @Password, @IsAdmin)"))
                    {
                        cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("IsAdmin", 0);
                        cmd.Connection = dbh.GetCon();
                        cmd.ExecuteNonQuery();
                    }
                }

                dbh.CloseConnectionToDB();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (dbh.GetCon().State == ConnectionState.Open)
                {
                    dbh.CloseConnectionToDB();
                }
                Application.Exit();
            }
        }

        private void btnShowRanking_Click(object sender, EventArgs e)
        {
            //frmRanking.Show(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            bool exist = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            txtUsername.Text = "";
            txtPassword.Text = "";

            using (SqlCeCommand cmd = new SqlCeCommand("SELECT COUNT(*) FROM [tblUsers] WHERE Username = @Username AND Password = @Password", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("Username", username);
                cmd.Parameters.AddWithValue("Password", password);
                exist = (int)cmd.ExecuteScalar() > 0;
            }           

            if (exist)
            {
                bool admin;
                using (SqlCeCommand cmd = new SqlCeCommand("SELECT COUNT(*) from [tblUsers] WHERE Username = @Username AND IsAdmin = 1", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Username", username);
                    admin = (int)cmd.ExecuteScalar() > 0;
                }
                dbh.CloseConnectionToDB();

                if (admin)
                {
                    frmAdmin.Show();
                }
                else
                {
                    formMain = new FormMain();
                    formMain.Show();
                }
            }
            else
            {
                dbh.CloseConnectionToDB();
                MessageHandler.ShowMessage("Wrong username and/or password.");
            }
<<<<<<< HEAD

            SqlCeCommand uCmd = new SqlCeCommand("SELECT id from [tblUsers] WHERE Username = @Username", dbh.GetCon());
            uCmd.Parameters.AddWithValue("Username", username);
            dbh.OpenConnectionToDB();
            userID = (int)uCmd.ExecuteNonQuery();
            dbh.CloseConnectionToDB();
=======
>>>>>>> 52e44c3038e509cb91a951b3810e9dda82c8d1df
        }
    }
}
