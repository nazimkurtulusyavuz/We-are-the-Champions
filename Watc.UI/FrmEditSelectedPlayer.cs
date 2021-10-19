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
    public partial class FrmEditSelectedPlayer : Form
    {
        WatcContext db;
        Player player;
        public FrmEditSelectedPlayer(WatcContext db, Player player)
        {
            this.db = db;
            this.player = player;
            InitializeComponent();
            LoadPlayer();
        }

        private void LoadPlayer()
        {
            txtPlayerName.Text = player.PlayerName;
            cbPlayerTeam.DataSource = db.Teams.ToList();
            cbPlayerTeam.SelectedItem = player.Team;
            chDoNotAssignTeam.Checked = false;
        }

        private void btnEditSelectedPlayer_Click(object sender, EventArgs e)
        {
            Player playerToBeEdited = db.Players.FirstOrDefault(plyr => plyr.Id == player.Id);
            playerToBeEdited.PlayerName = txtPlayerName.Text;
            playerToBeEdited.Team = chDoNotAssignTeam.Checked ? null : (Team)cbPlayerTeam.SelectedItem;
            db.SaveChanges();
            MessageBox.Show("player has edited");
        }

        private void chDoNotAssignTeam_CheckedChanged(object sender, EventArgs e)
        {
            cbPlayerTeam.Enabled = chDoNotAssignTeam.Checked ? false : true;
        }
    }
}
