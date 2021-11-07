using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booleanism
{
    public delegate void TextDelegate(object sender, EventArgs e);

    public partial class RoundTextBox : UserControl
    {
        public event TextDelegate RoundTextChanged;
        bool onlyNum;
        bool onlyCharacters;
        bool longTextBox;

        public RoundTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the maximum number of allowed characters of RoundTextBox.
        /// </summary>
        public int AllowedCharacters { get { return textBox1.MaxLength; } set { textBox1.MaxLength = value; } }

        /// <summary>
        /// Gets or sets the text of round text box.
        /// </summary>
        public string RoundText { get { return textBox1.Text; } set { textBox1.Text = value; textBox1.Name = "t" + this.Name; } }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (RoundTextChanged != null)
                this.RoundTextChanged(sender, e);
            if (textBox1.Text.Length != 0 && onlyNum)
            {
                if ((textBox1.Text[textBox1.Text.Length - 1] > 'A' && textBox1.Text[textBox1.Text.Length - 1] < 'Z')
                    || (textBox1.Text[textBox1.Text.Length - 1] > 'a' && textBox1.Text[textBox1.Text.Length - 1] < 'z'))
                {
                    char[] temp = textBox1.Text.ToCharArray();
                    textBox1.Clear();

                    for (int i = 0; i < temp.Length - 1; i++)
                        textBox1.Text += temp[i];

                    textBox1.SelectionStart = textBox1.Text.Length;     //Sets the cursor at the end
                }
            }
            else if (textBox1.Text.Length != 0 && onlyCharacters)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] >= '0' && textBox1.Text[textBox1.Text.Length - 1] <= '9')
                {
                    char[] temp = textBox1.Text.ToCharArray();
                    textBox1.Clear();

                    for (int i = 0; i < temp.Length - 1; i++)
                        textBox1.Text += temp[i];

                    textBox1.SelectionStart = textBox1.Text.Length;     //Sets the cursor at the end
                }
            }

        }

        /// <summary>
        /// Checks or sets whether the RoundTextBox is allowed to write or not.
        /// </summary>
        public bool WritingEnabled { get { return !textBox1.ReadOnly; } set { textBox1.ReadOnly = value; textBox1.ReadOnly = !textBox1.ReadOnly; } }

        /// <summary>
        /// Checks or sets whether only numbers and symbols are allowed or not.
        /// </summary>
        public bool OnlyNumbersAndSymbols { get { return onlyNum; } set
            {
                onlyNum = value;
                textBox1.Clear();
            }
        }

        public bool LongRoundTextBox { get { return longTextBox; } set {
                longTextBox = value;
                if (longTextBox)
                    pictureBox1.Image = Properties.Resources.long_text_back;
                else
                    pictureBox1.Image = Properties.Resources.text_back;
            }
        }

        /// <summary>
        /// Checks or sets whether only characters and symbols are allowed or not.
        /// </summary>
        public bool OnlyCharactersAndSymbols { get {return onlyCharacters; } set {onlyCharacters = value; textBox1.Clear(); } }
        
    }
}

    

