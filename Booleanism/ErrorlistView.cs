#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Booleanism
{
	/// <summary>
	/// Summary description for Errorlist.
	/// </summary>
	public class ErrorlistView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panelErrorList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem errorsBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem messagesBarItem;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar errorlistToolBar;
		private System.Windows.Forms.ImageList imageList1;
        public ListView dwTaskListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
        public ListView msgListView;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private System.ComponentModel.IContainer components;

		public ErrorlistView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
            this.errorlistToolBar.Bar.BeginGroupAt(this.messagesBarItem);
		}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorlistView));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable6 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable7 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable8 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable9 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable10 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.panelErrorList = new System.Windows.Forms.Panel();
            this.msgListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dwTaskListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorlistToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.errorsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.messagesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panelErrorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelErrorList
            // 
            this.panelErrorList.Controls.Add(this.msgListView);
            this.panelErrorList.Controls.Add(this.dwTaskListView);
            this.panelErrorList.Controls.Add(this.errorlistToolBar);
            this.panelErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelErrorList.Location = new System.Drawing.Point(0, 0);
            this.panelErrorList.Name = "panelErrorList";
            this.panelErrorList.Size = new System.Drawing.Size(680, 190);
            this.panelErrorList.TabIndex = 0;
            // 
            // msgListView
            // 
            this.msgListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msgListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.msgListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.msgListView.FullRowSelect = true;
            this.msgListView.GridLines = true;
            this.msgListView.Location = new System.Drawing.Point(0, 25);
            this.msgListView.MultiSelect = false;
            this.msgListView.Name = "msgListView";
            this.msgListView.Size = new System.Drawing.Size(680, 165);
            this.msgListView.TabIndex = 30;
            this.msgListView.UseCompatibleStateImageBehavior = false;
            this.msgListView.View = System.Windows.Forms.View.Details;
            this.msgListView.Visible = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "!";
            this.columnHeader7.Width = 43;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Time Span";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Description";
            this.columnHeader9.Width = 1000;
            // 
            // dwTaskListView
            // 
            this.dwTaskListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dwTaskListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dwTaskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.dwTaskListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwTaskListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dwTaskListView.FullRowSelect = true;
            this.dwTaskListView.GridLines = true;
            this.dwTaskListView.Location = new System.Drawing.Point(0, 25);
            this.dwTaskListView.MultiSelect = false;
            this.dwTaskListView.Name = "dwTaskListView";
            this.dwTaskListView.Size = new System.Drawing.Size(680, 165);
            this.dwTaskListView.TabIndex = 28;
            this.dwTaskListView.UseCompatibleStateImageBehavior = false;
            this.dwTaskListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "!";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time Span";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 1000;
            // 
            // errorlistToolBar
            // 
            this.errorlistToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            // 
            // 
            // 
            this.errorlistToolBar.Bar.BarName = "";
            this.errorlistToolBar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.errorsBarItem,
            this.messagesBarItem});
            this.errorlistToolBar.Bar.Manager = null;
            this.errorlistToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorlistToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorlistToolBar.Location = new System.Drawing.Point(0, 0);
            this.errorlistToolBar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.errorlistToolBar.Name = "errorlistToolBar";
            this.errorlistToolBar.Size = new System.Drawing.Size(680, 25);
            this.errorlistToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.errorlistToolBar.TabIndex = 0;
            // 
            // errorsBarItem
            // 
            this.errorsBarItem.BarName = "errorsBarItem";
            this.errorsBarItem.Checked = true;
            this.errorsBarItem.CustomActiveTextColor = System.Drawing.Color.White;
            this.errorsBarItem.CustomNormalTextColor = System.Drawing.Color.White;
            this.errorsBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorsBarItem.ID = "Errors";
            this.errorsBarItem.ImageIndex = 3;
            this.errorsBarItem.ImageList = this.imageList1;
            this.errorsBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.errorsBarItem.ShowToolTipInPopUp = false;
            this.errorsBarItem.SizeToFit = true;
            this.errorsBarItem.Text = "Elements";
            this.errorsBarItem.Click += new System.EventHandler(this.BarItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Wrong.png");
            this.imageList1.Images.SetKeyName(1, "Warning.png");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "booleanism_icon.ico");
            // 
            // messagesBarItem
            // 
            this.messagesBarItem.BarName = "messagesBarItem";
            this.messagesBarItem.CustomActiveTextColor = System.Drawing.Color.White;
            this.messagesBarItem.CustomNormalTextColor = System.Drawing.Color.White;
            this.messagesBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.messagesBarItem.ID = "Messages";
            this.messagesBarItem.ImageIndex = 2;
            this.messagesBarItem.ImageList = this.imageList1;
            this.messagesBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.messagesBarItem.ShowToolTipInPopUp = false;
            this.messagesBarItem.SizeToFit = true;
            this.messagesBarItem.Text = "Messages";
            this.messagesBarItem.Click += new System.EventHandler(this.messagesBarItem_Click);
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.dwTaskListView;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.MetroThumbSize = new System.Drawing.Size(0, 0);
            this.scrollersFrame1.Office2016ColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Colorful;
            metroColorTable6.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable6.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable6.ArrowInActive = System.Drawing.Color.White;
            metroColorTable6.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable6.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable6.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable6.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable6.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable6.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable6.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable6.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable6.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable6.ThumbInActive = System.Drawing.Color.White;
            metroColorTable6.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable6.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable6.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable6.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable6.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable6;
            metroColorTable7.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            metroColorTable7.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable7.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable7.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            metroColorTable7.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable7.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable7.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            metroColorTable7.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable7.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable7.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable7.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable7.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable7.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable7.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable7.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable7.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable7.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable7.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scrollersFrame1.ScrollOffice2016BlackColorTable = metroColorTable7;
            metroColorTable8.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable8.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable8.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable8.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable8.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable8.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable8.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable8.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable8.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable8.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable8.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable8.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable8.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable8.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable8.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable8.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable8.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable8.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016ColorfulColorTable = metroColorTable8;
            metroColorTable9.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable9.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable9.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable9.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable9.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable9.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable9.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable9.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable9.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable9.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable9.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            metroColorTable9.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable9.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable9.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable9.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable9.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable9.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable9.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scrollersFrame1.ScrollOffice2016DarkGrayColorTable = metroColorTable9;
            metroColorTable10.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable10.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable10.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable10.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable10.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable10.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable10.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable10.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable10.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable10.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable10.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable10.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable10.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable10.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable10.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable10.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable10.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable10.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016WhiteColorTable = metroColorTable10;
            this.scrollersFrame1.ShowMetroArrowButton = true;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.barItem1.ID = "Messages";
            this.barItem1.ImageIndex = 2;
            this.barItem1.ImageList = this.imageList1;
            this.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.Checked = true;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.barItem2.ID = "Errors";
            this.barItem2.ImageIndex = 3;
            this.barItem2.ImageList = this.imageList1;
            this.barItem2.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Elements";
            // 
            // ErrorlistView
            // 
            this.Controls.Add(this.panelErrorList);
            this.Name = "ErrorlistView";
            this.Size = new System.Drawing.Size(680, 190);
            this.panelErrorList.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private void BarItem_Click(object sender, EventArgs e)
        {
            msgListView.Visible = false;
            dwTaskListView.Visible = true;   
        }

        private void warningsBarItem_Click(object sender, EventArgs e)
        {
            //errorsBarItem.Checked = false;
            //messagesBarItem.Checked = false;
            msgListView.Visible = dwTaskListView.Visible = false;
            //eventsListView.Visible = true;
        }

        private void messagesBarItem_Click(object sender, EventArgs e)
        {
            dwTaskListView.Visible = false;
            msgListView.Visible = true;
        }
    }
}
