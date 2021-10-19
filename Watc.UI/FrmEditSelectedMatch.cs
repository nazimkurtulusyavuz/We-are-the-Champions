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
        public FrmEditSelectedMatch(WatcContext db,Match match)
        {
            InitializeComponent();
            this.db = db;
            this.match = match;
            FillComboBoxesWithAllTeams();
            LoadSelectedMatch();
        }

        private void FillComboBoxesWithAllTeams()
        {
            cbFirstTeamName.DataSource =  db.Teams.ToList();
            cbSecondTeamName.DataSource = db.Teams.ToList();
        }

        private void LoadSelectedMatch()
        {
            cbFirstTeamName.Text = match.Team1.Name;
            cbSecondTeamName.Text = match.Team2.Name;
            txtTeam1Score.Text = match.Score1.ToString();
            txtTeam2Score.Text = match.Score2.ToString();

            if (match.MatchTime == null)                              
            {
                chkAllowDtp.Checked = false;
                dtpDateTime.Visible = false;
            }
            else
            {
                chkAllowDtp.Checked = true;
                dtpDateTime.Visible = true;
                dtpDateTime.Value = (DateTime)match.MatchTime;
            }
        }

        private void btnEditSelectedMatch_Click(object sender, EventArgs e)
        {
            int? score1;
            int? score2;
            //int? score1 = txtTeam1Score.Text == "" ? null : int.Parse(txtTeam1Score.Text);    //9.0 hatası verıyo??
            if (txtTeam1Score.Text == "")
            {
                score1 = null;
            }
            else
            {
                score1 = int.Parse(txtTeam1Score.Text);
            }
            if (txtTeam2Score.Text == "")
            {
                score2 = null;
            }
            else
            {
                score2 = int.Parse(txtTeam2Score.Text);
            }

            DateTime? matchTime;

            if (chkAllowDtp.Checked == false)
            {
                matchTime = null;
            }
            else
            {
                matchTime = (DateTime)dtpDateTime.Value;
            }

            
            db.Matches.Where(x => x.Id == match.Id).ToList()
                .ForEach(y => 
                { 
                    y.Team1 = (Team)cbFirstTeamName.SelectedItem;
                    y.Team2 = (Team)cbSecondTeamName.SelectedItem;
                    y.MatchTime = matchTime;
                    y.Score1 = score1;
                    y.Score2 = score2;
                });
            MessageBox.Show("Your Edit was Successful");
            db.SaveChanges();
        }

        private void chkAllowDtp_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateTime.Visible = chkAllowDtp.Checked ? true : false;
        }
    }
}
