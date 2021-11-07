
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Booleanism
{
	/// <summary>
	/// Summary description for ToolBox.
	/// </summary>
	public class ToolBoxView : System.Windows.Forms.UserControl
	{
        private System.Windows.Forms.Panel panelToolBox;
		public Syncfusion.Windows.Forms.Tools.GroupBar gBToolBox;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gateTab;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gvbComponents;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gvbWindowsForm;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gvbGeneral;
		private System.Windows.Forms.ImageList largeImageList;
		private System.Windows.Forms.ImageList dockingImageList;
        private Panel panel2;
        private Panel panel1;
        private SideButton sideButton1;
        private SideButton sideButton2;
        private SideButton sideButton3;
        private SideButton sideButton4;
        private SideButton sideButton8;
        private SideButton sideButton7;
        private SideButton sideButton6;
        private SideButton sideButton5;
        private SideButton sideButton12;
        private SideButton sideButton11;
        private SideButton sideButton10;
        private SideButton sideButton9;
        private SideButton sideButton16;
        private SideButton sideButton15;
        private SideButton sideButton14;
        private SideButton sideButton13;
        private SideButton sideButton20;
        private SideButton sideButton19;
        private SideButton sideButton18;
        private SideButton sideButton17;
        private SideButton sideButton21;
        private SideButton sideButton22;
        private SideButton sideButton24;
        private SideButton sideButton23;
        private Panel panel3;
        private SideButton sideButton25;
        private SideButton sideButton26;
        private Panel panel4;
        private SideButton sideButton27;
        private SideButton sideButton32;
        private SideButton sideButton31;
        private SideButton sideButton30;
        private SideButton sideButton29;
        private SideButton sideButton28;
        private SideButton sideButton36;
        private SideButton sideButton35;
        private SideButton sideButton34;
        private SideButton sideButton33;
        private System.ComponentModel.IContainer components;

		public ToolBoxView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
            this.gBToolBox.HeaderBackColor = Color.FromArgb(0, 122, 204);
			// TODO: Add any initialization after the InitForm call

		}

        public Form2 Form { get; set; }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

    
        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBoxView));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.gBToolBox = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sideButton21 = new Booleanism.SideButton();
            this.sideButton20 = new Booleanism.SideButton();
            this.sideButton19 = new Booleanism.SideButton();
            this.sideButton18 = new Booleanism.SideButton();
            this.sideButton17 = new Booleanism.SideButton();
            this.sideButton16 = new Booleanism.SideButton();
            this.sideButton15 = new Booleanism.SideButton();
            this.sideButton14 = new Booleanism.SideButton();
            this.sideButton13 = new Booleanism.SideButton();
            this.sideButton12 = new Booleanism.SideButton();
            this.sideButton11 = new Booleanism.SideButton();
            this.sideButton10 = new Booleanism.SideButton();
            this.sideButton9 = new Booleanism.SideButton();
            this.sideButton8 = new Booleanism.SideButton();
            this.sideButton7 = new Booleanism.SideButton();
            this.sideButton6 = new Booleanism.SideButton();
            this.sideButton5 = new Booleanism.SideButton();
            this.sideButton4 = new Booleanism.SideButton();
            this.sideButton3 = new Booleanism.SideButton();
            this.sideButton2 = new Booleanism.SideButton();
            this.sideButton1 = new Booleanism.SideButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sideButton36 = new Booleanism.SideButton();
            this.sideButton35 = new Booleanism.SideButton();
            this.sideButton34 = new Booleanism.SideButton();
            this.sideButton33 = new Booleanism.SideButton();
            this.sideButton32 = new Booleanism.SideButton();
            this.sideButton31 = new Booleanism.SideButton();
            this.sideButton30 = new Booleanism.SideButton();
            this.sideButton29 = new Booleanism.SideButton();
            this.sideButton28 = new Booleanism.SideButton();
            this.sideButton27 = new Booleanism.SideButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sideButton26 = new Booleanism.SideButton();
            this.sideButton25 = new Booleanism.SideButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideButton24 = new Booleanism.SideButton();
            this.sideButton23 = new Booleanism.SideButton();
            this.sideButton22 = new Booleanism.SideButton();
            this.gateTab = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gvbComponents = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gvbWindowsForm = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gvbGeneral = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gBToolBox)).BeginInit();
            this.gBToolBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.Controls.Add(this.gBToolBox);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(216, 568);
            this.panelToolBox.TabIndex = 0;
            // 
            // gBToolBox
            // 
            this.gBToolBox.AllowDrop = true;
            this.gBToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gBToolBox.BeforeTouchSize = new System.Drawing.Size(216, 568);
            this.gBToolBox.BorderColor = System.Drawing.Color.White;
            this.gBToolBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gBToolBox.CollapseImage = ((System.Drawing.Image)(resources.GetObject("gBToolBox.CollapseImage")));
            this.gBToolBox.Controls.Add(this.panel3);
            this.gBToolBox.Controls.Add(this.panel2);
            this.gBToolBox.Controls.Add(this.panel4);
            this.gBToolBox.Controls.Add(this.panel1);
            this.gBToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBToolBox.ExpandButtonToolTip = null;
            this.gBToolBox.ExpandImage = ((System.Drawing.Image)(resources.GetObject("gBToolBox.ExpandImage")));
            this.gBToolBox.FlatLook = true;
            this.gBToolBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBToolBox.ForeColor = System.Drawing.Color.White;
            this.gBToolBox.GroupBarDropDownToolTip = null;
            this.gBToolBox.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.gateTab,
            this.gvbComponents,
            this.gvbWindowsForm,
            this.gvbGeneral});
            this.gBToolBox.IndexOnVisibleItems = true;
            this.gBToolBox.Location = new System.Drawing.Point(0, 0);
            this.gBToolBox.MinimizeButtonToolTip = null;
            this.gBToolBox.Name = "gBToolBox";
            this.gBToolBox.NavigationPaneTooltip = null;
            this.gBToolBox.PopupClientSize = new System.Drawing.Size(0, 0);
            this.gBToolBox.SelectedItem = 2;
            this.gBToolBox.ShowItemImageInHeader = true;
            this.gBToolBox.Size = new System.Drawing.Size(216, 568);
            this.gBToolBox.SmartSizeBox = false;
            this.gBToolBox.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.gBToolBox.TabIndex = 0;
            this.gBToolBox.Text = "groupBar1";
            this.gBToolBox.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.sideButton21);
            this.panel2.Controls.Add(this.sideButton20);
            this.panel2.Controls.Add(this.sideButton19);
            this.panel2.Controls.Add(this.sideButton18);
            this.panel2.Controls.Add(this.sideButton17);
            this.panel2.Controls.Add(this.sideButton16);
            this.panel2.Controls.Add(this.sideButton15);
            this.panel2.Controls.Add(this.sideButton14);
            this.panel2.Controls.Add(this.sideButton13);
            this.panel2.Controls.Add(this.sideButton12);
            this.panel2.Controls.Add(this.sideButton11);
            this.panel2.Controls.Add(this.sideButton10);
            this.panel2.Controls.Add(this.sideButton9);
            this.panel2.Controls.Add(this.sideButton8);
            this.panel2.Controls.Add(this.sideButton7);
            this.panel2.Controls.Add(this.sideButton6);
            this.panel2.Controls.Add(this.sideButton5);
            this.panel2.Controls.Add(this.sideButton4);
            this.panel2.Controls.Add(this.sideButton3);
            this.panel2.Controls.Add(this.sideButton2);
            this.panel2.Controls.Add(this.sideButton1);
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 0);
            this.panel2.TabIndex = 37;
            // 
            // sideButton21
            // 
            this.sideButton21.BackColor = System.Drawing.Color.White;
            this.sideButton21.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton21.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton21.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton21.Location = new System.Drawing.Point(0, 720);
            this.sideButton21.Name = "sideButton21";
            this.sideButton21.NormalColor = System.Drawing.Color.White;
            this.sideButton21.SideButtonColor = System.Drawing.Color.White;
            this.sideButton21.SideButtonImage = global::Booleanism.Properties.Resources.not_gate;
            this.sideButton21.SideButtonText = "Not Gate";
            this.sideButton21.Size = new System.Drawing.Size(216, 36);
            this.sideButton21.TabIndex = 20;
            this.sideButton21.TextColor = System.Drawing.Color.Black;
            this.sideButton21.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton21.ToolTipText = "";
            this.sideButton21.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton21_SideButtonMouseDown);
            // 
            // sideButton20
            // 
            this.sideButton20.BackColor = System.Drawing.Color.White;
            this.sideButton20.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton20.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton20.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton20.Location = new System.Drawing.Point(0, 684);
            this.sideButton20.Name = "sideButton20";
            this.sideButton20.NormalColor = System.Drawing.Color.White;
            this.sideButton20.SideButtonColor = System.Drawing.Color.White;
            this.sideButton20.SideButtonImage = global::Booleanism.Properties.Resources.five_inp_nor_gate;
            this.sideButton20.SideButtonText = "5 Inputs Nor Gate";
            this.sideButton20.Size = new System.Drawing.Size(216, 36);
            this.sideButton20.TabIndex = 19;
            this.sideButton20.TextColor = System.Drawing.Color.Black;
            this.sideButton20.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton20.ToolTipText = "";
            this.sideButton20.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton20_SideButtonMouseDown);
            // 
            // sideButton19
            // 
            this.sideButton19.BackColor = System.Drawing.Color.White;
            this.sideButton19.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton19.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton19.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton19.Location = new System.Drawing.Point(0, 648);
            this.sideButton19.Name = "sideButton19";
            this.sideButton19.NormalColor = System.Drawing.Color.White;
            this.sideButton19.SideButtonColor = System.Drawing.Color.White;
            this.sideButton19.SideButtonImage = global::Booleanism.Properties.Resources.four_inp_nor_gate;
            this.sideButton19.SideButtonText = "4 Inputs Nor Gate";
            this.sideButton19.Size = new System.Drawing.Size(216, 36);
            this.sideButton19.TabIndex = 18;
            this.sideButton19.TextColor = System.Drawing.Color.Black;
            this.sideButton19.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton19.ToolTipText = "";
            this.sideButton19.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton19_SideButtonMouseDown);
            // 
            // sideButton18
            // 
            this.sideButton18.BackColor = System.Drawing.Color.White;
            this.sideButton18.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton18.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton18.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton18.Location = new System.Drawing.Point(0, 612);
            this.sideButton18.Name = "sideButton18";
            this.sideButton18.NormalColor = System.Drawing.Color.White;
            this.sideButton18.SideButtonColor = System.Drawing.Color.White;
            this.sideButton18.SideButtonImage = global::Booleanism.Properties.Resources.three_inp_nor_gate;
            this.sideButton18.SideButtonText = "3 Inputs Nor Gate";
            this.sideButton18.Size = new System.Drawing.Size(216, 36);
            this.sideButton18.TabIndex = 17;
            this.sideButton18.TextColor = System.Drawing.Color.Black;
            this.sideButton18.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton18.ToolTipText = "";
            this.sideButton18.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton18_SideButtonMouseDown);
            // 
            // sideButton17
            // 
            this.sideButton17.BackColor = System.Drawing.Color.White;
            this.sideButton17.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton17.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton17.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton17.Location = new System.Drawing.Point(0, 576);
            this.sideButton17.Name = "sideButton17";
            this.sideButton17.NormalColor = System.Drawing.Color.White;
            this.sideButton17.SideButtonColor = System.Drawing.Color.White;
            this.sideButton17.SideButtonImage = global::Booleanism.Properties.Resources.two_inp_nor_gate;
            this.sideButton17.SideButtonText = "2 Inputs Nor Gate";
            this.sideButton17.Size = new System.Drawing.Size(216, 36);
            this.sideButton17.TabIndex = 16;
            this.sideButton17.TextColor = System.Drawing.Color.Black;
            this.sideButton17.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton17.ToolTipText = "";
            this.sideButton17.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton17_SideButtonMouseDown);
            // 
            // sideButton16
            // 
            this.sideButton16.BackColor = System.Drawing.Color.White;
            this.sideButton16.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton16.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton16.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton16.Location = new System.Drawing.Point(0, 540);
            this.sideButton16.Name = "sideButton16";
            this.sideButton16.NormalColor = System.Drawing.Color.White;
            this.sideButton16.SideButtonColor = System.Drawing.Color.White;
            this.sideButton16.SideButtonImage = global::Booleanism.Properties.Resources.five_inp_nand_gate1;
            this.sideButton16.SideButtonText = "5 Inputs Nand Gate";
            this.sideButton16.Size = new System.Drawing.Size(216, 36);
            this.sideButton16.TabIndex = 15;
            this.sideButton16.TextColor = System.Drawing.Color.Black;
            this.sideButton16.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton16.ToolTipText = "";
            this.sideButton16.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton16_SideButtonMouseDown);
            // 
            // sideButton15
            // 
            this.sideButton15.BackColor = System.Drawing.Color.White;
            this.sideButton15.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton15.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton15.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton15.Location = new System.Drawing.Point(0, 504);
            this.sideButton15.Name = "sideButton15";
            this.sideButton15.NormalColor = System.Drawing.Color.White;
            this.sideButton15.SideButtonColor = System.Drawing.Color.White;
            this.sideButton15.SideButtonImage = global::Booleanism.Properties.Resources.four_inp_nand_gate;
            this.sideButton15.SideButtonText = "4 Inputs Nand Gate";
            this.sideButton15.Size = new System.Drawing.Size(216, 36);
            this.sideButton15.TabIndex = 14;
            this.sideButton15.TextColor = System.Drawing.Color.Black;
            this.sideButton15.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton15.ToolTipText = "";
            this.sideButton15.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton15_SideButtonMouseDown);
            // 
            // sideButton14
            // 
            this.sideButton14.BackColor = System.Drawing.Color.White;
            this.sideButton14.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton14.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton14.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton14.Location = new System.Drawing.Point(0, 468);
            this.sideButton14.Name = "sideButton14";
            this.sideButton14.NormalColor = System.Drawing.Color.White;
            this.sideButton14.SideButtonColor = System.Drawing.Color.White;
            this.sideButton14.SideButtonImage = global::Booleanism.Properties.Resources.three_inp_nand_gate;
            this.sideButton14.SideButtonText = "3 Inputs Nand Gate";
            this.sideButton14.Size = new System.Drawing.Size(216, 36);
            this.sideButton14.TabIndex = 13;
            this.sideButton14.TextColor = System.Drawing.Color.Black;
            this.sideButton14.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton14.ToolTipText = "";
            this.sideButton14.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton14_SideButtonMouseDown);
            // 
            // sideButton13
            // 
            this.sideButton13.BackColor = System.Drawing.Color.White;
            this.sideButton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton13.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton13.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton13.Location = new System.Drawing.Point(0, 432);
            this.sideButton13.Name = "sideButton13";
            this.sideButton13.NormalColor = System.Drawing.Color.White;
            this.sideButton13.SideButtonColor = System.Drawing.Color.White;
            this.sideButton13.SideButtonImage = global::Booleanism.Properties.Resources.two_inp_nand_gate;
            this.sideButton13.SideButtonText = "2 Inputs Nand Gate";
            this.sideButton13.Size = new System.Drawing.Size(216, 36);
            this.sideButton13.TabIndex = 12;
            this.sideButton13.TextColor = System.Drawing.Color.Black;
            this.sideButton13.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton13.ToolTipText = "";
            this.sideButton13.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton13_SideButtonMouseDown);
            // 
            // sideButton12
            // 
            this.sideButton12.BackColor = System.Drawing.Color.White;
            this.sideButton12.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton12.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton12.Location = new System.Drawing.Point(0, 396);
            this.sideButton12.Name = "sideButton12";
            this.sideButton12.NormalColor = System.Drawing.Color.White;
            this.sideButton12.SideButtonColor = System.Drawing.Color.White;
            this.sideButton12.SideButtonImage = global::Booleanism.Properties.Resources.five_inp_xor_gate;
            this.sideButton12.SideButtonText = "5 Inputs Xor Gate";
            this.sideButton12.Size = new System.Drawing.Size(216, 36);
            this.sideButton12.TabIndex = 11;
            this.sideButton12.TextColor = System.Drawing.Color.Black;
            this.sideButton12.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton12.ToolTipText = "";
            this.sideButton12.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton12_SideButtonMouseDown);
            // 
            // sideButton11
            // 
            this.sideButton11.BackColor = System.Drawing.Color.White;
            this.sideButton11.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton11.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton11.Location = new System.Drawing.Point(0, 360);
            this.sideButton11.Name = "sideButton11";
            this.sideButton11.NormalColor = System.Drawing.Color.White;
            this.sideButton11.SideButtonColor = System.Drawing.Color.White;
            this.sideButton11.SideButtonImage = global::Booleanism.Properties.Resources.four_inp_xor_gate;
            this.sideButton11.SideButtonText = "4 Inputs Xor Gate";
            this.sideButton11.Size = new System.Drawing.Size(216, 36);
            this.sideButton11.TabIndex = 10;
            this.sideButton11.TextColor = System.Drawing.Color.Black;
            this.sideButton11.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton11.ToolTipText = "";
            this.sideButton11.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton11_SideButtonMouseDown);
            // 
            // sideButton10
            // 
            this.sideButton10.BackColor = System.Drawing.Color.White;
            this.sideButton10.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton10.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton10.Location = new System.Drawing.Point(0, 324);
            this.sideButton10.Name = "sideButton10";
            this.sideButton10.NormalColor = System.Drawing.Color.White;
            this.sideButton10.SideButtonColor = System.Drawing.Color.White;
            this.sideButton10.SideButtonImage = global::Booleanism.Properties.Resources.three_inp_xor_gate;
            this.sideButton10.SideButtonText = "3 Inputs Xor Gate";
            this.sideButton10.Size = new System.Drawing.Size(216, 36);
            this.sideButton10.TabIndex = 9;
            this.sideButton10.TextColor = System.Drawing.Color.Black;
            this.sideButton10.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton10.ToolTipText = "";
            this.sideButton10.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton10_SideButtonMouseDown);
            // 
            // sideButton9
            // 
            this.sideButton9.BackColor = System.Drawing.Color.White;
            this.sideButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton9.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton9.Location = new System.Drawing.Point(0, 288);
            this.sideButton9.Name = "sideButton9";
            this.sideButton9.NormalColor = System.Drawing.Color.White;
            this.sideButton9.SideButtonColor = System.Drawing.Color.White;
            this.sideButton9.SideButtonImage = global::Booleanism.Properties.Resources.two_inp_xor_gate;
            this.sideButton9.SideButtonText = "2 Inputs Xor Gate";
            this.sideButton9.Size = new System.Drawing.Size(216, 36);
            this.sideButton9.TabIndex = 8;
            this.sideButton9.TextColor = System.Drawing.Color.Black;
            this.sideButton9.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton9.ToolTipText = "";
            this.sideButton9.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton9_SideButtonMouseDown);
            // 
            // sideButton8
            // 
            this.sideButton8.BackColor = System.Drawing.Color.White;
            this.sideButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton8.Location = new System.Drawing.Point(0, 252);
            this.sideButton8.Name = "sideButton8";
            this.sideButton8.NormalColor = System.Drawing.Color.White;
            this.sideButton8.SideButtonColor = System.Drawing.Color.White;
            this.sideButton8.SideButtonImage = global::Booleanism.Properties.Resources.five_inp_or_gate;
            this.sideButton8.SideButtonText = "5 Inputs Or Gate";
            this.sideButton8.Size = new System.Drawing.Size(216, 36);
            this.sideButton8.TabIndex = 7;
            this.sideButton8.TextColor = System.Drawing.Color.Black;
            this.sideButton8.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton8.ToolTipText = "";
            this.sideButton8.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton8_SideButtonMouseDown);
            // 
            // sideButton7
            // 
            this.sideButton7.BackColor = System.Drawing.Color.White;
            this.sideButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton7.Location = new System.Drawing.Point(0, 216);
            this.sideButton7.Name = "sideButton7";
            this.sideButton7.NormalColor = System.Drawing.Color.White;
            this.sideButton7.SideButtonColor = System.Drawing.Color.White;
            this.sideButton7.SideButtonImage = global::Booleanism.Properties.Resources.four_inp_or_gate;
            this.sideButton7.SideButtonText = "4 Inputs Or Gate";
            this.sideButton7.Size = new System.Drawing.Size(216, 36);
            this.sideButton7.TabIndex = 6;
            this.sideButton7.TextColor = System.Drawing.Color.Black;
            this.sideButton7.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton7.ToolTipText = "";
            this.sideButton7.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton7_SideButtonMouseDown);
            // 
            // sideButton6
            // 
            this.sideButton6.BackColor = System.Drawing.Color.White;
            this.sideButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton6.Location = new System.Drawing.Point(0, 180);
            this.sideButton6.Name = "sideButton6";
            this.sideButton6.NormalColor = System.Drawing.Color.White;
            this.sideButton6.SideButtonColor = System.Drawing.Color.White;
            this.sideButton6.SideButtonImage = global::Booleanism.Properties.Resources.three_inp_or_gate;
            this.sideButton6.SideButtonText = "3 Inputs Or Gate";
            this.sideButton6.Size = new System.Drawing.Size(216, 36);
            this.sideButton6.TabIndex = 5;
            this.sideButton6.TextColor = System.Drawing.Color.Black;
            this.sideButton6.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton6.ToolTipText = "";
            this.sideButton6.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton6_SideButtonMouseDown);
            // 
            // sideButton5
            // 
            this.sideButton5.BackColor = System.Drawing.Color.White;
            this.sideButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton5.Location = new System.Drawing.Point(0, 144);
            this.sideButton5.Name = "sideButton5";
            this.sideButton5.NormalColor = System.Drawing.Color.White;
            this.sideButton5.SideButtonColor = System.Drawing.Color.White;
            this.sideButton5.SideButtonImage = global::Booleanism.Properties.Resources.two_inp_or_gate;
            this.sideButton5.SideButtonText = "2 Inputs Or Gate";
            this.sideButton5.Size = new System.Drawing.Size(216, 36);
            this.sideButton5.TabIndex = 4;
            this.sideButton5.TextColor = System.Drawing.Color.Black;
            this.sideButton5.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton5.ToolTipText = "";
            this.sideButton5.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton5_SideButtonMouseDown);
            // 
            // sideButton4
            // 
            this.sideButton4.BackColor = System.Drawing.Color.White;
            this.sideButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton4.Location = new System.Drawing.Point(0, 108);
            this.sideButton4.Name = "sideButton4";
            this.sideButton4.NormalColor = System.Drawing.Color.White;
            this.sideButton4.SideButtonColor = System.Drawing.Color.White;
            this.sideButton4.SideButtonImage = global::Booleanism.Properties.Resources.five_inp_and_gate;
            this.sideButton4.SideButtonText = "5 Inputs And Gate";
            this.sideButton4.Size = new System.Drawing.Size(216, 36);
            this.sideButton4.TabIndex = 3;
            this.sideButton4.TextColor = System.Drawing.Color.Black;
            this.sideButton4.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton4.ToolTipText = "";
            this.sideButton4.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton4_SideButtonMouseDown);
            // 
            // sideButton3
            // 
            this.sideButton3.BackColor = System.Drawing.Color.White;
            this.sideButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton3.Location = new System.Drawing.Point(0, 72);
            this.sideButton3.Name = "sideButton3";
            this.sideButton3.NormalColor = System.Drawing.Color.White;
            this.sideButton3.SideButtonColor = System.Drawing.Color.White;
            this.sideButton3.SideButtonImage = global::Booleanism.Properties.Resources.four_inp_and_gate;
            this.sideButton3.SideButtonText = "4 Inputs And Gate";
            this.sideButton3.Size = new System.Drawing.Size(216, 36);
            this.sideButton3.TabIndex = 2;
            this.sideButton3.TextColor = System.Drawing.Color.Black;
            this.sideButton3.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton3.ToolTipText = "";
            this.sideButton3.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton3_SideButtonMouseDown);
            // 
            // sideButton2
            // 
            this.sideButton2.BackColor = System.Drawing.Color.White;
            this.sideButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton2.Location = new System.Drawing.Point(0, 36);
            this.sideButton2.Name = "sideButton2";
            this.sideButton2.NormalColor = System.Drawing.Color.White;
            this.sideButton2.SideButtonColor = System.Drawing.Color.White;
            this.sideButton2.SideButtonImage = global::Booleanism.Properties.Resources.three_inp_and_gate;
            this.sideButton2.SideButtonText = "3 Inputs And Gate";
            this.sideButton2.Size = new System.Drawing.Size(216, 36);
            this.sideButton2.TabIndex = 1;
            this.sideButton2.TextColor = System.Drawing.Color.Black;
            this.sideButton2.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton2.ToolTipText = "";
            this.sideButton2.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton2_SideButtonMouseDown);
            // 
            // sideButton1
            // 
            this.sideButton1.BackColor = System.Drawing.Color.White;
            this.sideButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton1.Location = new System.Drawing.Point(0, 0);
            this.sideButton1.Name = "sideButton1";
            this.sideButton1.NormalColor = System.Drawing.Color.White;
            this.sideButton1.SideButtonColor = System.Drawing.Color.White;
            this.sideButton1.SideButtonImage = global::Booleanism.Properties.Resources.two_inp_and_gate;
            this.sideButton1.SideButtonText = "2 Inputs And Gate";
            this.sideButton1.Size = new System.Drawing.Size(216, 36);
            this.sideButton1.TabIndex = 0;
            this.sideButton1.TextColor = System.Drawing.Color.Black;
            this.sideButton1.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton1.ToolTipText = "";
            this.sideButton1.SideButtonClick += new Booleanism.SideButtonClick(this.sideButton1_SideButtonClick);
            this.sideButton1.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton1_SideButtonMouseDown);
            this.sideButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sideButton1_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sideButton36);
            this.panel4.Controls.Add(this.sideButton35);
            this.panel4.Controls.Add(this.sideButton34);
            this.panel4.Controls.Add(this.sideButton33);
            this.panel4.Controls.Add(this.sideButton32);
            this.panel4.Controls.Add(this.sideButton31);
            this.panel4.Controls.Add(this.sideButton30);
            this.panel4.Controls.Add(this.sideButton29);
            this.panel4.Controls.Add(this.sideButton28);
            this.panel4.Controls.Add(this.sideButton27);
            this.panel4.Location = new System.Drawing.Point(0, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 0);
            this.panel4.TabIndex = 39;
            // 
            // sideButton36
            // 
            this.sideButton36.BackColor = System.Drawing.Color.White;
            this.sideButton36.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton36.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton36.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton36.Location = new System.Drawing.Point(0, 324);
            this.sideButton36.Name = "sideButton36";
            this.sideButton36.NormalColor = System.Drawing.Color.White;
            this.sideButton36.SideButtonColor = System.Drawing.Color.White;
            this.sideButton36.SideButtonImage = global::Booleanism.Properties.Resources.display_icon;
            this.sideButton36.SideButtonText = "Red Display";
            this.sideButton36.Size = new System.Drawing.Size(220, 36);
            this.sideButton36.TabIndex = 20;
            this.sideButton36.TextColor = System.Drawing.Color.Black;
            this.sideButton36.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton36.ToolTipText = "";
            this.sideButton36.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton36_SideButtonMouseDown);
            // 
            // sideButton35
            // 
            this.sideButton35.BackColor = System.Drawing.Color.White;
            this.sideButton35.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton35.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton35.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton35.Location = new System.Drawing.Point(0, 288);
            this.sideButton35.Name = "sideButton35";
            this.sideButton35.NormalColor = System.Drawing.Color.White;
            this.sideButton35.SideButtonColor = System.Drawing.Color.White;
            this.sideButton35.SideButtonImage = global::Booleanism.Properties.Resources.displayYellow_icon;
            this.sideButton35.SideButtonText = "Yellow Display";
            this.sideButton35.Size = new System.Drawing.Size(220, 36);
            this.sideButton35.TabIndex = 19;
            this.sideButton35.TextColor = System.Drawing.Color.Black;
            this.sideButton35.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton35.ToolTipText = "";
            this.sideButton35.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton35_SideButtonMouseDown);
            // 
            // sideButton34
            // 
            this.sideButton34.BackColor = System.Drawing.Color.White;
            this.sideButton34.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton34.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton34.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton34.Location = new System.Drawing.Point(0, 252);
            this.sideButton34.Name = "sideButton34";
            this.sideButton34.NormalColor = System.Drawing.Color.White;
            this.sideButton34.SideButtonColor = System.Drawing.Color.White;
            this.sideButton34.SideButtonImage = global::Booleanism.Properties.Resources.displayGreen_icon;
            this.sideButton34.SideButtonText = "Green Display";
            this.sideButton34.Size = new System.Drawing.Size(220, 36);
            this.sideButton34.TabIndex = 18;
            this.sideButton34.TextColor = System.Drawing.Color.Black;
            this.sideButton34.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton34.ToolTipText = "";
            this.sideButton34.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton34_SideButtonMouseDown);
            // 
            // sideButton33
            // 
            this.sideButton33.BackColor = System.Drawing.Color.White;
            this.sideButton33.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton33.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton33.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton33.Location = new System.Drawing.Point(0, 216);
            this.sideButton33.Name = "sideButton33";
            this.sideButton33.NormalColor = System.Drawing.Color.White;
            this.sideButton33.SideButtonColor = System.Drawing.Color.White;
            this.sideButton33.SideButtonImage = global::Booleanism.Properties.Resources.displayblue_icon;
            this.sideButton33.SideButtonText = "Blue Display";
            this.sideButton33.Size = new System.Drawing.Size(220, 36);
            this.sideButton33.TabIndex = 17;
            this.sideButton33.TextColor = System.Drawing.Color.Black;
            this.sideButton33.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton33.ToolTipText = "";
            this.sideButton33.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton33_SideButtonMouseDown);
            // 
            // sideButton32
            // 
            this.sideButton32.BackColor = System.Drawing.Color.White;
            this.sideButton32.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton32.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton32.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton32.Location = new System.Drawing.Point(0, 180);
            this.sideButton32.Name = "sideButton32";
            this.sideButton32.NormalColor = System.Drawing.Color.White;
            this.sideButton32.SideButtonColor = System.Drawing.Color.White;
            this.sideButton32.SideButtonImage = global::Booleanism.Properties.Resources.purple_led;
            this.sideButton32.SideButtonText = "Purple LED";
            this.sideButton32.Size = new System.Drawing.Size(220, 36);
            this.sideButton32.TabIndex = 16;
            this.sideButton32.TextColor = System.Drawing.Color.Black;
            this.sideButton32.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton32.ToolTipText = "";
            this.sideButton32.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton32_SideButtonMouseDown);
            // 
            // sideButton31
            // 
            this.sideButton31.BackColor = System.Drawing.Color.White;
            this.sideButton31.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton31.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton31.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton31.Location = new System.Drawing.Point(0, 144);
            this.sideButton31.Name = "sideButton31";
            this.sideButton31.NormalColor = System.Drawing.Color.White;
            this.sideButton31.SideButtonColor = System.Drawing.Color.White;
            this.sideButton31.SideButtonImage = global::Booleanism.Properties.Resources.yellow_led;
            this.sideButton31.SideButtonText = "Yellow LED";
            this.sideButton31.Size = new System.Drawing.Size(220, 36);
            this.sideButton31.TabIndex = 15;
            this.sideButton31.TextColor = System.Drawing.Color.Black;
            this.sideButton31.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton31.ToolTipText = "";
            this.sideButton31.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton31_SideButtonMouseDown);
            // 
            // sideButton30
            // 
            this.sideButton30.BackColor = System.Drawing.Color.White;
            this.sideButton30.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton30.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton30.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton30.Location = new System.Drawing.Point(0, 108);
            this.sideButton30.Name = "sideButton30";
            this.sideButton30.NormalColor = System.Drawing.Color.White;
            this.sideButton30.SideButtonColor = System.Drawing.Color.White;
            this.sideButton30.SideButtonImage = global::Booleanism.Properties.Resources.white_led;
            this.sideButton30.SideButtonText = "White LED";
            this.sideButton30.Size = new System.Drawing.Size(220, 36);
            this.sideButton30.TabIndex = 14;
            this.sideButton30.TextColor = System.Drawing.Color.Black;
            this.sideButton30.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton30.ToolTipText = "";
            this.sideButton30.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton30_SideButtonMouseDown);
            // 
            // sideButton29
            // 
            this.sideButton29.BackColor = System.Drawing.Color.White;
            this.sideButton29.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton29.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton29.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton29.Location = new System.Drawing.Point(0, 72);
            this.sideButton29.Name = "sideButton29";
            this.sideButton29.NormalColor = System.Drawing.Color.White;
            this.sideButton29.SideButtonColor = System.Drawing.Color.White;
            this.sideButton29.SideButtonImage = global::Booleanism.Properties.Resources.red_led;
            this.sideButton29.SideButtonText = "Red LED";
            this.sideButton29.Size = new System.Drawing.Size(220, 36);
            this.sideButton29.TabIndex = 13;
            this.sideButton29.TextColor = System.Drawing.Color.Black;
            this.sideButton29.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton29.ToolTipText = "";
            this.sideButton29.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton29_SideButtonMouseDown);
            // 
            // sideButton28
            // 
            this.sideButton28.BackColor = System.Drawing.Color.White;
            this.sideButton28.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton28.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton28.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton28.Location = new System.Drawing.Point(0, 36);
            this.sideButton28.Name = "sideButton28";
            this.sideButton28.NormalColor = System.Drawing.Color.White;
            this.sideButton28.SideButtonColor = System.Drawing.Color.White;
            this.sideButton28.SideButtonImage = global::Booleanism.Properties.Resources.green_led;
            this.sideButton28.SideButtonText = "Green LED";
            this.sideButton28.Size = new System.Drawing.Size(220, 36);
            this.sideButton28.TabIndex = 12;
            this.sideButton28.TextColor = System.Drawing.Color.Black;
            this.sideButton28.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton28.ToolTipText = "";
            this.sideButton28.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton28_SideButtonMouseDown);
            // 
            // sideButton27
            // 
            this.sideButton27.BackColor = System.Drawing.Color.White;
            this.sideButton27.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton27.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton27.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton27.Location = new System.Drawing.Point(0, 0);
            this.sideButton27.Name = "sideButton27";
            this.sideButton27.NormalColor = System.Drawing.Color.White;
            this.sideButton27.SideButtonColor = System.Drawing.Color.White;
            this.sideButton27.SideButtonImage = global::Booleanism.Properties.Resources.blue_led;
            this.sideButton27.SideButtonText = "Blue LED";
            this.sideButton27.Size = new System.Drawing.Size(220, 36);
            this.sideButton27.TabIndex = 11;
            this.sideButton27.TextColor = System.Drawing.Color.Black;
            this.sideButton27.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton27.ToolTipText = "";
            this.sideButton27.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton27_SideButtonMouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sideButton26);
            this.panel3.Controls.Add(this.sideButton25);
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 480);
            this.panel3.TabIndex = 38;
            // 
            // sideButton26
            // 
            this.sideButton26.BackColor = System.Drawing.Color.White;
            this.sideButton26.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton26.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton26.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton26.Location = new System.Drawing.Point(0, 36);
            this.sideButton26.Name = "sideButton26";
            this.sideButton26.NormalColor = System.Drawing.Color.White;
            this.sideButton26.SideButtonColor = System.Drawing.Color.White;
            this.sideButton26.SideButtonImage = global::Booleanism.Properties.Resources.normal_push_button;
            this.sideButton26.SideButtonText = "Push Button";
            this.sideButton26.Size = new System.Drawing.Size(216, 36);
            this.sideButton26.TabIndex = 11;
            this.sideButton26.TextColor = System.Drawing.Color.Black;
            this.sideButton26.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton26.ToolTipText = "";
            this.sideButton26.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton26_SideButtonMouseDown);
            // 
            // sideButton25
            // 
            this.sideButton25.BackColor = System.Drawing.Color.White;
            this.sideButton25.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton25.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton25.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton25.Location = new System.Drawing.Point(0, 0);
            this.sideButton25.Name = "sideButton25";
            this.sideButton25.NormalColor = System.Drawing.Color.White;
            this.sideButton25.SideButtonColor = System.Drawing.Color.White;
            this.sideButton25.SideButtonImage = global::Booleanism.Properties.Resources.clock_signal;
            this.sideButton25.SideButtonText = "Clock";
            this.sideButton25.Size = new System.Drawing.Size(216, 36);
            this.sideButton25.TabIndex = 10;
            this.sideButton25.TextColor = System.Drawing.Color.Black;
            this.sideButton25.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton25.ToolTipText = "";
            this.sideButton25.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton25_SideButtonMouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sideButton24);
            this.panel1.Controls.Add(this.sideButton23);
            this.panel1.Controls.Add(this.sideButton22);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 0);
            this.panel1.TabIndex = 36;
            // 
            // sideButton24
            // 
            this.sideButton24.BackColor = System.Drawing.Color.White;
            this.sideButton24.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton24.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton24.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton24.Location = new System.Drawing.Point(0, 72);
            this.sideButton24.Name = "sideButton24";
            this.sideButton24.NormalColor = System.Drawing.Color.White;
            this.sideButton24.SideButtonColor = System.Drawing.Color.White;
            this.sideButton24.SideButtonImage = global::Booleanism.Properties.Resources.d_flipflop;
            this.sideButton24.SideButtonText = "D";
            this.sideButton24.Size = new System.Drawing.Size(216, 36);
            this.sideButton24.TabIndex = 11;
            this.sideButton24.TextColor = System.Drawing.Color.Black;
            this.sideButton24.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton24.ToolTipText = "";
            this.sideButton24.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton24_SideButtonMouseDown);
            // 
            // sideButton23
            // 
            this.sideButton23.BackColor = System.Drawing.Color.White;
            this.sideButton23.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton23.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton23.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton23.Location = new System.Drawing.Point(0, 36);
            this.sideButton23.Name = "sideButton23";
            this.sideButton23.NormalColor = System.Drawing.Color.White;
            this.sideButton23.SideButtonColor = System.Drawing.Color.White;
            this.sideButton23.SideButtonImage = global::Booleanism.Properties.Resources.rs_flipflop;
            this.sideButton23.SideButtonText = "RS";
            this.sideButton23.Size = new System.Drawing.Size(216, 36);
            this.sideButton23.TabIndex = 10;
            this.sideButton23.TextColor = System.Drawing.Color.Black;
            this.sideButton23.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton23.ToolTipText = "";
            this.sideButton23.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton23_SideButtonMouseDown);
            // 
            // sideButton22
            // 
            this.sideButton22.BackColor = System.Drawing.Color.White;
            this.sideButton22.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideButton22.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideButton22.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideButton22.Location = new System.Drawing.Point(0, 0);
            this.sideButton22.Name = "sideButton22";
            this.sideButton22.NormalColor = System.Drawing.Color.White;
            this.sideButton22.SideButtonColor = System.Drawing.Color.White;
            this.sideButton22.SideButtonImage = global::Booleanism.Properties.Resources.rs_flipflop;
            this.sideButton22.SideButtonText = "JK";
            this.sideButton22.Size = new System.Drawing.Size(216, 36);
            this.sideButton22.TabIndex = 9;
            this.sideButton22.TextColor = System.Drawing.Color.Black;
            this.sideButton22.TextFont = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.sideButton22.ToolTipText = "";
            this.sideButton22.SideButtonMouseDown += new Booleanism.SideButtonMouseDown(this.sideButton22_SideButtonMouseDown);
            // 
            // gateTab
            // 
            this.gateTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gateTab.Client = this.panel2;
            this.gateTab.Text = "Gates";
            // 
            // gvbComponents
            // 
            this.gvbComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gvbComponents.Client = this.panel1;
            this.gvbComponents.Text = "Flip Flops";
            // 
            // gvbWindowsForm
            // 
            this.gvbWindowsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gvbWindowsForm.Client = this.panel3;
            this.gvbWindowsForm.Text = "Inputs";
            // 
            // gvbGeneral
            // 
            this.gvbGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gvbGeneral.Client = this.panel4;
            this.gvbGeneral.Text = "Outputs";
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "");
            this.largeImageList.Images.SetKeyName(1, "");
            this.largeImageList.Images.SetKeyName(2, "");
            this.largeImageList.Images.SetKeyName(3, "");
            this.largeImageList.Images.SetKeyName(4, "");
            this.largeImageList.Images.SetKeyName(5, "");
            this.largeImageList.Images.SetKeyName(6, "");
            this.largeImageList.Images.SetKeyName(7, "");
            // 
            // dockingImageList
            // 
            this.dockingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dockingImageList.ImageStream")));
            this.dockingImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.dockingImageList.Images.SetKeyName(0, "and_gate_icon1.png");
            this.dockingImageList.Images.SetKeyName(1, "and_gate_icon2.png");
            this.dockingImageList.Images.SetKeyName(2, "and_gate_icon3.png");
            this.dockingImageList.Images.SetKeyName(3, "and_gate_icon4.png");
            this.dockingImageList.Images.SetKeyName(4, "or_gate_icon1.png");
            this.dockingImageList.Images.SetKeyName(5, "or_gate_icon2.png");
            this.dockingImageList.Images.SetKeyName(6, "or_gate_icon3.png");
            this.dockingImageList.Images.SetKeyName(7, "or_gate_icon4.png");
            this.dockingImageList.Images.SetKeyName(8, "xor_gate_icon1.png");
            this.dockingImageList.Images.SetKeyName(9, "xor_gate_icon2.png");
            this.dockingImageList.Images.SetKeyName(10, "xor_gate_icon3.png");
            this.dockingImageList.Images.SetKeyName(11, "xor_gate_icon4.png");
            this.dockingImageList.Images.SetKeyName(12, "nand_gate_icon1.png");
            this.dockingImageList.Images.SetKeyName(13, "nand_gate_icon2.png");
            this.dockingImageList.Images.SetKeyName(14, "nand_gate_icon3.png");
            this.dockingImageList.Images.SetKeyName(15, "nand_gate_icon4.png");
            this.dockingImageList.Images.SetKeyName(16, "nor_gate_icon1.png");
            this.dockingImageList.Images.SetKeyName(17, "nor_gate_icon2.png");
            this.dockingImageList.Images.SetKeyName(18, "nor_gate_icon3.png");
            this.dockingImageList.Images.SetKeyName(19, "nor_gate_icon4.png");
            // 
            // ToolBoxView
            // 
            this.Controls.Add(this.panelToolBox);
            this.Name = "ToolBoxView";
            this.Size = new System.Drawing.Size(216, 568);
            this.Load += new System.EventHandler(this.ToolBoxView_Load);
            this.panelToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gBToolBox)).EndInit();
            this.gBToolBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}


        #endregion

        private void ToolBoxView_Load(object sender, EventArgs e)
        {
            
        }

        private void sideButton1_SideButtonClick(object sender, EventArgs e)
        {
            
        }

        private void sideButton1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void sideButton1_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            And a = new And(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton2_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            And a = new And(Form.contentPanel, Form.configPanel, 3);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton3_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            And a = new And(Form.contentPanel, Form.configPanel, 4);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton4_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            And a = new And(Form.contentPanel, Form.configPanel, 5);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton5_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Or a = new Or(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton6_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Or a = new Or(Form.contentPanel, Form.configPanel, 3);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton7_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Or a = new Or(Form.contentPanel, Form.configPanel, 4);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton8_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Or a = new Or(Form.contentPanel, Form.configPanel, 5);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton9_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Xor a = new Xor(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton10_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Xor a = new Xor(Form.contentPanel, Form.configPanel, 3);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton11_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Xor a = new Xor(Form.contentPanel, Form.configPanel, 4);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton12_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Xor a = new Xor(Form.contentPanel, Form.configPanel, 5);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton13_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nand a = new Nand(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton14_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nand a = new Nand(Form.contentPanel, Form.configPanel, 3);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton15_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nand a = new Nand(Form.contentPanel, Form.configPanel, 4);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton16_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nand a = new Nand(Form.contentPanel, Form.configPanel, 5);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton17_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nor a = new Nor(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton18_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nor a = new Nor(Form.contentPanel, Form.configPanel, 3);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton19_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nor a = new Nor(Form.contentPanel, Form.configPanel, 4);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton20_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Nor a = new Nor(Form.contentPanel, Form.configPanel, 5);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton21_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Not a = new Not(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton22_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            JK a = new JK(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton23_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            RS a = new RS(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton24_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            D a = new D(Form.contentPanel, Form.configPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton25_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Clock_Signal a = new Clock_Signal(Form.contentPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton26_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            PushButton a = new PushButton(Form.contentPanel);
            a.DoDragDrop(a, DragDropEffects.Move);
        }

        private void sideButton27_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            LED led = new LED(LED.LEDType.Blue,Form.contentPanel, Form.configPanel);
            led.DoDragDrop(led, DragDropEffects.Move);
        }

        private void sideButton28_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            LED led = new LED(LED.LEDType.Green, Form.contentPanel, Form.configPanel);
            led.DoDragDrop(led, DragDropEffects.Move);
        }

        private void sideButton29_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            LED led = new LED(LED.LEDType.Red, Form.contentPanel, Form.configPanel);
            led.DoDragDrop(led, DragDropEffects.Move);
        }

        private void sideButton30_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            LED led = new LED(LED.LEDType.White, Form.contentPanel, Form.configPanel);
            led.DoDragDrop(led, DragDropEffects.Move);
        }

        private void sideButton31_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            LED led = new LED(LED.LEDType.Yellow, Form.contentPanel, Form.configPanel);
            led.DoDragDrop(led, DragDropEffects.Move);
        }

        private void sideButton32_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            LED led = new LED(LED.LEDType.Purple, Form.contentPanel, Form.configPanel);
            led.DoDragDrop(led, DragDropEffects.Move);
        }

        private void sideButton33_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Display d = new Display(Form.contentPanel, Form.configPanel, Color.Blue);
            d.DoDragDrop(d, DragDropEffects.Move);
        }

        private void sideButton34_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Display d = new Display(Form.contentPanel, Form.configPanel, Color.LimeGreen);
            d.DoDragDrop(d, DragDropEffects.Move);
        }

        private void sideButton35_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Display d = new Display(Form.contentPanel, Form.configPanel, Color.Gold);
            d.DoDragDrop(d, DragDropEffects.Move);
        }

        private void sideButton36_SideButtonMouseDown(object sender, MouseEventArgs e)
        {
            Display d = new Display(Form.contentPanel, Form.configPanel, Color.Red);
            d.DoDragDrop(d, DragDropEffects.Move);
        }
    }
}
