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
    public partial class FrmNewMatch : Form
    {
        WatcContext db;

        public FrmNewMatch(WatcContext db)
        {
            this.db = db;
            InitializeComponent();
            LoadTeams();
        }

        private void LoadTeams()
        {
            cbFirstTeamName.DataSource = db.Teams.ToList(); 
            cbSecondTeamName.DataSource = db.Teams.ToList();
        }

        private void btnCreateNewMatch_Click(object sender, EventArgs e)
        {
            Team team1 = (Team)cbFirstTeamName.SelectedItem;
            Team team2 = (Team)cbSecondTeamName.SelectedItem;
            int score1 = (int)nudTeam1Score.Value;
            int score2 = (int)nudTeam2Score.Value;

            if (team1 == team2)
            {
                MessageBox.Show("Please select different teams");
                return;
            }
            
            db.Matches.Add(new Match()
            {
                MatchTime = dtpDateTime.Value,
                Team1 = team1,
                Team2 = team2,
                Score1 = score1,
                Score2 = score2,
                Result = score1 == score2 ? Result.even : score1 > score2 ? Result.team1Win : Result.team2Win,
            });
            db.SaveChanges();
            MessageBox.Show("New Match Created");
        }
    }
}
