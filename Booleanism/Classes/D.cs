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
    /// Gives the features of D Flip Flop.
    /// </summary>
    sealed class D : FlipFlop
    {
        static int num = 0;

        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public D()
        {
            num++;
            this.Name = "DF" + num.ToString();
            nameLabel.Text = this.Name;
            SetType = FlipFlopType.D;
            ComponentImage = Properties.Resources.d_flipflop;
        }

        /// <summary>
        /// Initializes the class with specified panels.
        /// </summary>
        /// <param name="contentPanel">In which the component will be added.</param>
        /// <param name="configPanel">In which the properties of component will be added.</param>
        public D(Panel contentPanel, Panel configPanel):
            base(contentPanel, configPanel, FlipFlopType.D)
        {
            num++;
            this.Name = "DF" + num.ToString();
            nameLabel.Text = this.Name;
        }

        protected override bool FlipFlopOutput()
        {
            return pins[1].State;
        }

        public override Image GetComponentImage(int inputPins)
        {
            return Properties.Resources.d_flipflop;
        }

        public override string ToString()
        {
            return this.Name + ": It gives the same output as input when a clock signal arrived.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }
    }
}
