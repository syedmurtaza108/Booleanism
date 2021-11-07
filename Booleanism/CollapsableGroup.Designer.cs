namespace Booleanism
{
    partial class CollapsableGroup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.collapseBtn = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.collapseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 24);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // collapseBtn
            // 
            this.collapseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapseBtn.Image = global::Booleanism.Properties.Resources.collapse;
            this.collapseBtn.Location = new System.Drawing.Point(6, 4);
            this.collapseBtn.Name = "collapseBtn";
            this.collapseBtn.Size = new System.Drawing.Size(16, 16);
            this.collapseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.collapseBtn.TabIndex = 0;
            this.collapseBtn.TabStop = false;
            this.collapseBtn.MouseLeave += new System.EventHandler(this.collapseBtn_MouseLeave);
            this.collapseBtn.MouseHover += new System.EventHandler(this.collapseBtn_MouseHover);
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 24);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(104, 42);
            this.containerPanel.TabIndex = 1;
            // 
            // CollapsableGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel1);
            this.Name = "CollapsableGroup";
            this.Size = new System.Drawing.Size(104, 66);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox collapseBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel containerPanel;
    }
}
