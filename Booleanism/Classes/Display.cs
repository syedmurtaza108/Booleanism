using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booleanism
{
    class Display : Digital
    {
        #region members
        private Panel a;
        private Panel g;
        private Panel d;
        private Panel f;
        private Panel e;
        private Panel c;
        private Panel b;
        Color on = Color.Red;
        Color off = Color.LightGray;
        static int num = 0;
        #endregion

        #region Constructors
        public Display():
            base(Properties.Resources.display_img, new Panel(), new Panel(), 4)
        {
            SetPins(4);
            InitializeComponent();
            num++;
            this.Name = "Display" + num.ToString();
            nameLabel.Text = this.Name;
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        public Display(Panel contentPanel, Panel configPanel):
            base(Properties.Resources.display_img, contentPanel, configPanel,4)
        {
            InitializeComponent();
            num++;
            this.Name = "Display" + num.ToString();
            nameLabel.Text = this.Name;
            SetConfiguration();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the gate will be added.</param>
        /// <param name="configPanel">In which the gate's configuration will be added.</param>
        public Display(Panel contentPanel, Panel configPanel, Color DisplayColor) :
            base(Properties.Resources.display_img, contentPanel, configPanel, 4)
        {
            InitializeComponent();
            num++;
            this.Name = "Display" + num.ToString();
            nameLabel.Text = this.Name;
            on = DisplayColor;
            SetConfiguration();
        }
        #endregion

        /// <summary>
        /// Gets or sets the on state's color of display.
        /// </summary>
        public Color OnColor { get {return on; } set { on = value; } }

        /// <summary>
        /// Gets the off state's color of display.
        /// </summary>
        public Color OffColor { get {return off; } }

        public override string ToString()
        {
            return this.Name + ": Converts the binary numbers into decimal and then shows it.";
        }

        public override void SetConfiguration()
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
        }

        /// <summary>
        /// Gets the output of Display through color changing on it. Note: It always returns false.
        /// </summary>
        public override bool GetOutput()
        {
            if ((!pins[0].State && !pins[1].State && !pins[3].State && !pins[4].State)) //0
            {
                a.BackColor = b.BackColor = on;
                c.BackColor = d.BackColor = on;
                e.BackColor = f.BackColor = on;
                g.BackColor = off;
            }
            else if (!pins[4].State && !pins[3].State && !pins[1].State && pins[0].State) //1
            {
                b.BackColor = c.BackColor = on;
                a.BackColor = d.BackColor = e.BackColor = f.BackColor = g.BackColor = off;
            }
            else if (!pins[4].State && !pins[3].State && pins[1].State && !pins[0].State) //2
            {
                a.BackColor = b.BackColor = d.BackColor = e.BackColor = g.BackColor = on;
                c.BackColor = f.BackColor = off;
            }
            else if (!pins[4].State && !pins[3].State && pins[1].State && pins[0].State) //3
            {
                e.BackColor = f.BackColor = off;
                a.BackColor = d.BackColor = b.BackColor = c.BackColor = g.BackColor = on;
            }
            else if (!pins[4].State && pins[3].State && !pins[1].State && !pins[0].State) //4
            {
                a.BackColor = d.BackColor = e.BackColor = off;
                b.BackColor = c.BackColor = f.BackColor = g.BackColor = on;
            }
            else if (!pins[4].State && pins[3].State && !pins[1].State && pins[0].State) //5
            {
                b.BackColor = e.BackColor = off;
                a.BackColor = c.BackColor = d.BackColor = f.BackColor = g.BackColor = on;
            }
            else if (!pins[4].State && pins[3].State && pins[1].State && !pins[0].State) //6
            {
                b.BackColor = off;
                a.BackColor = c.BackColor = f.BackColor = g.BackColor = d.BackColor = e.BackColor = on;
            }
            else if (!pins[4].State && pins[3].State && pins[1].State && pins[0].State) //7
            {
                a.BackColor = b.BackColor = c.BackColor = on;
                d.BackColor = e.BackColor = f.BackColor = g.BackColor = off;
            }
            else if (pins[4].State && !pins[3].State && !pins[1].State && !pins[0].State) //8
            {
                a.BackColor = b.BackColor = c.BackColor = d.BackColor = e.BackColor = f.BackColor = g.BackColor = on;
            }
            else if (pins[4].State && !pins[3].State && !pins[1].State && pins[0].State) //9
            {
                d.BackColor = e.BackColor = off;
                a.BackColor = b.BackColor = c.BackColor = f.BackColor = g.BackColor = on;
            }
            else if (pins[4].State && !pins[3].State && pins[1].State && !pins[0].State)//10
            {
                f.BackColor = off;
                a.BackColor = b.BackColor = c.BackColor = e.BackColor = d.BackColor = g.BackColor = on;
            }
            else if (pins[4].State && !pins[3].State && pins[1].State && pins[0].State)//11
            {
                a.BackColor = b.BackColor = off;
                d.BackColor = c.BackColor = e.BackColor = f.BackColor = g.BackColor = on;
            }
            else if (pins[4].State && pins[3].State && !pins[1].State && !pins[0].State) //12
            {
                b.BackColor = c.BackColor = g.BackColor = off;
                a.BackColor = d.BackColor = f.BackColor = e.BackColor = on;
            }
            else if (pins[4].State && pins[3].State && !pins[1].State && pins[0].State) //13
            {
                a.BackColor = f.BackColor = off;
                b.BackColor = c.BackColor = d.BackColor = e.BackColor = g.BackColor = on;
            }
            else if (pins[4].State && pins[3].State && pins[1].State && !pins[0].State) //14
            {
                b.BackColor = c.BackColor = off;
                a.BackColor = f.BackColor = d.BackColor = e.BackColor = g.BackColor = on;
            }
            else if (pins[4].State && pins[3].State && pins[1].State && pins[0].State) //15
            {
                b.BackColor = c.BackColor = d.BackColor = off;
                a.BackColor = f.BackColor = e.BackColor = g.BackColor = on;
            }

            return false;
        }



        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.Panel();
            this.g = new System.Windows.Forms.Panel();
            this.d = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Panel();
            this.e = new System.Windows.Forms.Panel();
            this.c = new System.Windows.Forms.Panel();
            this.b = new System.Windows.Forms.Panel();
            this.configPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).BeginInit();
            this.pinsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pin4
            // 
            this.pin4.BackColorChanged += new System.EventHandler(this.pin1_BackColorChanged);
            // 
            // pin3
            // 
            this.pin3.BackColorChanged += new System.EventHandler(this.pin1_BackColorChanged);
            // 
            // pin2
            // 
            this.pin2.BackColorChanged += new System.EventHandler(this.pin1_BackColorChanged);
            // 
            // digImage
            // 
            this.digImage.Image = global::Booleanism.Properties.Resources.display_img;
            // 
            // outputPin
            // 
            this.outputPin.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Visible = false;
            // 
            // pin1
            // 
            this.pin1.BackColorChanged += new System.EventHandler(this.pin1_BackColorChanged);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.LightGray;
            this.a.Location = new System.Drawing.Point(107, 7);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(34, 3);
            this.a.TabIndex = 6;
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.LightGray;
            this.g.Location = new System.Drawing.Point(107, 39);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(34, 3);
            this.g.TabIndex = 7;
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.LightGray;
            this.d.Location = new System.Drawing.Point(107, 71);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(34, 3);
            this.d.TabIndex = 7;
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.LightGray;
            this.f.Location = new System.Drawing.Point(107, 12);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(3, 24);
            this.f.TabIndex = 8;
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.LightGray;
            this.e.Location = new System.Drawing.Point(107, 45);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(3, 24);
            this.e.TabIndex = 9;
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.LightGray;
            this.c.Location = new System.Drawing.Point(138, 45);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(3, 24);
            this.c.TabIndex = 11;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.LightGray;
            this.b.Location = new System.Drawing.Point(138, 13);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(3, 24);
            this.b.TabIndex = 10;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ComponentImage = global::Booleanism.Properties.Resources.display_img;
            this.Controls.Add(this.c);
            this.Controls.Add(this.e);
            this.Controls.Add(this.b);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.g);
            this.Controls.Add(this.a);
            this.Name = "Display";
            this.Controls.SetChildIndex(this.digImage, 0);
            this.Controls.SetChildIndex(this.pinsPanel, 0);
            this.Controls.SetChildIndex(this.outputPin, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.a, 0);
            this.Controls.SetChildIndex(this.g, 0);
            this.Controls.SetChildIndex(this.d, 0);
            this.Controls.SetChildIndex(this.f, 0);
            this.Controls.SetChildIndex(this.b, 0);
            this.Controls.SetChildIndex(this.e, 0);
            this.Controls.SetChildIndex(this.c, 0);
            this.configPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).EndInit();
            this.pinsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pin1_BackColorChanged(object sender, EventArgs e)
        {
            

        }
    }
}
