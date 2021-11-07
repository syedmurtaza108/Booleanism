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
    public partial class ToolboxForm : Form
    {
        Form1 preForm;
        public ToolboxForm()
        {
            InitializeComponent();
            preForm = new Form1();
        }

        public ToolboxForm(Form1 PreForm)
        {
            InitializeComponent();
            preForm = PreForm;
        }

        public Panel ToolboxOuter { get { return toolBoxOuter; } }

        public Panel Toolbox { get { return toolBox; } }

        public Panel HeadingPanel { get {return gatesLabelPanel; } }

        private void pinToolboxBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            preForm.Toolbox.Visible = true;
        }

        #region Gates initialization methods
        private void InitializeAndGate(int inputPins)
        {
            try
            {
                And and = new And(preForm.ContentPanel, Properties.Settings.Default.configPanel, inputPins);
                and.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(and);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeOrGate(int inputPins)
        {
            try
            {
                Or and = new Or(preForm.ContentPanel, Properties.Settings.Default.configPanel, inputPins);
                and.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(and);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeXorGate(int inputPins)
        {
            try
            {
                Xor xor = new Xor(preForm.ContentPanel, Properties.Settings.Default.configPanel, inputPins);
                xor.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(xor);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeNorGate(int inputPins)
        {
            try
            {
                Nor nor = new Nor(preForm.ContentPanel, Properties.Settings.Default.configPanel, inputPins);
                nor.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(nor);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeNandGate(int inputPins)
        {
            try
            {
                Nand nand = new Nand(preForm.ContentPanel, Properties.Settings.Default.configPanel, inputPins);
                nand.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(nand);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region ToolBox buttons methods
        private void andGatePicBox_Click(object sender, EventArgs e)
        {
            switch (andGateLabel.Text)
            {
                case "3 Inputs":
                    InitializeAndGate(3);
                    break;
                case "4 Inputs":
                    InitializeAndGate(4);
                    break;
                case "5 Inputs":
                    InitializeAndGate(5);
                    break;
                default:
                    InitializeAndGate(2);
                    break;
            }
        }

        private void orGatePicBox_Click(object sender, EventArgs e)
        {
            switch (orGateLabel.Text)
            {
                case "3 Inputs":
                    InitializeOrGate(3);
                    break;
                case "4 Inputs":
                    InitializeOrGate(4);
                    break;
                case "5 Inputs":
                    InitializeOrGate(5);
                    break;
                default:
                    InitializeOrGate(2);
                    break;
            }
        }

        private void xorGatePicBox_Click(object sender, EventArgs e)
        {
            switch (xorGateLabel.Text)
            {
                case "3 Inputs":
                    InitializeXorGate(3);
                    break;
                case "4 Inputs":
                    InitializeXorGate(4);
                    break;
                case "5 Inputs":
                    InitializeXorGate(5);
                    break;
                default:
                    InitializeXorGate(2);
                    break;
            }
        }

        private void nandGatePicBox_Click(object sender, EventArgs e)
        {
            switch (nandGateLabel.Text)
            {
                case "3 Inputs":
                    InitializeNandGate(3);
                    break;
                case "4 Inputs":
                    InitializeNandGate(4);
                    break;
                case "5 Inputs":
                    InitializeNandGate(5);
                    break;
                default:
                    InitializeNandGate(2);
                    break;
            }
        }

        private void norGatePicBox_Click(object sender, EventArgs e)
        {
            switch (norGateLabel.Text)
            {
                case "3 Inputs":
                    InitializeNorGate(3);
                    break;
                case "4 Inputs":
                    InitializeNorGate(4);
                    break;
                case "5 Inputs":
                    InitializeNorGate(5);
                    break;
                default:
                    InitializeNorGate(2);
                    break;
            }
        }

        private void notGatePicBox_Click(object sender, EventArgs e)
        {

        }

        private void rsFlipFlopPicBox_Click(object sender, EventArgs e)
        {
            try
            {
                RS rs = new RS(preForm.ContentPanel, Properties.Settings.Default.configPanel);
                rs.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(rs);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void jkFlipFlopPicBox_Click(object sender, EventArgs e)
        {
            try
            {
                JK jk = new JK(preForm.ContentPanel, Properties.Settings.Default.configPanel);
                jk.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(jk);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dFlipFlopPicBox_Click(object sender, EventArgs e)
        {
            try
            {
                D d = new D(preForm.ContentPanel, Properties.Settings.Default.configPanel);
                d.DetailsLabel = preForm.DetailsLabel;
                preForm.ContentPanel.Controls.Add(d);
            }
            catch (InvalidPinException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDigitalException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidControlException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred!!", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Led Methods

        private void ledButton_Click(object sender, EventArgs e)
        {
            LED led = new LED(preForm.ContentPanel, Properties.Settings.Default.configPanel);
            led.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(led);
        }

        private void greenLedPicBox_Click(object sender, EventArgs e)
        {
            LED greenLed = new LED(LED.LEDType.Green, preForm.ContentPanel, Properties.Settings.Default.configPanel);
            greenLed.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(greenLed);
        }


        private void redLedPicBox_Click(object sender, EventArgs e)
        {
            LED redLed = new LED(LED.LEDType.Red, preForm.ContentPanel, Properties.Settings.Default.configPanel);
            redLed.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(redLed);
        }

        private void purpleLedPicBox_Click(object sender, EventArgs e)
        {
            LED purpleLed = new LED(LED.LEDType.Purple, preForm.ContentPanel, Properties.Settings.Default.configPanel);
            purpleLed.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(purpleLed);
        }

        private void yellowLedPicBox_Click(object sender, EventArgs e)
        {
            LED yellowLed = new LED(LED.LEDType.Yellow, preForm.ContentPanel, Properties.Settings.Default.configPanel);
            yellowLed.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(yellowLed);
        }

        private void whiteLedPicBox_Click(object sender, EventArgs e)
        {
            LED whiteLed = new LED(LED.LEDType.White, preForm.ContentPanel, Properties.Settings.Default.configPanel);
            whiteLed.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(whiteLed);
        }

        #endregion

        private void pushBtnPicBox_Click(object sender, EventArgs e)
        {
            PushButton btn = new PushButton(preForm.ContentPanel);
            btn.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(btn);
        }

        private void clockPicBox_Click(object sender, EventArgs e)
        {
            Clock_Signal signal = new Clock_Signal(preForm.ContentPanel);
            signal.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(signal);
        }

        private void gatesLabelPanel_BackColorChanged(object sender, EventArgs e)
        {
            panel2.BackColor = gatesLabelPanel.BackColor;
            panel3.BackColor = gatesLabelPanel.BackColor;
            panel4.BackColor = gatesLabelPanel.BackColor;
        }

        private void ToolboxForm_Resize(object sender, EventArgs e)
        {
            if (this.Width > 214)
                this.Size = new Size(214, this.Height);
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            Display d = new Display(preForm.ContentPanel, preForm.ConfigPanel);
            d.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(d);
        }

        private void greenDisplayMenuItem_Click(object sender, EventArgs e)
        {
            Display d = new Display(preForm.ContentPanel, preForm.ConfigPanel, Color.LimeGreen);
            d.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(d);
        }

        private void blueDisplayMenuItem_Click(object sender, EventArgs e)
        {
            Display d = new Display(preForm.ContentPanel, preForm.ConfigPanel, Color.Blue);
            d.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(d);
        }

        private void yellowDisplayMenuItem_Click(object sender, EventArgs e)
        {
            Display d = new Display(preForm.ContentPanel, preForm.ConfigPanel, Color.Gold);
            d.DetailsLabel = preForm.DetailsLabel;
            preForm.ContentPanel.Controls.Add(d);
        }
    }
}
