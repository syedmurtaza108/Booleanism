namespace Booleanism
{
    partial class SideButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideButton));
            this.sideBtnText = new System.Windows.Forms.Label();
            this.sideBtnImage = new System.Windows.Forms.PictureBox();
            this.msgTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sideBtnImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBtnText
            // 
            this.sideBtnText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBtnText.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtnText.ForeColor = System.Drawing.Color.White;
            this.sideBtnText.Location = new System.Drawing.Point(42, 0);
            this.sideBtnText.Name = "sideBtnText";
            this.sideBtnText.Size = new System.Drawing.Size(150, 60);
            this.sideBtnText.TabIndex = 5;
            this.sideBtnText.Text = "Home";
            this.sideBtnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtnText.Click += new System.EventHandler(this.sideBtnText_Click);
            this.sideBtnText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sideBtnImage_MouseDown);
            this.sideBtnText.MouseLeave += new System.EventHandler(this.sideBtnText_MouseLeave);
            this.sideBtnText.MouseHover += new System.EventHandler(this.sideBtnText_MouseHover);
            // 
            // sideBtnImage
            // 
            this.sideBtnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBtnImage.Image = ((System.Drawing.Image)(resources.GetObject("sideBtnImage.Image")));
            this.sideBtnImage.Location = new System.Drawing.Point(0, 0);
            this.sideBtnImage.Name = "sideBtnImage";
            this.sideBtnImage.Size = new System.Drawing.Size(42, 60);
            this.sideBtnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sideBtnImage.TabIndex = 4;
            this.sideBtnImage.TabStop = false;
            this.sideBtnImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sideBtnImage_MouseDown);
            // 
            // msgTip
            // 
            this.msgTip.BackColor = System.Drawing.Color.Red;
            this.msgTip.ForeColor = System.Drawing.Color.White;
            this.msgTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.msgTip.ToolTipTitle = "The Tech Valley - Software";
            // 
            // SideButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.Controls.Add(this.sideBtnText);
            this.Controls.Add(this.sideBtnImage);
            this.Name = "SideButton";
            this.Size = new System.Drawing.Size(192, 60);
            this.Click += new System.EventHandler(this.sideBtnText_Click);
            this.MouseLeave += new System.EventHandler(this.sideBtnText_MouseLeave);
            this.MouseHover += new System.EventHandler(this.sideBtnText_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.sideBtnImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sideBtnText;
        private System.Windows.Forms.PictureBox sideBtnImage;
        private System.Windows.Forms.ToolTip msgTip;
    }
}
