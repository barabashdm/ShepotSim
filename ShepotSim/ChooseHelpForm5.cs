using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShepotSim
{
    public partial class ChooseHelpForm5 : Form
    {
        public ChooseHelpForm5()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Справка.chm", HelpNavigator.TableOfContents);
        }

        private void btnPlusHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Дополнительная справка.pdf");
        }
    }
}
