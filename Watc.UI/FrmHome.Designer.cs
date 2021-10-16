
namespace Watc.UI
{
    partial class FrmHome
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
            this.btnEditSelectedMatch = new System.Windows.Forms.Button();
            this.btnDeleteSelectedMatch = new System.Windows.Forms.Button();
            this.btnHideSelectedMatch = new System.Windows.Forms.Button();
            this.btnShowHidedMatches = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.btnCreateNewMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditSelectedMatch
            // 
            this.btnEditSelectedMatch.Location = new System.Drawing.Point(6, 305);
            this.btnEditSelectedMatch.Name = "btnEditSelectedMatch";
            this.btnEditSelectedMatch.Size = new System.Drawing.Size(115, 23);
            this.btnEditSelectedMatch.TabIndex = 4;
            this.btnEditSelectedMatch.Text = "Edit Selected Match";
            this.btnEditSelectedMatch.UseVisualStyleBackColor = true;
            this.btnEditSelectedMatch.Click += new System.EventHandler(this.btnEditSelectedMatch_Click);
            // 
            // btnDeleteSelectedMatch
            // 
            this.btnDeleteSelectedMatch.Location = new System.Drawing.Point(128, 305);
            this.btnDeleteSelectedMatch.Name = "btnDeleteSelectedMatch";
            this.btnDeleteSelectedMatch.Size = new System.Drawing.Size(128, 23);
            this.btnDeleteSelectedMatch.TabIndex = 5;
            this.btnDeleteSelectedMatch.Text = "Delete Selected Match";
            this.btnDeleteSelectedMatch.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedMatch.Click += new System.EventHandler(this.btnDeleteSelectedMatch_Click);
            // 
            // btnHideSelectedMatch
            // 
            this.btnHideSelectedMatch.Location = new System.Drawing.Point(263, 305);
            this.btnHideSelectedMatch.Name = "btnHideSelectedMatch";
            this.btnHideSelectedMatch.Size = new System.Drawing.Size(115, 23);
            this.btnHideSelectedMatch.TabIndex = 6;
            this.btnHideSelectedMatch.Text = "Hide Selected Match";
            this.btnHideSelectedMatch.UseVisualStyleBackColor = true;
            // 
            // btnShowHidedMatches
            // 
            this.btnShowHidedMatches.Location = new System.Drawing.Point(385, 305);
            this.btnShowHidedMatches.Name = "btnShowHidedMatches";
            this.btnShowHidedMatches.Size = new System.Drawing.Size(134, 23);
            this.btnShowHidedMatches.TabIndex = 7;
            this.btnShowHidedMatches.Text = "Show All Hided Matches";
            this.btnShowHidedMatches.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 354);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvMatches);
            this.tabPage4.Controls.Add(this.btnCreateNewMatch);
            this.tabPage4.Controls.Add(this.btnShowHidedMatches);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.btnHideSelectedMatch);
            this.tabPage4.Controls.Add(this.btnEditSelectedMatch);
            this.tabPage4.Controls.Add(this.btnDeleteSelectedMatch);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(533, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Matches";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvMatches.Location = new System.Drawing.Point(9, 32);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(513, 270);
            this.dgvMatches.TabIndex = 9;
            // 
            // btnCreateNewMatch
            // 
            this.btnCreateNewMatch.Location = new System.Drawing.Point(385, 9);
            this.btnCreateNewMatch.Name = "btnCreateNewMatch";
            this.btnCreateNewMatch.Size = new System.Drawing.Size(137, 23);
            this.btnCreateNewMatch.TabIndex = 1;
            this.btnCreateNewMatch.Text = "+ Create a New Match";
            this.btnCreateNewMatch.UseVisualStyleBackColor = true;
            this.btnCreateNewMatch.Click += new System.EventHandler(this.btnCreateNewMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Matches";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teams";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Colors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(533, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Players";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Team1";
            this.Column1.HeaderText = "First Team";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Team2";
            this.Column2.HeaderText = "Second Team";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatchTime";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MatchTime";
            this.Column4.HeaderText = "Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Result";
            this.Column5.HeaderText = "Result";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 376);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmHome";
            this.Text = "We are the Champions 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditSelectedMatch;
        private System.Windows.Forms.Button btnDeleteSelectedMatch;
        private System.Windows.Forms.Button btnHideSelectedMatch;
        private System.Windows.Forms.Button btnShowHidedMatches;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCreateNewMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}