namespace Fifa_Dev_Edition
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.lblUsernameTxt = new System.Windows.Forms.Label();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.dtgLeaderboard = new System.Windows.Forms.DataGridView();
            this.btnBetHistory = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabPredictions = new System.Windows.Forms.TabPage();
            this.btnBets = new System.Windows.Forms.Button();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.txtTeam2 = new System.Windows.Forms.TextBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.txtTeam1 = new System.Windows.Forms.TextBox();
            this.lblWedstrijdTxt = new System.Windows.Forms.Label();
            this.lblWedstrijdScoreTxt = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.dtgInfo = new System.Windows.Forms.DataGridView();
            this.lblCurrentTimeTxt = new System.Windows.Forms.Label();
            this.lblCurrenttime = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLeaderboard)).BeginInit();
            this.tabPredictions.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabPredictions);
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Location = new System.Drawing.Point(-4, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(834, 526);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblScore);
            this.tabHome.Controls.Add(this.lblUsername);
            this.tabHome.Controls.Add(this.lblScoreTxt);
            this.tabHome.Controls.Add(this.lblUsernameTxt);
            this.tabHome.Controls.Add(this.btnLeaderboard);
            this.tabHome.Controls.Add(this.dtgLeaderboard);
            this.tabHome.Controls.Add(this.btnBetHistory);
            this.tabHome.Controls.Add(this.btnLogOut);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(826, 497);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(123, 66);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 23);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "error";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(123, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 23);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "error";
            // 
            // lblScoreTxt
            // 
            this.lblScoreTxt.AutoSize = true;
            this.lblScoreTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTxt.Location = new System.Drawing.Point(15, 66);
            this.lblScoreTxt.Name = "lblScoreTxt";
            this.lblScoreTxt.Size = new System.Drawing.Size(63, 23);
            this.lblScoreTxt.TabIndex = 5;
            this.lblScoreTxt.Text = "Score:";
            // 
            // lblUsernameTxt
            // 
            this.lblUsernameTxt.AutoSize = true;
            this.lblUsernameTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTxt.Location = new System.Drawing.Point(15, 34);
            this.lblUsernameTxt.Name = "lblUsernameTxt";
            this.lblUsernameTxt.Size = new System.Drawing.Size(103, 23);
            this.lblUsernameTxt.TabIndex = 4;
            this.lblUsernameTxt.Text = "Username:";
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.Location = new System.Drawing.Point(285, 0);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(535, 52);
            this.btnLeaderboard.TabIndex = 3;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            // 
            // dtgLeaderboard
            // 
            this.dtgLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLeaderboard.Location = new System.Drawing.Point(285, 52);
            this.dtgLeaderboard.Name = "dtgLeaderboard";
            this.dtgLeaderboard.RowTemplate.Height = 24;
            this.dtgLeaderboard.Size = new System.Drawing.Size(535, 439);
            this.dtgLeaderboard.TabIndex = 2;
            // 
            // btnBetHistory
            // 
            this.btnBetHistory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetHistory.Location = new System.Drawing.Point(15, 380);
            this.btnBetHistory.Name = "btnBetHistory";
            this.btnBetHistory.Size = new System.Drawing.Size(131, 50);
            this.btnBetHistory.TabIndex = 1;
            this.btnBetHistory.Text = "History";
            this.btnBetHistory.UseVisualStyleBackColor = true;
            this.btnBetHistory.Click += new System.EventHandler(this.btnBetHistory_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(15, 436);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(131, 50);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabPredictions
            // 
            this.tabPredictions.Controls.Add(this.btnBets);
            this.tabPredictions.Controls.Add(this.txtGame);
            this.tabPredictions.Controls.Add(this.txtTeam2);
            this.tabPredictions.Controls.Add(this.lblTeam2);
            this.tabPredictions.Controls.Add(this.lblTeam1);
            this.tabPredictions.Controls.Add(this.txtTeam1);
            this.tabPredictions.Controls.Add(this.lblWedstrijdTxt);
            this.tabPredictions.Controls.Add(this.lblWedstrijdScoreTxt);
            this.tabPredictions.Location = new System.Drawing.Point(4, 25);
            this.tabPredictions.Name = "tabPredictions";
            this.tabPredictions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPredictions.Size = new System.Drawing.Size(826, 497);
            this.tabPredictions.TabIndex = 1;
            this.tabPredictions.Text = "Predictions";
            this.tabPredictions.UseVisualStyleBackColor = true;
            // 
            // btnBets
            // 
            this.btnBets.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBets.Location = new System.Drawing.Point(351, 293);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(182, 75);
            this.btnBets.TabIndex = 4;
            this.btnBets.Text = "Predict!";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // txtGame
            // 
            this.txtGame.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGame.Location = new System.Drawing.Point(222, 152);
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(491, 46);
            this.txtGame.TabIndex = 1;
            // 
            // txtTeam2
            // 
            this.txtTeam2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam2.Location = new System.Drawing.Point(649, 230);
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(64, 46);
            this.txtTeam2.TabIndex = 3;
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(521, 233);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(118, 38);
            this.lblTeam2.TabIndex = 0;
            this.lblTeam2.Text = "Team 2";
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(246, 233);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(118, 38);
            this.lblTeam1.TabIndex = 0;
            this.lblTeam1.Text = "Team 1";
            // 
            // txtTeam1
            // 
            this.txtTeam1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam1.Location = new System.Drawing.Point(374, 230);
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Size = new System.Drawing.Size(64, 46);
            this.txtTeam1.TabIndex = 2;
            // 
            // lblWedstrijdTxt
            // 
            this.lblWedstrijdTxt.AutoSize = true;
            this.lblWedstrijdTxt.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedstrijdTxt.Location = new System.Drawing.Point(50, 155);
            this.lblWedstrijdTxt.Name = "lblWedstrijdTxt";
            this.lblWedstrijdTxt.Size = new System.Drawing.Size(163, 38);
            this.lblWedstrijdTxt.TabIndex = 0;
            this.lblWedstrijdTxt.Text = "Wedstrijd:";
            // 
            // lblWedstrijdScoreTxt
            // 
            this.lblWedstrijdScoreTxt.AutoSize = true;
            this.lblWedstrijdScoreTxt.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedstrijdScoreTxt.Location = new System.Drawing.Point(50, 233);
            this.lblWedstrijdScoreTxt.Name = "lblWedstrijdScoreTxt";
            this.lblWedstrijdScoreTxt.Size = new System.Drawing.Size(163, 38);
            this.lblWedstrijdScoreTxt.TabIndex = 0;
            this.lblWedstrijdScoreTxt.Text = "Wedstrijd:";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.dtgInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(826, 497);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // dtgInfo
            // 
            this.dtgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfo.Location = new System.Drawing.Point(3, 6);
            this.dtgInfo.Name = "dtgInfo";
            this.dtgInfo.RowTemplate.Height = 24;
            this.dtgInfo.Size = new System.Drawing.Size(817, 485);
            this.dtgInfo.TabIndex = 0;
            // 
            // lblCurrentTimeTxt
            // 
            this.lblCurrentTimeTxt.AutoSize = true;
            this.lblCurrentTimeTxt.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentTimeTxt.Name = "lblCurrentTimeTxt";
            this.lblCurrentTimeTxt.Size = new System.Drawing.Size(89, 17);
            this.lblCurrentTimeTxt.TabIndex = 1;
            this.lblCurrentTimeTxt.Text = "Current time:";
            // 
            // lblCurrenttime
            // 
            this.lblCurrenttime.AutoSize = true;
            this.lblCurrenttime.Location = new System.Drawing.Point(107, 9);
            this.lblCurrenttime.Name = "lblCurrenttime";
            this.lblCurrenttime.Size = new System.Drawing.Size(36, 17);
            this.lblCurrenttime.TabIndex = 2;
            this.lblCurrenttime.Text = "0.00";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Fifa_Dev_Edition.Properties.Resources.logoradiuscollege;
            this.picLogo.Location = new System.Drawing.Point(632, 1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(191, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblCurrenttime);
            this.Controls.Add(this.lblCurrentTimeTxt);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "SchoolPredictions";
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLeaderboard)).EndInit();
            this.tabPredictions.ResumeLayout(false);
            this.tabPredictions.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabPredictions;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label lblCurrentTimeTxt;
        private System.Windows.Forms.Label lblCurrenttime;
        private System.Windows.Forms.Label lblScoreTxt;
        private System.Windows.Forms.Label lblUsernameTxt;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.DataGridView dtgLeaderboard;
        private System.Windows.Forms.Button btnBetHistory;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.TextBox txtTeam2;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.TextBox txtTeam1;
        private System.Windows.Forms.Label lblWedstrijdTxt;
        private System.Windows.Forms.Label lblWedstrijdScoreTxt;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dtgInfo;
    }
}