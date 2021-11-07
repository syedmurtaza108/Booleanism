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
    /// <summary>C:\Users\SYED MURTAZA\OneDrive\VS\Third Semester\C#\Booleanism\Booleanism\Pin.cs
    /// Gives the features of Digital Pins.
    /// </summary>
    public partial class Pin : UserControl
    {
        private bool signal = false;                //Basic data member which shows the state (on/off) of the pin.
        private String signalFrom = "0";
        private Color on = Color.Blue;              //Default colors of on/off states.
        private Color off = Color.Red;
        private Pin contentOfPin = null;            //Handles if this pin is made as a content pin of another pin. If yes then its state depends on that pin's state.
        private Digital contentOfDig = null;        //Handles the digital's instant, in which this pin will be made as a content.
        private int[] relPins = new int[100];       //Handles the other pins which are related to this pin, which results the change in other pins' states through its state. 100 pins can be related to a single pin.
        public bool isPinContentOfAnother = false;  //It will be true if this pin will be the content of some other.
        Digital[] dig = new Digital[100];           //This instant can have 100 digital's instants to be related.
        static int num = 0;

        //This region has constructors.
        #region

        /// <summary>
        /// Initializes the class with default constructor.
        /// </summary>
        public Pin()
        {
            InitializeComponent();
            this.Name = "Pin" + num.ToString();
            num++;
            for (int i = 0; i < relPins.Length; i++)
                relPins[i] = -1;
        }

        
        #endregion

        //This region has properties.
        #region

        /// <summary>
        /// Gets or sets the state(on/off) of pin.
        /// </summary>
        public bool State { get { return signal; } set { signal = value; statePanel.BackColor = value ? on : off;} }

        /// <summary>
        /// Sets the digital's instant in which this pin will be included.
        /// </summary>
        public void SetDigital(Digital digital, int pinNum)
        {
            if(!IsDuplication(digital, pinNum))
            {
                dig[GetIndexofNullDigital()] = digital;
                State = digital.GetOutput();
                relPins[GetIndexofNullRelativePin()] = pinNum;
            }
        }

        private bool IsDuplication(Digital digital, int pinNum)
        {
            bool ans = false;
            for(int i = 0; i<dig.Length; i++)
            {
                if(dig[i] != null && dig[i] == digital)
                {
                    ans = relPins[i].Equals(pinNum);
                }
            }
            return ans;
        }
        
        /// <summary>
        /// Gets the digital's instant in which this pin included as a content pin. By Default, it's null.
        /// </summary>
        public Digital ContentOfDigital { get { return contentOfDig; } }

        /// <summary>
        /// Gets or sets the name of instant from which the signal is coming.
        /// </summary>
        public String SignalFrom { get {return signalFrom; }
            set {
                signalFrom = value;
            }
        }
        #endregion

        //This region has public methods.
        #region

        /// <summary>
        /// Clears the pin on which this pin depends.
        /// InvalidPinException: Thrown, when this pin doesn't depend on any other pin.
        /// NullDigitalException: Throw, when this pin doesn't depend on any other pin.
        /// </summary>
        public void ClearContentOfPin()
        {
            if (contentOfDig != null)
            {
                if (contentOfPin != null)
                {
                    contentOfPin = null;
                    contentOfDig = null;
                    isPinContentOfAnother = false;
                }
                else
                    throw new InvalidPinException();
            }
            else
                throw new NullDigitalException();
        }
        /// <summary>
        /// Deletes a specified pin from the list of Relative Pins of this pin.
        /// InvalidPinException: Thrown, when the specified pin doesn't avail in the list of relative pins.
        /// </summary>
        /// <param name="pinNum">Zero based index of pin, which is to delete from the list of relative pins.</param>
        public void DeleteARelativePin(Digital dig, int pinNum)
        {
            bool isException = false;
                for(int i = 0; i<this.dig.Length;i++)
                {
                    if (this.dig[i] == dig)
                    {
                        relPins[i] = -1;
                        this.dig[i] = null;
                        isException = false;
                        break;
                    }
                    else
                        isException = true;
                }
                if(isException)
                    throw new InvalidPinException();

        }
            
        

        /// <summary>
        /// Clears the list of Relative Pins.
        /// </summary>
        public void DelateAllRelativePins()
        {
            for (int i = 0; i < relPins.Length; i++)
            {
                relPins[i] = -1;
                this.dig[i] = null;
            }
        }

        /// <summary>
        /// Sets the pin as a content of another specified pin in the specified Digital's instant.
        /// </summary>
        /// <param name="dig">Digital's instant in which the pin is added as a content pin.</param>
        /// <param name="pin">The pin of which this pin will be the content.</param>
        public void ContentOf(Digital dig, Pin pin)
        {
            contentOfDig = dig;
            contentOfPin = pin;
            signalFrom = dig.Name;
            isPinContentOfAnother = contentOfPin == null ? false: true;
        }
        #endregion

        //This region has private methods. umairarif.attari
        #region

        private void statePanel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < relPins.Length; i++)
            {
                if (relPins[i] != -1)
                {
                    dig[i].SetInputOn(relPins[i], State);
                }
            }
        }

        /// <summary>
        /// Used when another pin is added as a relative to this pin.
        /// </summary>
        /// <returns>First index of null object in relPins array.</returns>
        private int GetIndexofNullRelativePin()
        {
            int ans = 0;
            for (int i = 0; i < relPins.Length; i++)
            {
                if (relPins[i] == -1)
                {
                    ans = i;
                    break;
                }
            }
            return ans;
        }

        /// Used when another pin is added as a relative to this pin.
        /// </summary>
        /// <returns>First index of null object in relPins array.</returns>
        private int GetIndexofNullDigital()
        {
            int ans = 0;
            for (int i = 0; i < dig.Length; i++)
            {
                if (dig[i] == null)
                {
                    ans = i;
                    break;
                }
            }
            return ans;
        }

        #endregion
        
    }

}


