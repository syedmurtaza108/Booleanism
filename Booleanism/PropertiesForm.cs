using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booleanism
{
    public partial class PropertiesForm : Form
    {
        Form2 preForm;

        
        public PropertiesForm()
        {
            InitializeComponent();
            preForm = new Form2();
        }

        public PropertiesForm(Form2 PreForm)
        {
            InitializeComponent();
            preForm = PreForm;
        }



        public Panel ConfigPanelOuter { get {return configPanelOuter; } }

        public Panel ConfigPanel { get { return configPanel; } }

        private void pinToolboxBtn_Click(object sender, EventArgs e)
        {
            foreach (object item in preForm.ListOfControls)
            {
                Digital dig = (Digital)item;
                dig.ConfigPanel = preForm.ConfigPanel;
            }
            this.Hide();
            preForm.ConfigPanelOuter.Visible = true;
            Properties.Settings.Default.configPanel = preForm.ConfigPanel;
        }
    }
}
