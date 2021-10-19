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

            chkAllowDtp.Checked = true;
            dtpDateTime.Visible = true;
        }

        private void btnCreateNewMatch_Click(object sender, EventArgs e)
        {
            Team team1 = (Team)cbFirstTeamName.SelectedItem;
            Team team2 = (Team)cbSecondTeamName.SelectedItem;
            
            int? score1;
            int? score2;

            if (txtTeam1Score.Text == string.Empty)
            {
                score1 = null;
            }
            else if (Convert.ToInt32(txtTeam1Score.Text) >= 0)
            {
                score1 = Convert.ToInt32(txtTeam1Score.Text);
            }
            else
            {
                MessageBox.Show("Please enter a positive number");
                return;
            }


            if (txtTeam2Score.Text == string.Empty)
            {
                score2 = null;
            }
            else if (Convert.ToInt32(txtTeam2Score.Text) >= 0)
            {
                score2 = Convert.ToInt32(txtTeam2Score.Text);
            }
            else
            {
                MessageBox.Show("Please enter a positive number");
                return;
            }

            if (team1 == team2)
            {
                MessageBox.Show("Please select different teams");
                return;
            }

            DateTime? matchtime = chkAllowDtp.Checked == false ? null : (DateTime?)dtpDateTime.Value;
            
            db.Matches.Add(new Match()
            {
                MatchTime = matchtime,
                Team1 = team1,
                Team2 = team2,
                Score1 = score1,
                Score2 = score2,
                //Result = score1 == score2 ? Result.even : score1 > score2 ? Result.team1Win : Result.team2Win, doğrusu
                Result = (score1 == null || score2 == null) ? Result.none : 
                ( score1 == score2 ? Result.even : score1 > score2 ? Result.team1Win : Result.team2Win ),
            });

            db.SaveChanges();
            MessageBox.Show("New Match Created");
        }

        private void chkAllowDtp_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateTime.Visible = chkAllowDtp.Checked != true ? false : true;
        }
    }
}
