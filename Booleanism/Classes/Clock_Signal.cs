using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booleanism
{
    class Clock_Signal : Digital
    {
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private ComboBox intervalCombo;
        static int num = 0;         //Counts the number of instants of this class.

        public Clock_Signal()
        {
            InitializeComponent();
            this.digImage.Image = Properties.Resources.normal_push_button;
            num++;
            this.Name = "Clock" + num.ToString();
            nameLabel.Text = this.Name;
            Start();
            intervalCombo.SelectedIndex = 0;
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the button will be added.</param>
        public Clock_Signal(Panel contentPanel):
            base(Properties.Resources.normal_push_button, contentPanel, new Panel())
        {
            InitializeComponent();
            num++;
            this.Name = "Clock" + num.ToString();
            nameLabel.Text = this.Name;
            Start();
            intervalCombo.SelectedIndex = 0;
        }

        public ComboBox IntervalComboBox { get { return intervalCombo; } }

        public override void SetConfiguration()
        {

        }

        public override bool GetOutput()
        {
            return false;
        }

        public void Start(int interval = 1000)
        {
            timer1.Interval = interval;
            timer1.Start();
        }

        public void Stop()
        {
            timer1.Stop();
        }

        public override Image GetComponentImage(int inputPins)
        {
            return Properties.Resources.clock_signal;
        }

        public override string ToString()
        {
            return "Provides the clock pulses after the desired interval.";
        }

        public override void RestartCounting()
        {
            num = 0;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.intervalCombo = new System.Windows.Forms.ComboBox();
            this.configPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).BeginInit();
            this.SuspendLayout();
            // 
            // digImage
            // 
            this.digImage.Image = global::Booleanism.Properties.Resources.clock_signal;
            // 
            // pinsPanel
            // 
            this.pinsPanel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(55, 60);
            this.nameLabel.Size = new System.Drawing.Size(40, 13);
            this.nameLabel.Text = "Clock1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // intervalCombo
            // 
            this.intervalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalCombo.FormattingEnabled = true;
            this.intervalCombo.Items.AddRange(new object[] {
            "1000 ms",
            "500 ms",
            "100 ms",
            "Stop"});
            this.intervalCombo.Location = new System.Drawing.Point(33, 4);
            this.intervalCombo.Name = "intervalCombo";
            this.intervalCombo.Size = new System.Drawing.Size(87, 21);
            this.intervalCombo.TabIndex = 6;
            this.intervalCombo.SelectedIndexChanged += new System.EventHandler(this.intervalCombo_SelectedIndexChanged);
            // 
            // Clock_Signal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ComponentImage = global::Booleanism.Properties.Resources.clock_signal;
            this.Controls.Add(this.intervalCombo);
            this.Name = "Clock_Signal";
            this.Title = "Clock1";
            this.Controls.SetChildIndex(this.digImage, 0);
            this.Controls.SetChildIndex(this.pinsPanel, 0);
            this.Controls.SetChildIndex(this.outputPin, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.intervalCombo, 0);
            this.configPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            outputPin.State = !outputPin.State;
        }

        private void intervalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(intervalCombo.SelectedIndex)
            {
                case 0:
                    Start();
                    break;
                case 1:
                    Start(500);
                    break;
                case 2:
                    Start(100);
                    break;
                default:
                    Stop();
                    break;
            }
        }
    }
}
