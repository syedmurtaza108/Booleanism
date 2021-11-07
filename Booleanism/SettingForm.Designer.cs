namespace Booleanism
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.color3Btn = new System.Windows.Forms.Button();
            this.color2Btn = new System.Windows.Forms.Button();
            this.color1Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.demoPanel = new System.Windows.Forms.Panel();
            this.wireSizeCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clearRecentFiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clearTxtBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.color3Btn);
            this.groupBox1.Controls.Add(this.color2Btn);
            this.groupBox1.Controls.Add(this.color1Btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wire Colors:";
            // 
            // color3Btn
            // 
            this.color3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color3Btn.Location = new System.Drawing.Point(274, 37);
            this.color3Btn.Name = "color3Btn";
            this.color3Btn.Size = new System.Drawing.Size(55, 23);
            this.color3Btn.TabIndex = 6;
            this.color3Btn.UseVisualStyleBackColor = true;
            this.color3Btn.Click += new System.EventHandler(this.color1Btn_Click);
            // 
            // color2Btn
            // 
            this.color2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color2Btn.Location = new System.Drawing.Point(163, 37);
            this.color2Btn.Name = "color2Btn";
            this.color2Btn.Size = new System.Drawing.Size(55, 23);
            this.color2Btn.TabIndex = 5;
            this.color2Btn.UseVisualStyleBackColor = true;
            this.color2Btn.Click += new System.EventHandler(this.color1Btn_Click);
            // 
            // color1Btn
            // 
            this.color1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color1Btn.Location = new System.Drawing.Point(52, 38);
            this.color1Btn.Name = "color1Btn";
            this.color1Btn.Size = new System.Drawing.Size(55, 23);
            this.color1Btn.TabIndex = 4;
            this.color1Btn.UseVisualStyleBackColor = true;
            this.color1Btn.Click += new System.EventHandler(this.color1Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F);
            this.label4.Location = new System.Drawing.Point(224, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.Location = new System.Drawing.Point(113, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose three default colors of wires";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.demoPanel);
            this.groupBox2.Controls.Add(this.wireSizeCombo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wire Size:";
            // 
            // demoPanel
            // 
            this.demoPanel.Location = new System.Drawing.Point(256, 16);
            this.demoPanel.Name = "demoPanel";
            this.demoPanel.Size = new System.Drawing.Size(73, 23);
            this.demoPanel.TabIndex = 2;
            this.demoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.demoPanel_Paint);
            // 
            // wireSizeCombo
            // 
            this.wireSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wireSizeCombo.FormattingEnabled = true;
            this.wireSizeCombo.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0"});
            this.wireSizeCombo.Location = new System.Drawing.Point(163, 16);
            this.wireSizeCombo.Name = "wireSizeCombo";
            this.wireSizeCombo.Size = new System.Drawing.Size(90, 23);
            this.wireSizeCombo.TabIndex = 1;
            this.wireSizeCombo.SelectedIndexChanged += new System.EventHandler(this.wireSizeCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Choose the size of wires:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.clearRecentFiles);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recent Files:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(239, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(202, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Add:";
            // 
            // clearRecentFiles
            // 
            this.clearRecentFiles.ForeColor = System.Drawing.Color.Black;
            this.clearRecentFiles.Location = new System.Drawing.Point(68, 15);
            this.clearRecentFiles.Name = "clearRecentFiles";
            this.clearRecentFiles.Size = new System.Drawing.Size(90, 23);
            this.clearRecentFiles.TabIndex = 2;
            this.clearRecentFiles.Text = "Clear All";
            this.clearRecentFiles.UseVisualStyleBackColor = true;
            this.clearRecentFiles.Click += new System.EventHandler(this.clearRecentFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Clear All:";
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Booleanism File(.bool)|*.bool";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clearTxtBtn);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(12, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 47);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Startup File:";
            // 
            // clearTxtBtn
            // 
            this.clearTxtBtn.ForeColor = System.Drawing.Color.Black;
            this.clearTxtBtn.Location = new System.Drawing.Point(286, 19);
            this.clearTxtBtn.Name = "clearTxtBtn";
            this.clearTxtBtn.Size = new System.Drawing.Size(43, 23);
            this.clearTxtBtn.TabIndex = 8;
            this.clearTxtBtn.Text = "x";
            this.clearTxtBtn.UseVisualStyleBackColor = true;
            this.clearTxtBtn.Click += new System.EventHandler(this.clearTxtBtn_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(239, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBox1.Location = new System.Drawing.Point(9, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 21);
            this.textBox1.TabIndex = 5;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::Booleanism.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(175, 263);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 23);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "&Cancel";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = global::Booleanism.Properties.Resources.saveicon_16x16;
            this.saveBtn.Location = new System.Drawing.Point(62, 263);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "&Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 294);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button color1Btn;
        private System.Windows.Forms.Button color3Btn;
        private System.Windows.Forms.Button color2Btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox wireSizeCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearRecentFiles;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel demoPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clearTxtBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}