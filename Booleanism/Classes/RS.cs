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
    /// Gives the features of RS Flip Flop.
    /// </summary>
    sealed class RS : FlipFlop
    {
        static int num = 0;

        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public RS()
        {
            num++;
            this.Name = "RS" + num.ToString();
            nameLabel.Text = this.Name;
            SetType = FlipFlopType.RS;
            ComponentImage = Properties.Resources.rs_flipflop;

        }

        /// <summary>
        /// Initializes the class with specified panels.
        /// </summary>
        /// <param name="contentPanel">In which the component will be added.</param>
        /// <param name="configPanel">In which the properties of component will be added.</param>
        public RS(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.rs_flipflop ,contentPanel, configPanel, FlipFlopType.RS)
        {
            num++;
            this.Name = "RS" + num.ToString();
            nameLabel.Text = this.Name;
        }

        protected override bool FlipFlopOutput()
        {
            bool result = outputPin.State;
            if (pins[1].State && !pins[2].State)
                result = false;
            else if (!pins[1].State && pins[2].State)
                result = true;
            return result;
        }

        public override Image GetComponentImage(int inputPins)
        {
            return Properties.Resources.rs_flipflop;
        }

        public override string ToString()
        {
            return this.Name + ": It gives the high output if R  is low , S is high and clock signal arrives.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }
    }
}
