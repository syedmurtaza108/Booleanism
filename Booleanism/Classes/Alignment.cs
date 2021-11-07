    /*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
April 09, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Drawing;
using System.Collections;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of alignment for Digital components.
    /// </summary>
    public sealed class Alignment
    {
        private ArrayList compList;  //Components to align

        public enum AlignmentType
        {
            Vertically = 0, Horizontally = 1, Justify = 2
        }

        /// <summary>
        /// Initializes the class with no arguments.
        /// </summary>
        public Alignment()
        {
            compList = new ArrayList();
        }

        /// <summary>
        /// Initializes the class with specified list.
        /// </summary>
        /// <param name="listOfComponents">List of components which is to align.</param>
        public Alignment(ArrayList listOfComponents)
        {
            compList = listOfComponents;
        }

        /// <summary>
        /// Initializes the class with specified Digital array.
        /// </summary>
        /// <param name="listOfComponents">Array of components which is to align.</param>
        public Alignment(Digital[] listOfComponents)
        {
            for(int i = 0; i<listOfComponents.Length; i++)
            {
                compList.Add(listOfComponents[i]);
            }
        }

        /// <summary>
        /// Sets the list of Digital components which will be aligned.
        /// </summary>
        public ArrayList SetComponentsList{ set { compList = value; } }

        /// <summary>
        /// Align the controls with specific type.
        /// </summary>
        /// <param name="type">Alignment's type which will be performed.</param>
        public void Align(AlignmentType type)
        {
            ArrayList buttons = SeparatePushButton();
            ArrayList gates = SeparateGates();
            ArrayList flipFlops = SeparateFlipFlops();
            ArrayList leds = SeparateLeds();

            switch(type)
            {
                case AlignmentType.Vertically:
                    AlignVertically(buttons, gates, leds, flipFlops);
                    break;
                case AlignmentType.Horizontally:
                    AlignHorizontally(buttons, gates, leds, flipFlops);
                    break;
                case AlignmentType.Justify:
                    AlignJustified();
                    break;
                default:
                    break;
            }
            
        }

        #region Private
        private void AlignVertically( ArrayList buttons, ArrayList gates, ArrayList leds, ArrayList flipFlops)
        {
            int x = 0, y = 0, temp = 0;

            foreach (Digital btn in buttons)
            {
                btn.Location = new Point(x , y * temp++);
                y = 100;
            }

            x = 200; y = 0; temp = 0;

            foreach (Digital gate in gates)
            {
                gate.Location = new Point(x, y * temp++);
                y = 100;
            }

            y = 0; temp = 0; x = 200 * 2;

            foreach (FlipFlop ff in flipFlops)
            {
                ff.Location = new Point(x, y * temp++);
                y = 100;
            }

            x = 200 * 3; temp = 0; y = 0;

            foreach (LED led in leds)
            {
                led.Location = new Point(x, y * temp++);
                y = 100;
            }
        }

        private void AlignHorizontally(ArrayList buttons, ArrayList gates, ArrayList leds, ArrayList flipFlops)
        {
            int x = 0, y = 0, temp = 0;

            foreach (Digital btn in buttons)
            {
                btn.Location = new Point(x * temp++, y);
                x = 200;
            }

            x = 0; y = 100; temp = 0;

            foreach (Digital gate in gates)
            {
                gate.Location = new Point(x * temp++, y);
                x = 200;
            }

            y = 100 * 2; temp = 0; x = 0;

            foreach (FlipFlop ff in flipFlops)
            {
                ff.Location = new Point(x * temp++, y);
                x = 200;
            }

            y = 100 * 3; temp = 0; x = 0;

            foreach (LED led in leds)
            {
                led.Location = new Point(x * temp++, y);
                x = 200;
            }
        }

        private void AlignJustified()
        {
            int x = 0, y = 0, temp = 0;

            foreach (Digital dig in compList)
            {
                if(temp % 5 == 0 && temp != 0)
                {
                    y += 100;
                    temp = 0;
                }
                dig.Location = new Point(x * temp++, y);
                x = 200;
            }
        }

        private ArrayList SeparatePushButton()
        {
            ArrayList buttons = new ArrayList();
            foreach(Digital dig in compList)
            {
                if(dig is PushButton || dig is Clock_Signal)
                    buttons.Add(dig);
            }
            return buttons;
        }

        private ArrayList SeparateLeds()
        {
            ArrayList leds = new ArrayList();
            foreach (Digital dig in compList)
            {
                if (dig is LED)
                    leds.Add(dig);
            }
            return leds;
        }

        private ArrayList SeparateGates()
        {
            ArrayList gates = new ArrayList();
            foreach (Digital dig in compList)
            {
                if (dig.Name.Contains("Gate"))
                    gates.Add(dig);
            }
            return gates;
        }

        private ArrayList SeparateFlipFlops()
        {
            ArrayList ffs = new ArrayList();
            foreach (Digital dig in compList)
            {
                if (dig is FlipFlop)
                    ffs.Add(dig);
            }
            return ffs;
        }

        #endregion
    }
}
