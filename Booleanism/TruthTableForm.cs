using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booleanism
{
    public partial class TruthTableForm : Syncfusion.Windows.Forms.MetroForm
    {
        ArrayList comp;
        TruthTable table;

        public TruthTableForm()
        {
            InitializeComponent();
            comp = new ArrayList();
        }

        public TruthTableForm(ArrayList listOfComp)
        {
            InitializeComponent();
            comp = listOfComp;
        }

        public ArrayList ListOfComponents { set {comp =value; } }

        private void TruthTableForm_Load(object sender, EventArgs e)
        {
            try
            {
                table = new TruthTable(comp);
                int a = this.Text.LastIndexOf('\\');
                truthTableTxt.Text = table.TextTable(this.Text.Substring(a + 1, Text.Length - a - 6));
            }
            catch
            {
                MessageBox.Show("Truth Table couldn't be generated. Probably, you didn't connect your required components with PushButtons.\nFix it and then try again!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            string s = "Booleanism - Truth Table";
            int a = this.Text.LastIndexOf('\\');
            if (a != -1)
                s = this.Text.Substring(a+1,Text.Length - a - 6) ;
            sDia.FileName = s + " - Truth Table";
            if (sDia.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(sDia.FileName);
                StreamWriter sW = new StreamWriter(sDia.FileName);
                switch (extension.ToLower())
                {
                    case ".html":
                        sW.Write(table.HTMLTable(s));
                        break;
                    default:
                        sW.Write(table.TextTable(s)) ;
                        break;
                }
                sW.Close();
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                truthTableDoc.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void truthTableDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int a = this.Text.LastIndexOf('\\');
            string s = "Booleanism";
            if (a != -1)
                s = this.Text.Substring(a + 1, Text.Length - a - 6);
            e.Graphics.DrawString(table.TextTable(s), new Font("Cambria", 10), Brushes.Blue, e.MarginBounds.X, e.MarginBounds.Y);
        }

        private void pageSetupBtn_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void instructionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InstructionsForm form = new InstructionsForm();
            form.ShowDialog();
        }
    }
}
