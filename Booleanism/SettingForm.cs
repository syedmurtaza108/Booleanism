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
    public partial class SettingForm : Syncfusion.Windows.Forms.MetroForm
    {
        float f = 1.0f;
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            color1Btn.BackColor = Properties.Settings.Default.wireColor;
            color2Btn.BackColor = Properties.Settings.Default.wireColor2;
            color3Btn.BackColor = Properties.Settings.Default.wireColor3;
            wireSizeCombo.SelectedIndex = GetIndexOfComboBox(Properties.Settings.Default.wireSize.ToString("N1"));
            textBox1.Text = Properties.Settings.Default.startupFile;
            //GetTheme();
        }

        private void clearRecentFiles_Click(object sender, EventArgs e)
        {
            string s = "Are you sure to clear all recent files";
            if(MessageBox.Show(s, "Booleanism V 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.recentFiles.Clear();
                Properties.Settings.Default.Save();
            }
        }

        private int GetIndexOfComboBox(string item)
        {
            int a = 0;
            switch(item)
            {
                case "1.5":
                    a = 1;
                    break;
                case "2.0":
                    a = 2;
                    break;
                case "2.5":
                    a = 3;
                    break;
                case "3.0":
                    a = 4;
                    break;
                case "3.5":
                    a = 5;
                    break;
                case "4.0":
                    a = 6;
                    break;
                case "4.5":
                    a = 7;
                    break;
                case "5.0":
                    a = 8;
                    break;
                case "5.5":
                    a = 9;
                    break;
                case "6.0":
                    a = 10;
                    break;
                default:
                    break;
            }
            return a;
        }

        private void color1Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                btn.BackColor = colorDialog.Color;
        }

        private void wireSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = (float)Convert.ToDouble(wireSizeCombo.SelectedItem);
            demoPanel.Refresh();

        }

        private void demoPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Red, f), new Point(0,0), new Point(100,0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.recentFiles.Add(openFileDialog.FileName);
                Properties.Settings.Default.Save();
                MessageBox.Show("This file has been added in Recent Files list.", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wireColor = color1Btn.BackColor;
            Properties.Settings.Default.wireColor2 = color2Btn.BackColor;
            Properties.Settings.Default.wireColor3 = color3Btn.BackColor;
            Properties.Settings.Default.wireSize = (float)Convert.ToDouble(wireSizeCombo.SelectedItem);
            Properties.Settings.Default.startupFile = textBox1.Text;
            

            Properties.Settings.Default.Save();
            if (MessageBox.Show("Your setting changes have been saved. For enjoying new selected theme, you must restart Booleanism V 1.0.", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Close();
        }

        private void clearTxtBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
