namespace Fifa_Dev_V2
{
    partial class FormPredictionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPredictionHistory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUsernameTxt = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCurrentScoretxt = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblCurrentRankingtxt = new System.Windows.Forms.Label();
            this.lblCurrentRanking = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 483);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblUsernameTxt
            // 
            this.lblUsernameTxt.AutoSize = true;
            this.lblUsernameTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTxt.Location = new System.Drawing.Point(12, 9);
            this.lblUsernameTxt.Name = "lblUsernameTxt";
            this.lblUsernameTxt.Size = new System.Drawing.Size(103, 23);
            this.lblUsernameTxt.TabIndex = 1;
            this.lblUsernameTxt.Text = "Username:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(121, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 23);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "error";
            // 
            // lblCurrentScoretxt
            // 
            this.lblCurrentScoretxt.AutoSize = true;
            this.lblCurrentScoretxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoretxt.Location = new System.Drawing.Point(207, 9);
            this.lblCurrentScoretxt.Name = "lblCurrentScoretxt";
            this.lblCurrentScoretxt.Size = new System.Drawing.Size(133, 23);
            this.lblCurrentScoretxt.TabIndex = 3;
            this.lblCurrentScoretxt.Text = "Current Score:";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.Location = new System.Drawing.Point(346, 9);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(55, 23);
            this.lblCurrentScore.TabIndex = 4;
            this.lblCurrentScore.Text = "error";
            // 
            // lblCurrentRankingtxt
            // 
            this.lblCurrentRankingtxt.AutoSize = true;
            this.lblCurrentRankingtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRankingtxt.Location = new System.Drawing.Point(427, 9);
            this.lblCurrentRankingtxt.Name = "lblCurrentRankingtxt";
            this.lblCurrentRankingtxt.Size = new System.Drawing.Size(155, 23);
            this.lblCurrentRankingtxt.TabIndex = 5;
            this.lblCurrentRankingtxt.Text = "Current Ranking:";
            // 
            // lblCurrentRanking
            // 
            this.lblCurrentRanking.AutoSize = true;
            this.lblCurrentRanking.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRanking.Location = new System.Drawing.Point(588, 9);
            this.lblCurrentRanking.Name = "lblCurrentRanking";
            this.lblCurrentRanking.Size = new System.Drawing.Size(55, 23);
            this.lblCurrentRanking.TabIndex = 6;
            this.lblCurrentRanking.Text = "error";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormPredictionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentRanking);
            this.Controls.Add(this.lblCurrentRankingtxt);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblCurrentScoretxt);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUsernameTxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPredictionHistory";
            this.Text = "Prediction_History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUsernameTxt;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCurrentScoretxt;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblCurrentRankingtxt;
        private System.Windows.Forms.Label lblCurrentRanking;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}