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
using Color = Watc.Data.Color;


namespace Watc.UI
{
    public partial class FrmHome : Form
    {
        WatcContext db = new WatcContext();
        //List<Match> playedMatches = new List<Match>();
        List<MatchviewModel> myMatchModels;
        
        public FrmHome()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false;
            dgvPlayers.AutoGenerateColumns = false;
            dgvTeams.AutoGenerateColumns = false;
            LoadMatches();
            chbHidePlayedMatches.Checked = false;
            LoadColors();
            LoadPlayersControls();
            LoadTeams();
        }

        private void LoadTeams()
        {
            var myTeamModels = (db.Teams.Select
           (
              x => new TeamviewModel
              {
                  Id = x.Id,
                  Name = x.Name,
                  Colors = (List<Color>)x.Colors,
                  Players = (List<Player>)x.Players,
                  Matches = (List<Match>)x.Matches,
              }
           ).ToList());

            dgvTeams.DataSource = myTeamModels;
        }

        private void LoadPlayersControls()
        {
            rbShowAllPlayers.Checked = true;
            rbShowPlayersAccordingtoTeam.Checked = false;
            lblSelectTeamToSeePlayers.Visible = false;
            chkTeamsToListPlayers.Visible = false;
            LoadAllPlayers();
        }
        private void LoadAllPlayers()
        {
            dgvPlayers.DataSource = db.Players.ToList();
        }

        private void LoadColors()
        {
            cbAllColors.DataSource = db.Colors.ToList();
        }
        
        private void LoadMatches()
        {
            myMatchModels = (db.Matches.Select
           (
              x => new MatchviewModel
              {
                  Team1Name = x.Team1.Name,
                  Team2Name = x.Team2.Name,
                  MatchDateTime = x.MatchTime.ToString(),    //MatchTime=(x.MatchTime).ToString("HH:mm");
                  MatchScore = x.Score1 == null || x.Score2 == null ? "?-?" : x.Score1 + "-" + x.Score2,
                  Match = x,
              }
           ).OrderBy(x => x.MatchDateTime).ToList());

            dgvMatches.DataSource = myMatchModels;
        }

        private void btnCreateNewMatch_Click(object sender, EventArgs e)
        {
            FrmNewMatch frm = new FrmNewMatch(db);
            frm.ShowDialog();
            LoadMatches();
        }

        private void btnEditSelectedMatch_Click(object sender, EventArgs e)
        {
            MatchviewModel selectedRow = (MatchviewModel)dgvMatches.SelectedRows[0].DataBoundItem;
            Match match = selectedRow.Match;
            FrmEditSelectedMatch frm = new FrmEditSelectedMatch(db, match);
            frm.ShowDialog();
            LoadMatches();
        }

        private void btnDeleteSelectedMatch_Click(object sender, EventArgs e)
        {
            db.Matches.Remove((Match)dgvMatches.SelectedRows[0].DataBoundItem);
            db.SaveChanges();
            MessageBox.Show("Selected Match has deleted");
            LoadMatches();
        }

        private void chbHidePlayedMatches_CheckedChanged(object sender, EventArgs e)
        {
            dgvMatches.DataSource = chbHidePlayedMatches.Checked ? 
                myMatchModels.Where(x => x.Match.MatchTime < DateTime.Now).ToList() : 
                myMatchModels.ToList();
        }

        private void btnCreateColor_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text == "" || int.TryParse(txtColorName.Text, out int n))
            {
                MessageBox.Show("Color name is required and it has to be a text");
                return;
            }
            else
            {
                Data.Color color = new Data.Color()
                {
                    ColorName = txtColorName.Text,
                    Red = hsbColorRed.Value,
                    Green = hsbColorGreen.Value,
                    Blue = hsbColorBlue.Value,
                };

                db.Colors.Add(color);
                db.SaveChanges();
                MessageBox.Show("A new color saved to database");
            }
        }

        private void hsbColorRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblColorRed.BackColor = System.Drawing.Color.FromArgb(hsbColorRed.Value, 0, 0);
            lblRedValue.Text = hsbColorRed.Value.ToString();
        }

        private void hsbColorGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblColorGreen.BackColor = System.Drawing.Color.FromArgb(0, hsbColorGreen.Value, 0);
            lblGreenValue.Text = hsbColorGreen.Value.ToString();
        }

        private void hsbColorBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblColorBlue.BackColor = System.Drawing.Color.FromArgb(0, 0, hsbColorBlue.Value);
            lblBlueValue.Text = hsbColorBlue.Value.ToString();
        }

        private void btnColorRGBPreview_Click(object sender, EventArgs e)
        {
            btnColorRGBPreview.BackColor = System.Drawing.Color
            .FromArgb(hsbColorRed.Value, hsbColorGreen.Value, hsbColorBlue.Value);
        }

        private void btnEditSelectedColor_Click(object sender, EventArgs e)
        {
            Color selectedColor = (Color)cbAllColors.SelectedItem;
            int colorId = selectedColor.Id;
            Color color = db.Colors.FirstOrDefault(clr => clr.Id == colorId);
            color.ColorName = txtColorName.Text;
            color.Red = hsbColorRed.Value;
            color.Green = hsbColorGreen.Value;
            color.Blue = hsbColorBlue.Value;
            db.SaveChanges();
            MessageBox.Show("Selected color has edited");
        }

        private void cbAllColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = (Color)cbAllColors.SelectedItem;
            txtColorName.Text = color.ColorName;
            hsbColorRed.Value = color.Red;
            lblRedValue.Text = color.Red.ToString();
            hsbColorGreen.Value = color.Green;
            lblGreenValue.Text = color.Green.ToString();
            hsbColorBlue.Value = color.Blue;
            lblBlueValue.Text = color.Blue.ToString();
            lblColorRed.BackColor = System.Drawing.Color.FromArgb(hsbColorRed.Value, 0, 0);
            lblColorGreen.BackColor = System.Drawing.Color.FromArgb(0, hsbColorGreen.Value, 0);
            lblColorBlue.BackColor = System.Drawing.Color.FromArgb(0, 0, hsbColorBlue.Value);
            btnColorRGBPreview.BackColor = System.Drawing.Color
                .FromArgb(hsbColorRed.Value, hsbColorGreen.Value, hsbColorBlue.Value);
        }

        private void btnDeleteSelectedColor_Click(object sender, EventArgs e)
        {
            Color selectedColor = (Color)cbAllColors.SelectedItem;
            int colorId = selectedColor.Id;
            Color color = db.Colors.FirstOrDefault(color1 => color1.Id == colorId);
            db.Colors.Remove(color);
            db.SaveChanges();
            MessageBox.Show("Selected color has deleted");

        }

        private void rbShowPlayersAccordingtoTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowPlayersAccordingtoTeam.Checked)
            {
                lblSelectTeamToSeePlayers.Visible = true;
                chkTeamsToListPlayers.Visible = true;
                chkTeamsToListPlayers.DataSource = db.Teams.ToList();
            }
            else
            {
                lblSelectTeamToSeePlayers.Visible = false;
                chkTeamsToListPlayers.Visible = false;
            }

        }

        private void chkTeamsToListPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayersByTeam();
        }

        private void LoadPlayersByTeam()
        {
            Team team = (Team)chkTeamsToListPlayers.SelectedItem;
            int id = team.Id;
            dgvPlayers.DataSource = db.Players.Where(player => player.Team.Id == id).ToList();
        }

        private void rbShowAllPlayers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowAllPlayers.Checked)
            {
                lblSelectTeamToSeePlayers.Visible = false;
                chkTeamsToListPlayers.Visible = false;
                LoadAllPlayers();
            }
        }

        private void btCreateNewPlayer_Click(object sender, EventArgs e)
        {
            FrmNewPlayer frm = new FrmNewPlayer(db);
            frm.ShowDialog();
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            if (rbShowAllPlayers.Checked)
            {
                LoadAllPlayers();
            }
            else
            {
                LoadPlayersByTeam();
            }
        }

        private void btnDeleteSelectedPlayer_Click(object sender, EventArgs e)
        {
            db.Players.Remove((Player)dgvPlayers.SelectedRows[0].DataBoundItem);
            db.SaveChanges();
            MessageBox.Show("player removal was successful!");
            LoadPlayers();
        }

        private void btnEditSelectedPlayer_Click(object sender, EventArgs e)
        {
            Player player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
            FrmEditSelectedPlayer frm = new FrmEditSelectedPlayer(db, player);
            frm.ShowDialog();
            LoadPlayers();
        }

        private void btnAddColorToSelectedTeam_Click(object sender, EventArgs e)
        {
            TeamviewModel twm = (TeamviewModel)dgvTeams.SelectedRows[0].DataBoundItem;
            FrmAddColorToSelectedTeam frm = new FrmAddColorToSelectedTeam(db,twm);
            frm.ShowDialog();
        }

        private void btnAddRemovePlayer_Click(object sender, EventArgs e)
        {
            TeamviewModel twm = (TeamviewModel)dgvTeams.SelectedRows[0].DataBoundItem;
            FrmAddRemovePlayersFromTheSelectedTeam frm = new FrmAddRemovePlayersFromTheSelectedTeam(db, twm);
            frm.ShowDialog();
        }

        private void btnCreateNewTeam_Click(object sender, EventArgs e)
        {
            Team team = new Team() { Name = txtNewTeamName.Text };
            db.Teams.Add(team);
            db.SaveChanges();
            MessageBox.Show("Team has saved");
            LoadTeams();
        }
    }
    
}
