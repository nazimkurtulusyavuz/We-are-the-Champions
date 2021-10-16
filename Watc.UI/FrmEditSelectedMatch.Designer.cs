
namespace Watc.UI
{
    partial class FrmEditSelectedMatch
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
            this.nudTeam2Score = new System.Windows.Forms.NumericUpDown();
            this.nudTeam1Score = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditSelectedMatch = new System.Windows.Forms.Button();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSecondTeamName = new System.Windows.Forms.ComboBox();
            this.cbFirstTeamName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTeam2Score
            // 
            this.nudTeam2Score.Location = new System.Drawing.Point(427, 40);
            this.nudTeam2Score.Name = "nudTeam2Score";
            this.nudTeam2Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam2Score.TabIndex = 42;
            // 
            // nudTeam1Score
            // 
            this.nudTeam1Score.Location = new System.Drawing.Point(427, 13);
            this.nudTeam1Score.Name = "nudTeam1Score";
            this.nudTeam1Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam1Score.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Score of the Second Team";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Score of the First Team";
            // 
            // btnEditSelectedMatch
            // 
            this.btnEditSelectedMatch.Location = new System.Drawing.Point(9, 89);
            this.btnEditSelectedMatch.Name = "btnEditSelectedMatch";
            this.btnEditSelectedMatch.Size = new System.Drawing.Size(476, 25);
            this.btnEditSelectedMatch.TabIndex = 39;
            this.btnEditSelectedMatch.Text = "Edit Selected Match";
            this.btnEditSelectedMatch.UseVisualStyleBackColor = true;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "dd.MMM.yyyy hh:mm tt";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(126, 60);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(153, 20);
            this.dtpDateTime.TabIndex = 38;
            this.dtpDateTime.Value = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date-Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name of Second Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name of First Team";
            // 
            // cbSecondTeamName
            // 
            this.cbSecondTeamName.DisplayMember = "Name";
            this.cbSecondTeamName.FormattingEnabled = true;
            this.cbSecondTeamName.Location = new System.Drawing.Point(126, 36);
            this.cbSecondTeamName.Name = "cbSecondTeamName";
            this.cbSecondTeamName.Size = new System.Drawing.Size(153, 21);
            this.cbSecondTeamName.TabIndex = 34;
            this.cbSecondTeamName.ValueMember = "Id";
            // 
            // cbFirstTeamName
            // 
            this.cbFirstTeamName.DisplayMember = "Name";
            this.cbFirstTeamName.FormattingEnabled = true;
            this.cbFirstTeamName.Location = new System.Drawing.Point(126, 12);
            this.cbFirstTeamName.Name = "cbFirstTeamName";
            this.cbFirstTeamName.Size = new System.Drawing.Size(153, 21);
            this.cbFirstTeamName.TabIndex = 33;
            this.cbFirstTeamName.ValueMember = "Id";
            // 
            // FrmEditSelectedMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 127);
            this.Controls.Add(this.nudTeam2Score);
            this.Controls.Add(this.nudTeam1Score);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEditSelectedMatch);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSecondTeamName);
            this.Controls.Add(this.cbFirstTeamName);
            this.Name = "FrmEditSelectedMatch";
            this.Text = "FrmEditSelectedMatch";
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTeam2Score;
        private System.Windows.Forms.NumericUpDown nudTeam1Score;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEditSelectedMatch;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSecondTeamName;
        private System.Windows.Forms.ComboBox cbFirstTeamName;
    }
}