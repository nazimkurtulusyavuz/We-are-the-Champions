
namespace Watc.UI
{
    partial class FrmAddRemovePlayersFromTheSelectedTeam
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.dgvTeamPlayers = new System.Windows.Forms.DataGridView();
            this.btnAddPlayerToTeam = new System.Windows.Forms.Button();
            this.btnRemoveSelectedPlayer = new System.Windows.Forms.Button();
            this.cbAllPlayers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(102, 9);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(65, 13);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Team Name";
            // 
            // dgvTeamPlayers
            // 
            this.dgvTeamPlayers.AllowUserToAddRows = false;
            this.dgvTeamPlayers.AllowUserToDeleteRows = false;
            this.dgvTeamPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTeamPlayers.Location = new System.Drawing.Point(15, 36);
            this.dgvTeamPlayers.MultiSelect = false;
            this.dgvTeamPlayers.Name = "dgvTeamPlayers";
            this.dgvTeamPlayers.ReadOnly = true;
            this.dgvTeamPlayers.RowHeadersVisible = false;
            this.dgvTeamPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamPlayers.Size = new System.Drawing.Size(267, 205);
            this.dgvTeamPlayers.TabIndex = 2;
            // 
            // btnAddPlayerToTeam
            // 
            this.btnAddPlayerToTeam.Location = new System.Drawing.Point(318, 141);
            this.btnAddPlayerToTeam.Name = "btnAddPlayerToTeam";
            this.btnAddPlayerToTeam.Size = new System.Drawing.Size(113, 23);
            this.btnAddPlayerToTeam.TabIndex = 3;
            this.btnAddPlayerToTeam.Text = "Add Player";
            this.btnAddPlayerToTeam.UseVisualStyleBackColor = true;
            this.btnAddPlayerToTeam.Click += new System.EventHandler(this.btnAddPlayerToTeam_Click);
            // 
            // btnRemoveSelectedPlayer
            // 
            this.btnRemoveSelectedPlayer.Location = new System.Drawing.Point(15, 247);
            this.btnRemoveSelectedPlayer.Name = "btnRemoveSelectedPlayer";
            this.btnRemoveSelectedPlayer.Size = new System.Drawing.Size(267, 23);
            this.btnRemoveSelectedPlayer.TabIndex = 4;
            this.btnRemoveSelectedPlayer.Text = "Remove Selected Player";
            this.btnRemoveSelectedPlayer.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPlayer.Click += new System.EventHandler(this.btnRemoveSelectedPlayer_Click);
            // 
            // cbAllPlayers
            // 
            this.cbAllPlayers.DisplayMember = "PlayerName";
            this.cbAllPlayers.FormattingEnabled = true;
            this.cbAllPlayers.Location = new System.Drawing.Point(318, 114);
            this.cbAllPlayers.Name = "cbAllPlayers";
            this.cbAllPlayers.Size = new System.Drawing.Size(113, 21);
            this.cbAllPlayers.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(315, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select a Player To Add";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PlayerName";
            this.Column2.HeaderText = "Player Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FrmAddRemovePlayersFromTheSelectedTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAllPlayers);
            this.Controls.Add(this.btnRemoveSelectedPlayer);
            this.Controls.Add(this.btnAddPlayerToTeam);
            this.Controls.Add(this.dgvTeamPlayers);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddRemovePlayersFromTheSelectedTeam";
            this.Text = "FrmAddRemovePlayersFromTheSelectedTeam";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.DataGridView dgvTeamPlayers;
        private System.Windows.Forms.Button btnAddPlayerToTeam;
        private System.Windows.Forms.Button btnRemoveSelectedPlayer;
        private System.Windows.Forms.ComboBox cbAllPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}