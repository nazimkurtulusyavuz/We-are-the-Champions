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
    public partial class FrmAddRemovePlayersFromTheSelectedTeam : Form
    {
        WatcContext db;
        TeamviewModel team;
        public FrmAddRemovePlayersFromTheSelectedTeam(WatcContext db, TeamviewModel team)
        {
            this.db = db;
            this.team = team;
            InitializeComponent();
            dgvTeamPlayers.AutoGenerateColumns = false;
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            Team team = db.Teams.FirstOrDefault(t => t.Id == this.team.Id);
            lblTeamName.Text = team.Name;
            dgvTeamPlayers.DataSource = team.Players.ToList();
            cbAllPlayers.DataSource = db.Players.Where(player => player.Team.Id == null).OrderBy(player => player.PlayerName).ToList();
        }

        private void btnAddPlayerToTeam_Click(object sender, EventArgs e)
        {
            Player player = (Player)cbAllPlayers.SelectedItem;
            Team team = db.Teams.FirstOrDefault(t => t.Id == this.team.Id);
            team.Players.Add(player);
            db.SaveChanges();
            MessageBox.Show("player has saved");
            dgvTeamPlayers.DataSource = team.Players.ToList();
            cbAllPlayers.DataSource = db.Players.Where(plyr => plyr.Team.Id == null).OrderBy(plyr => plyr.PlayerName).ToList();
        }

        private void btnRemoveSelectedPlayer_Click(object sender, EventArgs e)
        {
            Player player = (Player)dgvTeamPlayers.SelectedRows[0].DataBoundItem;
            Team team = db.Teams.FirstOrDefault(t => t.Id == this.team.Id);
            team.Players.Remove(player);
            db.SaveChanges();
            MessageBox.Show("player has removed");
            dgvTeamPlayers.DataSource = team.Players.ToList();
            LoadPlayers();
        }
    }
}
