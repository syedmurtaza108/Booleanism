/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by Syed Murtaza as a project of OOP Subject on
March 27, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of And Gate.
    /// </summary>
    class And : Digital
    {
        static int num = 0;         //Counts the number of instants of this class.

        #region Constructors
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public And()
        {
            this.digImage.Image = Properties.Resources.two_inputs_and_gate;
            num++;
            this.Name = "AND" + num.ToString();
            nameLabel.Text = this.Name;
            SetPins(2);             //By default And Gate with 2 input pins initialized
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        public And(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.two_inputs_and_gate, contentPanel, configPanel)
        {
            num++;
            this.Name = "AND" + num.ToString();
            nameLabel.Text = this.Name;
            SetPins(2);
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        /// /// <param name="inputPins">No of input pins in And Gate.</param>
        public And(Panel contentPanel, Panel configPanel, int inputPins):
                base(Properties.Resources.two_inputs_and_gate, contentPanel, configPanel)
        {
            inputPins = inputPins < 2 || inputPins > 5 ? 2 : inputPins; //To avoid invalid number of pins.
            this.digImage.Image = GetComponentImage(inputPins);
            num++;
            this.Name = "AND" + num.ToString();
            SetPins(inputPins);
            nameLabel.Text = this.Name;
            SetConfiguration();
        }
        #endregion


        #region Public

        public override void RestartCounting()
        {
            num = 0;
        }

        /// <summary>
        /// Gives the output of And Gate.
        /// </summary>
        public override bool GetOutput()
        {
            bool result = true;
            for (int i = 0; i < pins.Length; i++)
                if (pins[i] != null)
                {
                    result = result && pins[i].State;
                }

            return result;
        }

        /// <summary>
        /// Gets the image of And Gate with respect to input pins.
        /// </summary>
        /// <param name="inputPins">No. of input pins.</param>
        public override Image GetComponentImage(int inputPins)
        {
            Image img = Properties.Resources.two_inputs_and_gate;
            switch(inputPins)
            {
                case 2:
                    img = Properties.Resources.two_inputs_and_gate;
                    break;
                case 3:
                    img = Properties.Resources.three_inp_and_gate;
                    break;
                case 4:
                    img = Properties.Resources.four_inp_and_gate;
                    break;
                case 5:
                    img = Properties.Resources.five_inp_and_gate;
                    break;
                default:
                    break;
            }
            return img;
        }

        /// <summary>
        /// Gets the details about this instant.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name + ": It gives the high output if all the inputs are high.";
        }
        #endregion

        

    }
}
