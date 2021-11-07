using System;
using System.Collections;
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
    public partial class Form2 : Syncfusion.Windows.Forms.MetroForm
    {
        ArrayList listOfControls;
        public static System.Windows.Forms.PropertyGrid propertyGrid1;
        PropertiesForm propForm;
        public static TableTool tableTool;
        int msgCount = 0;
        int elemCount = 0;

        public Form2()
        {
            InitializeComponent();
            InitalizePropertGrid();
            listOfControls = new ArrayList();
            Properties.Settings.Default.configPanel = configPanel;
            toolBoxView1.Form = this;

        }

        public Form2(string file)
        {
            InitializeComponent();
            InitalizePropertGrid();
            listOfControls = new ArrayList();
            Properties.Settings.Default.configPanel = configPanel;
            toolBoxView1.Form = this;
            OpenAFile(file);
        }

        
        #region Gates initialization methods
        private void InitializeAndGate(int inputPins)
        {
            try
            {
                And and = new And(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                and.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(and);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private And GetInstanceOfAndGate(int inputPins)
        {
            try
            {
                And and = new And(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                and.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(and);
                return and;
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        private Clock_Signal GetInstanceOfClock()
        {
            try
            {
                Clock_Signal signal = new Clock_Signal(contentPanel);
                signal.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(signal);
                return signal;
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        JK GetInstanceOfJK()
        {
            try
            {
                JK jk = new JK(contentPanel, Properties.Settings.Default.configPanel);
                jk.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(jk);
                return jk;
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        Display GetInstanceOfDisplay()
        {
            try
            {
                Display d = new Display(contentPanel, configPanel, Color.Blue);
                d.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(d);
                return d;
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        Not GetInstanceOfNotGate()
        {
            try
            {
                Not not = new Not(contentPanel, Properties.Settings.Default.configPanel);
                not.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(not);
                return not;
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private Or GetInstanceOfOrGate(int inputPins)
        {
            try
            {
                Or and = new Or(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                and.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(and);
                return and;
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void InitializeOrGate(int inputPins)
        {
            try
            {
                Or and = new Or(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                and.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(and);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeXorGate(int inputPins)
        {
            try
            {
                Xor xor = new Xor(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                xor.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(xor);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Xor GetInstanceOfXorGate(int inputPins)
        {
            try
            {
                Xor xor = new Xor(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                xor.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(xor);
                return xor;
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void InitializeNorGate(int inputPins)
        {
            try
            {
                Nor nor = new Nor(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                nor.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(nor);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeNandGate(int inputPins)
        {
            try
            {
                Nand nand = new Nand(contentPanel, Properties.Settings.Default.configPanel, inputPins);
                nand.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(nand);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializePushButton()
        {
            try
            {
                PushButton btn = new PushButton(contentPanel);
                btn.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(btn);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        PushButton GetInstanceOfPushButton()
        {
            try
            {
                PushButton btn = new PushButton(contentPanel);
                btn.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(btn);
                return btn;
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        #endregion

        #region Gates button methods
        private void andGate_ButtonClick(object sender, EventArgs e)
        {
            InitializeAndGate(2);
        }

        private void andGate3InputsItem_Click(object sender, EventArgs e)
        {
            InitializeAndGate(3);
        }

        private void andGate4InputsItem_Click(object sender, EventArgs e)
        {
            InitializeAndGate(4);
        }

        private void andGate5InputsItem_Click(object sender, EventArgs e)
        {
            InitializeAndGate(5);
        }

        private void orGate_ButtonClick(object sender, EventArgs e)
        {
            InitializeOrGate(2);
        }

        private void orGate3Inputs_Click(object sender, EventArgs e)
        {
            InitializeOrGate(3);
        }

        private void orGate4Inputs_Click(object sender, EventArgs e)
        {
            InitializeOrGate(4);
        }

        private void orGate5Inputs_Click(object sender, EventArgs e)
        {
            InitializeOrGate(5);
        }

        private void xorGate_ButtonClick(object sender, EventArgs e)
        {
            InitializeXorGate(2);
        }

        private void xorGate3Inputs_Click(object sender, EventArgs e)
        {
            InitializeXorGate(3);
        }

        private void xorGate4Inputs_Click(object sender, EventArgs e)
        {
            InitializeXorGate(4);
        }

        private void xorGate5Inputs_Click(object sender, EventArgs e)
        {
            InitializeXorGate(5);
        }

        private void norGate_ButtonClick(object sender, EventArgs e)
        {
            InitializeNorGate(2);
        }

        private void norGate3Inputs_Click(object sender, EventArgs e)
        {
            InitializeNorGate(3);
        }

        private void norGate4Inputs_Click(object sender, EventArgs e)
        {
            InitializeNorGate(4);
        }

        private void norGate5Inputs_Click(object sender, EventArgs e)
        {
            InitializeNorGate(5);
        }

        private void nandGate_ButtonClick(object sender, EventArgs e)
        {
            InitializeNandGate(2);
        }

        private void nandGate3Inputs_Click(object sender, EventArgs e)
        {
            InitializeNandGate(3);
        }

        private void nandGate4Inputs_Click(object sender, EventArgs e)
        {
            InitializeNandGate(4);
        }

        private void nandGate5Inputs_Click(object sender, EventArgs e)
        {
            InitializeNandGate(5);
        }

        private void notGate_Click(object sender, EventArgs e)
        {

            try
            {
                Not not = new Not(contentPanel, Properties.Settings.Default.configPanel);
                not.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(not);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Flipflops methods
        private void rsFlip_Click(object sender, EventArgs e)
        {
            try
            {
                RS rs = new RS(contentPanel, Properties.Settings.Default.configPanel);
                rs.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(rs);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void jkFlip_Click(object sender, EventArgs e)
        {
            try
            {
                JK jk = new JK(contentPanel, Properties.Settings.Default.configPanel);
                jk.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(jk);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dFlip_Click(object sender, EventArgs e)
        {
            try
            {
                D d = new D(contentPanel, Properties.Settings.Default.configPanel);
                d.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(d);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public Panel ConfigPanelOuter { get { return configPanelOuter; } }

        public Panel ConfigPanel { get { return configPanel; } }

        public Panel ContentPanel { get { return contentPanel; } }


        public Label DetailsLabel { get { return detailsLabel; } }

        public ArrayList ListOfControls { get { return listOfControls; } set { listOfControls = value; } }

        private void duplicateBtn_Click(object sender, EventArgs e)
        {
            Duplicate duplicate = new Duplicate(contentPanel, Properties.Settings.Default.configPanel);
            contentPanel.Controls.Add(duplicate.GetDuplicate(Digital.GetDigitalInstantByName(Digital.SelectedInstant)));
        }

        private void detailsLabel_TextChanged(object sender, EventArgs e)
        {
            if (!detailsLabel.Text.Contains("Ready") && Digital.SelectedInstant != "")
            {
                duplicateBtn.Enabled = true;
                tableTool.Heading = Digital.GetDigitalInstantByName(Digital.SelectedInstant).Name;
            }
            else
                duplicateBtn.Enabled = false;
        }

        private void ledButton_Click(object sender, EventArgs e)
        {
            LED led = new LED(contentPanel, Properties.Settings.Default.configPanel);
            led.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(led);
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            InitializePushButton();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Digital.GetDigitalInstantByName(Digital.SelectedInstant).SetConfiguration();
        }


        private void findTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (findBtn.Checked)
                    {
                        string temp = Digital.SelectedInstant;
                        Digital.GetDigitalInstantByName(findTxtBox.Text).BorderStyle = BorderStyle.FixedSingle;
                        Digital.SelectedInstant = findTxtBox.Text;
                        Digital.GetDigitalInstantByName(temp).BorderStyle = BorderStyle.None;
                    }
                    else
                    {
                        string temp = Digital.SelectedInstant;
                        Digital.GetDigitalInstantByTitle(findTxtBox.Text).BorderStyle = BorderStyle.FixedSingle;
                        Digital.SelectedInstant = Digital.GetDigitalInstantByTitle(findTxtBox.Text).Name;
                        Digital.GetDigitalInstantByName(temp).BorderStyle = BorderStyle.None;
                    }
                    findTxtBox.Clear();
                }
            }
            catch
            {
                MessageBox.Show("No component found! Make sure that you've entered correct name/title of the instant.", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void contentPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (contentPanel.Controls.Count == 0)
            {
                nextBtn.Enabled = false;
                detailsLabel.Text = "Welcome";
            }
            tableTool.ListOfControls = listOfControls;
            //elemCount++;
            //Digital a = listOfControls[listOfControls.Count - 1] as Digital;
            //errorlistView1.dwTaskListView.Items.Add(elemCount.ToString()).SubItems.Add(DateTime.Now.ToLongTimeString());
            //errorlistView1.dwTaskListView.Items[errorlistView1.dwTaskListView.Items.Count - 1].SubItems.Add(a.Name + " has been added in the circuit.");
        }



        private void contentPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            
            listOfControls.Add(contentPanel.Controls[contentPanel.Controls.Count - 1]);
            if (contentPanel.Controls.Count > 0)
            {
                nextBtn.Enabled = true;
            }
            elemCount++;
            Digital a = listOfControls[listOfControls.Count - 1] as Digital;
            errorlistView1.dwTaskListView.Items.Add(elemCount.ToString()).SubItems.Add(DateTime.Now.ToLongTimeString());
            errorlistView1.dwTaskListView.Items[errorlistView1.dwTaskListView.Items.Count - 1].SubItems.Add(a.Name + " has been added in the circuit.");
            tableTool.ListOfControls = listOfControls;
        }

        private void changeTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Digital.GetDigitalInstantByName(Digital.SelectedInstant).Title = changeTitle.Text;
                changeTitle.Clear();
            }

        }

        private void preBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Digital temp = Digital.GetDigitalInstantByName(Digital.SelectedInstant);
                int index = listOfControls.IndexOf(temp);
                index = index == 0 ? listOfControls.Count - 1 : index - 1;
                Digital temp2 = (Digital)listOfControls[index];
                temp.BorderStyle = BorderStyle.None;
                Digital.SelectedInstant = temp2.Name;
                temp2.BorderStyle = BorderStyle.FixedSingle;

            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Digital temp = Digital.GetDigitalInstantByName(Digital.SelectedInstant);
                int index = listOfControls.IndexOf(temp);
                index = index == listOfControls.Count - 1 ? 0 : index + 1;
                Digital temp2 = (Digital)listOfControls[index];
                temp.BorderStyle = BorderStyle.None;
                Digital.SelectedInstant = temp2.Name;
                temp2.BorderStyle = BorderStyle.FixedSingle;

            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void allignTypeBtn_Click(object sender, EventArgs e)
        {
            Alignment alignment = new Alignment(listOfControls);
            alignment.Align(Alignment.AlignmentType.Vertically);
        }

        private void allignHorizonBtn_Click(object sender, EventArgs e)
        {
            Alignment alignment = new Alignment(listOfControls);
            alignment.Align(Alignment.AlignmentType.Horizontally);
        }

        private void allignJustifyBtn_Click(object sender, EventArgs e)
        {
            Alignment alignment = new Alignment(listOfControls);
            alignment.Align(Alignment.AlignmentType.Justify);
        }

        private void nextBtn_EnabledChanged(object sender, EventArgs e)
        {
            nextToolStripMenuItem.Enabled = nextBtn.Enabled;
            preToolStripMenuItem.Enabled = nextBtn.Enabled;
            preBtn.Enabled = nextBtn.Enabled;
            deleteBtn.Enabled = nextBtn.Enabled;
            refreshBtn.Enabled = nextBtn.Enabled;
            duplicateBtn.Enabled = nextBtn.Enabled;
            changeTitle.Enabled = nextBtn.Enabled;
            findBtn.Enabled = nextBtn.Enabled;
            findTxtBox.Enabled = nextBtn.Enabled;
            deleteAllToolStripMenuItem.Enabled = nextBtn.Enabled;
            deleteToolStripMenuItem.Enabled = nextBtn.Enabled;
            allignJustifyBtn.Enabled = nextBtn.Enabled;
            alignmentToolStripMenuItem.Enabled = nextBtn.Enabled;
            duplicateToolStripMenuItem.Enabled = nextBtn.Enabled;
            refreshToolStripMenuItem.Enabled = nextBtn.Enabled;
            refreshAllWiresToolStripMenuItem.Enabled = nextBtn.Enabled;
            refreshAllWireToolStripButton.Enabled = nextBtn.Enabled;
        }

        private void deleteAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            listOfControls.Clear();
            Digital.DeleteAllComponents();
            Properties.Settings.Default.configPanel.Controls.Clear();
            Wire.wireList.Clear();
            contentPanel.Controls.Clear();
        }

        private void deleteBtn_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                Digital temp = Digital.GetDigitalInstantByName(Digital.SelectedInstant);
                foreach (Digital i in listOfControls)        //Also delete the object from the listOfControls of this class.
                {
                    if (i.Name == temp.Name)
                    {
                        listOfControls.Remove(i);
                        break;
                    }
                }
                elemCount++;
                errorlistView1.dwTaskListView.Items.Add(elemCount.ToString()).SubItems.Add(DateTime.Now.ToLongTimeString());
                errorlistView1.dwTaskListView.Items[errorlistView1.dwTaskListView.Items.Count - 1].SubItems.Add(temp.Name + " has been removed from the circuit.");
                temp.Delete();
                Properties.Settings.Default.configPanel.Controls.Clear();
                detailsLabel.Text = "Ready";

            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void configPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (Properties.Settings.Default.configPanel.Controls.Count > 0)
            {
                propLabel.Enabled = true;
                
            }

            }

        private void configPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (Properties.Settings.Default.configPanel.Controls.Count < 1)
                propLabel.Enabled = false;
        }
        
        private void notGatePicBox_Click(object sender, EventArgs e)
        {
            notGate_Click(sender, e);
        }

        private void rsFlipFlopPicBox_Click(object sender, EventArgs e)
        {
            rsFlip_Click(sender, e);
        }

        private void jkFlipFlopPicBox_Click(object sender, EventArgs e)
        {
            jkFlip_Click(sender, e);
        }

        private void dFlipFlopPicBox_Click(object sender, EventArgs e)
        {
            dFlip_Click(sender, e);
        }

        #region Led Methods

        LED GetInstanceOfLED(LED.LEDType type)
        {
            LED greenLed = new LED(type, contentPanel, Properties.Settings.Default.configPanel);
            greenLed.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(greenLed);
            return greenLed;
        }

        private void greenLedPicBox_Click(object sender, EventArgs e)
        {
            LED greenLed = new LED(LED.LEDType.Green, contentPanel, Properties.Settings.Default.configPanel);
            greenLed.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(greenLed);
        }


        private void redLedPicBox_Click(object sender, EventArgs e)
        {
            LED redLed = new LED(LED.LEDType.Red, contentPanel, Properties.Settings.Default.configPanel);
            redLed.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(redLed);
        }

        private void purpleLedPicBox_Click(object sender, EventArgs e)
        {
            LED purpleLed = new LED(LED.LEDType.Purple, contentPanel, Properties.Settings.Default.configPanel);
            purpleLed.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(purpleLed);
        }

        private void yellowLedPicBox_Click(object sender, EventArgs e)
        {
            LED yellowLed = new LED(LED.LEDType.Yellow, contentPanel, Properties.Settings.Default.configPanel);
            yellowLed.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(yellowLed);
        }

        private void whiteLedPicBox_Click(object sender, EventArgs e)
        {
            LED whiteLed = new LED(LED.LEDType.White, contentPanel, Properties.Settings.Default.configPanel);
            whiteLed.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(whiteLed);
        }
        #endregion

        private void clockPicBox_Click(object sender, EventArgs e)
        {
            Clock_Signal signal = new Clock_Signal(contentPanel);
            signal.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(signal);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Digital_File file = new Digital_File(Properties.Settings.Default.mostRecentFile);
            file.WriteFile(listOfControls);
            this.Text = "Booleanism V 2.0 - " + Properties.Settings.Default.mostRecentFile;
            detailsLabel.Text = Properties.Settings.Default.mostRecentFile + "successfully saved.";
            Properties.Settings.Default.isSaved = true;
        }

        private void saveToolStripMenuItem_EnabledChanged(object sender, EventArgs e)
        {
            saveToolStripButton.Enabled = saveToolStripMenuItem.Enabled;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                newToolStripMenuItem_Click(sender, e);
                OpenFileDialog oD = new OpenFileDialog();
                oD.Title = "Open a File";
                oD.Multiselect = false;
                oD.Filter = "Booleanism File(.bool)|*.bool";
                oD.FileName = "Booleanism";
                if (oD.ShowDialog() == DialogResult.OK)
                {
                    OpenAFile(oD.FileName);
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void OpenAFile(string fileName)
        {
            Digital_File file = new Digital_File(fileName);
            file.ReadFile(contentPanel, configPanel, detailsLabel);
            int a = Properties.Settings.Default.recentFiles.IndexOf(fileName);
            if (a == -1)
                Properties.Settings.Default.recentFiles.Add(fileName);
            else
            {
                Properties.Settings.Default.recentFiles.RemoveAt(a);
                recentStripMenuItem.DropDownItems.RemoveAt(a + 1);
                Properties.Settings.Default.recentFiles.Add(fileName);
            }
            this.Text = "Booleanism V 2.0 - " + fileName;
            Properties.Settings.Default.mostRecentFile = fileName;
            saveToolStripMenuItem.Enabled = true;
            Properties.Settings.Default.Save();
            detailsLabel.Text = Properties.Settings.Default.mostRecentFile + " successfully loaded.";
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            break;
                        case DialogResult.No:
                            NewFile();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sD = new SaveFileDialog();
                sD.Title = "Save the File";
                sD.RestoreDirectory = true;
                sD.FileName = "Booleanism";
                sD.Filter = "Booleanism File(.bool)|*.bool";
                if (sD.ShowDialog() == DialogResult.OK)
                {
                    Digital_File file = new Digital_File(sD.FileName);
                    file.WriteFile(listOfControls);
                    Properties.Settings.Default.mostRecentFile = sD.FileName;
                    Properties.Settings.Default.isSaved = true;
                    saveToolStripMenuItem.Enabled = true;
                }
                Text = "Booleanism V 2.0 - " + sD.FileName;
                detailsLabel.Text = sD.FileName + " successfully saved.";
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void NewFile()
        {
            try
            {
                contentPanel.Controls.Clear();
                Properties.Settings.Default.configPanel.Controls.Clear();
                this.Text = "Booleanism V 2.0";
                Digital.SelectedInstant = "";
                contentPanel.Refresh();
                Properties.Settings.Default.mostRecentFile = "";
                saveToolStripMenuItem.Enabled = false;
                for (int i = 0; i < Digital.DigitalComponents.Length; i++)
                {
                    if (Digital.DigitalComponents[i] != null)
                        Digital.DigitalComponents[i] = null;
                }
                for (int i = listOfControls.Count - 1; i >= 0; i--)
                {
                    Digital dig = (Digital)listOfControls[i];
                    dig.RestartCounting();
                    listOfControls.RemoveAt(i);
                }
                Wire.wireList.Clear();

            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printPanel_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                CircuitDiagram dia = new CircuitDiagram(listOfControls, this.Text.Substring(this.Text.LastIndexOf('\\') + 1));
                dia.GetDiagram(e.Graphics);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelPrintDialog.ShowDialog() == DialogResult.OK)
                printPanel.Print();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewPanel.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                //Setup themes
                //if (Properties.Settings.Default.themeColor == Color.Brown)
                //    BrownTheme();
                //else if (Properties.Settings.Default.themeColor == Color.Green)
                //    GreenTheme();
                //else
                //    BlueTheme();

                //Setups recent files
                if (Properties.Settings.Default.recentFiles.Count > 1)
                {
                    recentStripMenuItem.Enabled = true;
                    for (int i = 0; i < Properties.Settings.Default.recentFiles.Count; i++)
                    {
                        if (Properties.Settings.Default.recentFiles[i].ToUpper() != "NULL")
                        {
                            recentStripMenuItem.DropDownItems.Add(Properties.Settings.Default.recentFiles[i], Properties.Resources.file_icon);
                            recentStripMenuItem.DropDownItems[i + 1].Click += new EventHandler(recentSubItems_Click);
                        }
                    }
                }
                else
                    recentStripMenuItem.Enabled = false;

                //Setup startup file
                if (Properties.Settings.Default.startupFile != "")
                {
                    Digital_File file = new Digital_File(Properties.Settings.Default.startupFile);
                    this.Text = "Booleanism V 2.0 - " + file.File;
                    detailsLabel.Text = file.File + " has been loaded successfully.";
                    file.ReadFile(contentPanel, Properties.Settings.Default.configPanel, detailsLabel);
                    saveToolStripMenuItem.Enabled = true;
                }

                //View Toolstrip Menu
                SetViewToolstrip();
                ToolbarSetting();
                outputWindowView1.outputTextBox.Text = "Welcome To Booleanism V 2.0, developed By Syed Murtaza. For any query, contact me at syedmurtaza108@gmail.com.";
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recentSubItems_Click(object sender, EventArgs e)
        {
            try
            {
                newToolStripMenuItem_Click(sender, e);
                ToolStripMenuItem temp = (ToolStripMenuItem)sender;
                if (System.IO.File.Exists(temp.Text))
                {
                    Properties.Settings.Default.mostRecentFile = temp.Text;
                    Digital_File file = new Digital_File(Properties.Settings.Default.mostRecentFile);
                    file.ReadFile(contentPanel, Properties.Settings.Default.configPanel, detailsLabel);
                    saveToolStripMenuItem.Enabled = true;
                    this.Text = "Booleanism V 2.0 - " + temp.Text;
                    detailsLabel.Text = temp.Text + " has successfully loaded.";
                }
                else
                {
                    recentStripMenuItem.DropDownItems.Remove(temp);
                    Properties.Settings.Default.recentFiles.Remove(temp.Text);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("This file doesn't exist.", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearAllRecentItems_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = recentStripMenuItem.DropDownItems.Count - 1; i > 1; i--)
                {
                    recentStripMenuItem.DropDownItems.RemoveAt(i);
                    Properties.Settings.Default.recentFiles.RemoveAt(i - 1);
                    Properties.Settings.Default.Save();
                }
                recentStripMenuItem.Enabled = false;
                this.Text = "Booleanism V 2.0";
                detailsLabel.Text = "Recent items have been cleared.";
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sD = new SaveFileDialog();
                sD.Title = "Save The Diagram As Image";
                sD.RestoreDirectory = true;
                int a = this.Text.LastIndexOf('\\');
                string temp = "Diagram - " + this.Text.Substring(a + 1, Text.Length - a - 6);
                sD.FileName = temp;
                sD.Filter = "Joint Photographic Experts Group(JPEG)|*.jpeg;*.jpg|Portable Network Graphics(PNG)|*.png|Graphics Interchange Format(GIF)|*.gif";
                if (sD.ShowDialog() == DialogResult.OK)
                {
                    CircuitDiagram dia = new CircuitDiagram(listOfControls, temp);
                    Bitmap bmp = dia.GetDiagram(contentPanel.Width, contentPanel.Height);
                    bmp.Save(sD.FileName);
                    MessageBox.Show("File has been successfully saved at " + sD.FileName + ".", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    detailsLabel.Text = "File has been successfully saved at " + sD.FileName + ".";
                }


            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!! File was not successfully saved.", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshAllWireToolStripButton_Click(object sender, EventArgs e)
        {
            contentPanel.Refresh();
            for (int i = 0; i < Wire.wireList.Count; i++)
            {
                Wire wire = (Wire)Wire.wireList[i];
                wire.DrawWire();
                detailsLabel.Text = "Wires has been refreshed successfully.";
            }
        }

        private void contentPanel_Click(object sender, EventArgs e)
        {
            if (Digital.SelectedInstant != "")
            {
                Digital temp = Digital.GetDigitalInstantByName(Digital.SelectedInstant);
                temp.BorderStyle = BorderStyle.None;
                detailsLabel.Text = "Ready";
            }
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TruthTableForm form = new TruthTableForm(listOfControls);
                form.Text = this.Text;
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!! ", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm s = new SettingForm();
            s.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Properties.Settings.Default.isSaved)
            {
                DialogResult result = MessageBox.Show("Do you want to save your recent changes?", "Booleanism V 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        if (saveToolStripMenuItem.Enabled)
                            saveToolStripMenuItem_Click(sender, e);
                        else
                            saveAsToolStripMenuItem_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
        }

        #region Themes
        private void BrownTheme()
        {
            menuStrip1.BackColor = Color.White;
            toolStrip1.BackColor = Color.FloralWhite;
            toolStrip2.BackColor = Color.PapayaWhip;
            toolStrip3.BackColor = Color.AntiqueWhite;
            configPanel.BackColor = Color.Linen;
            configPanelOuter.BackColor = Color.PeachPuff;
            detailsLabel.ForeColor = Color.Red;
        }

        private void BlueTheme()
        {
            menuStrip1.BackColor = Color.Lavender;
            toolStrip1.BackColor = Color.PowderBlue;
            toolStrip2.BackColor = Color.PaleTurquoise;
            toolStrip3.BackColor = Color.SkyBlue;
            configPanel.BackColor = Color.PaleTurquoise;
            configPanelOuter.BackColor = Color.MediumTurquoise;
            detailsLabel.ForeColor = Color.Teal;
        }

        private void GreenTheme()
        {
            menuStrip1.BackColor = Color.Gainsboro;
            toolStrip1.BackColor = Color.White;
            toolStrip2.BackColor = Color.MediumAquamarine;
            toolStrip3.BackColor = Color.White;
            configPanel.BackColor = Color.Honeydew;
            configPanelOuter.BackColor = Color.PowderBlue;
            detailsLabel.ForeColor = Color.Green;
        }
        #endregion

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {
            Properties.Settings.Default.isSaved = contentPanel.Controls.Count > 0 ? false : true;
        }

        private void SetViewToolstrip()
        {
            if (Properties.Settings.Default.isCompToolbar)
                hideComponentsToolbarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
            if (Properties.Settings.Default.isFileMenuToolbar)
                hideFileMenuToolbarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
            if (Properties.Settings.Default.isEditMenuToolbar)
                hideEditMenuToolbarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
            if (Properties.Settings.Default.isStatusbar)
                statusBarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
            if (Properties.Settings.Default.isTruthTool)
                truthTableWindowToolStripMenuItem.Image = Properties.Resources.ok_16x16;
        }

        private void ToolbarSetting()
        {
            int a = 24;
            if (Properties.Settings.Default.isProperties)
                configPanelOuter.Visible = true;
            else
                configPanelOuter.Visible = false;
            if (Properties.Settings.Default.isFileMenuToolbar)
            {
                toolStrip3.Visible = true;
                a += toolStrip3.Height;
            }
            else
                toolStrip3.Visible = false;
            if (Properties.Settings.Default.isEditMenuToolbar)
            {
                toolStrip2.Visible = true;
                a += toolStrip2.Height;
            }
            else
                toolStrip2.Visible = false;
            if (Properties.Settings.Default.isCompToolbar)
            {
                toolStrip1.Visible = true;
                a += toolStrip1.Height;
            }
            else
                toolStrip1.Visible = false;
            tableTool = new TableTool(listOfControls);
            if (Properties.Settings.Default.isTruthTool)
                tableTool.Show();
            else
                tableTool.Hide();
            propForm = new PropertiesForm(this);
            propForm.ConfigPanelOuter.BackColor = configPanelOuter.BackColor;
            propForm.ConfigPanel.BackColor = configPanel.BackColor;
            
        }

        private void hideToolboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isToolbox)
            {
                Properties.Settings.Default.isToolbox = false;
                
            }
            else
            {
                Properties.Settings.Default.isToolbox = true;
                
            }
            Properties.Settings.Default.Save();
        }

        private void hidePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isProperties)
            {
                Properties.Settings.Default.isProperties = false;
                
                configPanelOuter.Visible = false;
            }
            else
            {
                Properties.Settings.Default.isProperties = true;
                configPanelOuter.Visible = true;
            }
            propForm.Hide();
            Properties.Settings.Default.Save();
        }

        private void hideComponentsToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isCompToolbar)
            {
                Properties.Settings.Default.isCompToolbar = false;
                hideComponentsToolbarToolStripMenuItem.Image = null;
                toolStrip1.Visible = false;
            }
            else
            {
                Properties.Settings.Default.isCompToolbar = true;
                hideComponentsToolbarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
                toolStrip1.Visible = true;
            }
            Properties.Settings.Default.Save();
        }

        private void hideEditMenuToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isEditMenuToolbar)
            {
                Properties.Settings.Default.isEditMenuToolbar = false;
                hideEditMenuToolbarToolStripMenuItem.Image = null;
                toolStrip2.Visible = false;
            }
            else
            {
                Properties.Settings.Default.isEditMenuToolbar = true;
                hideEditMenuToolbarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
                toolStrip2.Visible = true;
            }
            Properties.Settings.Default.Save();
        }

        private void hideFileMenuToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isFileMenuToolbar)
            {
                Properties.Settings.Default.isFileMenuToolbar = false;
                hideFileMenuToolbarToolStripMenuItem.Image = null;
                toolStrip3.Visible = false;
            }
            else
            {
                Properties.Settings.Default.isFileMenuToolbar = true;
                hideFileMenuToolbarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
                toolStrip3.Visible = true;
            }
            Properties.Settings.Default.Save();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isStatusbar)
            {
                Properties.Settings.Default.isStatusbar = false;
                statusBarToolStripMenuItem.Image = null;
            
            }
            else
            {
                Properties.Settings.Default.isStatusbar = true;
                statusBarToolStripMenuItem.Image = Properties.Resources.ok_16x16;
               
            }
            Properties.Settings.Default.Save();
        }

        private void toolStrip3_VisibleChanged(object sender, EventArgs e)
        {
            
        }


        private void pinToolboxBtn_Click(object sender, EventArgs e)
        {
        }

        private void pinPropBtn_Click(object sender, EventArgs e)
        {
            foreach (object item in listOfControls)
            {
                Digital dig = (Digital)item;
                dig.ConfigPanel = propForm.configPanel;
            }
            configPanelOuter.Visible = false;
            propForm.Show();
            Properties.Settings.Default.configPanel = propForm.configPanel;
        }

        private void truthTableWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isTruthTool)
            {
                Properties.Settings.Default.isTruthTool = false;
                truthTableWindowToolStripMenuItem.Image = null;
                tableTool.Hide();
            }
            else
            {
                Properties.Settings.Default.isTruthTool = true;
                truthTableWindowToolStripMenuItem.Image = Properties.Resources.ok_16x16;
                tableTool.Show();
            }
            Properties.Settings.Default.Save();
        }


        private void displayBtn_Click(object sender, EventArgs e)
        {
            Display d = new Display(contentPanel, configPanel);
            d.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(d);
        }

        private void greenDisplayMenuItem_Click(object sender, EventArgs e)
        {
            Display d = new Display(contentPanel, configPanel, Color.LimeGreen);
            d.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(d);
        }

        private void blueDisplayMenuItem_Click(object sender, EventArgs e)
        {
            Display d = new Display(contentPanel, configPanel, Color.Blue);
            d.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(d);
        }

        private void yellowDisplayMenuItem_Click(object sender, EventArgs e)
        {
            Display d = new Display(contentPanel, configPanel, Color.Gold);
            d.DetailsLabel = detailsLabel;
            contentPanel.Controls.Add(d);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBool abt = new AboutBool();
            abt.Show();
        }

        private void halfAdderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            HalfAdder();
                            break;
                        case DialogResult.No:
                            NewFile();
                            HalfAdder();
                            break;
                        default:
                            break;
                    }
                }
                else
                    HalfAdder();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void HalfAdder()
        {
            int x = 50, y = 50;
            Digital btn1 = GetInstanceOfPushButton();
            btn1.Location = new Point(x, y); y += 100;
            btn1.Title = "A";
            Digital btn2 = GetInstanceOfPushButton();
            btn2.Title = "B";
            btn2.Location = new Point(x, y); y = 50; x += 200;
            Digital xor = GetInstanceOfXorGate(2);
            xor.Location = new Point(x, y); y += 100;
            Digital and = GetInstanceOfAndGate(2);
            and.Location = new Point(x, y);
            Digital led1 = GetInstanceOfLED(LED.LEDType.Red); y = 50; x += 200;
            xor.Title = "SUM";
            led1.Location = new Point(x, y);
            Digital led2 = GetInstanceOfLED(LED.LEDType.Red); y += 100;
            and.Title = "CARRY";
            led2.Location = new Point(x, y);

            SetPinsToInstance(ref btn1, ref xor, 0);
            SetPinsToInstance(ref btn2, ref xor, 4);
            SetPinsToInstance(ref btn1, ref and, 0);
            SetPinsToInstance(ref btn2, ref and, 4);
            SetPinsToInstance(ref xor, ref led1, 0);
            SetPinsToInstance(ref and, ref led2, 0);
        }

        void SetPinsToInstance(ref Digital dig1, ref Digital dig2, int pinNum)
        {
            dig1.OutputPin.SetDigital(dig2, pinNum);
            dig2.GetAvailablePins[pinNum].ContentOf(dig1, dig1.OutputPin);
            Wire w = new Wire(dig1, dig2, dig2.ContentPanel.CreateGraphics(), pinNum, Properties.Settings.Default.wireSize);
            w.DrawWire();
        }

        private void fullAdderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            FullAdder();
                            break;
                        case DialogResult.No:
                            NewFile();
                            FullAdder();
                            break;
                        default:
                            break;
                    }
                }
                else
                    FullAdder();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void FullAdder()
        {
            int x = 50, y = 50;
            Digital btn1 = GetInstanceOfPushButton();
            btn1.Location = new Point(x, y); y += 100;
            btn1.Title = "A";
            Digital btn2 = GetInstanceOfPushButton();
            btn2.Title = "B";
            btn2.Location = new Point(x, y); y += 100;
            Digital btn3 = GetInstanceOfPushButton();
            btn3.Title = "Cin";
            btn3.Location = new Point(x, y); y = 50; x += 200;
            Digital xor1 = GetInstanceOfXorGate(2);
            xor1.Location = new Point(x, y); y += 100;
            Digital and2 = GetInstanceOfAndGate(2);
            and2.Location = new Point(x, y);
            Digital and1 = GetInstanceOfAndGate(2); y = 50; x += 200; ;
            and1.Location = new Point(x, y);
            Digital xor2 = GetInstanceOfXorGate(2); y += 100;
            xor2.Location = new Point(x, y); y += 100;

            Digital or = GetInstanceOfOrGate(2); y = 50; x += 200;
            or.Location = new Point(x, y);
            Digital led1 = GetInstanceOfLED(LED.LEDType.Red); y = 50; x += 200;
            led1.Location = new Point(x, y);
            Digital led2 = GetInstanceOfLED(LED.LEDType.Red); y += 100;
            led2.Location = new Point(x, y);


            xor2.Title = "SUM";
            or.Title = "CARRY";
            SetPinsToInstance(ref btn1, ref xor1, 0);
            SetPinsToInstance(ref btn2, ref xor1, 4);
            SetPinsToInstance(ref btn1, ref and2, 0);
            SetPinsToInstance(ref btn2, ref and2, 4);
            SetPinsToInstance(ref xor1, ref xor2, 0);
            SetPinsToInstance(ref btn3, ref xor2, 4);
            SetPinsToInstance(ref xor1, ref and1, 0);
            SetPinsToInstance(ref btn3, ref and1, 4);
            SetPinsToInstance(ref and1, ref or, 0);
            SetPinsToInstance(ref and2, ref or, 4);
            SetPinsToInstance(ref xor2, ref led1, 0);
            SetPinsToInstance(ref or, ref led2, 0);
        }

        private void rippleCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            Create3BitsUpCounter();
                            break;
                        case DialogResult.No:
                            NewFile();
                            Create3BitsUpCounter();
                            break;
                        default:
                            break;
                    }
                }
                else
                    Create3BitsUpCounter();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SetPresetAndClear(ref Digital ff)
        {
            ff.SetInputOn(1, true);
            ff.GetAvailablePins[3].SignalFrom = "1";
            ff.SetInputOn(2, true);
            ff.GetAvailablePins[4].SignalFrom = "1";
            ff.SetInputOn(3, true);
            ff.GetAvailablePins[3].SignalFrom = "1";
            ff.SetInputOn(4, true);
            ff.GetAvailablePins[4].SignalFrom = "1";
        }

        void SetPreset(ref Digital ff)
        {
            ff.SetInputOn(1, true);
            ff.GetAvailablePins[3].SignalFrom = "1";
            ff.SetInputOn(2, true);
            ff.GetAvailablePins[4].SignalFrom = "1";
            ff.SetInputOn(3, true);
            ff.GetAvailablePins[4].SignalFrom = "1";
        }

        private void bitsRippleCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            Create4BitsUpCounter();
                            break;
                        case DialogResult.No:
                            NewFile();
                            Create4BitsUpCounter();
                            break;
                        default:
                            break;
                    }
                }
                else
                    Create4BitsUpCounter();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mod10CounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            Create3BitsDownCounter();
                            break;
                        case DialogResult.No:
                            NewFile();
                            Create3BitsDownCounter();
                            break;
                        default:
                            break;
                    }
                }
                else
                    Create3BitsDownCounter();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Create3BitsUpCounter()
        {
            int x = 50, y = 50;
            Digital clk = GetInstanceOfClock();
            clk.Location = new Point(x, y);
            Digital jk1 = GetInstanceOfJK(); x += 200;
            jk1.Location = new Point(x, y);
            SetPinsToInstance(ref clk, ref jk1, 0);
            SetPresetAndClear(ref jk1);
            Digital jk2 = GetInstanceOfJK(); x += 200;
            jk2.Location = new Point(x, y);
            SetPresetAndClear(ref jk2);
            SetPinsToInstance(ref jk1, ref jk2, 0);
            Digital display = GetInstanceOfDisplay(); y += 200;
            display.Location = new Point(x, y);
            Digital jk3 = GetInstanceOfJK(); x += 200; y = 50;
            jk3.Location = new Point(x, y);
            SetPinsToInstance(ref jk2, ref jk3, 0);
            SetPresetAndClear(ref jk3);


            SetPinsToInstance(ref jk1, ref display, 0);
            SetPinsToInstance(ref jk2, ref display, 1);
            SetPinsToInstance(ref jk3, ref display, 3);

        }

        void Create4BitsUpCounter()
        {
            int x = 50, y = 50;
            Digital clk = GetInstanceOfClock();
            clk.Location = new Point(x, y);
            Digital jk1 = GetInstanceOfJK(); x += 200;
            jk1.Location = new Point(x, y);
            SetPresetAndClear(ref jk1);
            SetPinsToInstance(ref clk, ref jk1, 0);
            Digital jk2 = GetInstanceOfJK(); x += 200;
            jk2.Location = new Point(x, y);
            SetPresetAndClear(ref jk2);
            SetPinsToInstance(ref jk1, ref jk2, 0);
            Digital display = GetInstanceOfDisplay(); y += 200;
            display.Location = new Point(x, y);
            Digital jk3 = GetInstanceOfJK(); x += 200; y = 50;
            jk3.Location = new Point(x, y);
            SetPresetAndClear(ref jk3);
            SetPinsToInstance(ref jk2, ref jk3, 0);
            Digital jk4 = GetInstanceOfJK(); x += 200;
            jk4.Location = new Point(x, y);
            SetPresetAndClear(ref jk4);
            SetPinsToInstance(ref jk3, ref jk4, 0);

            SetPinsToInstance(ref jk1, ref display, 0);
            SetPinsToInstance(ref jk2, ref display, 1);
            SetPinsToInstance(ref jk3, ref display, 3);
            SetPinsToInstance(ref jk4, ref display, 4);
        }

        void Create3BitsDownCounter()
        {
            int x = 50, y = 50;
            Digital clk = GetInstanceOfClock();
            clk.Location = new Point(x, y);
            Digital jk1 = GetInstanceOfJK(); x += 200;
            jk1.Location = new Point(x, y);
            SetPresetAndClear(ref jk1);
            SetPinsToInstance(ref clk, ref jk1, 0);
            Digital not1 = GetInstanceOfNotGate(); y += 200;
            not1.Location = new Point(x, y);
            Digital jk2 = GetInstanceOfJK(); x += 200; y = 50;
            jk2.Location = new Point(x, y);
            SetPresetAndClear(ref jk2);
            SetPinsToInstance(ref jk1, ref jk2, 0);
            Digital not2 = GetInstanceOfNotGate(); y += 200;
            not2.Location = new Point(x, y);
            Digital display = GetInstanceOfDisplay(); y += 200;
            display.Location = new Point(x, y);
            Digital jk3 = GetInstanceOfJK(); x += 200; y = 50;
            jk3.Location = new Point(x, y);
            SetPresetAndClear(ref jk3);
            SetPinsToInstance(ref jk2, ref jk3, 0);
            Digital not3 = GetInstanceOfNotGate(); y += 200;
            not3.Location = new Point(x, y);

            SetPinsToInstance(ref jk1, ref not1, 0);
            SetPinsToInstance(ref jk2, ref not2, 0);
            SetPinsToInstance(ref jk3, ref not3, 0);
            SetPinsToInstance(ref not1, ref display, 0);
            SetPinsToInstance(ref not2, ref display, 1);
            SetPinsToInstance(ref not3, ref display, 3);
        }

        void Create3BitsUpDownCounter()
        {
            int x = 50, y = 50;
            Digital clk = GetInstanceOfClock();
            clk.Location = new Point(x, y);
            Digital jk1 = GetInstanceOfJK(); x += 200;
            jk1.Location = new Point(x, y);
            SetPresetAndClear(ref jk1);
            SetPinsToInstance(ref clk, ref jk1, 0);
            Digital xor1 = GetInstanceOfXorGate(2); x += 200;
            xor1.Location = new Point(x, y);
            Digital jk2 = GetInstanceOfJK(); x += 200;
            jk2.Location = new Point(x, y);
            SetPresetAndClear(ref jk2);
            SetPinsToInstance(ref xor1, ref jk2, 0);
            Digital xor2 = GetInstanceOfXorGate(2); x += 200;
            xor2.Location = new Point(x, y);
            Digital display = GetInstanceOfDisplay(); y += 200;
            display.Location = new Point(x, y);
            Digital jk3 = GetInstanceOfJK(); x += 200; y = 50;
            jk3.Location = new Point(x, y);
            SetPresetAndClear(ref jk3);
            SetPinsToInstance(ref xor2, ref jk3, 0);
            Digital pushBtn = GetInstanceOfPushButton();
            pushBtn.Location = new Point(50, y + 200);


            SetPinsToInstance(ref jk1, ref xor1, 0);
            SetPinsToInstance(ref jk2, ref xor2, 0);
            SetPinsToInstance(ref pushBtn, ref xor1, 4);
            SetPinsToInstance(ref pushBtn, ref xor2, 4);
            SetPinsToInstance(ref jk1, ref display, 0);
            SetPinsToInstance(ref jk2, ref display, 1);
            SetPinsToInstance(ref jk3, ref display, 3);
        }

        void Create4BitsDownCounter()
        {
            int x = 50, y = 50;
            Digital clk = GetInstanceOfClock();
            clk.Location = new Point(x, y);
            Digital jk1 = GetInstanceOfJK(); x += 200;
            jk1.Location = new Point(x, y);
            SetPresetAndClear(ref jk1);
            SetPinsToInstance(ref clk, ref jk1, 0);
            Digital not1 = GetInstanceOfNotGate(); y += 200;
            not1.Location = new Point(x, y);
            Digital jk2 = GetInstanceOfJK(); x += 200; y = 50;
            jk2.Location = new Point(x, y);
            SetPresetAndClear(ref jk2);
            SetPinsToInstance(ref jk1, ref jk2, 0);
            Digital not2 = GetInstanceOfNotGate(); y += 200;
            not2.Location = new Point(x, y);
            Digital display = GetInstanceOfDisplay(); y += 200;
            display.Location = new Point(x, y);
            Digital jk3 = GetInstanceOfJK(); x += 200; y = 50;
            jk3.Location = new Point(x, y);
            SetPresetAndClear(ref jk3);
            SetPinsToInstance(ref jk2, ref jk3, 0);
            Digital not3 = GetInstanceOfNotGate(); y += 200;
            not3.Location = new Point(x, y);
            Digital jk4 = GetInstanceOfJK(); x += 200; y = 50;
            jk4.Location = new Point(x, y);
            SetPresetAndClear(ref jk4);
            SetPinsToInstance(ref jk3, ref jk4, 0);
            Digital not4 = GetInstanceOfNotGate(); y += 200;
            not4.Location = new Point(x, y);

            SetPinsToInstance(ref jk1, ref not1, 0);
            SetPinsToInstance(ref jk2, ref not2, 0);
            SetPinsToInstance(ref jk3, ref not3, 0);
            SetPinsToInstance(ref jk4, ref not4, 0);
            SetPinsToInstance(ref not1, ref display, 0);
            SetPinsToInstance(ref not2, ref display, 1);
            SetPinsToInstance(ref not3, ref display, 3);
            SetPinsToInstance(ref not4, ref display, 4);
        }

        private void bitsDownCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            Create4BitsDownCounter();
                            break;
                        case DialogResult.No:
                            NewFile();
                            Create4BitsDownCounter();
                            break;
                        default:
                            break;
                    }
                }
                else
                    Create4BitsDownCounter();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bitsUpAndDownCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentPanel.Controls.Count != 0)
                {
                    string msg = "Do you want to save the file?\nIf you choose NO then your data might be lost.";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (Properties.Settings.Default.mostRecentFile == "")
                                saveAsToolStripMenuItem_Click(sender, e);
                            else
                                saveToolStripMenuItem_Click(sender, e);
                            NewFile();
                            Create3BitsUpDownCounter();
                            break;
                        case DialogResult.No:
                            NewFile();
                            Create3BitsUpDownCounter();
                            break;
                        default:
                            break;
                    }
                }
                else
                    Create3BitsUpDownCounter();
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detailsLabel_TextChanged_1(object sender, EventArgs e)
        {
            msgCount++;
            errorlistView1.msgListView.Items.Add(msgCount.ToString()).SubItems.Add(DateTime.Now.ToLongTimeString());
            errorlistView1.msgListView.Items[errorlistView1.msgListView.Items.Count - 1].SubItems.Add(detailsLabel.Text);
        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Digital temp = Digital.GetDigitalInstantByName(Digital.SelectedInstant);
                int index = listOfControls.IndexOf(temp);
                index = index == listOfControls.Count - 1 ? 0 : index + 1;
                Digital temp2 = (Digital)listOfControls[index];
                temp.BorderStyle = BorderStyle.None;
                Digital.SelectedInstant = temp2.Name;
                temp2.BorderStyle = BorderStyle.FixedSingle;

            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayBtn_Click_1(object sender, EventArgs e)
        {
            colorPickerUIAdv1.Visible = colorPickerUIAdv1.Visible ? false : true;
        }

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            try
            {
                Display d = new Display(contentPanel, configPanel, colorPickerUIAdv1.SelectedColor);
                d.DetailsLabel = detailsLabel;
                contentPanel.Controls.Add(d);
                colorPickerUIAdv1.Visible = false;

            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void outputWindowView1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBool f = new AboutBool();
            f.ShowDialog();
        }

        private void sendYourComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMail a = new SendMail();
            a.ShowDialog();
        }

        void InitalizePropertGrid()
        {
            propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGrid1.Location = new System.Drawing.Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new System.Drawing.Size(177, 137);
            propertyGrid1.TabIndex = 6;
            this.splitContainer1.Panel2.Controls.Add(propertyGrid1);
        }

        private void contentPanel_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void contentPanel_DragDrop(object sender, DragEventArgs e)
        {
            Digital d = e.Data.GetData(e.Data.GetFormats()[0]) as Digital;
            
            if (d != null)
            {
                d.Location = this.contentPanel.PointToClient(new Point(e.X, e.Y));
                this.contentPanel.Controls.Add(d);
            }
        }
    }
}
