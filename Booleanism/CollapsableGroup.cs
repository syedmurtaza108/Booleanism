using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booleanism
{
    public partial class CollapsableGroup : UserControl
    {
        public CollapsableGroup()
        {
            InitializeComponent();
        }

        private void collapseBtn_MouseHover(object sender, EventArgs e)
        {
            collapseBtn.Image = Properties.Resources.collapse_hover;
        }

        private void collapseBtn_MouseLeave(object sender, EventArgs e)
        {
            collapseBtn.Image = Properties.Resources.collapse;
        }
    }
}
