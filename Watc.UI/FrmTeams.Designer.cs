
namespace Watc.UI
{
    partial class FrmTeams
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedColor = new System.Windows.Forms.Button();
            this.btnAddSelectedColor = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAddRemovePlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a Team";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(586, 97);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team Name";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(586, 143);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(221, 199);
            this.checkedListBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select from Predefined Color";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Select a Team to Edit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team Id";
            // 
            // lblTeamId
            // 
            this.lblTeamId.AutoSize = true;
            this.lblTeamId.Location = new System.Drawing.Point(110, 95);
            this.lblTeamId.Name = "lblTeamId";
            this.lblTeamId.Size = new System.Drawing.Size(46, 13);
            this.lblTeamId.TabIndex = 8;
            this.lblTeamId.Text = "Team Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Team Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Team Colors";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(113, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 12;
            // 
            // btnDeleteSelectedColor
            // 
            this.btnDeleteSelectedColor.Location = new System.Drawing.Point(113, 335);
            this.btnDeleteSelectedColor.Name = "btnDeleteSelectedColor";
            this.btnDeleteSelectedColor.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteSelectedColor.TabIndex = 13;
            this.btnDeleteSelectedColor.Text = "Delete Selected Color";
            this.btnDeleteSelectedColor.UseVisualStyleBackColor = true;
            // 
            // btnAddSelectedColor
            // 
            this.btnAddSelectedColor.Location = new System.Drawing.Point(248, 335);
            this.btnAddSelectedColor.Name = "btnAddSelectedColor";
            this.btnAddSelectedColor.Size = new System.Drawing.Size(120, 23);
            this.btnAddSelectedColor.TabIndex = 14;
            this.btnAddSelectedColor.Text = "Add Selected Color";
            this.btnAddSelectedColor.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // btnAddRemovePlayers
            // 
            this.btnAddRemovePlayers.Location = new System.Drawing.Point(186, 36);
            this.btnAddRemovePlayers.Name = "btnAddRemovePlayers";
            this.btnAddRemovePlayers.Size = new System.Drawing.Size(120, 23);
            this.btnAddRemovePlayers.TabIndex = 16;
            this.btnAddRemovePlayers.Text = "Add-Remove Players from the Selected Team";
            this.btnAddRemovePlayers.UseVisualStyleBackColor = true;
            // 
            // FrmTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.btnAddRemovePlayers);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnAddSelectedColor);
            this.Controls.Add(this.btnDeleteSelectedColor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTeamId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.button1);
            this.Name = "FrmTeams";
            this.Text = "FrmTeams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTeamId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeleteSelectedColor;
        private System.Windows.Forms.Button btnAddSelectedColor;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnAddRemovePlayers;
    }
}