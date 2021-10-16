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
    public partial class FrmOyuncular : Form
    {
        Match match;
        public FrmOyuncular(Match match)
        {
            InitializeComponent();
            this.match = match;
            label2.Text = match.Id.ToString();
        }
    }
}
