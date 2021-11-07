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
    /// Gives the features of NOR gate.
    /// </summary>
    class Nor : Digital
    {
        static int num = 0;         //Counts the number of instants of this class.

        //This region has constructors.
        #region
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public Nor()
        {
            this.digImage.Image = Properties.Resources.two_inp_nor_gate;
            num++;
            this.Name = "NOR" + num.ToString();
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
        public Nor(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.two_inp_nor_gate, contentPanel, configPanel)
        {
            num++;
            this.Name = "NOR" + num.ToString();
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
        /// /// <param name="inputPins">No of input pins in NOR Gate.</param>
        public Nor(Panel contentPanel, Panel configPanel, int inputPins):
            base(Properties.Resources.two_inp_nor_gate, contentPanel, configPanel)
        {
            inputPins = inputPins < 2 || inputPins > 5 ? 2 : inputPins; //To avoid invalid number of pins.
            this.digImage.Image = GetComponentImage(inputPins);
            num++;
            this.Name = "NOR" + num.ToString();
            SetPins(inputPins);
            nameLabel.Text = this.Name;
            nameLabel.Location = new Point(nameLabel.Location.X + 5, nameLabel.Location.Y);
            SetConfiguration();
        }
        #endregion

        //This region has public methods.
        #region

        /// <summary>
        /// Gets the output of NOR gate.
        /// </summary>
        public override bool GetOutput()
        {
            bool result = false;
            for (int i = 0; i < pins.Length; i++)
                if (pins[i] != null)
                {
                    result = result || pins[i].State;
                }

            return !result;
        }

        /// <summary>
        /// Gets the image of NOR gate with respect to number of input pins.
        /// </summary>
        /// <param name="inputPins">Number of input pins.</param>
        public override Image GetComponentImage(int inputPins)
        {
            Image img = Properties.Resources.two_inp_nor_gate;
            switch (inputPins)
            {
                case 2:
                    img = Properties.Resources.two_inp_nor_gate;
                    break;
                case 3:
                    img = Properties.Resources.three_inp_nor_gate;
                    break;
                case 4:
                    img = Properties.Resources.four_inp_nor_gate;
                    break;
                case 5:
                    img = Properties.Resources.five_inp_nor_gate;
                    break;
                default:
                    break;
            }
            return img;
        }

        public override string ToString()
        {
            return this.Name + ": It gives the high output if all the inputs are low.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }

        #endregion

    }
}
