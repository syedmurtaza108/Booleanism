/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
March 31, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of NOT gate.
    /// </summary>
    class Not:Digital
    {

        static int num = 0;         //Counts the number of instants of this class.

        //This region has constructors.
        #region
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public Not()
        {
            this.digImage.Image = Properties.Resources.not_gate;
            num++;
            this.Name = "NOT" + num.ToString();
            nameLabel.Text = this.Name;
            pins[0].Location = new Point(0, outputPin.Location.Y);
            SetConfiguration();
            SetGateNameLabel();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        public Not(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.not_gate, contentPanel, configPanel)
        {
            num++;
            this.Name = "NOT" + num.ToString();
            pins[0].Location = new Point(0, outputPin.Location.Y);
            SetGateNameLabel();
            SetConfiguration();
        }

        #endregion

        //This region has public methods.
        #region

        /// <summary>
        /// Gives the output of NOT gate.
        /// </summary>
        public override bool GetOutput()
        {
            return !pins[0].State;
        }

        public override void SetConfiguration()
        {
            configPanel.Controls.Clear();
            nameConfig = new Configuration("TextBox", this);
            nameConfig.SetupTextBox("Name:", this.Name);
            configPanel.Controls.Add(nameConfig);
            Configuration inputConfig = new Configuration("ComboBox", this);
            inputConfig.SetAction = Configuration.ComboBoxActions.InputsSetup;
            inputConfig.SetupComboBox("Input1:", GetStringOfInput());
            inputConfig.SetInputIndexesOfComboBox(pins[0].SignalFrom);
            inputConfig.Location = new System.Drawing.Point(inputConfig.Location.X, inputConfig.Height);
            configPanel.Controls.Add(inputConfig);
        }
        #endregion

        private void SetGateNameLabel()
        {
            nameLabel.Text = this.Name;
            nameLabel.Location = new Point(nameLabel.Location.X + 3, nameLabel.Location.Y + 1);
            nameLabel.Font = new Font("Microsoft Sans Serif", 5.75f);
        }

        public override Image GetComponentImage(int inputPins)
        {
            return Properties.Resources.not_gate;
        }

        public override string ToString()
        {
            return this.Name + ": It gives the inverse of input.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }

        private void InitializeComponent()
        {
            this.configPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).BeginInit();
            this.pinsPanel.SuspendLayout();
            this.SuspendLayout();
            this.configPanel.Controls.SetChildIndex(this.activeInpConfig, 0);
            this.configPanel.Controls.SetChildIndex(this.nameConfig, 0);
            // 
            // digImage
            // 
            this.digImage.Image = global::Booleanism.Properties.Resources.not_gate;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.nameLabel.Location = new System.Drawing.Point(46, 34);
            // 
            // pin1
            // 
            this.pin1.Location = new System.Drawing.Point(0, 39);
            // 
            // Not
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ComponentImage = global::Booleanism.Properties.Resources.not_gate;
            this.Name = "Not";
            this.Controls.SetChildIndex(this.digImage, 0);
            this.Controls.SetChildIndex(this.pinsPanel, 0);
            this.Controls.SetChildIndex(this.outputPin, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.configPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).EndInit();
            this.pinsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
