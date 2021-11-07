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
    /// Gives the features of XOR gate.
    /// </summary>
    class Xor : Digital
    {
        static int num = 0;         //Counts the number of instants of this class.

        
        #region Constructors
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public Xor()
        {
            this.digImage.Image = Properties.Resources.two_inp_xor_gate;
            num++;
            this.Name = "XOR" + num.ToString();
            nameLabel.Text = this.Name;
            nameLabel.Location = new Point(nameLabel.Location.X + 5, nameLabel.Location.Y);
            SetPins(2);
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        public Xor(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.two_inp_xor_gate, contentPanel, configPanel)
        {
            num++;
            this.Name = "XOR" + num.ToString();
            nameLabel.Text = this.Name;
            nameLabel.Location = new Point(nameLabel.Location.X + 5, nameLabel.Location.Y);
            SetPins(2);
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        /// /// <param name="inputPins">No of input pins in XOR Gate.</param>
        public Xor(Panel contentPanel, Panel configPanel, int inputPins):
            base(Properties.Resources.two_inp_xor_gate, contentPanel, configPanel)
        {
            inputPins = inputPins < 2 || inputPins > 5 ? 2 : inputPins; //To avoid invalid number of pins.
            this.digImage.Image = GetComponentImage(inputPins);
            num++;
            this.Name = "XOR" + num.ToString();
            SetPins(inputPins);
            nameLabel.Text = this.Name;
            nameLabel.Location = new Point(nameLabel.Location.X + 5, nameLabel.Location.Y);
            SetPins(inputPins);
            SetConfiguration();
        }
        #endregion

        
        #region Public

        /// <summary>
        /// Gives the output of XOR gate.
        /// </summary>
        public override bool GetOutput()
        {
            bool result = false;
            for (int i = 0; i < pins.Length; i++)
                if (pins[i] != null)
                {
                    result = result ^ pins[i].State;
                }

            return result;
        }

        /// <summary>
        /// Gets the image of XOR gate with respect to no. of input pins.
        /// </summary>
        /// <param name="inputPins">Number of input pins</param>
        public override Image GetComponentImage(int inputPins)
        {
            Image img = Properties.Resources.two_inp_xor_gate;
            switch (inputPins)
            {
                case 2:
                    img = Properties.Resources.two_inp_xor_gate;
                    break;
                case 3:
                    img = Properties.Resources.three_inp_xor_gate;
                    break;
                case 4:
                    img = Properties.Resources.four_inp_xor_gate;
                    break;
                case 5:
                    img = Properties.Resources.five_inp_xor_gate;
                    break;
                default:
                    break;
            }
            return img;
        }

        public override string ToString()
        {
            return this.Name + ": It gives the high output if odd number of inputs are high.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }

        #endregion

    }
}
