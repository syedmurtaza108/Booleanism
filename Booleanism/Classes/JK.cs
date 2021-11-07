/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
April 02, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of JK Flip Flop.
    /// </summary>
    sealed class JK : FlipFlop
    {
        static int num = 0;

        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public JK()
        {
            num++;
            this.Name = "JK" + num.ToString();
            nameLabel.Text = this.Name;
            SetType = FlipFlopType.JK;
            ComponentImage = Properties.Resources.rs_flipflop;

        }

        /// <summary>
        /// Initializes the class with specified panels.
        /// </summary>
        /// <param name="contentPanel">In which the component will be added.</param>
        /// <param name="configPanel">In which the properties of component will be added.</param>
        public JK(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.rs_flipflop ,contentPanel, configPanel, FlipFlopType.JK)
        {
            num++;
            this.Name = "JK" + num.ToString();
            nameLabel.Text = this.Name;
        }

        protected override bool FlipFlopOutput()
        {
            bool result = outputPin.State;
            if (pins[1].State && !pins[2].State)
                result = true;
            else if (!pins[1].State && pins[2].State)
                result = false;
            else if (pins[1].State && pins[2].State)
                result = !outputPin.State;
            return result;
        }

        public override Image GetComponentImage(int inputPins)
        {
            return Properties.Resources.rs_flipflop;
        }

        public override string ToString()
        {
            return this.Name + ": It gives the high output if J is high, K is low and clock signal arrived.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }
    }
}
