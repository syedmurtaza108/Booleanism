namespace Booleanism
{
    partial class SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.roundTextBox2 = new Booleanism.RoundTextBox();
            this.roundTextBox1 = new Booleanism.RoundTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 265);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.Enabled = false;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(138, 399);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Send";
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Problem Description:";
            // 
            // roundTextBox2
            // 
            this.roundTextBox2.AllowedCharacters = 32767;
            this.roundTextBox2.Location = new System.Drawing.Point(78, 56);
            this.roundTextBox2.LongRoundTextBox = true;
            this.roundTextBox2.Name = "roundTextBox2";
            this.roundTextBox2.OnlyCharactersAndSymbols = false;
            this.roundTextBox2.OnlyNumbersAndSymbols = false;
            this.roundTextBox2.RoundText = "";
            this.roundTextBox2.Size = new System.Drawing.Size(315, 38);
            this.roundTextBox2.TabIndex = 2;
            this.roundTextBox2.WritingEnabled = true;
            this.roundTextBox2.RoundTextChanged += new Booleanism.TextDelegate(this.roundTextBox2_RoundTextChanged);
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.AllowedCharacters = 32767;
            this.roundTextBox1.Location = new System.Drawing.Point(78, 12);
            this.roundTextBox1.LongRoundTextBox = true;
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.OnlyCharactersAndSymbols = false;
            this.roundTextBox1.OnlyNumbersAndSymbols = false;
            this.roundTextBox1.RoundText = "";
            this.roundTextBox1.Size = new System.Drawing.Size(315, 38);
            this.roundTextBox1.TabIndex = 0;
            this.roundTextBox1.WritingEnabled = true;
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "SendMail";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Your Complaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundTextBox roundTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RoundTextBox roundTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
    }
}