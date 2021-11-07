/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
April 04, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of a LED.
    /// </summary>
    class LED : Digital
    {
        static int num = 0;         //Counts the number of instants of this class.
        Image ledOn;
        Image ledOff;
        LEDType Type;

        public enum LEDType
        {
            Blue = 0, Green = 1, White = 2, Yellow = 3, Purple = 4, Red = 5
        }
        
        #region Constructors
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public LED()
        {
            InitializeComponent();
            ledOn = Properties.Resources.blue_led_glow;
            ledOff = Properties.Resources.blue_led;
            Type = LEDType.Blue;
            this.digImage.Image = ledOff;
            num++;
            this.Name = "LED" + num.ToString();
            nameLabel.Text = this.Name;
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the LED will be added.</param>
        /// <param name="configPanel">In which the LED configuration will be added.</param>
        public LED(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.blue_led, contentPanel, configPanel)
        {

            ledOn = Properties.Resources.blue_led_glow;
            ledOff = Properties.Resources.blue_led;
            Type = LEDType.Blue;
            InitializeComponent();
            num++;
            this.Name = "LED" + num.ToString();
            nameLabel.Text = this.Name;
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="type">Type of LED that is tended to instantiate.</param>
        /// <param name="contentPanel">In which the LED will be added.</param>
        /// <param name="configPanel">In which the LED configuration will be added.</param>
        public LED(LEDType type, Panel contentPanel, Panel configPanel):
            base(Properties.Resources.blue_led, contentPanel, configPanel)
        {
            Type = type;
            SetOnOffImages();
            InitializeComponent();
            this.digImage.Image = ledOff;
            num++;
            this.Name = "LED" + num.ToString();
            nameLabel.Text = this.Name;
            SetConfiguration();
        }
        #endregion
        public LEDType TypeOfLED { get { return Type; } set {Type = value; SetOnOffImages(); } }

        #region Public methods

        public override string ToString()
        {
            return this.Name+": It indicates whether high voltage is applied or not.";
        }

        public override void SetConfiguration()
        {
            configPanel.Controls.Clear();                       //This configuration is for Gates. For other components it must be overridden.
            nameConfig = new Configuration("TextBox", this);
            nameConfig.SetupTextBox("Name:         ", this.Name);
            configPanel.Controls.Add(nameConfig);
            Configuration inputConfig = new Configuration("ComboBox", this);
            inputConfig.SetAction = Configuration.ComboBoxActions.InputsSetup;
            inputConfig.SetupComboBox("Component:" , GetStringOfInput());
            inputConfig.Location = new Point(inputConfig.Location.X, inputConfig.Height);
            configPanel.Controls.Add(inputConfig);
        }

        public override Image GetComponentImage(int inputPins)
        {
            return ledOff;
        }

        public override void RestartCounting()
        {
            num = 0;
        }

        public override bool GetOutput()
        {
            outputPin.State = pins[0].State;
            if (!outputPin.State)
                this.ComponentImage = ledOff;
            else
                this.ComponentImage = ledOn;
            return outputPin.State;
        }

        #endregion

        private void SetOnOffImages()
        {
            switch(Type)
            {
                case LEDType.Green:
                    ledOff = Properties.Resources.green_led;
                    ledOn = Properties.Resources.green_led_glow;
                    break;
                case LEDType.Red:
                    ledOff = Properties.Resources.red_led;
                    ledOn = Properties.Resources.red_led_glow;
                    break;
                case LEDType.Purple:
                    ledOff = Properties.Resources.purple_led;
                    ledOn = Properties.Resources.purple_led_glow;
                    break;
                case LEDType.White:
                    ledOff = Properties.Resources.white_led;
                    ledOn = Properties.Resources.white_led_glow;
                    break;
                case LEDType.Yellow:
                    ledOff = Properties.Resources.yellow_led;
                    ledOn = Properties.Resources.yellow_led_glow;
                    break;
                default:
                    ledOff = Properties.Resources.blue_led;
                    ledOn = Properties.Resources.blue_led_glow;
                    break;

            }
            this.digImage.Image = ledOff;
        }


        #region Auto generated code

        private void InitializeComponent()
        {
            this.configPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).BeginInit();
            this.pinsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // digImage
            // 
            this.digImage.Image = global::Booleanism.Properties.Resources.blue_led;
            // 
            // pinsPanel
            // 
            this.pinsPanel.Visible = false;
            // 
            // outputPin
            // 
            this.outputPin.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(12, 18);
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.Text = "LED1";
            // 
            // pin1
            // 
            this.pin1.Location = new System.Drawing.Point(0, 39);
            // 
            // LED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ComponentImage = global::Booleanism.Properties.Resources.blue_led;
            this.Name = "LED";
            this.Title = "LED1";
            this.Controls.SetChildIndex(this.digImage, 0);
            this.Controls.SetChildIndex(this.pinsPanel, 0);
            this.Controls.SetChildIndex(this.outputPin, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.configPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).EndInit();
            this.pinsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


    }
}
