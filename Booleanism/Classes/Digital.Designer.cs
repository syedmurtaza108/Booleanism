namespace Booleanism
{
    partial class Digital
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renameTxt = new System.Windows.Forms.ToolStripTextBox();
            this.refreshPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinsPanel = new System.Windows.Forms.Panel();
            this.pin1 = new Booleanism.Pin();
            this.digImage = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.outputPin = new Booleanism.Pin();
            this.menu.SuspendLayout();
            this.pinsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.renameTxt,
            this.refreshPropertiesToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(170, 79);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Booleanism.Properties.Resources.delete_icon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.ToolTipText = "Delete this instant";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // renameTxt
            // 
            this.renameTxt.Name = "renameTxt";
            this.renameTxt.Size = new System.Drawing.Size(100, 23);
            this.renameTxt.ToolTipText = "Change the title of this instant";
            this.renameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.renameTxt_KeyPress);
            // 
            // refreshPropertiesToolStripMenuItem
            // 
            this.refreshPropertiesToolStripMenuItem.Image = global::Booleanism.Properties.Resources.rotate_icon;
            this.refreshPropertiesToolStripMenuItem.Name = "refreshPropertiesToolStripMenuItem";
            this.refreshPropertiesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.refreshPropertiesToolStripMenuItem.Text = "Refresh Properties";
            this.refreshPropertiesToolStripMenuItem.ToolTipText = "Refresh properties of this instant";
            this.refreshPropertiesToolStripMenuItem.Click += new System.EventHandler(this.refreshPropertiesToolStripMenuItem_Click);
            // 
            // pinsPanel
            // 
            this.pinsPanel.BackColor = System.Drawing.Color.Transparent;
            this.pinsPanel.Controls.Add(this.pin1);
            this.pinsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pinsPanel.Location = new System.Drawing.Point(0, 0);
            this.pinsPanel.Name = "pinsPanel";
            this.pinsPanel.Size = new System.Drawing.Size(10, 84);
            this.pinsPanel.TabIndex = 3;
            this.pinsPanel.Click += new System.EventHandler(this.digImage_Click);
            // 
            // pin1
            // 
            this.pin1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pin1.BackColor = System.Drawing.Color.White;
            this.pin1.Location = new System.Drawing.Point(0, 12);
            this.pin1.Name = "pin1";
            this.pin1.SignalFrom = "0";
            this.pin1.Size = new System.Drawing.Size(5, 5);
            this.pin1.State = false;
            this.pin1.TabIndex = 1;
            // 
            // digImage
            // 
            this.digImage.BackColor = System.Drawing.Color.Transparent;
            this.digImage.ContextMenuStrip = this.menu;
            this.digImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digImage.Image = global::Booleanism.Properties.Resources.two_inputs_and_gate;
            this.digImage.Location = new System.Drawing.Point(0, 0);
            this.digImage.Name = "digImage";
            this.digImage.Size = new System.Drawing.Size(150, 84);
            this.digImage.TabIndex = 0;
            this.digImage.TabStop = false;
            this.digImage.Click += new System.EventHandler(this.digImage_Click);
            this.digImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.digImage_MouseDown);
            this.digImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.digImage_MouseMove);
            this.digImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.digImage_MouseUp);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "label1";
            this.nameLabel.TextChanged += new System.EventHandler(this.nameLabel_TextChanged);
            // 
            // outputPin
            // 
            this.outputPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPin.BackColor = System.Drawing.Color.White;
            this.outputPin.Location = new System.Drawing.Point(145, 39);
            this.outputPin.Name = "outputPin";
            this.outputPin.SignalFrom = "0";
            this.outputPin.Size = new System.Drawing.Size(5, 5);
            this.outputPin.State = false;
            this.outputPin.TabIndex = 2;
            // 
            // Digital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.outputPin);
            this.Controls.Add(this.pinsPanel);
            this.Controls.Add(this.digImage);
            this.MaximumSize = new System.Drawing.Size(150, 84);
            this.MinimumSize = new System.Drawing.Size(150, 84);
            this.Name = "Digital";
            this.Size = new System.Drawing.Size(150, 84);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Digital_Paint);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pinsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        protected System.Windows.Forms.PictureBox digImage;
        protected System.Windows.Forms.Panel pinsPanel;
        protected Pin outputPin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshPropertiesToolStripMenuItem;
        protected System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ToolStripTextBox renameTxt;
        protected System.Windows.Forms.ContextMenuStrip menu;
        protected Pin pin1;
    }
}
