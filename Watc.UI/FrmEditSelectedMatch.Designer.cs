
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditSelectedMatch = new System.Windows.Forms.Button();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSecondTeamName = new System.Windows.Forms.ComboBox();
            this.cbFirstTeamName = new System.Windows.Forms.ComboBox();
            this.txtTeam1Score = new System.Windows.Forms.TextBox();
            this.txtTeam2Score = new System.Windows.Forms.TextBox();
            this.chkAllowDtp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Score of the Second Team";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Score of the First Team";
            // 
            // btnEditSelectedMatch
            // 
            this.btnEditSelectedMatch.Location = new System.Drawing.Point(8, 97);
            this.btnEditSelectedMatch.Name = "btnEditSelectedMatch";
            this.btnEditSelectedMatch.Size = new System.Drawing.Size(541, 25);
            this.btnEditSelectedMatch.TabIndex = 39;
            this.btnEditSelectedMatch.Text = "Edit Selected Match";
            this.btnEditSelectedMatch.UseVisualStyleBackColor = true;
            this.btnEditSelectedMatch.Click += new System.EventHandler(this.btnEditSelectedMatch_Click);
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "dd.MMM.yyyy hh:mm tt";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(399, 68);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(150, 20);
            this.dtpDateTime.TabIndex = 38;
            this.dtpDateTime.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name of Second Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
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
            // txtTeam1Score
            // 
            this.txtTeam1Score.Location = new System.Drawing.Point(449, 12);
            this.txtTeam1Score.Name = "txtTeam1Score";
            this.txtTeam1Score.Size = new System.Drawing.Size(100, 20);
            this.txtTeam1Score.TabIndex = 44;
            // 
            // txtTeam2Score
            // 
            this.txtTeam2Score.Location = new System.Drawing.Point(449, 37);
            this.txtTeam2Score.Name = "txtTeam2Score";
            this.txtTeam2Score.Size = new System.Drawing.Size(100, 20);
            this.txtTeam2Score.TabIndex = 45;
            // 
            // chkAllowDtp
            // 
            this.chkAllowDtp.AutoSize = true;
            this.chkAllowDtp.Location = new System.Drawing.Point(8, 71);
            this.chkAllowDtp.Name = "chkAllowDtp";
            this.chkAllowDtp.Size = new System.Drawing.Size(157, 17);
            this.chkAllowDtp.TabIndex = 46;
            this.chkAllowDtp.Text = "Click Here To Arrange Time";
            this.chkAllowDtp.UseVisualStyleBackColor = true;
            this.chkAllowDtp.CheckedChanged += new System.EventHandler(this.chkAllowDtp_CheckedChanged);
            // 
            // FrmEditSelectedMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 139);
            this.Controls.Add(this.chkAllowDtp);
            this.Controls.Add(this.txtTeam2Score);
            this.Controls.Add(this.txtTeam1Score);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEditSelectedMatch);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSecondTeamName);
            this.Controls.Add(this.cbFirstTeamName);
            this.Name = "FrmEditSelectedMatch";
            this.Text = "FrmEditSelectedMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEditSelectedMatch;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSecondTeamName;
        private System.Windows.Forms.ComboBox cbFirstTeamName;
        private System.Windows.Forms.TextBox txtTeam1Score;
        private System.Windows.Forms.TextBox txtTeam2Score;
        private System.Windows.Forms.CheckBox chkAllowDtp;
    }
}