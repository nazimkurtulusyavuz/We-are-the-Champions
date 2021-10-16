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
    public partial class FrmHome : Form
    {
        WatcContext db = new WatcContext();
        
        public FrmHome()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false;
            LoadMatches();
        }
        ////deneme yapıldı
        ////MatchTime=(x.MatchTime).ToString("HH:mm");
        private void LoadMatches()
        {
            dgvMatches.DataSource = db.Matches.ToList();
            //    var myMaches = db.Matches.Select
            //    (
            //       x => new MatchviewModel
            //       {
            //           Team1Name = x.Team1.Name,
            //           Team2Name = x.Team2.Name,
            //           //MatchTime = (x.MatchTime.ToString()).ToString("HH:mm"),
            //           //MatchTime = (x.MatchTime).ToString("HH:mm"),
            //           //MatchDate = DateTime.Parse(x.MatchTime.ToString()).ToString("dddd, dd MMMM yyyy"), 
            //           MatchScor = x.Score1 + "-" + x.Score2,
            //           Match = x,
            //       }
            //    );
            //    dgvMatches.DataSource = myMaches.ToList();
        }

        private void btnCreateNewMatch_Click(object sender, EventArgs e)
        {
            FrmNewMatch frm = new FrmNewMatch(db);
            frm.ShowDialog();
            LoadMatches();
        }

        private void btnEditSelectedMatch_Click(object sender, EventArgs e)
        {
            Match selectedMatch = (Match)dgvMatches.SelectedRows[0].DataBoundItem;
            FrmEditSelectedMatch frm = new FrmEditSelectedMatch(db,selectedMatch);
            frm.ShowDialog();
        }

        private void btnDeleteSelectedMatch_Click(object sender, EventArgs e)
        {
            db.Matches.Remove((Match)dgvMatches.SelectedRows[0].DataBoundItem);
            db.SaveChanges();
            MessageBox.Show("Selected Match has deleted");
            LoadMatches();
        }
        ////Deneme
        //private void dgvMatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow row = dgvMatches.SelectedRows[0];
        //    MatchviewModel matchviewModel = (MatchviewModel)row.DataBoundItem;
        //    Match match = matchviewModel.Match;
        //    //deneme basarılı sonuclandı.
        //    //FrmOyuncular deneme = new FrmOyuncular(match);
        //    //deneme.ShowDialog();
        //}
    }
}
