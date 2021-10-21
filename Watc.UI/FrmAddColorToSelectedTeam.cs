using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watc.Data;

namespace Watc.UI
{
    public partial class FrmAddColorToSelectedTeam : Form
    {
        WatcContext db;
        TeamviewModel team;
        public FrmAddColorToSelectedTeam(WatcContext db, TeamviewModel team)
        {
            this.db = db;
            this.team = team;
            InitializeComponent();
            dgvTeamColors.AutoGenerateColumns = false;
            LoadTeam();
        }
        private void LoadTeam()
        {
            lblTeamName.Text = team.Name;
            dgvTeamColors.DataSource = team.Colors.ToList();
            cbAllColors.DataSource = db.Colors.ToList();
        }

        private void btnSaveColor_Click(object sender, EventArgs e)
        {
            Team team1 = db.Teams.Where(team2 => team2.Name == team.Name).FirstOrDefault();
            Data.Color color = (Data.Color)cbAllColors.SelectedItem;
            string colorName = color.ColorName;
            if (team1.Colors.Any(x => x.ColorName == colorName))
            {
                MessageBox.Show("selected color has exists");
                return;
            }
            team1.Colors.Add(color);
            db.SaveChanges();
            MessageBox.Show("Color has Saved");
            dgvTeamColors.DataSource = team1.Colors.ToList();
        }

        private void btnDeleteSelectedColorFromTheTeam_Click(object sender, EventArgs e)
        {
            Data.Color color = (Data.Color)dgvTeamColors.SelectedRows[0].DataBoundItem;
            int colorId = color.Id;
            Team tm = db.Teams.FirstOrDefault(team => team.Id == this.team.Id);
            tm.Colors.Remove(color);
            db.SaveChanges();
            MessageBox.Show("Color has Removed");
            dgvTeamColors.DataSource = tm.Colors.ToList();
        }
    }
}
