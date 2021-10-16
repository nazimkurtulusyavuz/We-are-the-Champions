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
    public partial class FrmEditSelectedMatch : Form
    {
        WatcContext db;
        Match match;
        public FrmEditSelectedMatch(WatcContext db, Match match)
        {
            InitializeComponent();
            this.db = db;
            this.match = match;
            cbFirstTeamName.DataSource =  db.Teams.ToList();
            cbSecondTeamName.DataSource = db.Teams.ToList();
            LoadSelectedMatch();
        }

        private void LoadSelectedMatch()
        {
            cbFirstTeamName.SelectedItem = match.Team1;
            cbSecondTeamName.SelectedItem = match.Team2;
        }
    }
}
