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
    public partial class FrmNewPlayer : Form
    {
        WatcContext db;
        public FrmNewPlayer(WatcContext db)
        {
            this.db = db;
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            chDoNotAssignTeam.Checked = false;
            cbNewPlayerTeam.DataSource = db.Teams.ToList();
        }

        private void btnSavePlayer_Click(object sender, EventArgs e)
        {
            Team team = chDoNotAssignTeam.Checked ? null : (Team)cbNewPlayerTeam.SelectedItem;

            if (txtPlayerName.Text == string.Empty || int.TryParse(txtPlayerName.Text,out int result))
            {
                MessageBox.Show("Please Enter a Valid Player Name");
                return;
            }
            
            db.Players.Add(new Player() { PlayerName = txtPlayerName.Text, Team = team });
            db.SaveChanges();
            MessageBox.Show("player has saved to database");
        }

        private void chDoNotAssignTeam_CheckedChanged(object sender, EventArgs e)
        {
            cbNewPlayerTeam.Enabled = chDoNotAssignTeam.Checked ? false : true;
        }
    }
}
