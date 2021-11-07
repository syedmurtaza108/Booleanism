namespace Booleanism
{
    partial class TableTool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.truthTableTxt = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 36);
            this.panel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.Red;
            this.nameLabel.Location = new System.Drawing.Point(4, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(171, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Select a valid component";
            this.nameLabel.TextChanged += new System.EventHandler(this.nameLabel_TextChanged);
            // 
            // truthTableTxt
            // 
            this.truthTableTxt.BackColor = System.Drawing.Color.White;
            this.truthTableTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truthTableTxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truthTableTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.truthTableTxt.Location = new System.Drawing.Point(0, 36);
            this.truthTableTxt.Name = "truthTableTxt";
            this.truthTableTxt.ReadOnly = true;
            this.truthTableTxt.Size = new System.Drawing.Size(243, 273);
            this.truthTableTxt.TabIndex = 3;
            this.truthTableTxt.Text = "";
            this.truthTableTxt.WordWrap = false;
            // 
            // TableTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 309);
            this.ControlBox = false;
            this.Controls.Add(this.truthTableTxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TableTool";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TableTool";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TableTool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox truthTableTxt;
        private System.Windows.Forms.Label nameLabel;
    }
}