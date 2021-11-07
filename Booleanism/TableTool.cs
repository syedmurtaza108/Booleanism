using System;
using System.Collections;
using Booleanism;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace Booleanism
{
    public partial class TableTool : MetroForm
    {
        ArrayList list;

        public TableTool()
        {
            InitializeComponent();
            list = new ArrayList();
        }

        public TableTool(ArrayList components)
        {
            InitializeComponent();
            list = components;
        }

        public ArrayList ListOfControls { get {return list; } set {list = value; } }

        public RichTextBox TruthTable { get {return truthTableTxt; } set {truthTableTxt = value; } }

        public string Heading { get { return nameLabel.Text; } set { nameLabel.Text = value; } }

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {
            TruthTable table = new Booleanism.TruthTable(list);
            truthTableTxt.Text = table.ShortTable(Digital.GetDigitalInstantByName(nameLabel.Text));            
        }


        private void TableTool_Load(object sender, EventArgs e)
        {

        }
    }
}
