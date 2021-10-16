
namespace Watc.UI
{
    partial class FrmNewMatch
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
            this.cbFirstTeamName = new System.Windows.Forms.ComboBox();
            this.cbSecondTeamName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnCreateNewMatch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudTeam2Score = new System.Windows.Forms.NumericUpDown();
            this.nudTeam1Score = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFirstTeamName
            // 
            this.cbFirstTeamName.DisplayMember = "Name";
            this.cbFirstTeamName.FormattingEnabled = true;
            this.cbFirstTeamName.Location = new System.Drawing.Point(124, 2);
            this.cbFirstTeamName.Name = "cbFirstTeamName";
            this.cbFirstTeamName.Size = new System.Drawing.Size(153, 21);
            this.cbFirstTeamName.TabIndex = 0;
            this.cbFirstTeamName.ValueMember = "Id";
            // 
            // cbSecondTeamName
            // 
            this.cbSecondTeamName.DisplayMember = "Name";
            this.cbSecondTeamName.FormattingEnabled = true;
            this.cbSecondTeamName.Location = new System.Drawing.Point(124, 26);
            this.cbSecondTeamName.Name = "cbSecondTeamName";
            this.cbSecondTeamName.Size = new System.Drawing.Size(153, 21);
            this.cbSecondTeamName.TabIndex = 1;
            this.cbSecondTeamName.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of First Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of Second Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date-Time";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "dd.MMM.yyyy hh:mm tt";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(124, 50);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(153, 20);
            this.dtpDateTime.TabIndex = 6;
            this.dtpDateTime.Value = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            // 
            // btnCreateNewMatch
            // 
            this.btnCreateNewMatch.Location = new System.Drawing.Point(7, 79);
            this.btnCreateNewMatch.Name = "btnCreateNewMatch";
            this.btnCreateNewMatch.Size = new System.Drawing.Size(476, 25);
            this.btnCreateNewMatch.TabIndex = 8;
            this.btnCreateNewMatch.Text = "Create a Match";
            this.btnCreateNewMatch.UseVisualStyleBackColor = true;
            this.btnCreateNewMatch.Click += new System.EventHandler(this.btnCreateNewMatch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Score of the First Team";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Score of the Second Team";
            // 
            // nudTeam2Score
            // 
            this.nudTeam2Score.Location = new System.Drawing.Point(425, 30);
            this.nudTeam2Score.Name = "nudTeam2Score";
            this.nudTeam2Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam2Score.TabIndex = 31;
            // 
            // nudTeam1Score
            // 
            this.nudTeam1Score.Location = new System.Drawing.Point(425, 3);
            this.nudTeam1Score.Name = "nudTeam1Score";
            this.nudTeam1Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam1Score.TabIndex = 32;
            // 
            // FrmNewMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 116);
            this.Controls.Add(this.nudTeam2Score);
            this.Controls.Add(this.nudTeam1Score);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCreateNewMatch);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSecondTeamName);
            this.Controls.Add(this.cbFirstTeamName);
            this.Name = "FrmNewMatch";
            this.Text = "FrmNemMatch";
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFirstTeamName;
        private System.Windows.Forms.ComboBox cbSecondTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Button btnCreateNewMatch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudTeam2Score;
        private System.Windows.Forms.NumericUpDown nudTeam1Score;
    }
}