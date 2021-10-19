
namespace Watc.UI
{
    partial class FrmAddColorToSelectedTeam
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
            this.cbAllColors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveColor = new System.Windows.Forms.Button();
            this.dgvTeamColors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSelectedColorFromTheTeam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamColors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name : ";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.SystemColors.Control;
            this.lblTeamName.Location = new System.Drawing.Point(87, 14);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(65, 13);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Team Name";
            // 
            // cbAllColors
            // 
            this.cbAllColors.DisplayMember = "ColorName";
            this.cbAllColors.FormattingEnabled = true;
            this.cbAllColors.Location = new System.Drawing.Point(10, 65);
            this.cbAllColors.Name = "cbAllColors";
            this.cbAllColors.Size = new System.Drawing.Size(174, 21);
            this.cbAllColors.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pick a Color from the color list below";
            // 
            // btnSaveColor
            // 
            this.btnSaveColor.Location = new System.Drawing.Point(10, 92);
            this.btnSaveColor.Name = "btnSaveColor";
            this.btnSaveColor.Size = new System.Drawing.Size(174, 23);
            this.btnSaveColor.TabIndex = 4;
            this.btnSaveColor.Text = "Add Seledted Color to the Team";
            this.btnSaveColor.UseVisualStyleBackColor = true;
            this.btnSaveColor.Click += new System.EventHandler(this.btnSaveColor_Click);
            // 
            // dgvTeamColors
            // 
            this.dgvTeamColors.AllowUserToAddRows = false;
            this.dgvTeamColors.AllowUserToDeleteRows = false;
            this.dgvTeamColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTeamColors.Location = new System.Drawing.Point(10, 129);
            this.dgvTeamColors.MultiSelect = false;
            this.dgvTeamColors.Name = "dgvTeamColors";
            this.dgvTeamColors.ReadOnly = true;
            this.dgvTeamColors.RowHeadersVisible = false;
            this.dgvTeamColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamColors.Size = new System.Drawing.Size(602, 196);
            this.dgvTeamColors.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ColorName";
            this.Column1.HeaderText = "Color Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Red";
            this.Column2.HeaderText = "Red (0-255)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Green";
            this.Column3.HeaderText = "Green (0-255)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Blue";
            this.Column4.HeaderText = "Blue (0-255)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnDeleteSelectedColorFromTheTeam
            // 
            this.btnDeleteSelectedColorFromTheTeam.Location = new System.Drawing.Point(344, 71);
            this.btnDeleteSelectedColorFromTheTeam.Name = "btnDeleteSelectedColorFromTheTeam";
            this.btnDeleteSelectedColorFromTheTeam.Size = new System.Drawing.Size(268, 23);
            this.btnDeleteSelectedColorFromTheTeam.TabIndex = 7;
            this.btnDeleteSelectedColorFromTheTeam.Text = "Delete Selected Color";
            this.btnDeleteSelectedColorFromTheTeam.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedColorFromTheTeam.Click += new System.EventHandler(this.btnDeleteSelectedColorFromTheTeam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(341, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select a color from the list below to remove from the team";
            // 
            // FrmAddColorToSelectedTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteSelectedColorFromTheTeam);
            this.Controls.Add(this.dgvTeamColors);
            this.Controls.Add(this.btnSaveColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAllColors);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddColorToSelectedTeam";
            this.Text = "FrmAddColorToSelectedTeam";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ComboBox cbAllColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveColor;
        private System.Windows.Forms.DataGridView dgvTeamColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnDeleteSelectedColorFromTheTeam;
        private System.Windows.Forms.Label label3;
    }
}