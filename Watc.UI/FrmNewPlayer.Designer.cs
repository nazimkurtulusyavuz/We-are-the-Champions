
namespace Watc.UI
{
    partial class FrmNewPlayer
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNewPlayerTeam = new System.Windows.Forms.ComboBox();
            this.lblPlayerTeam = new System.Windows.Forms.Label();
            this.btnSavePlayer = new System.Windows.Forms.Button();
            this.chDoNotAssignTeam = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(74, 6);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(217, 20);
            this.txtPlayerName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Player Name";
            // 
            // cbNewPlayerTeam
            // 
            this.cbNewPlayerTeam.FormattingEnabled = true;
            this.cbNewPlayerTeam.Location = new System.Drawing.Point(74, 32);
            this.cbNewPlayerTeam.Name = "cbNewPlayerTeam";
            this.cbNewPlayerTeam.Size = new System.Drawing.Size(217, 21);
            this.cbNewPlayerTeam.TabIndex = 12;
            // 
            // lblPlayerTeam
            // 
            this.lblPlayerTeam.AutoSize = true;
            this.lblPlayerTeam.Location = new System.Drawing.Point(3, 35);
            this.lblPlayerTeam.Name = "lblPlayerTeam";
            this.lblPlayerTeam.Size = new System.Drawing.Size(66, 13);
            this.lblPlayerTeam.TabIndex = 13;
            this.lblPlayerTeam.Text = "Player Team";
            // 
            // btnSavePlayer
            // 
            this.btnSavePlayer.Location = new System.Drawing.Point(4, 82);
            this.btnSavePlayer.Name = "btnSavePlayer";
            this.btnSavePlayer.Size = new System.Drawing.Size(287, 30);
            this.btnSavePlayer.TabIndex = 15;
            this.btnSavePlayer.Text = "Save Player to Database";
            this.btnSavePlayer.UseVisualStyleBackColor = true;
            this.btnSavePlayer.Click += new System.EventHandler(this.btnSavePlayer_Click);
            // 
            // chDoNotAssignTeam
            // 
            this.chDoNotAssignTeam.AutoSize = true;
            this.chDoNotAssignTeam.Location = new System.Drawing.Point(6, 59);
            this.chDoNotAssignTeam.Name = "chDoNotAssignTeam";
            this.chDoNotAssignTeam.Size = new System.Drawing.Size(285, 17);
            this.chDoNotAssignTeam.TabIndex = 16;
            this.chDoNotAssignTeam.Text = "Click Here if you dont wanna assign a team to a player ";
            this.chDoNotAssignTeam.UseVisualStyleBackColor = true;
            this.chDoNotAssignTeam.CheckedChanged += new System.EventHandler(this.chDoNotAssignTeam_CheckedChanged);
            // 
            // FrmNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 125);
            this.Controls.Add(this.chDoNotAssignTeam);
            this.Controls.Add(this.btnSavePlayer);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNewPlayerTeam);
            this.Controls.Add(this.lblPlayerTeam);
            this.Name = "FrmNewPlayer";
            this.Text = "FrmNewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNewPlayerTeam;
        private System.Windows.Forms.Label lblPlayerTeam;
        private System.Windows.Forms.Button btnSavePlayer;
        private System.Windows.Forms.CheckBox chDoNotAssignTeam;
    }
}