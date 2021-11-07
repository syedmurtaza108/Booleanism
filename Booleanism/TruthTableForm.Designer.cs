namespace Booleanism
{
    partial class TruthTableForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruthTableForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.instructionLabel = new System.Windows.Forms.LinkLabel();
            this.pageSetupBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.truthTableTxt = new System.Windows.Forms.RichTextBox();
            this.sDia = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.truthTableDoc = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instructionLabel);
            this.panel1.Controls.Add(this.pageSetupBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.printBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 80);
            this.panel1.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(35, 17);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(495, 13);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.TabStop = true;
            this.instructionLabel.Text = "Note: This tool generates the truth table with respect importing the components i" +
    "n Booleanism V 1.0 ......";
            this.toolTip1.SetToolTip(this.instructionLabel, "Click here for more!");
            this.instructionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.instructionLabel_LinkClicked);
            // 
            // pageSetupBtn
            // 
            this.pageSetupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageSetupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageSetupBtn.Image = global::Booleanism.Properties.Resources.page_16x16;
            this.pageSetupBtn.Location = new System.Drawing.Point(238, 45);
            this.pageSetupBtn.Name = "pageSetupBtn";
            this.pageSetupBtn.Size = new System.Drawing.Size(107, 23);
            this.pageSetupBtn.TabIndex = 4;
            this.pageSetupBtn.Text = "Pa&ge Setup";
            this.pageSetupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.pageSetupBtn, "Change the specifications of the page before printing.");
            this.pageSetupBtn.UseVisualStyleBackColor = true;
            this.pageSetupBtn.Click += new System.EventHandler(this.pageSetupBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Booleanism.Properties.Resources.printpre_16x16;
            this.button1.Location = new System.Drawing.Point(125, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print Pre&view";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button1, "Preview the the truth table before printing.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::Booleanism.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(464, 45);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.exitBtn, "Close this window.");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Image = global::Booleanism.Properties.Resources.print_16x16;
            this.printBtn.Location = new System.Drawing.Point(351, 45);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(107, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "&Print";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.printBtn, "Print the truth table.");
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = global::Booleanism.Properties.Resources.saveicon_16x16;
            this.saveBtn.Location = new System.Drawing.Point(12, 45);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "&Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.saveBtn, "Save the truth table in .txt, .rtf, .html and etc file formats");
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // truthTableTxt
            // 
            this.truthTableTxt.BackColor = System.Drawing.Color.White;
            this.truthTableTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truthTableTxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truthTableTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.truthTableTxt.Location = new System.Drawing.Point(0, 0);
            this.truthTableTxt.Name = "truthTableTxt";
            this.truthTableTxt.ReadOnly = true;
            this.truthTableTxt.Size = new System.Drawing.Size(585, 349);
            this.truthTableTxt.TabIndex = 1;
            this.truthTableTxt.Text = "";
            this.truthTableTxt.WordWrap = false;
            // 
            // sDia
            // 
            this.sDia.Filter = "Plain Text File(.txt) |*.txt|Rich Text File(RTF)|*.rtf |Hyper Text Markup Languag" +
    "e(HTML)|*.html|All Files|*.*";
            this.sDia.Title = "Save Truth Table";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.truthTableDoc;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // truthTableDoc
            // 
            this.truthTableDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.truthTableDoc_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.truthTableDoc;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.truthTableDoc;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Booleanism V 1.0 Help:";
            // 
            // TruthTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 429);
            this.Controls.Add(this.truthTableTxt);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TruthTableForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TruthTableForm";
            this.Load += new System.EventHandler(this.TruthTableForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox truthTableTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.SaveFileDialog sDia;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument truthTableDoc;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pageSetupBtn;
        private System.Windows.Forms.LinkLabel instructionLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}