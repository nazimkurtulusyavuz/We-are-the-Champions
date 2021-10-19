
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chbHidePlayedMatches = new System.Windows.Forms.CheckBox();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateNewMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewTeamName = new System.Windows.Forms.TextBox();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllTeams = new System.Windows.Forms.Label();
            this.btnAddRemovePlayer = new System.Windows.Forms.Button();
            this.btnCreateNewTeam = new System.Windows.Forms.Button();
            this.btnAddColorToSelectedTeam = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColorRGBPreview = new System.Windows.Forms.Button();
            this.lblColorRGBPreview = new System.Windows.Forms.Label();
            this.lblColorBlue = new System.Windows.Forms.Label();
            this.lblColorGreen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hsbColorBlue = new System.Windows.Forms.HScrollBar();
            this.hsbColorGreen = new System.Windows.Forms.HScrollBar();
            this.lblColorRed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hsbColorRed = new System.Windows.Forms.HScrollBar();
            this.cbAllColors = new System.Windows.Forms.ComboBox();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteSelectedColor = new System.Windows.Forms.Button();
            this.btnEditSelectedColor = new System.Windows.Forms.Button();
            this.btnCreateColor = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.btnEditSelectedPlayer = new System.Windows.Forms.Button();
            this.rbShowPlayersAccordingtoTeam = new System.Windows.Forms.RadioButton();
            this.btCreateNewPlayer = new System.Windows.Forms.Button();
            this.rbShowAllPlayers = new System.Windows.Forms.RadioButton();
            this.lblSelectTeamToSeePlayers = new System.Windows.Forms.Label();
            this.chkTeamsToListPlayers = new System.Windows.Forms.ComboBox();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
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
            this.tabPage4.Controls.Add(this.chbHidePlayedMatches);
            this.tabPage4.Controls.Add(this.dgvMatches);
            this.tabPage4.Controls.Add(this.btnCreateNewMatch);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.btnEditSelectedMatch);
            this.tabPage4.Controls.Add(this.btnDeleteSelectedMatch);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(533, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Matches";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chbHidePlayedMatches
            // 
            this.chbHidePlayedMatches.AutoSize = true;
            this.chbHidePlayedMatches.Location = new System.Drawing.Point(396, 309);
            this.chbHidePlayedMatches.Name = "chbHidePlayedMatches";
            this.chbHidePlayedMatches.Size = new System.Drawing.Size(127, 17);
            this.chbHidePlayedMatches.TabIndex = 10;
            this.chbHidePlayedMatches.Text = "Hide Played Matches";
            this.chbHidePlayedMatches.UseVisualStyleBackColor = true;
            this.chbHidePlayedMatches.CheckedChanged += new System.EventHandler(this.chbHidePlayedMatches_CheckedChanged);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "Team1Name";
            this.Column1.HeaderText = "First Team";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Team2Name";
            this.Column2.HeaderText = "Second Team";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatchDateTime";
            this.Column3.HeaderText = "Date-Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MatchScore";
            this.Column5.HeaderText = "Match-Score";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNewTeamName);
            this.tabPage1.Controls.Add(this.dgvTeams);
            this.tabPage1.Controls.Add(this.lblAllTeams);
            this.tabPage1.Controls.Add(this.btnAddRemovePlayer);
            this.tabPage1.Controls.Add(this.btnCreateNewTeam);
            this.tabPage1.Controls.Add(this.btnAddColorToSelectedTeam);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teams";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(160, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Team Name";
            // 
            // txtNewTeamName
            // 
            this.txtNewTeamName.Location = new System.Drawing.Point(163, 246);
            this.txtNewTeamName.Name = "txtNewTeamName";
            this.txtNewTeamName.Size = new System.Drawing.Size(156, 20);
            this.txtNewTeamName.TabIndex = 8;
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvTeams.Location = new System.Drawing.Point(9, 25);
            this.dgvTeams.MultiSelect = false;
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(310, 195);
            this.dgvTeams.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Team Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblAllTeams
            // 
            this.lblAllTeams.AutoSize = true;
            this.lblAllTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAllTeams.ForeColor = System.Drawing.Color.Maroon;
            this.lblAllTeams.Location = new System.Drawing.Point(6, 7);
            this.lblAllTeams.Name = "lblAllTeams";
            this.lblAllTeams.Size = new System.Drawing.Size(61, 15);
            this.lblAllTeams.TabIndex = 4;
            this.lblAllTeams.Text = "All Teams";
            // 
            // btnAddRemovePlayer
            // 
            this.btnAddRemovePlayer.Location = new System.Drawing.Point(9, 299);
            this.btnAddRemovePlayer.Name = "btnAddRemovePlayer";
            this.btnAddRemovePlayer.Size = new System.Drawing.Size(310, 23);
            this.btnAddRemovePlayer.TabIndex = 3;
            this.btnAddRemovePlayer.Text = "Add/Remove a Player from the Selected Team";
            this.btnAddRemovePlayer.UseVisualStyleBackColor = true;
            this.btnAddRemovePlayer.Click += new System.EventHandler(this.btnAddRemovePlayer_Click);
            // 
            // btnCreateNewTeam
            // 
            this.btnCreateNewTeam.Location = new System.Drawing.Point(9, 230);
            this.btnCreateNewTeam.Name = "btnCreateNewTeam";
            this.btnCreateNewTeam.Size = new System.Drawing.Size(135, 36);
            this.btnCreateNewTeam.TabIndex = 2;
            this.btnCreateNewTeam.Text = "Create a New Team";
            this.btnCreateNewTeam.UseVisualStyleBackColor = true;
            this.btnCreateNewTeam.Click += new System.EventHandler(this.btnCreateNewTeam_Click);
            // 
            // btnAddColorToSelectedTeam
            // 
            this.btnAddColorToSelectedTeam.Location = new System.Drawing.Point(9, 272);
            this.btnAddColorToSelectedTeam.Name = "btnAddColorToSelectedTeam";
            this.btnAddColorToSelectedTeam.Size = new System.Drawing.Size(310, 23);
            this.btnAddColorToSelectedTeam.TabIndex = 1;
            this.btnAddColorToSelectedTeam.Text = "Add  a Color to Selected Team";
            this.btnAddColorToSelectedTeam.UseVisualStyleBackColor = true;
            this.btnAddColorToSelectedTeam.Click += new System.EventHandler(this.btnAddColorToSelectedTeam_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnColorRGBPreview);
            this.tabPage2.Controls.Add(this.lblColorRGBPreview);
            this.tabPage2.Controls.Add(this.lblColorBlue);
            this.tabPage2.Controls.Add(this.lblColorGreen);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.hsbColorBlue);
            this.tabPage2.Controls.Add(this.hsbColorGreen);
            this.tabPage2.Controls.Add(this.lblColorRed);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.hsbColorRed);
            this.tabPage2.Controls.Add(this.cbAllColors);
            this.tabPage2.Controls.Add(this.txtColorName);
            this.tabPage2.Controls.Add(this.lblBlueValue);
            this.tabPage2.Controls.Add(this.lblGreenValue);
            this.tabPage2.Controls.Add(this.lblRedValue);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnDeleteSelectedColor);
            this.tabPage2.Controls.Add(this.btnEditSelectedColor);
            this.tabPage2.Controls.Add(this.btnCreateColor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Colors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select a color below to edit or delete";
            // 
            // btnColorRGBPreview
            // 
            this.btnColorRGBPreview.Location = new System.Drawing.Point(395, 204);
            this.btnColorRGBPreview.Name = "btnColorRGBPreview";
            this.btnColorRGBPreview.Size = new System.Drawing.Size(105, 57);
            this.btnColorRGBPreview.TabIndex = 24;
            this.btnColorRGBPreview.Text = "ColorRGBPreview";
            this.btnColorRGBPreview.UseVisualStyleBackColor = true;
            this.btnColorRGBPreview.Click += new System.EventHandler(this.btnColorRGBPreview_Click);
            // 
            // lblColorRGBPreview
            // 
            this.lblColorRGBPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColorRGBPreview.ForeColor = System.Drawing.Color.Maroon;
            this.lblColorRGBPreview.Location = new System.Drawing.Point(399, 171);
            this.lblColorRGBPreview.Name = "lblColorRGBPreview";
            this.lblColorRGBPreview.Size = new System.Drawing.Size(93, 30);
            this.lblColorRGBPreview.TabIndex = 23;
            this.lblColorRGBPreview.Text = "Click Here to Preview Color";
            this.lblColorRGBPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorBlue
            // 
            this.lblColorBlue.AutoSize = true;
            this.lblColorBlue.Location = new System.Drawing.Point(286, 274);
            this.lblColorBlue.Name = "lblColorBlue";
            this.lblColorBlue.Size = new System.Drawing.Size(52, 13);
            this.lblColorBlue.TabIndex = 22;
            this.lblColorBlue.Text = "ColorBlue";
            // 
            // lblColorGreen
            // 
            this.lblColorGreen.AutoSize = true;
            this.lblColorGreen.Location = new System.Drawing.Point(283, 221);
            this.lblColorGreen.Name = "lblColorGreen";
            this.lblColorGreen.Size = new System.Drawing.Size(60, 13);
            this.lblColorGreen.TabIndex = 21;
            this.lblColorGreen.Text = "ColorGreen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Blue(0-255)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Green(0-255)";
            // 
            // hsbColorBlue
            // 
            this.hsbColorBlue.Location = new System.Drawing.Point(14, 274);
            this.hsbColorBlue.Maximum = 264;
            this.hsbColorBlue.Name = "hsbColorBlue";
            this.hsbColorBlue.Size = new System.Drawing.Size(262, 17);
            this.hsbColorBlue.TabIndex = 18;
            this.hsbColorBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbColorBlue_Scroll);
            // 
            // hsbColorGreen
            // 
            this.hsbColorGreen.Location = new System.Drawing.Point(14, 221);
            this.hsbColorGreen.Maximum = 264;
            this.hsbColorGreen.Name = "hsbColorGreen";
            this.hsbColorGreen.Size = new System.Drawing.Size(262, 17);
            this.hsbColorGreen.TabIndex = 17;
            this.hsbColorGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbColorGreen_Scroll);
            // 
            // lblColorRed
            // 
            this.lblColorRed.AutoSize = true;
            this.lblColorRed.Location = new System.Drawing.Point(284, 167);
            this.lblColorRed.Name = "lblColorRed";
            this.lblColorRed.Size = new System.Drawing.Size(51, 13);
            this.lblColorRed.TabIndex = 16;
            this.lblColorRed.Text = "ColorRed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Red(0-255)";
            // 
            // hsbColorRed
            // 
            this.hsbColorRed.Location = new System.Drawing.Point(14, 167);
            this.hsbColorRed.Maximum = 264;
            this.hsbColorRed.Name = "hsbColorRed";
            this.hsbColorRed.Size = new System.Drawing.Size(262, 17);
            this.hsbColorRed.TabIndex = 13;
            this.hsbColorRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbColorRed_Scroll);
            // 
            // cbAllColors
            // 
            this.cbAllColors.DisplayMember = "ColorName";
            this.cbAllColors.FormattingEnabled = true;
            this.cbAllColors.Location = new System.Drawing.Point(9, 28);
            this.cbAllColors.Name = "cbAllColors";
            this.cbAllColors.Size = new System.Drawing.Size(334, 21);
            this.cbAllColors.TabIndex = 11;
            this.cbAllColors.Text = "Select from predifined colors";
            this.cbAllColors.SelectedIndexChanged += new System.EventHandler(this.cbAllColors_SelectedIndexChanged);
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(9, 109);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(334, 20);
            this.txtColorName.TabIndex = 8;
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Location = new System.Drawing.Point(86, 248);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(55, 13);
            this.lblBlueValue.TabIndex = 6;
            this.lblBlueValue.Text = "BlueValue";
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Location = new System.Drawing.Point(86, 197);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(63, 13);
            this.lblGreenValue.TabIndex = 5;
            this.lblGreenValue.Text = "GreenValue";
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Location = new System.Drawing.Point(86, 144);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(54, 13);
            this.lblRedValue.TabIndex = 4;
            this.lblRedValue.Text = "RedValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color Name";
            // 
            // btnDeleteSelectedColor
            // 
            this.btnDeleteSelectedColor.Location = new System.Drawing.Point(186, 55);
            this.btnDeleteSelectedColor.Name = "btnDeleteSelectedColor";
            this.btnDeleteSelectedColor.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteSelectedColor.TabIndex = 2;
            this.btnDeleteSelectedColor.Text = "Delete Selected Color";
            this.btnDeleteSelectedColor.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedColor.Click += new System.EventHandler(this.btnDeleteSelectedColor_Click);
            // 
            // btnEditSelectedColor
            // 
            this.btnEditSelectedColor.Location = new System.Drawing.Point(9, 55);
            this.btnEditSelectedColor.Name = "btnEditSelectedColor";
            this.btnEditSelectedColor.Size = new System.Drawing.Size(160, 23);
            this.btnEditSelectedColor.TabIndex = 1;
            this.btnEditSelectedColor.Text = "Edit Selected Color";
            this.btnEditSelectedColor.UseVisualStyleBackColor = true;
            this.btnEditSelectedColor.Click += new System.EventHandler(this.btnEditSelectedColor_Click);
            // 
            // btnCreateColor
            // 
            this.btnCreateColor.Location = new System.Drawing.Point(388, 31);
            this.btnCreateColor.Name = "btnCreateColor";
            this.btnCreateColor.Size = new System.Drawing.Size(112, 70);
            this.btnCreateColor.TabIndex = 0;
            this.btnCreateColor.Text = "Create a Color";
            this.btnCreateColor.UseVisualStyleBackColor = true;
            this.btnCreateColor.Click += new System.EventHandler(this.btnCreateColor_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteSelectedPlayer);
            this.tabPage3.Controls.Add(this.btnEditSelectedPlayer);
            this.tabPage3.Controls.Add(this.rbShowPlayersAccordingtoTeam);
            this.tabPage3.Controls.Add(this.btCreateNewPlayer);
            this.tabPage3.Controls.Add(this.rbShowAllPlayers);
            this.tabPage3.Controls.Add(this.lblSelectTeamToSeePlayers);
            this.tabPage3.Controls.Add(this.chkTeamsToListPlayers);
            this.tabPage3.Controls.Add(this.dgvPlayers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(533, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Players";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPlayer
            // 
            this.btnDeleteSelectedPlayer.Location = new System.Drawing.Point(291, 209);
            this.btnDeleteSelectedPlayer.Name = "btnDeleteSelectedPlayer";
            this.btnDeleteSelectedPlayer.Size = new System.Drawing.Size(188, 23);
            this.btnDeleteSelectedPlayer.TabIndex = 13;
            this.btnDeleteSelectedPlayer.Text = "Delete Selected Player";
            this.btnDeleteSelectedPlayer.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedPlayer.Click += new System.EventHandler(this.btnDeleteSelectedPlayer_Click);
            // 
            // btnEditSelectedPlayer
            // 
            this.btnEditSelectedPlayer.Location = new System.Drawing.Point(291, 180);
            this.btnEditSelectedPlayer.Name = "btnEditSelectedPlayer";
            this.btnEditSelectedPlayer.Size = new System.Drawing.Size(188, 23);
            this.btnEditSelectedPlayer.TabIndex = 12;
            this.btnEditSelectedPlayer.Text = "Edit Selected Player";
            this.btnEditSelectedPlayer.UseVisualStyleBackColor = true;
            this.btnEditSelectedPlayer.Click += new System.EventHandler(this.btnEditSelectedPlayer_Click);
            // 
            // rbShowPlayersAccordingtoTeam
            // 
            this.rbShowPlayersAccordingtoTeam.AutoSize = true;
            this.rbShowPlayersAccordingtoTeam.Location = new System.Drawing.Point(6, 22);
            this.rbShowPlayersAccordingtoTeam.Name = "rbShowPlayersAccordingtoTeam";
            this.rbShowPlayersAccordingtoTeam.Size = new System.Drawing.Size(206, 17);
            this.rbShowPlayersAccordingtoTeam.TabIndex = 11;
            this.rbShowPlayersAccordingtoTeam.TabStop = true;
            this.rbShowPlayersAccordingtoTeam.Text = "Show Players (according to their team)";
            this.rbShowPlayersAccordingtoTeam.UseVisualStyleBackColor = true;
            this.rbShowPlayersAccordingtoTeam.CheckedChanged += new System.EventHandler(this.rbShowPlayersAccordingtoTeam_CheckedChanged);
            // 
            // btCreateNewPlayer
            // 
            this.btCreateNewPlayer.Location = new System.Drawing.Point(291, 151);
            this.btCreateNewPlayer.Name = "btCreateNewPlayer";
            this.btCreateNewPlayer.Size = new System.Drawing.Size(188, 23);
            this.btCreateNewPlayer.TabIndex = 0;
            this.btCreateNewPlayer.Text = "Create a New Player";
            this.btCreateNewPlayer.UseVisualStyleBackColor = true;
            this.btCreateNewPlayer.Click += new System.EventHandler(this.btCreateNewPlayer_Click);
            // 
            // rbShowAllPlayers
            // 
            this.rbShowAllPlayers.AutoSize = true;
            this.rbShowAllPlayers.Location = new System.Drawing.Point(5, 4);
            this.rbShowAllPlayers.Name = "rbShowAllPlayers";
            this.rbShowAllPlayers.Size = new System.Drawing.Size(109, 17);
            this.rbShowAllPlayers.TabIndex = 10;
            this.rbShowAllPlayers.TabStop = true;
            this.rbShowAllPlayers.Text = "Show Players (All)";
            this.rbShowAllPlayers.UseVisualStyleBackColor = true;
            this.rbShowAllPlayers.CheckedChanged += new System.EventHandler(this.rbShowAllPlayers_CheckedChanged);
            // 
            // lblSelectTeamToSeePlayers
            // 
            this.lblSelectTeamToSeePlayers.AutoSize = true;
            this.lblSelectTeamToSeePlayers.ForeColor = System.Drawing.Color.Maroon;
            this.lblSelectTeamToSeePlayers.Location = new System.Drawing.Point(7, 43);
            this.lblSelectTeamToSeePlayers.Name = "lblSelectTeamToSeePlayers";
            this.lblSelectTeamToSeePlayers.Size = new System.Drawing.Size(140, 13);
            this.lblSelectTeamToSeePlayers.TabIndex = 8;
            this.lblSelectTeamToSeePlayers.Text = "Select a team to see players";
            // 
            // chkTeamsToListPlayers
            // 
            this.chkTeamsToListPlayers.DisplayMember = "Name";
            this.chkTeamsToListPlayers.FormattingEnabled = true;
            this.chkTeamsToListPlayers.Location = new System.Drawing.Point(10, 61);
            this.chkTeamsToListPlayers.Name = "chkTeamsToListPlayers";
            this.chkTeamsToListPlayers.Size = new System.Drawing.Size(230, 21);
            this.chkTeamsToListPlayers.TabIndex = 7;
            this.chkTeamsToListPlayers.SelectedIndexChanged += new System.EventHandler(this.chkTeamsToListPlayers_SelectedIndexChanged);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6});
            this.dgvPlayers.Location = new System.Drawing.Point(10, 88);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(230, 225);
            this.dgvPlayers.TabIndex = 6;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PlayerName";
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Team";
            this.Column6.HeaderText = "Team";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmHome";
            this.Text = "We are the Champions 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditSelectedMatch;
        private System.Windows.Forms.Button btnDeleteSelectedMatch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCreateNewMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.CheckBox chbHidePlayedMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDeleteSelectedColor;
        private System.Windows.Forms.Button btnEditSelectedColor;
        private System.Windows.Forms.Button btnCreateColor;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAllColors;
        private System.Windows.Forms.HScrollBar hsbColorRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblColorRed;
        private System.Windows.Forms.Label lblColorBlue;
        private System.Windows.Forms.Label lblColorGreen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar hsbColorBlue;
        private System.Windows.Forms.HScrollBar hsbColorGreen;
        private System.Windows.Forms.Label lblColorRGBPreview;
        private System.Windows.Forms.Button btnColorRGBPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectTeamToSeePlayers;
        private System.Windows.Forms.ComboBox chkTeamsToListPlayers;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btCreateNewPlayer;
        private System.Windows.Forms.RadioButton rbShowPlayersAccordingtoTeam;
        private System.Windows.Forms.RadioButton rbShowAllPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnEditSelectedPlayer;
        private System.Windows.Forms.Button btnDeleteSelectedPlayer;
        private System.Windows.Forms.Label lblAllTeams;
        private System.Windows.Forms.Button btnAddRemovePlayer;
        private System.Windows.Forms.Button btnCreateNewTeam;
        private System.Windows.Forms.Button btnAddColorToSelectedTeam;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewTeamName;
    }
}