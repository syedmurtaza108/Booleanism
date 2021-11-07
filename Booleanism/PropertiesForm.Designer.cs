namespace Booleanism
{
    partial class PropertiesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.configPanelOuter = new System.Windows.Forms.Panel();
            this.pinToolboxBtn = new System.Windows.Forms.PictureBox();
            this.configPanel = new System.Windows.Forms.Panel();
            this.configPanelOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinToolboxBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // configPanelOuter
            // 
            this.configPanelOuter.BackColor = System.Drawing.Color.PeachPuff;
            this.configPanelOuter.Controls.Add(this.pinToolboxBtn);
            this.configPanelOuter.Controls.Add(this.configPanel);
            this.configPanelOuter.Dock = System.Windows.Forms.DockStyle.Right;
            this.configPanelOuter.Location = new System.Drawing.Point(0, 0);
            this.configPanelOuter.Name = "configPanelOuter";
            this.configPanelOuter.Size = new System.Drawing.Size(177, 342);
            this.configPanelOuter.TabIndex = 5;
            // 
            // pinToolboxBtn
            // 
            this.pinToolboxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinToolboxBtn.Image = global::Booleanism.Properties.Resources.pin_icon;
            this.pinToolboxBtn.Location = new System.Drawing.Point(159, 9);
            this.pinToolboxBtn.Name = "pinToolboxBtn";
            this.pinToolboxBtn.Size = new System.Drawing.Size(14, 15);
            this.pinToolboxBtn.TabIndex = 6;
            this.pinToolboxBtn.TabStop = false;
            this.pinToolboxBtn.Click += new System.EventHandler(this.pinToolboxBtn_Click);
            // 
            // configPanel
            // 
            this.configPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.configPanel.BackColor = System.Drawing.Color.Linen;
            this.configPanel.Location = new System.Drawing.Point(0, 33);
            this.configPanel.Name = "configPanel";
            this.configPanel.Size = new System.Drawing.Size(177, 309);
            this.configPanel.TabIndex = 0;
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 342);
            this.ControlBox = false;
            this.Controls.Add(this.configPanelOuter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.TopMost = true;
            this.configPanelOuter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pinToolboxBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel configPanelOuter;
        private System.Windows.Forms.PictureBox pinToolboxBtn;
        public System.Windows.Forms.Panel configPanel;
    }
}