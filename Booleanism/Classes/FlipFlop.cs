/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
April 01, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Booleanism
{
    //Gives the basic features of a Flip Flop.
    public abstract class FlipFlop : Digital
    {
        
        #region Data members
        private Pin secOutputPin;               //Output which is always the inverse of primary output.
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label input1Label;
        private Label input2Label;
        private FlipFlopType type = FlipFlopType.RS;
        private bool preOutput = false;
        #endregion

        public enum FlipFlopType
        {
            D = 0, RS = 1, JK = 2
        }

        
        #region Constructors
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public FlipFlop()
        {
            InitializeComponent();
            SetFlipFlopType(type);                  //By default, A RS type of FLIP FLIP initialized
            nameLabel.Location = new Point(61, 21); //Relocate the label of component's name.
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        public FlipFlop(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.rs_flipflop, contentPanel, configPanel)
        {
            InitializeComponent();
            SetFlipFlopType(type);
            nameLabel.Location = new Point(61, 21);
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        /// <param name="type">Type of Flip Flop</param>
        public FlipFlop(Panel contentPanel, Panel configPanel, FlipFlopType type):
            base(Properties.Resources.rs_flipflop, contentPanel, configPanel)
        {
            InitializeComponent();
            this.type = type;
            SetFlipFlopType(type);
            nameLabel.Location = new Point(61, 21);
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="flipFlopImage">Image of Flip Flop.</param>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        /// <param name="type">Type of Flip Flop</param>
        public FlipFlop(Image flipFlopImage, Panel contentPanel, Panel configPanel, FlipFlopType type) :
            base(flipFlopImage, contentPanel, configPanel)
        {
            InitializeComponent();
            this.type = type;
            SetFlipFlopType(type);
            nameLabel.Location = new Point(61, 21);
        }
        #endregion

        
        #region Properties
        /// <summary>
        /// Sets the type of Flip Flop.
        /// </summary>
        public FlipFlopType SetType { set {type = value; SetFlipFlopType(value); } }
        #endregion

        #region Protected methods
        /// <summary>
        /// Gives the output of a specified Flip Flop.
        /// </summary>
        protected virtual bool FlipFlopOutput()
        {
            return false;
        }

        #endregion


        #region Public methods

        public override Image GetComponentImage(int inputPins)
        {
            return null;
        }

        //Gives the basic output of a Flip Flop.
        public override bool GetOutput()
        {
            bool result = false;
            if(pins[1] != null)
            {
                if (pins[3].State && !pins[4].State)
                {
                    result = false;
                }
                else if (!pins[3].State && pins[4].State)
                {
                    result = true;
                }
                else if (pins[3].State && pins[4].State)
                {
                    if (pins[0].State)
                        result = preOutput;
                    else
                    {
                        result = FlipFlopOutput();
                    }
                }
                preOutput = result;
            }
            if(secOutputPin != null)        //Q bar
                secOutputPin.State = !result;
            return result;
        }
        
        /// <summary>
        /// Sets the configuration of a Flip Flop.
        /// </summary>
        public override void SetConfiguration()
        {
            configPanel.Controls.Clear();
            AssignAllInputPins();
            nameConfig = new Configuration("TextBox", this);
            nameConfig.SetupTextBox("Name:", this.Name);
            configPanel.Controls.Add(nameConfig);
            SetInputConfig("CLK:  ", GetStringOfInput(),  0);
            SetInputPinsConfig();
            SetInputConfig("PRE:  ", GetStringOfInput(), 3);
            SetInputConfig("CLR:  ", GetStringOfInput(), 4);
        }
        #endregion

        
        #region Private methods
        private void SetFlipFlopType(FlipFlopType type)
        {
            if (type == FlipFlopType.D)
            {
                SetPins(4);
                input1Label.Text = "D";
                input2Label.Visible = false;
                ComponentImage = Properties.Resources.d_flipflop;
            }
            else if(type == FlipFlopType.JK)
            {
                SetPins(5);
                input1Label.Text = "J";
                input2Label.Text = "K";
                input2Label.Visible = true;
                ComponentImage = Properties.Resources.rs_flipflop;
            }
            else
            {
                SetPins(5);
                input1Label.Text = "R";
                input2Label.Text = "S";
                input2Label.Visible = true;
                ComponentImage = Properties.Resources.rs_flipflop;
            }
                
        }

        //Sets the configuration of input pin e.g. R pin or D pin.
        private void SetInputConfig(String title, System.Collections.Specialized.StringCollection values, int pinNum)
        {
            
            Configuration inputConfig = new Configuration("ComboBox", this);
            inputConfig.SetAction = Configuration.ComboBoxActions.InputsSetup;
            inputConfig.SetupComboBox(title, values);
            inputConfig.SetInputIndexesOfComboBox(pins[pinNum].SignalFrom);
            if (type == FlipFlopType.D && pinNum > 2)                           //To resolve the location issue in case of D Flip Flop, since it doesn't have its companion input so 
                inputConfig.Location = new Point(inputConfig.Location.X, inputConfig.Height + inputConfig.Height * (pinNum-1));
            else
                inputConfig.Location = new Point(inputConfig.Location.X, inputConfig.Height + inputConfig.Height * pinNum);
            configPanel.Controls.Add(inputConfig);
        }

        private void AssignAllInputPins()
        {
            pins[1] = pin2;
            pins[2] = pin3;
            pins[3] = pin4;
            pins[4] = pin5;
        }

        //Called by SetConfiguration method.
        private void SetInputPinsConfig()
        {
            if (type == FlipFlopType.RS)
            {
                SetInputConfig("R:      ", GetStringOfInput(), 1);
                SetInputConfig("S:      ", GetStringOfInput(), 2);
            }
            else if (type == FlipFlopType.JK)
            {
                SetInputConfig("J:      ", GetStringOfInput(), 1);
                SetInputConfig("K:      ", GetStringOfInput(), 2);
            }
            else
            {
                SetInputConfig("D:      ", GetStringOfInput(), 1);
            }
        }
        #endregion

        
        #region Event methods

        private void FlipFlop_Load(object sender, EventArgs e)
        {
            SetConfiguration();
        }
        #endregion

        
        #region Auto generated code
        private void InitializeComponent()
        {
            this.secOutputPin = new Booleanism.Pin();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input1Label = new System.Windows.Forms.Label();
            this.input2Label = new System.Windows.Forms.Label();
            this.configPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).BeginInit();
            this.SuspendLayout();
            //this.configPanel.Controls.SetChildIndex(this.activeInpConfig, 0);
            //this.configPanel.Controls.SetChildIndex(this.nameConfig, 0);
            //// 
            // digImage
            // 
            this.digImage.Image = global::Booleanism.Properties.Resources.rs_flipflop;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(61, 21);
            // 
            // secOutputPin
            // 
            this.secOutputPin.BackColor = System.Drawing.Color.White;
            this.secOutputPin.Location = new System.Drawing.Point(145, 67);
            this.secOutputPin.Name = "secOutputPin";
            this.secOutputPin.Size = new System.Drawing.Size(5, 5);
            this.secOutputPin.State = true;
            this.secOutputPin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(91, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(91, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(94, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 4);
            this.label3.TabIndex = 8;
            this.label3.Text = "___";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(46, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CLK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(46, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(46, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CLR";
            // 
            // input1Label
            // 
            this.input1Label.AutoSize = true;
            this.input1Label.BackColor = System.Drawing.Color.Transparent;
            this.input1Label.ForeColor = System.Drawing.Color.Red;
            this.input1Label.Location = new System.Drawing.Point(46, 23);
            this.input1Label.Name = "input1Label";
            this.input1Label.Size = new System.Drawing.Size(15, 13);
            this.input1Label.TabIndex = 12;
            this.input1Label.Text = "R";
            // 
            // input2Label
            // 
            this.input2Label.AutoSize = true;
            this.input2Label.BackColor = System.Drawing.Color.Transparent;
            this.input2Label.ForeColor = System.Drawing.Color.Red;
            this.input2Label.Location = new System.Drawing.Point(46, 36);
            this.input2Label.Name = "input2Label";
            this.input2Label.Size = new System.Drawing.Size(14, 13);
            this.input2Label.TabIndex = 13;
            this.input2Label.Text = "S";
            // 
            // FlipFlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ComponentImage = global::Booleanism.Properties.Resources.rs_flipflop;
            this.Controls.Add(this.input2Label);
            this.Controls.Add(this.input1Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secOutputPin);
            this.Name = "FlipFlop";
            this.Load += new System.EventHandler(this.FlipFlop_Load);
            this.Controls.SetChildIndex(this.digImage, 0);
            this.Controls.SetChildIndex(this.pinsPanel, 0);
            this.Controls.SetChildIndex(this.outputPin, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.secOutputPin, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.input1Label, 0);
            this.Controls.SetChildIndex(this.input2Label, 0);
            this.configPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    }
}
