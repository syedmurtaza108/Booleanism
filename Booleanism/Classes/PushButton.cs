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
    /// This class gives the features of a push button.
    /// </summary>
    class PushButton : Digital
    {
        private PictureBox buttonPush;
        private bool previousState;
        static int num = 0;         //Counts the number of instants of this class.
        
        #region Constructors
        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public PushButton()
        {
            InitializeComponent();
            this.digImage.Image = Properties.Resources.normal_push_button;
            num++;
            this.Name = "Button" + num.ToString();
            nameLabel.Text = this.Name;
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the button will be added.</param>
        public PushButton(Panel contentPanel):
            base(Properties.Resources.normal_push_button, contentPanel, new Panel())
        {
            InitializeComponent();
            num++;
            this.Name = "Button" + num.ToString();
            nameLabel.Text = this.Name;
        }
        #endregion

        /// <summary>
        /// Gets or sets the previous state of the component linked to this push button.
        /// </summary>
        public bool PreviousState { get {return previousState; } set {previousState = value; } }

        #region Public methods

        public override void SetConfiguration()
        {
            
        }

        public override bool GetOutput()
        {
            return previousState;
        }

        public override Image GetComponentImage(int inputPins)
        {
            return Properties.Resources.normal_push_button;
        }

        #endregion

        #region Event methods

        private void buttonPush_Click(object sender, EventArgs e)
        {
            buttonPush.Image = Properties.Resources.click_circle;
            outputPin.State = !outputPin.State;
        }

        private void buttonPush_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPush.Image = Properties.Resources.click_circle;
        }

        private void buttonPush_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPush.Image = Properties.Resources.normal_circle;
        }
        
        public override string ToString()
        {
            return this.Name + ": Toggle between on and off.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }

        #endregion

        #region Auto generated code
        private void InitializeComponent()
        {
            this.buttonPush = new System.Windows.Forms.PictureBox();
            this.configPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).BeginInit();
            this.pinsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPush)).BeginInit();
            this.SuspendLayout();
            // 
            // digImage
            // 
            this.digImage.Image = global::Booleanism.Properties.Resources.normal_push_button;
            // 
            // pinsPanel
            // 
            this.pinsPanel.Visible = false;
            // 
            // outputPin
            // 
            this.outputPin.Location = new System.Drawing.Point(73, 71);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(54, 35);
            this.nameLabel.Size = new System.Drawing.Size(44, 13);
            this.nameLabel.Text = "Button1";
            this.nameLabel.Click += new System.EventHandler(this.buttonPush_Click);
            this.nameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPush_MouseDown);
            this.nameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPush_MouseUp);
            // 
            // buttonPush
            // 
            this.buttonPush.BackColor = System.Drawing.Color.LightGray;
            this.buttonPush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPush.Image = global::Booleanism.Properties.Resources.normal_circle;
            this.buttonPush.Location = new System.Drawing.Point(49, 16);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(52, 52);
            this.buttonPush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonPush.TabIndex = 5;
            this.buttonPush.TabStop = false;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            this.buttonPush.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPush_MouseDown);
            this.buttonPush.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPush_MouseUp);
            // 
            // PushButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ComponentImage = global::Booleanism.Properties.Resources.normal_push_button;
            this.Controls.Add(this.buttonPush);
            this.Name = "PushButton";
            this.Title = "Button1";
            this.Controls.SetChildIndex(this.digImage, 0);
            this.Controls.SetChildIndex(this.buttonPush, 0);
            this.Controls.SetChildIndex(this.pinsPanel, 0);
            this.Controls.SetChildIndex(this.outputPin, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.configPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).EndInit();
            this.pinsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonPush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


    }
}
