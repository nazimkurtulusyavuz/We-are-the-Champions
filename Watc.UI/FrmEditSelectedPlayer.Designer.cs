
namespace Watc.UI
{
    partial class FrmEditSelectedPlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.cbPlayerTeam = new System.Windows.Forms.ComboBox();
            this.btnEditSelectedPlayer = new System.Windows.Forms.Button();
            this.chDoNotAssignTeam = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Team";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(83, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(116, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // cbPlayerTeam
            // 
            this.cbPlayerTeam.FormattingEnabled = true;
            this.cbPlayerTeam.Location = new System.Drawing.Point(83, 38);
            this.cbPlayerTeam.Name = "cbPlayerTeam";
            this.cbPlayerTeam.Size = new System.Drawing.Size(116, 21);
            this.cbPlayerTeam.TabIndex = 3;
            // 
            // btnEditSelectedPlayer
            // 
            this.btnEditSelectedPlayer.Location = new System.Drawing.Point(12, 88);
            this.btnEditSelectedPlayer.Name = "btnEditSelectedPlayer";
            this.btnEditSelectedPlayer.Size = new System.Drawing.Size(187, 29);
            this.btnEditSelectedPlayer.TabIndex = 4;
            this.btnEditSelectedPlayer.Text = "Edit Selected Player";
            this.btnEditSelectedPlayer.UseVisualStyleBackColor = true;
            this.btnEditSelectedPlayer.Click += new System.EventHandler(this.btnEditSelectedPlayer_Click);
            // 
            // chDoNotAssignTeam
            // 
            this.chDoNotAssignTeam.AutoSize = true;
            this.chDoNotAssignTeam.Location = new System.Drawing.Point(13, 65);
            this.chDoNotAssignTeam.Name = "chDoNotAssignTeam";
            this.chDoNotAssignTeam.Size = new System.Drawing.Size(187, 17);
            this.chDoNotAssignTeam.TabIndex = 5;
            this.chDoNotAssignTeam.Text = "Do not assign a team to the player";
            this.chDoNotAssignTeam.UseVisualStyleBackColor = true;
            this.chDoNotAssignTeam.CheckedChanged += new System.EventHandler(this.chDoNotAssignTeam_CheckedChanged);
            // 
            // FrmEditSelectedPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 135);
            this.Controls.Add(this.chDoNotAssignTeam);
            this.Controls.Add(this.btnEditSelectedPlayer);
            this.Controls.Add(this.cbPlayerTeam);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditSelectedPlayer";
            this.Text = "FrmEditSelectedPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ComboBox cbPlayerTeam;
        private System.Windows.Forms.Button btnEditSelectedPlayer;
        private System.Windows.Forms.CheckBox chDoNotAssignTeam;
    }
}