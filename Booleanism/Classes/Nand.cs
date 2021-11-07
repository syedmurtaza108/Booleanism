/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
March 27, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of NAND Gate.
    /// </summary>
    class Nand : Digital
    {
        static int num = 0;         //Counts the number of instants of this class.

        //This region has constructors.
        #region
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public Nand()
        {
            this.digImage.Image = Properties.Resources.two_inp_nand_gate;
            num++;
            this.Name = "NAND" + num.ToString();
            nameLabel.Text = this.Name;
            SetPins(2);
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        public Nand(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.two_inp_nand_gate, contentPanel, configPanel)
        {
            num++;
            this.Name = "NAND" + num.ToString();
            nameLabel.Text = this.Name;
            SetPins(2);
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        /// /// <param name="inputPins">No of input pins in NAND Gate.</param>
        public Nand(Panel contentPanel, Panel configPanel, int inputPins):
            base(Properties.Resources.two_inputs_and_gate, contentPanel, configPanel)
        {
            inputPins = inputPins < 2 || inputPins > 5 ? 2 : inputPins; //To avoid invalid number of pins.
            this.digImage.Image = GetComponentImage(inputPins);
            num++;
            this.Name = "NAND" + num.ToString();
            SetPins(inputPins);
            SetConfiguration();
            nameLabel.Text = this.Name;
        }
        #endregion

        //This region has public methods.
        #region

        /// <summary>
        /// Gives the output of Nand Gate.
        /// </summary>
        public override bool GetOutput()
        {
            bool result = true;
            for (int i = 0; i < pins.Length; i++)
                if (pins[i] != null)
                {
                    result = result && pins[i].State;
                }

            return !result;
        }

        /// <summary>
        /// Gets the image of NAND gate with respect to number of input pins.
        /// </summary>
        /// <param name="inputPins">Number of input pins.</param>
        public override Image GetComponentImage(int inputPins)
        {
            Image img = Properties.Resources.two_inputs_and_gate;
            switch (inputPins)
            {
                case 2:
                    img = Properties.Resources.two_inp_nand_gate;
                    break;
                case 3:
                    img = Properties.Resources.three_inp_nand_gate;
                    break;
                case 4:
                    img = Properties.Resources.four_inp_nand_gate;
                    break;
                case 5:
                    img = Properties.Resources.five_inp_nand_gate1;
                    break;
                default:
                    break;
            }
            return img;
        }

        public override string ToString()
        {
            return this.Name + ": It gives the high output if at least one input is low.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }

        #endregion

    }
}
