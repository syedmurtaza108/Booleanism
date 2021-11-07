/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
March 29, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Drawing;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.ComponentModel;

namespace Booleanism
{
    /// <summary>
    /// The base class for digital components.
    /// </summary>
    public partial class Digital : UserControl
    {
        
        #region Data members
        private static bool isConfiguration = false;
        private bool isMove = false;        //Allows to move the control.
        private int x;                      //x and y will be used in the MouseDown event of picture box.
        private int y;  
        protected Panel contentPanel;       //Panel in which this will be added.
        protected Panel configPanel;        //Panel in which it's configurations will be added. 
        protected Pin[] pins = new Pin[5];  //A digital component can have maximum 5 input pins
        const int iniY = 11;                //Constant difference between the first pin and the top of it's instant.
        static Digital[] inpDigtalComp = new Digital[100]; //100 other digital instants can be linked to a single digital instant.   
        private static String selectedInstant = "";       //Used to select an instant;
        protected Pin pin5 = null;
        protected Pin pin4 = null;
        protected Pin pin3 = null;
        protected Pin pin2 = null;
        protected Configuration nameConfig;         //These configurations must for all digital's sub classes.
        protected Configuration activeInpConfig;
        protected Label detailsLabel = null;

        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public Digital()
        {
            InitializeComponent();
            contentPanel = new Panel();
            configPanel = new Panel();
            inpDigtalComp[GetIndexofNullInputDigital()] = this;     //Stores this instant into the input digital array.
            InitializePins();                                       //Initializes the 5 input pins.
            SetConfiguration();                                     //Sets the configurations for this instant.
        }

        /// <summary>
        /// Initializes the class with component image.
        /// </summary>
        /// <param name="ComponentPicture">The image of digital component</param>
        public Digital(Image ComponentPicture)
        {
            InitializeComponent();
            digImage.Image = ComponentPicture;
            contentPanel  = new Panel();
            configPanel = new Panel();
            inpDigtalComp[GetIndexofNullInputDigital()] = this;
            InitializePins();
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with component image and panel, in which the component will be added.
        /// </summary>
        /// <param name="ComponentPicture">The image of digital component</param>
        /// <param name="ContentPanel">In which the component will be added.</param>
        public Digital(Image ComponentPicture, Panel ContentPanel)
        {
            InitializeComponent();
            digImage.Image = ComponentPicture;
            contentPanel = ContentPanel;
            configPanel = new Panel();
            inpDigtalComp[GetIndexofNullInputDigital()] = this;
            InitializePins();
            SetConfiguration();
        }

        /// <summary>
        /// /// Initializes the class with component image and panel, in which the component will be added.
        /// </summary>
        /// <param name="ComponentPicture">The image of digital component.</param>
        /// <param name="ContentPanel">In which the component will be added.</param>
        /// <param name="configPanel">In which the component's configurations will be added.</param>
        public Digital(Image ComponentPicture, Panel ContentPanel, Panel configPanel):
            this(ComponentPicture, ContentPanel)
        {
            this.configPanel = configPanel;
        }

        /// <summary>
        /// /// Initializes the class with component image and panel, in which the component will be added.
        /// </summary>
        /// <param name="ComponentPicture">The image of digital component.</param>
        /// <param name="ContentPanel">In which the component will be added.</param>
        /// <param name="configPanel">In which the component's configurations will be added.</param>
        /// /// <param name="ActivePins">Numbers of pins that intended to be active.</param>
        public Digital(Image ComponentPicture, Panel ContentPanel, Panel configPanel, int ActivePins)
        {
            InitializeComponent();
            digImage.Image = ComponentPicture;
            contentPanel = ContentPanel;
            inpDigtalComp[GetIndexofNullInputDigital()] = this;
            this.configPanel = configPanel;
            InitializePins();
            SetPins(ActivePins);
        }
        #endregion

        #region Properties
        [Browsable(false)]
        /// <summary>
        /// Gets or sets the image of component.
        /// </summary>
        /// 
        public Image ComponentImage { get {return digImage.Image; } set { digImage.Image = value; } }

        [Browsable(false)]
        /// <summary>
        /// Gets or Sets the panel in which the component will be added.
        /// </summary>
        public Panel ContentPanel { set { contentPanel = value; }
            get { return contentPanel; }
        }

        [Browsable(false)]
        /// <summary>
        /// Gets the array of 100 allowed input Digital's instants.
        /// </summary>
        public static Digital[] DigitalComponents { get {return inpDigtalComp; } }


        [Browsable(false)]
        /// <summary>
        /// Gets or Sets the panel in which the component's configurations will be added.
        /// </summary>
        public Panel ConfigPanel {
            get {
                return configPanel;
            }
            set {
                configPanel = value;
            }
        }

        [Browsable(false)]
        /// <summary>
        /// Gets the array of all available input pins.
        /// </summary>
        public Pin[] GetAvailablePins { get {return pins; } }

        [Browsable(false)]
        /// <summary>
        /// Gets or sets the label in which the details of Digital component will be shown.
        /// </summary>
        public Label DetailsLabel { get { return detailsLabel; } set {detailsLabel = value; } }

        [Browsable(false)]
        /// <summary>
        /// Gets or sets the name of current selected digital's instant.
        /// </summary>
        public static String SelectedInstant { get {return selectedInstant; } set { selectedInstant = value; isConfiguration = true; }}

        /// <summary>
        /// Gets the number of active input pins.
        /// </summary>
        public int ActivePins { get
            {
                int temp = 0;
                for (int i = 0; i < pins.Length; i++)
                    if (pins[i] != null)
                        temp++;
                return temp;
            }
        }


        [Browsable(false)]
        /// <summary>
        /// Gets the output pin.
        /// </summary>
        public Pin OutputPin { get {return outputPin; }}

        /// <summary>
        /// Gets or sets the title of this instant.
        /// </summary>
        public String Title { get {return nameLabel.Text ; } set {nameLabel.Text = value; } }

        
        #endregion

        #region Methods used to move component
        private void digImage_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            x = e.X;
            y = e.Y;
            this.Cursor = Cursors.Cross;
        }

        private void digImage_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
            this.Cursor = Cursors.Default;
        }

        private void digImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - x, this.Location.Y + e.Y - y);
            }
        }
        #endregion

        #region Protected methods
        /// <summary>
        /// Gets the collection of String containing the names of all the available Digital's instants.
        /// </summary>
        protected StringCollection GetStringOfInput()
        {
            StringCollection result = new StringCollection();
            for (int i = 0; i < inpDigtalComp.Length; i++)
            {
                if (inpDigtalComp[i] != null)
                    result.Add(inpDigtalComp[i].Name);
            }
            return result;
        }
        #endregion
        
        #region Public methods

        /// <summary>
        /// Restarts the count of this instant.
        /// </summary>
        public virtual void RestartCounting()
        {

        }

        /// <summary>
        /// Gets the name of this instant.
        /// </summary>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// Gets the total number of input pins, which are connected through any wire.
        /// </summary>
        public int GetNumberOfWiredInputs()
        {
            int ans = 0;
            switch(ActivePins)
            {
                case 1:
                    if (pin3.SignalFrom != null)
                        ans++;
                    break;
                case 2:
                    if (pin2.SignalFrom != null)
                        ans++;
                    if (pin4.SignalFrom != null)
                        ans++;
                    break;
                case 3:
                    if (pin1.SignalFrom != null)
                        ans++;
                    if (pin3.SignalFrom != null)
                        ans++;
                    if (pin5.SignalFrom != null)
                        ans++;
                    break;
                case 4:
                    if (pin1.SignalFrom != null)
                        ans++;
                    if (pin2.SignalFrom != null)
                        ans++;
                    if (pin4.SignalFrom != null)
                        ans++;
                    if (pin5.SignalFrom != null)
                        ans++;
                    break;
                default:
                    if (pin1.SignalFrom != null)
                        ans++;
                    if (pin2.SignalFrom != null)
                        ans++;
                    if (pin3.SignalFrom != null)
                        ans++;
                    if (pin4.SignalFrom != null)
                        ans++;
                    if (pin5.SignalFrom != null)
                        ans++;
                    break;
            }
            return ans;
        }

        /// <summary>
        /// Sets the number of Input pins.
        /// </summary>
        /// <param name="pinNum">Number of desired input pins. Must be 2 to 5</param>
        public void SetPins(int pinNum)
        {
            pinNum = pinNum < 2 || pinNum > 5 ? 2 : pinNum;     //To handle the array bound of index exception.
            pin2.Location = new Point(0, 14 * 1 + iniY);
            pin3.Location = new Point(0, 14 * 2 + iniY);
            pin4.Location = new Point(0, 14 * 3 + iniY);
            pin5.Location = new Point(0, 14 * 4 + iniY);
            switch (pinNum)
            {
                case 2:
                    TwoInputPins();
                    break;
                case 3:
                    ThreeInputPins();
                    break;
                case 4:
                    FourInputPins();
                    break;
                case 5:
                    FiveInputPins();
                    break;
                default:
                    break;
            }
            
        }

        /// <summary>
        /// Sets the configuration of Digital's instant. This method can be overridden.
        /// </summary>
        public virtual void SetConfiguration()
        {
            configPanel.Controls.Clear();                       //This configuration is for Gates. For other components it must be overridden.
            int temp = 0;
            nameConfig = new Configuration("TextBox", this);
            nameConfig.SetupTextBox("Name: ", this.Name);
            configPanel.Controls.Add(nameConfig);
            for (int i = 0; i < 5; i++)
            {
                if (pins[i] != null)
                {
                    temp++;
                    Configuration inputConfig = new Configuration("ComboBox", this);
                    inputConfig.SetAction = Configuration.ComboBoxActions.InputsSetup;
                    inputConfig.SetupComboBox("Input" + temp.ToString() + ":", GetStringOfInput());
                    inputConfig.SetInputIndexesOfComboBox(pins[i].SignalFrom);
                    inputConfig.Location = new System.Drawing.Point(inputConfig.Location.X, inputConfig.Height * temp);
                    configPanel.Controls.Add(inputConfig);
                }
            }
            temp++;
            activeInpConfig = new Configuration("ComboBox", this);
            String[] values = { "2", "3", "4", "5" };
            activeInpConfig.SetupComboBox("Pins:   ", values);
            activeInpConfig.SetAction = Configuration.ComboBoxActions.InputPinsSetup;
            activeInpConfig.SetAvailableInputsOfComboBox();
            activeInpConfig.Location = new Point(activeInpConfig.Location.X, activeInpConfig.Height * temp);
            configPanel.Controls.Add(activeInpConfig);
        }

        
        /// <summary>
        /// Sets the specified input on specified pin.
        /// InvalidPinException: Thrown, if the specified pin is not found in the available input pins.
        /// </summary>
        /// <param name="pinNum">The zero based index of input pin on which the input is to set.</param>
        /// <param name="input">State which is to set.</param>
        public void SetInputOn(int pinNum, bool input)
        {
            if (pins[pinNum] != null)
            {
                pins[pinNum].State = input;
                outputPin.State = GetOutput();  //After the input is set output also changes respect to input.
            }
            else
            {
                throw new InvalidPinException();
            }
        }

        /// <summary>
        /// Sets the specified input on specified pin.
        /// InvalidPinException: Thrown, if the specified pin is not found in the available input pins.
        /// </summary>
        /// <param name="pin">On which the input is to set.</param>
        /// <param name="input">State which is to set.</param>
        public void SetInputOn(Pin pin, bool input)
        {
            int ans = 0;
            for(int i = 0; i<pins.Length; i++)
            {
                if (pins[i] == pin)
                {
                    ans++;
                    break;
                }
            }
            if (ans == 0)
                throw new InvalidPinException();
            else
            {
                pin.State = input;
                outputPin.State = GetOutput();
            }
        }

        /// <summary>
        /// Output of Digital component. This method can be overridden.
        /// </summary>
        public virtual bool GetOutput() { return false; }

        /// <summary>
        /// Gets the Digital's instant by its name.
        /// InvalidDigitalNameException: Thrown, if the name is invalid.
        /// </summary>
        /// <param name="name">Name of specified Digital's instant.</param>
        public static Digital GetDigitalInstantByName(String name)
        {
            Digital dig = null;
            ValidateDigitalName(name);
            for (int i = 0; i < inpDigtalComp.Length; i++)
            {
                if(inpDigtalComp[i] != null)
                {
                    if (inpDigtalComp[i].Name == name)
                    {
                        dig = inpDigtalComp[i];
                        break;
                    }
                }
            }
            return dig;
            
        }

        /// <summary>
        /// Gets the Digital's instant by its title.
        /// InvalidDigitalNameException: Thrown, if the name is invalid.
        /// </summary>
        /// <param name="name">Name of specified Digital's instant.</param>
        public static Digital GetDigitalInstantByTitle(String title)
        {
            Digital dig = null;
            for (int i = 0; i < inpDigtalComp.Length; i++)
            {
                if (inpDigtalComp[i].nameLabel.Text == title)
                {
                    dig = inpDigtalComp[i];
                    break;
                }

            }
            if (dig == null)
                throw new InvalidDigitalNameException(title);
            return dig;

        }

        /// <summary>
        /// Deletes this instant.
        /// </summary>
        public void Delete()
        {
            selectedInstant = "";
            contentPanel.Controls.Remove(this);
            configPanel.Controls.Clear();
            for (int i = 0; i < inpDigtalComp.Length; i++)     //Also deletes the gate from the list of input pins.
            {
                if (inpDigtalComp[i] == this)
                {
                    inpDigtalComp[i] = null;
                    break;
                }
            }
        }

        /// <summary>
        /// Returns the image of Digital's instant w.r.t input pins. This can be overridden.
        /// </summary>
        /// <param name="inputPins">which image is returned.</param>
        public virtual Image GetComponentImage(int inputPins) { return null; }
        
        /// <summary>
        /// Copies the configurations of this instant to the another specified instant.
        /// </summary>
        /// <param name="copyTo"></param>
        public void CopyConfiguration(Digital copyTo)
        {
            if(!this.Name.Contains("NOT"))
                copyTo.SetPins(this.ActivePins);
            copyTo.ComponentImage = GetComponentImage(ActivePins);
            copyTo.outputPin.State = this.outputPin.State;
            for (int i = 0; i < pins.Length; i++)
                if (pins[i] != null)
                {
                    copyTo.GetAvailablePins[i].State = this.pins[i].State;
                }
        }

        /// <summary>
        /// Deletes all the components initialized.
        /// </summary>
        public static void DeleteAllComponents()
        {
            for (int i = 0; i < inpDigtalComp.Length; i++)
                if (inpDigtalComp[i] != null)
                    inpDigtalComp[i] = null;
            selectedInstant = "";
        }

        #endregion
        
        #region  Private Methods


        /// <summary>
        /// Validates the name of specified Digital's instant and throws InvalidDigitalNameExcpetion if it's invalid.
        /// </summary>
        /// <param name="name">Name of specified Digital's instant.</param>
        private static void ValidateDigitalName(String name)
        {
            bool isException = true;
            for(int i = 0; i< inpDigtalComp.Length; i++)
            {
                if (inpDigtalComp[i] != null)
                {
                    if(inpDigtalComp[i].Name == name)
                    {
                        isException = false;
                        break;
                    }
                }
            }
            if (isException)
                throw new InvalidDigitalNameException(name);
        }

        //Initialize the 5 input pins.
        private void InitializePins()
        {
            pins[0] = pin1;
            pin5 = new Pin();
            pin4 = new Pin();
            pin3 = new Pin();
            pin2 = new Pin();
        }

        /// <summary>
        /// Gets the first index of null object in inpDigitalComp array.
        /// </summary>
        private int GetIndexofNullInputDigital()
        {
            int ans = 0;
            for (int i = 0; i < inpDigtalComp.Length; i++)
            {
                if (inpDigtalComp[i] == null)
                {
                    ans = i;
                    break;
                }
            }
            return ans;
        }
        #endregion
  
        #region Events Methods

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {
            renameTxt.Text = nameLabel.Text;
        }

        private void renameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.nameLabel.Text = renameTxt.Text;
        }


        private void Digital_Paint(object sender, PaintEventArgs e)
        {
            if (isConfiguration && this.BorderStyle == BorderStyle.FixedSingle)
            {
                SetConfiguration();
                detailsLabel.Text = ToString();
                isConfiguration = false;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        
        private void digImage_Click(object sender, EventArgs e)
        {
            if (selectedInstant != "")
            {
                Digital temp = GetDigitalInstantByName(selectedInstant);
                temp.BorderStyle = BorderStyle.None;
                
            }
            this.BorderStyle = BorderStyle.FixedSingle;
            selectedInstant = this.Name;

            Form2.propertyGrid1.SelectedObject = this;
            Form2.tableTool.Heading = this.Name;
            if (detailsLabel != null)
                detailsLabel.Text = this.ToString();
            SetConfiguration();
        }
        
        private void refreshPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetConfiguration();
        }
        #endregion

        #region Methods used in SetInput()
        private void TwoInputPins()         
        {
            pins[4] = pin5;                 //Defines second input pin.
            pinsPanel.Controls.Add(pin5);   
            if (pins[1] != null)            //Non required pins must be invisible
                pins[1].Visible = false;
            if (pins[2] != null)
                pins[2].Visible = false;
            if (pins[3] != null)
                pins[3].Visible = false;
            pins[1] = null;                 //Non required pins going to disable in configuration panel.
            pins[2] = null;
            pins[3] = null;
        }

        private void ThreeInputPins()
        {
            pinsPanel.Controls.Add(pin5);
            pins[4] = pin5;
            pins[4].Visible = true;
            pinsPanel.Controls.Add(pin3);
            pins[2] = pin3;
            pins[2].Visible = true;
            if (pins[1] != null)
                pins[1].Visible = false;
            if (pins[3] != null)
                pins[3].Visible = false;
            pins[1] = pins[3] = null;
            pins[2].Visible = true;
        }

        private void FourInputPins()
        {
            pinsPanel.Controls.Add(pin5);
            pins[4] = pin5;
            pinsPanel.Controls.Add(pin4);
            pins[3] = pin4;
            pinsPanel.Controls.Add(pin2);
            pins[1] = pin2;
            if (pins[2] != null)
                pins[2].Visible = false;
            pins[2] = null;
            pins[1].Visible = pins[3].Visible = true;
        }


        private void FiveInputPins()
        {
            pinsPanel.Controls.Add(pin5);
            pins[4] = pin5;
            pinsPanel.Controls.Add(pin4);
            pins[3] = pin4;
            pinsPanel.Controls.Add(pin2);
            pins[1] = pin2;
            pinsPanel.Controls.Add(pin3);
            pins[2] = pin3;
            pins[1].Visible = pins[2].Visible = pins[3].Visible = true;
        }
        #endregion

        
    }
}
