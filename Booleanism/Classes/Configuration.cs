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
    /// Gives the configuration's features for a Digital component.
    /// </summary>
    public partial class Configuration : UserControl
    {
        
        String controlType;         //Used in the constructor to initialize the class.
        Control control;            //The type of control which will be used in the configuration
        Digital dig;                //Which is to configure.
        ComboBoxActions actions = ComboBoxActions.InputsSetup;

        public enum ComboBoxActions
        {
            InputsSetup = 0, InputPinsSetup = 1
        }

        public ErrorlistView ListView { get; set; }


        #region Constructors

        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public Configuration()
        {
            InitializeComponent();
            control = txtBox;
            dig = new And();
        }

        /// <summary>
        /// Initializes the class with specified control.
        /// </summary>
        /// <param name="control">Which is used in configuration e.g. ComboBox</param>
        public Configuration(String control)
        {
            InitializeComponent();
            this.controlType = control;
            if (control == "ComboBox")
                this.control = comboBox;
            else
                this.control = txtBox;
            dig = new And();
        }


        /// <summary>
        /// Initializes the class with specified control.
        /// </summary>
        /// <param name="control">Which is used in configuration e.g. ComboBox</param>
        /// <param name="digital">Which is to configure.</param>
        public Configuration(String control, Digital digital)
        {
            InitializeComponent();
            this.controlType = control;
            dig = digital;
            if (control == "ComboBox")
                this.control = comboBox;
            else
                this.control = txtBox;
            
        }
        #endregion

        #region Properties

        /// <summary>
        /// Sets the type of Control which is used in the configuration e.g. ComboBox.
        /// </summary>
        public String SetControl { set
            {
                controlType = value;
                if (controlType == "ComboBox")
                    this.control = comboBox;
                else
                    this.control = txtBox;
            }
        }

        /// <summary>
        /// Sets the action performed when the ComboBox's index changed.
        /// </summary>
        public ComboBoxActions SetAction { set
            {
                actions = value;
                if (value == ComboBoxActions.InputPinsSetup)
                {
                    comboBox.Items.RemoveAt(0);
                    comboBox.Items.RemoveAt(0);
                }
            }
        }
        #endregion
        
        #region Public

        /// <summary>
        /// Setups the ComboBox with the specified title and items.
        /// InvalidControlException: Thrown, when the class initializes with another control.
        /// </summary>
        /// <param name="configTitle">Appearing as a heading before ComboBox</param>
        /// <param name="item">Which are to include in the ComboBox</param>
        public void SetupComboBox(String configTitle, System.Collections.Specialized.StringCollection item)
        {
            ValidateControl("ComboBox");
            txtBox.Visible = false;
            label.Text = configTitle;
            comboBox.Location = new Point(label.Width + 5, comboBox.Location.Y);
            for (int i = 0; i < item.Count; i++)
                comboBox.Items.Add(item[i]);
            this.Size = new Size(label.Width + comboBox.Width + 10, this.Height);
            if (configTitle != "Pins:   " && dig.GetAvailablePins[GetPinNumber()].isPinContentOfAnother)
                comboBox.SelectedIndex = comboBox.Items.IndexOf(dig.GetAvailablePins[GetPinNumber()].ContentOfDigital.Name);

        }

        /// <summary>
        /// Setups the ComboBox with the specified title and items.
        /// InvalidControlException: Thrown, when the class initializes with another control.
        /// </summary>
        /// <param name="configTitle">Appearing as a heading before ComboBox</param>
        /// <param name="item">Which are to include in the ComboBox</param>
        public void SetupComboBox(String configTitle, String[] item)
        {
            ValidateControl("ComboBox");
            txtBox.Visible = false;
            label.Text = configTitle;
            comboBox.Location = new Point(label.Width + 5, comboBox.Location.Y);
            for (int i = 0; i < item.Length; i++)
                comboBox.Items.Add(item[i]);
            this.Size = new Size(label.Width + comboBox.Width + 10, this.Height);
            if (configTitle != "Pins:   " && dig.GetAvailablePins[GetPinNumber()].isPinContentOfAnother)
                comboBox.SelectedIndex = comboBox.Items.IndexOf(dig.GetAvailablePins[GetPinNumber()].ContentOfDigital.Name);

        }

        /// <summary>
        /// Setups the TextBox with the specified title and item.
        /// InvalidControlException: Thrown, when the class initializes with another control.
        /// </summary>
        /// <param name="configTitle">Appearing as a heading before ComboBox</param>
        /// <param name="value">Which is to include in the TextBox</param>
        public void SetupTextBox(String configTitle, String value)
        {
            ValidateControl("TextBox");
            comboBox.Visible = false;
            label.Text = configTitle;
            txtBox.Location = new Point(label.Width + 5, txtBox.Location.Y);
            txtBox.Text = value;
            this.Size = new Size(label.Width + txtBox.Width + 10, this.Height);
        }

        /// <summary>
        /// Sets the index of ComboBox respect to specified item. 
        /// </summary>
        /// <param name="item">Of which the index is to set.</param>
        public void SetInputIndexesOfComboBox(String item)
        {
            switch (item)
            {
                case "0":
                    comboBox.SelectedIndex = 0;
                    break;
                case "1":
                    comboBox.SelectedIndex = 1;
                    break;
                default:
                    comboBox.SelectedIndex = comboBox.Items.IndexOf(dig.GetAvailablePins[GetPinNumber()].ContentOfDigital.Name);
                    break;
            }
        }

        /// <summary>
        /// Sets the number of active input pins in combo box.
        /// </summary>
        public void SetAvailableInputsOfComboBox()
        {
            switch (dig.ActivePins)
            {
                case 2:
                    comboBox.SelectedIndex = 0;
                    break;
                case 3:
                    comboBox.SelectedIndex = 1;
                    break;
                case 4:
                    comboBox.SelectedIndex = 2;
                    break;
                case 5:
                    comboBox.SelectedIndex = 3;
                    break;
                default:
                    break;
            }
        }
        #endregion
        
        #region Private

        /// <summary>
        /// Validates the control and throws the InvalidControlException in case of any issue.
        /// </summary>
        /// <param name="type">Which type of control is to validate e.g. ComboBox</param>
        private void ValidateControl(String type)
        {
            switch (type)
            {
                case "ComboBox":
                    if (control != comboBox)
                        throw new InvalidControlException(type);
                    break;
                case "TextBox":
                    if (control != txtBox)
                        throw new InvalidControlException(type);
                    break;
                default:
                    break;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (actions)
            {
                case ComboBoxActions.InputsSetup:
                    InputsSetup();
                    break;
                case ComboBoxActions.InputPinsSetup:
                    InputPinsSetup();
                    break;
                default:
                    break;
            }
        }
        
        private void InputPinsSetup()
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    dig.SetPins(2);
                    dig.ComponentImage = dig.GetComponentImage(2);
                    break;
                case 1:
                    dig.SetPins(3);
                    dig.ComponentImage = dig.GetComponentImage(3);
                    break;
                case 2:
                    dig.SetPins(4);
                    dig.ComponentImage = dig.GetComponentImage(4);
                    break;
                case 3:
                    dig.SetPins(5);
                    dig.ComponentImage = dig.GetComponentImage(5);
                    break;
                default:
                    break;
            }

        }

        private void InputsSetup()
        {
            int pinNum = GetPinNumber();
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    if (dig.GetAvailablePins[pinNum].isPinContentOfAnother)
                    {
                        Digital.GetDigitalInstantByName(dig.GetAvailablePins[pinNum].ContentOfDigital.Name).OutputPin.DeleteARelativePin(dig, pinNum);
                        dig.GetAvailablePins[pinNum].ClearContentOfPin();
                    }
                    Wire.RemoveAWire(dig, pinNum);
                    dig.SetInputOn(pinNum, false);
                    dig.GetAvailablePins[pinNum].SignalFrom = "0";
                    //ListView.eventsListView.Items.Add(ListView.eventsListView.Items.Count.ToString()).SubItems.Add(DateTime.Now.ToLongTimeString());
                    //ListView.eventsListView.Items[ListView.eventsListView.Items.Count - 1].SubItems.Add(dig.Name + " has been turned off.");
                    break;
                case 1:
                    if (dig.GetAvailablePins[pinNum].isPinContentOfAnother)
                    {
                        Digital.GetDigitalInstantByName(dig.GetAvailablePins[pinNum].ContentOfDigital.Name).OutputPin.DeleteARelativePin(dig, pinNum);
                        dig.GetAvailablePins[pinNum].ClearContentOfPin();
                    }
                    Wire.RemoveAWire(dig, pinNum);
                    dig.SetInputOn(pinNum, true);
                    dig.GetAvailablePins[pinNum].SignalFrom = "1";
                    //ListView.eventsListView.Items.Add(ListView.eventsListView.Items.Count.ToString()).SubItems.Add(DateTime.Now.ToLongTimeString());
                    //ListView.eventsListView.Items[ListView.eventsListView.Items.Count - 1].SubItems.Add(dig.Name + " has been turned on.");
                    break;
                default:
                    if (dig.GetAvailablePins[pinNum].isPinContentOfAnother)
                    {
                        Digital.GetDigitalInstantByName(dig.GetAvailablePins[pinNum].ContentOfDigital.Name).OutputPin.DeleteARelativePin(dig, pinNum);
                        dig.GetAvailablePins[pinNum].ClearContentOfPin();
                    }
                    Digital  temp = Digital.GetDigitalInstantByName((string)comboBox.SelectedItem);
                    PushButton p;
                    if(temp is PushButton)
                    {
                        p = (PushButton)temp;
                        p.PreviousState = dig.GetAvailablePins[pinNum].State;
                        dig.SetInputOn(pinNum, p.PreviousState);
                    }
                    else
                    {
                        dig.SetInputOn(pinNum, temp.GetOutput());
                    }
                    temp.OutputPin.SetDigital(dig, pinNum);
                    dig.GetAvailablePins[pinNum].ContentOf(temp, temp.OutputPin);
                    Wire.RemoveAWire(dig, pinNum);
                    Wire w = new Wire(temp, dig, dig.ContentPanel.CreateGraphics(), pinNum,Properties.Settings.Default.wireSize);
                    w.DrawWire();
                    //Form2.errorlistView1.eventsListView.Items.Add(Form2.errorlistView1.eventsListView.Items.Count.ToString()).SubItems.Add(DateTime.Now.ToLongTimeString());
                    //Form2.errorlistView1.eventsListView.Items[Form2.errorlistView1.eventsListView.Items.Count - 1].SubItems.Add(dig.Name + " has been connected to " + temp.Name + ".");
                    break;
            }
            
        }
        
        /// <summary>
        /// Gets the actual index of Digital's default pins with reference to a temporary number.
        /// </summary>
        /// <returns>Index of Specified Pin</returns>
        public int GetPinNumber()
        {
            int ans = 0;
            switch (label.Text)
            {
                case "Input1:":
                case "CLK:  ":
                case "Component:":
                    ans = 0;
                    break;
                case "Input2:":
                case "R:      ":
                case "J:      ":
                case "D:      ":
                    if (dig.ActivePins == 2)
                        ans = 4;
                    else if (dig.ActivePins == 3)
                        ans = 2;
                    else if (dig.ActivePins == 4 || dig.ActivePins == 5)
                        ans = 1;
                    break;
                case "Input3:":
                case "S:      ":
                case "K:      ":
                    if (dig.ActivePins == 3)
                        ans = 4;
                    else if (dig.ActivePins == 4)
                        ans = 3;
                    else if (dig.ActivePins == 5)
                        ans = 2;
                    break;
                case "Input4:":
                case "PRE:  ":
                    if (dig.ActivePins == 4)
                        ans = 4;
                    else
                        ans = 3;
                    break;
                case "Input5:":
                case "CLR:  ":
                    ans = 4;
                    break;
                default:
                    ans = -1;
                    break;
            }
            return ans;
        }
        #endregion
    }
}
