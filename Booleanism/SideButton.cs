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
    public delegate void SideButtonClick(object sender, EventArgs e);
    public delegate void SideButtonMouseDown(object sender, MouseEventArgs e);
    /// <summary>
    /// Gives the features of side button.
    /// </summary>
    public partial class SideButton : UserControl
    {
        Color normalColor = Color.OrangeRed;
        Color hoverColor = Color.Coral;
        string toolTipTxt = "This is The Tech Valley.";
        public event SideButtonClick SideButtonClick;
        public event SideButtonMouseDown SideButtonMouseDown;

        public SideButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets 0r sets the text of Side button.
        /// </summary>
        public string SideButtonText { get {return sideBtnText.Text; } set {sideBtnText.Text = value; } }

        /// <summary>
        /// Gets or sets the image of Side button.
        /// </summary>
        public Image SideButtonImage { get {return sideBtnImage.Image; } set {sideBtnImage.Image = value; } }

        /// <summary>
        /// Gets or sets the color of Side button.
        /// </summary>
        public Color SideButtonColor { get {return BackColor; } set {BackColor = value; } }

        /// <summary>
        /// Gets or sets the normal color of side button when mouse's cursor is not on the button.
        /// </summary>
        public Color NormalColor { get {return normalColor; } set {normalColor = value; } }

        /// <summary>
        /// Gets or sets the color of button when the cursor is on the top.
        /// </summary>
        public Color HoverColor { get {return hoverColor; } set {hoverColor = value; } }

        /// <summary>
        /// Gets or sets the Tool Tip text appearing on the control.
        /// </summary>
        public string ToolTipText { get {return toolTipTxt; } set {toolTipTxt = value; msgTip.SetToolTip(sideBtnText, value); msgTip.SetToolTip(sideBtnImage, value); } }

        public Font TextFont { get { return sideBtnText.Font; } set {sideBtnText.Font = value; } }

        public Color TextColor { get { return sideBtnText.ForeColor; } set {sideBtnText.ForeColor = value; } }

        private void sideBtnText_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = hoverColor;
            sideBtnText.BackColor = hoverColor;
            sideBtnImage.BackColor = hoverColor;
        }

        private void sideBtnText_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = normalColor;
            sideBtnText.BackColor = normalColor;
            sideBtnImage.BackColor = normalColor;
        }

        private void sideBtnText_Click(object sender, EventArgs e)
        {
            if(SideButtonClick != null)
                this.SideButtonClick(sender, e);
        }

        private void sideBtnImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (SideButtonMouseDown != null)
                this.SideButtonMouseDown(sender, e);
        }
    }
}
