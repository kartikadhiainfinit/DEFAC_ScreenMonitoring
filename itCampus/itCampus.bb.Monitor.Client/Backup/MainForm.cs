using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using itCampus.bb.Common;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Hauptformular des Monitors.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemFileEnd;
		private System.Windows.Forms.MenuItem menuItemView;
		private System.Windows.Forms.MenuItem menuItemViewRefresh;
		private System.Windows.Forms.MenuItem menuItemFrontend;
		private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoring;
		private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhispering;
		private System.Windows.Forms.MenuItem menuItemFrontendStopCoaching;
		private System.Windows.Forms.MenuItem menuItemSite;
		private System.Windows.Forms.MenuItem menuItemSiteAdd;
		private System.Windows.Forms.MenuItem menuItemSiteEdit;
		private System.Windows.Forms.MenuItem menuItemSiteRemove;
		private System.Windows.Forms.MenuItem menuItemDevice;
		private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoring;
		private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhispering;
		private System.Windows.Forms.MenuItem menuItemDeviceStopCoaching;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemHelpInfo;
		private System.Windows.Forms.ContextMenu contextMenuFrontend;
		private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoringCtx;
		private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhisperingCtx;
		private System.Windows.Forms.MenuItem menuItemFrontendStopCoachingCtx;
		private System.Windows.Forms.ContextMenu contextMenuSite;
		private System.Windows.Forms.MenuItem menuItemSiteAddCtx;
		private System.Windows.Forms.MenuItem menuItemSiteEditCtx;
		private System.Windows.Forms.MenuItem menuItemSiteRemoveCtx;
		private System.Windows.Forms.ContextMenu contextMenuDevice;
		private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoringCtx;
		private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhisperingCtx;
		private System.Windows.Forms.MenuItem menuItemDeviceStopCoachingCtx;
		private System.Windows.Forms.ToolBar toolBar;
		private System.Windows.Forms.ToolBarButton toolBarButtonNavi;
		private System.Windows.Forms.ToolBarButton toolBarButtonPreview;
		private System.Windows.Forms.ToolBarButton toolBarButtonDetails;
		private System.Windows.Forms.ToolBarButton toolBarButtonSeparator;
		private System.Windows.Forms.ToolBarButton toolBarButtonDevice;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarPanelLog;
		private System.Windows.Forms.StatusBarPanel statusBarPanelState;
		private System.Windows.Forms.StatusBarPanel statusBarPanelDate;
		private System.Windows.Forms.StatusBarPanel statusBarPanelTime;
		private System.Windows.Forms.Panel panelNavi;
		private itCampus.bb.Controls.NaviBar naviBar;
		private itCampus.bb.Controls.NaviBarButton naviBarButtonFrontends;
		private itCampus.bb.Controls.NaviBarButton naviBarButtonCampaigns;
		private itCampus.bb.Controls.NaviBarButton naviBarButtonConferences;
		private itCampus.bb.Controls.NaviBarButton naviBarButtonSites;
		private itCampus.bb.Controls.NaviBarButton naviBarButtonDevices;
		private System.Windows.Forms.Splitter splitterVertical;
		private System.Windows.Forms.Panel panelPage;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Timer timerRefresh;
		private System.Windows.Forms.Timer timerStopCoaching;
		private System.ComponentModel.IContainer components;

		// Hauptobjekt
		private MainControl _mainControl;

		// Frontendverwaltung
		private FrontendControl _frontendControl;

		// Kategorieseiten
		private FrontendPage _frontendPage;
		private CampaignPage _campaignPage;
		private ConferencePage _conferencePage;
		private SitePage _sitePage;
		private DevicePage _devicePage;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		/// <summary>
		/// initialisiert Hauptformular
		/// </summary>
		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Windows Form Designer generated code -----------------

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemFileEnd = new System.Windows.Forms.MenuItem();
			this.menuItemView = new System.Windows.Forms.MenuItem();
			this.menuItemViewRefresh = new System.Windows.Forms.MenuItem();
			this.menuItemFrontend = new System.Windows.Forms.MenuItem();
			this.menuItemFrontendStartCoachingSilentMonitoring = new System.Windows.Forms.MenuItem();
			this.menuItemFrontendStartCoachingWhispering = new System.Windows.Forms.MenuItem();
			this.menuItemFrontendStopCoaching = new System.Windows.Forms.MenuItem();
			this.menuItemSite = new System.Windows.Forms.MenuItem();
			this.menuItemSiteAdd = new System.Windows.Forms.MenuItem();
			this.menuItemSiteEdit = new System.Windows.Forms.MenuItem();
			this.menuItemSiteRemove = new System.Windows.Forms.MenuItem();
			this.menuItemDevice = new System.Windows.Forms.MenuItem();
			this.menuItemDeviceStartCoachingSilentMonitoring = new System.Windows.Forms.MenuItem();
			this.menuItemDeviceStartCoachingWhispering = new System.Windows.Forms.MenuItem();
			this.menuItemDeviceStopCoaching = new System.Windows.Forms.MenuItem();
			this.menuItemHelp = new System.Windows.Forms.MenuItem();
			this.menuItemHelpInfo = new System.Windows.Forms.MenuItem();
			this.contextMenuFrontend = new System.Windows.Forms.ContextMenu();
			this.menuItemFrontendStartCoachingSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
			this.menuItemFrontendStartCoachingWhisperingCtx = new System.Windows.Forms.MenuItem();
			this.menuItemFrontendStopCoachingCtx = new System.Windows.Forms.MenuItem();
			this.contextMenuSite = new System.Windows.Forms.ContextMenu();
			this.menuItemSiteAddCtx = new System.Windows.Forms.MenuItem();
			this.menuItemSiteEditCtx = new System.Windows.Forms.MenuItem();
			this.menuItemSiteRemoveCtx = new System.Windows.Forms.MenuItem();
			this.contextMenuDevice = new System.Windows.Forms.ContextMenu();
			this.menuItemDeviceStartCoachingSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
			this.menuItemDeviceStartCoachingWhisperingCtx = new System.Windows.Forms.MenuItem();
			this.menuItemDeviceStopCoachingCtx = new System.Windows.Forms.MenuItem();
			this.toolBar = new System.Windows.Forms.ToolBar();
			this.toolBarButtonNavi = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonPreview = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonDetails = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonSeparator = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonDevice = new System.Windows.Forms.ToolBarButton();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusBarPanelLog = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanelState = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanelDate = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanelTime = new System.Windows.Forms.StatusBarPanel();
			this.panelNavi = new System.Windows.Forms.Panel();
			this.naviBar = new itCampus.bb.Controls.NaviBar();
			this.naviBarButtonFrontends = new itCampus.bb.Controls.NaviBarButton();
			this.naviBarButtonCampaigns = new itCampus.bb.Controls.NaviBarButton();
			this.naviBarButtonConferences = new itCampus.bb.Controls.NaviBarButton();
			this.naviBarButtonSites = new itCampus.bb.Controls.NaviBarButton();
			this.naviBarButtonDevices = new itCampus.bb.Controls.NaviBarButton();
			this.splitterVertical = new System.Windows.Forms.Splitter();
			this.panelPage = new System.Windows.Forms.Panel();
			this.timerRefresh = new System.Windows.Forms.Timer(this.components);
			this.timerStopCoaching = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelState)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelTime)).BeginInit();
			this.panelNavi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.naviBar)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItemFile,
																					 this.menuItemView,
																					 this.menuItemFrontend,
																					 this.menuItemSite,
																					 this.menuItemDevice,
																					 this.menuItemHelp});
			this.mainMenu.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mainMenu.RightToLeft")));
			// 
			// menuItemFile
			// 
			this.menuItemFile.Enabled = ((bool)(resources.GetObject("menuItemFile.Enabled")));
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemFileEnd});
			this.menuItemFile.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFile.Shortcut")));
			this.menuItemFile.ShowShortcut = ((bool)(resources.GetObject("menuItemFile.ShowShortcut")));
			this.menuItemFile.Text = resources.GetString("menuItemFile.Text");
			this.menuItemFile.Visible = ((bool)(resources.GetObject("menuItemFile.Visible")));
			// 
			// menuItemFileEnd
			// 
			this.menuItemFileEnd.Enabled = ((bool)(resources.GetObject("menuItemFileEnd.Enabled")));
			this.menuItemFileEnd.Index = 0;
			this.menuItemFileEnd.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFileEnd.Shortcut")));
			this.menuItemFileEnd.ShowShortcut = ((bool)(resources.GetObject("menuItemFileEnd.ShowShortcut")));
			this.menuItemFileEnd.Text = resources.GetString("menuItemFileEnd.Text");
			this.menuItemFileEnd.Visible = ((bool)(resources.GetObject("menuItemFileEnd.Visible")));
			this.menuItemFileEnd.Click += new System.EventHandler(this.menuItemFileEnd_Click);
			// 
			// menuItemView
			// 
			this.menuItemView.Enabled = ((bool)(resources.GetObject("menuItemView.Enabled")));
			this.menuItemView.Index = 1;
			this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemViewRefresh});
			this.menuItemView.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemView.Shortcut")));
			this.menuItemView.ShowShortcut = ((bool)(resources.GetObject("menuItemView.ShowShortcut")));
			this.menuItemView.Text = resources.GetString("menuItemView.Text");
			this.menuItemView.Visible = ((bool)(resources.GetObject("menuItemView.Visible")));
			// 
			// menuItemViewRefresh
			// 
			this.menuItemViewRefresh.Enabled = ((bool)(resources.GetObject("menuItemViewRefresh.Enabled")));
			this.menuItemViewRefresh.Index = 0;
			this.menuItemViewRefresh.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemViewRefresh.Shortcut")));
			this.menuItemViewRefresh.ShowShortcut = ((bool)(resources.GetObject("menuItemViewRefresh.ShowShortcut")));
			this.menuItemViewRefresh.Text = resources.GetString("menuItemViewRefresh.Text");
			this.menuItemViewRefresh.Visible = ((bool)(resources.GetObject("menuItemViewRefresh.Visible")));
			this.menuItemViewRefresh.Click += new System.EventHandler(this.menuItemViewRefresh_Click);
			// 
			// menuItemFrontend
			// 
			this.menuItemFrontend.Enabled = ((bool)(resources.GetObject("menuItemFrontend.Enabled")));
			this.menuItemFrontend.Index = 2;
			this.menuItemFrontend.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.menuItemFrontendStartCoachingSilentMonitoring,
																							 this.menuItemFrontendStartCoachingWhispering,
																							 this.menuItemFrontendStopCoaching});
			this.menuItemFrontend.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFrontend.Shortcut")));
			this.menuItemFrontend.ShowShortcut = ((bool)(resources.GetObject("menuItemFrontend.ShowShortcut")));
			this.menuItemFrontend.Text = resources.GetString("menuItemFrontend.Text");
			this.menuItemFrontend.Visible = ((bool)(resources.GetObject("menuItemFrontend.Visible")));
			// 
			// menuItemFrontendStartCoachingSilentMonitoring
			// 
			this.menuItemFrontendStartCoachingSilentMonitoring.Enabled = ((bool)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoring.Enabled")));
			this.menuItemFrontendStartCoachingSilentMonitoring.Index = 0;
			this.menuItemFrontendStartCoachingSilentMonitoring.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoring.Shortcut")));
			this.menuItemFrontendStartCoachingSilentMonitoring.ShowShortcut = ((bool)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoring.ShowShortcut")));
			this.menuItemFrontendStartCoachingSilentMonitoring.Text = resources.GetString("menuItemFrontendStartCoachingSilentMonitoring.Text");
			this.menuItemFrontendStartCoachingSilentMonitoring.Visible = ((bool)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoring.Visible")));
			this.menuItemFrontendStartCoachingSilentMonitoring.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoring_Click);
			// 
			// menuItemFrontendStartCoachingWhispering
			// 
			this.menuItemFrontendStartCoachingWhispering.Enabled = ((bool)(resources.GetObject("menuItemFrontendStartCoachingWhispering.Enabled")));
			this.menuItemFrontendStartCoachingWhispering.Index = 1;
			this.menuItemFrontendStartCoachingWhispering.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFrontendStartCoachingWhispering.Shortcut")));
			this.menuItemFrontendStartCoachingWhispering.ShowShortcut = ((bool)(resources.GetObject("menuItemFrontendStartCoachingWhispering.ShowShortcut")));
			this.menuItemFrontendStartCoachingWhispering.Text = resources.GetString("menuItemFrontendStartCoachingWhispering.Text");
			this.menuItemFrontendStartCoachingWhispering.Visible = ((bool)(resources.GetObject("menuItemFrontendStartCoachingWhispering.Visible")));
			this.menuItemFrontendStartCoachingWhispering.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhispering_Click);
			// 
			// menuItemFrontendStopCoaching
			// 
			this.menuItemFrontendStopCoaching.Enabled = ((bool)(resources.GetObject("menuItemFrontendStopCoaching.Enabled")));
			this.menuItemFrontendStopCoaching.Index = 2;
			this.menuItemFrontendStopCoaching.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFrontendStopCoaching.Shortcut")));
			this.menuItemFrontendStopCoaching.ShowShortcut = ((bool)(resources.GetObject("menuItemFrontendStopCoaching.ShowShortcut")));
			this.menuItemFrontendStopCoaching.Text = resources.GetString("menuItemFrontendStopCoaching.Text");
			this.menuItemFrontendStopCoaching.Visible = ((bool)(resources.GetObject("menuItemFrontendStopCoaching.Visible")));
			this.menuItemFrontendStopCoaching.Click += new System.EventHandler(this.menuItemFrontendStopCoaching_Click);
			// 
			// menuItemSite
			// 
			this.menuItemSite.Enabled = ((bool)(resources.GetObject("menuItemSite.Enabled")));
			this.menuItemSite.Index = 3;
			this.menuItemSite.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemSiteAdd,
																						 this.menuItemSiteEdit,
																						 this.menuItemSiteRemove});
			this.menuItemSite.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemSite.Shortcut")));
			this.menuItemSite.ShowShortcut = ((bool)(resources.GetObject("menuItemSite.ShowShortcut")));
			this.menuItemSite.Text = resources.GetString("menuItemSite.Text");
			this.menuItemSite.Visible = ((bool)(resources.GetObject("menuItemSite.Visible")));
			// 
			// menuItemSiteAdd
			// 
			this.menuItemSiteAdd.Enabled = ((bool)(resources.GetObject("menuItemSiteAdd.Enabled")));
			this.menuItemSiteAdd.Index = 0;
			this.menuItemSiteAdd.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemSiteAdd.Shortcut")));
			this.menuItemSiteAdd.ShowShortcut = ((bool)(resources.GetObject("menuItemSiteAdd.ShowShortcut")));
			this.menuItemSiteAdd.Text = resources.GetString("menuItemSiteAdd.Text");
			this.menuItemSiteAdd.Visible = ((bool)(resources.GetObject("menuItemSiteAdd.Visible")));
			this.menuItemSiteAdd.Click += new System.EventHandler(this.menuItemSiteAdd_Click);
			// 
			// menuItemSiteEdit
			// 
			this.menuItemSiteEdit.Enabled = ((bool)(resources.GetObject("menuItemSiteEdit.Enabled")));
			this.menuItemSiteEdit.Index = 1;
			this.menuItemSiteEdit.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemSiteEdit.Shortcut")));
			this.menuItemSiteEdit.ShowShortcut = ((bool)(resources.GetObject("menuItemSiteEdit.ShowShortcut")));
			this.menuItemSiteEdit.Text = resources.GetString("menuItemSiteEdit.Text");
			this.menuItemSiteEdit.Visible = ((bool)(resources.GetObject("menuItemSiteEdit.Visible")));
			this.menuItemSiteEdit.Click += new System.EventHandler(this.menuItemSiteEdit_Click);
			// 
			// menuItemSiteRemove
			// 
			this.menuItemSiteRemove.Enabled = ((bool)(resources.GetObject("menuItemSiteRemove.Enabled")));
			this.menuItemSiteRemove.Index = 2;
			this.menuItemSiteRemove.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemSiteRemove.Shortcut")));
			this.menuItemSiteRemove.ShowShortcut = ((bool)(resources.GetObject("menuItemSiteRemove.ShowShortcut")));
			this.menuItemSiteRemove.Text = resources.GetString("menuItemSiteRemove.Text");
			this.menuItemSiteRemove.Visible = ((bool)(resources.GetObject("menuItemSiteRemove.Visible")));
			this.menuItemSiteRemove.Click += new System.EventHandler(this.menuItemSiteRemove_Click);
			// 
			// menuItemDevice
			// 
			this.menuItemDevice.Enabled = ((bool)(resources.GetObject("menuItemDevice.Enabled")));
			this.menuItemDevice.Index = 4;
			this.menuItemDevice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItemDeviceStartCoachingSilentMonitoring,
																						   this.menuItemDeviceStartCoachingWhispering,
																						   this.menuItemDeviceStopCoaching});
			this.menuItemDevice.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDevice.Shortcut")));
			this.menuItemDevice.ShowShortcut = ((bool)(resources.GetObject("menuItemDevice.ShowShortcut")));
			this.menuItemDevice.Text = resources.GetString("menuItemDevice.Text");
			this.menuItemDevice.Visible = ((bool)(resources.GetObject("menuItemDevice.Visible")));
			// 
			// menuItemDeviceStartCoachingSilentMonitoring
			// 
			this.menuItemDeviceStartCoachingSilentMonitoring.Enabled = ((bool)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoring.Enabled")));
			this.menuItemDeviceStartCoachingSilentMonitoring.Index = 0;
			this.menuItemDeviceStartCoachingSilentMonitoring.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoring.Shortcut")));
			this.menuItemDeviceStartCoachingSilentMonitoring.ShowShortcut = ((bool)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoring.ShowShortcut")));
			this.menuItemDeviceStartCoachingSilentMonitoring.Text = resources.GetString("menuItemDeviceStartCoachingSilentMonitoring.Text");
			this.menuItemDeviceStartCoachingSilentMonitoring.Visible = ((bool)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoring.Visible")));
			this.menuItemDeviceStartCoachingSilentMonitoring.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoring_Click);
			// 
			// menuItemDeviceStartCoachingWhispering
			// 
			this.menuItemDeviceStartCoachingWhispering.Enabled = ((bool)(resources.GetObject("menuItemDeviceStartCoachingWhispering.Enabled")));
			this.menuItemDeviceStartCoachingWhispering.Index = 1;
			this.menuItemDeviceStartCoachingWhispering.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDeviceStartCoachingWhispering.Shortcut")));
			this.menuItemDeviceStartCoachingWhispering.ShowShortcut = ((bool)(resources.GetObject("menuItemDeviceStartCoachingWhispering.ShowShortcut")));
			this.menuItemDeviceStartCoachingWhispering.Text = resources.GetString("menuItemDeviceStartCoachingWhispering.Text");
			this.menuItemDeviceStartCoachingWhispering.Visible = ((bool)(resources.GetObject("menuItemDeviceStartCoachingWhispering.Visible")));
			this.menuItemDeviceStartCoachingWhispering.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhispering_Click);
			// 
			// menuItemDeviceStopCoaching
			// 
			this.menuItemDeviceStopCoaching.Enabled = ((bool)(resources.GetObject("menuItemDeviceStopCoaching.Enabled")));
			this.menuItemDeviceStopCoaching.Index = 2;
			this.menuItemDeviceStopCoaching.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDeviceStopCoaching.Shortcut")));
			this.menuItemDeviceStopCoaching.ShowShortcut = ((bool)(resources.GetObject("menuItemDeviceStopCoaching.ShowShortcut")));
			this.menuItemDeviceStopCoaching.Text = resources.GetString("menuItemDeviceStopCoaching.Text");
			this.menuItemDeviceStopCoaching.Visible = ((bool)(resources.GetObject("menuItemDeviceStopCoaching.Visible")));
			this.menuItemDeviceStopCoaching.Click += new System.EventHandler(this.menuItemDeviceStopCoaching_Click);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Enabled = ((bool)(resources.GetObject("menuItemHelp.Enabled")));
			this.menuItemHelp.Index = 5;
			this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemHelpInfo});
			this.menuItemHelp.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemHelp.Shortcut")));
			this.menuItemHelp.ShowShortcut = ((bool)(resources.GetObject("menuItemHelp.ShowShortcut")));
			this.menuItemHelp.Text = resources.GetString("menuItemHelp.Text");
			this.menuItemHelp.Visible = ((bool)(resources.GetObject("menuItemHelp.Visible")));
			// 
			// menuItemHelpInfo
			// 
			this.menuItemHelpInfo.Enabled = ((bool)(resources.GetObject("menuItemHelpInfo.Enabled")));
			this.menuItemHelpInfo.Index = 0;
			this.menuItemHelpInfo.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemHelpInfo.Shortcut")));
			this.menuItemHelpInfo.ShowShortcut = ((bool)(resources.GetObject("menuItemHelpInfo.ShowShortcut")));
			this.menuItemHelpInfo.Text = resources.GetString("menuItemHelpInfo.Text");
			this.menuItemHelpInfo.Visible = ((bool)(resources.GetObject("menuItemHelpInfo.Visible")));
			this.menuItemHelpInfo.Click += new System.EventHandler(this.menuItemHelpInfo_Click);
			// 
			// contextMenuFrontend
			// 
			this.contextMenuFrontend.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								this.menuItemFrontendStartCoachingSilentMonitoringCtx,
																								this.menuItemFrontendStartCoachingWhisperingCtx,
																								this.menuItemFrontendStopCoachingCtx});
			this.contextMenuFrontend.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenuFrontend.RightToLeft")));
			// 
			// menuItemFrontendStartCoachingSilentMonitoringCtx
			// 
			this.menuItemFrontendStartCoachingSilentMonitoringCtx.Enabled = ((bool)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoringCtx.Enabled")));
			this.menuItemFrontendStartCoachingSilentMonitoringCtx.Index = 0;
			this.menuItemFrontendStartCoachingSilentMonitoringCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoringCtx.Shortcut")));
			this.menuItemFrontendStartCoachingSilentMonitoringCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoringCtx.ShowShortcut")));
			this.menuItemFrontendStartCoachingSilentMonitoringCtx.Text = resources.GetString("menuItemFrontendStartCoachingSilentMonitoringCtx.Text");
			this.menuItemFrontendStartCoachingSilentMonitoringCtx.Visible = ((bool)(resources.GetObject("menuItemFrontendStartCoachingSilentMonitoringCtx.Visible")));
			this.menuItemFrontendStartCoachingSilentMonitoringCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoring_Click);
			// 
			// menuItemFrontendStartCoachingWhisperingCtx
			// 
			this.menuItemFrontendStartCoachingWhisperingCtx.Enabled = ((bool)(resources.GetObject("menuItemFrontendStartCoachingWhisperingCtx.Enabled")));
			this.menuItemFrontendStartCoachingWhisperingCtx.Index = 1;
			this.menuItemFrontendStartCoachingWhisperingCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFrontendStartCoachingWhisperingCtx.Shortcut")));
			this.menuItemFrontendStartCoachingWhisperingCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemFrontendStartCoachingWhisperingCtx.ShowShortcut")));
			this.menuItemFrontendStartCoachingWhisperingCtx.Text = resources.GetString("menuItemFrontendStartCoachingWhisperingCtx.Text");
			this.menuItemFrontendStartCoachingWhisperingCtx.Visible = ((bool)(resources.GetObject("menuItemFrontendStartCoachingWhisperingCtx.Visible")));
			this.menuItemFrontendStartCoachingWhisperingCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhispering_Click);
			// 
			// menuItemFrontendStopCoachingCtx
			// 
			this.menuItemFrontendStopCoachingCtx.Enabled = ((bool)(resources.GetObject("menuItemFrontendStopCoachingCtx.Enabled")));
			this.menuItemFrontendStopCoachingCtx.Index = 2;
			this.menuItemFrontendStopCoachingCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemFrontendStopCoachingCtx.Shortcut")));
			this.menuItemFrontendStopCoachingCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemFrontendStopCoachingCtx.ShowShortcut")));
			this.menuItemFrontendStopCoachingCtx.Text = resources.GetString("menuItemFrontendStopCoachingCtx.Text");
			this.menuItemFrontendStopCoachingCtx.Visible = ((bool)(resources.GetObject("menuItemFrontendStopCoachingCtx.Visible")));
			this.menuItemFrontendStopCoachingCtx.Click += new System.EventHandler(this.menuItemFrontendStopCoaching_Click);
			// 
			// contextMenuSite
			// 
			this.contextMenuSite.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItemSiteAddCtx,
																							this.menuItemSiteEditCtx,
																							this.menuItemSiteRemoveCtx});
			this.contextMenuSite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenuSite.RightToLeft")));
			// 
			// menuItemSiteAddCtx
			// 
			this.menuItemSiteAddCtx.Enabled = ((bool)(resources.GetObject("menuItemSiteAddCtx.Enabled")));
			this.menuItemSiteAddCtx.Index = 0;
			this.menuItemSiteAddCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemSiteAddCtx.Shortcut")));
			this.menuItemSiteAddCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemSiteAddCtx.ShowShortcut")));
			this.menuItemSiteAddCtx.Text = resources.GetString("menuItemSiteAddCtx.Text");
			this.menuItemSiteAddCtx.Visible = ((bool)(resources.GetObject("menuItemSiteAddCtx.Visible")));
			this.menuItemSiteAddCtx.Click += new System.EventHandler(this.menuItemSiteAdd_Click);
			// 
			// menuItemSiteEditCtx
			// 
			this.menuItemSiteEditCtx.Enabled = ((bool)(resources.GetObject("menuItemSiteEditCtx.Enabled")));
			this.menuItemSiteEditCtx.Index = 1;
			this.menuItemSiteEditCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemSiteEditCtx.Shortcut")));
			this.menuItemSiteEditCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemSiteEditCtx.ShowShortcut")));
			this.menuItemSiteEditCtx.Text = resources.GetString("menuItemSiteEditCtx.Text");
			this.menuItemSiteEditCtx.Visible = ((bool)(resources.GetObject("menuItemSiteEditCtx.Visible")));
			this.menuItemSiteEditCtx.Click += new System.EventHandler(this.menuItemSiteEdit_Click);
			// 
			// menuItemSiteRemoveCtx
			// 
			this.menuItemSiteRemoveCtx.Enabled = ((bool)(resources.GetObject("menuItemSiteRemoveCtx.Enabled")));
			this.menuItemSiteRemoveCtx.Index = 2;
			this.menuItemSiteRemoveCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemSiteRemoveCtx.Shortcut")));
			this.menuItemSiteRemoveCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemSiteRemoveCtx.ShowShortcut")));
			this.menuItemSiteRemoveCtx.Text = resources.GetString("menuItemSiteRemoveCtx.Text");
			this.menuItemSiteRemoveCtx.Visible = ((bool)(resources.GetObject("menuItemSiteRemoveCtx.Visible")));
			this.menuItemSiteRemoveCtx.Click += new System.EventHandler(this.menuItemSiteRemove_Click);
			// 
			// contextMenuDevice
			// 
			this.contextMenuDevice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							  this.menuItemDeviceStartCoachingSilentMonitoringCtx,
																							  this.menuItemDeviceStartCoachingWhisperingCtx,
																							  this.menuItemDeviceStopCoachingCtx});
			this.contextMenuDevice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenuDevice.RightToLeft")));
			// 
			// menuItemDeviceStartCoachingSilentMonitoringCtx
			// 
			this.menuItemDeviceStartCoachingSilentMonitoringCtx.Enabled = ((bool)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoringCtx.Enabled")));
			this.menuItemDeviceStartCoachingSilentMonitoringCtx.Index = 0;
			this.menuItemDeviceStartCoachingSilentMonitoringCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoringCtx.Shortcut")));
			this.menuItemDeviceStartCoachingSilentMonitoringCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoringCtx.ShowShortcut")));
			this.menuItemDeviceStartCoachingSilentMonitoringCtx.Text = resources.GetString("menuItemDeviceStartCoachingSilentMonitoringCtx.Text");
			this.menuItemDeviceStartCoachingSilentMonitoringCtx.Visible = ((bool)(resources.GetObject("menuItemDeviceStartCoachingSilentMonitoringCtx.Visible")));
			this.menuItemDeviceStartCoachingSilentMonitoringCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoring_Click);
			// 
			// menuItemDeviceStartCoachingWhisperingCtx
			// 
			this.menuItemDeviceStartCoachingWhisperingCtx.Enabled = ((bool)(resources.GetObject("menuItemDeviceStartCoachingWhisperingCtx.Enabled")));
			this.menuItemDeviceStartCoachingWhisperingCtx.Index = 1;
			this.menuItemDeviceStartCoachingWhisperingCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDeviceStartCoachingWhisperingCtx.Shortcut")));
			this.menuItemDeviceStartCoachingWhisperingCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemDeviceStartCoachingWhisperingCtx.ShowShortcut")));
			this.menuItemDeviceStartCoachingWhisperingCtx.Text = resources.GetString("menuItemDeviceStartCoachingWhisperingCtx.Text");
			this.menuItemDeviceStartCoachingWhisperingCtx.Visible = ((bool)(resources.GetObject("menuItemDeviceStartCoachingWhisperingCtx.Visible")));
			this.menuItemDeviceStartCoachingWhisperingCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhispering_Click);
			// 
			// menuItemDeviceStopCoachingCtx
			// 
			this.menuItemDeviceStopCoachingCtx.Enabled = ((bool)(resources.GetObject("menuItemDeviceStopCoachingCtx.Enabled")));
			this.menuItemDeviceStopCoachingCtx.Index = 2;
			this.menuItemDeviceStopCoachingCtx.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDeviceStopCoachingCtx.Shortcut")));
			this.menuItemDeviceStopCoachingCtx.ShowShortcut = ((bool)(resources.GetObject("menuItemDeviceStopCoachingCtx.ShowShortcut")));
			this.menuItemDeviceStopCoachingCtx.Text = resources.GetString("menuItemDeviceStopCoachingCtx.Text");
			this.menuItemDeviceStopCoachingCtx.Visible = ((bool)(resources.GetObject("menuItemDeviceStopCoachingCtx.Visible")));
			this.menuItemDeviceStopCoachingCtx.Click += new System.EventHandler(this.menuItemDeviceStopCoaching_Click);
			// 
			// toolBar
			// 
			this.toolBar.AccessibleDescription = resources.GetString("toolBar.AccessibleDescription");
			this.toolBar.AccessibleName = resources.GetString("toolBar.AccessibleName");
			this.toolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("toolBar.Anchor")));
			this.toolBar.Appearance = ((System.Windows.Forms.ToolBarAppearance)(resources.GetObject("toolBar.Appearance")));
			this.toolBar.AutoSize = ((bool)(resources.GetObject("toolBar.AutoSize")));
			this.toolBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolBar.BackgroundImage")));
			this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					   this.toolBarButtonNavi,
																					   this.toolBarButtonPreview,
																					   this.toolBarButtonDetails,
																					   this.toolBarButtonSeparator,
																					   this.toolBarButtonDevice});
			this.toolBar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("toolBar.Dock")));
			this.toolBar.DropDownArrows = ((bool)(resources.GetObject("toolBar.DropDownArrows")));
			this.toolBar.Enabled = ((bool)(resources.GetObject("toolBar.Enabled")));
			this.toolBar.Font = ((System.Drawing.Font)(resources.GetObject("toolBar.Font")));
			this.toolBar.ImageList = this.imageList;
			this.toolBar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("toolBar.ImeMode")));
			this.toolBar.Location = ((System.Drawing.Point)(resources.GetObject("toolBar.Location")));
			this.toolBar.Name = "toolBar";
			this.toolBar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("toolBar.RightToLeft")));
			this.toolBar.ShowToolTips = ((bool)(resources.GetObject("toolBar.ShowToolTips")));
			this.toolBar.Size = ((System.Drawing.Size)(resources.GetObject("toolBar.Size")));
			this.toolBar.TabIndex = ((int)(resources.GetObject("toolBar.TabIndex")));
			this.toolBar.TextAlign = ((System.Windows.Forms.ToolBarTextAlign)(resources.GetObject("toolBar.TextAlign")));
			this.toolBar.Visible = ((bool)(resources.GetObject("toolBar.Visible")));
			this.toolBar.Wrappable = ((bool)(resources.GetObject("toolBar.Wrappable")));
			this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
			// 
			// toolBarButtonNavi
			// 
			this.toolBarButtonNavi.Enabled = ((bool)(resources.GetObject("toolBarButtonNavi.Enabled")));
			this.toolBarButtonNavi.ImageIndex = ((int)(resources.GetObject("toolBarButtonNavi.ImageIndex")));
			this.toolBarButtonNavi.Pushed = true;
			this.toolBarButtonNavi.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolBarButtonNavi.Text = resources.GetString("toolBarButtonNavi.Text");
			this.toolBarButtonNavi.ToolTipText = resources.GetString("toolBarButtonNavi.ToolTipText");
			this.toolBarButtonNavi.Visible = ((bool)(resources.GetObject("toolBarButtonNavi.Visible")));
			// 
			// toolBarButtonPreview
			// 
			this.toolBarButtonPreview.Enabled = ((bool)(resources.GetObject("toolBarButtonPreview.Enabled")));
			this.toolBarButtonPreview.ImageIndex = ((int)(resources.GetObject("toolBarButtonPreview.ImageIndex")));
			this.toolBarButtonPreview.Pushed = true;
			this.toolBarButtonPreview.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolBarButtonPreview.Text = resources.GetString("toolBarButtonPreview.Text");
			this.toolBarButtonPreview.ToolTipText = resources.GetString("toolBarButtonPreview.ToolTipText");
			this.toolBarButtonPreview.Visible = ((bool)(resources.GetObject("toolBarButtonPreview.Visible")));
			// 
			// toolBarButtonDetails
			// 
			this.toolBarButtonDetails.Enabled = ((bool)(resources.GetObject("toolBarButtonDetails.Enabled")));
			this.toolBarButtonDetails.ImageIndex = ((int)(resources.GetObject("toolBarButtonDetails.ImageIndex")));
			this.toolBarButtonDetails.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolBarButtonDetails.Text = resources.GetString("toolBarButtonDetails.Text");
			this.toolBarButtonDetails.ToolTipText = resources.GetString("toolBarButtonDetails.ToolTipText");
			this.toolBarButtonDetails.Visible = ((bool)(resources.GetObject("toolBarButtonDetails.Visible")));
			// 
			// toolBarButtonSeparator
			// 
			this.toolBarButtonSeparator.Enabled = ((bool)(resources.GetObject("toolBarButtonSeparator.Enabled")));
			this.toolBarButtonSeparator.ImageIndex = ((int)(resources.GetObject("toolBarButtonSeparator.ImageIndex")));
			this.toolBarButtonSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButtonSeparator.Text = resources.GetString("toolBarButtonSeparator.Text");
			this.toolBarButtonSeparator.ToolTipText = resources.GetString("toolBarButtonSeparator.ToolTipText");
			this.toolBarButtonSeparator.Visible = ((bool)(resources.GetObject("toolBarButtonSeparator.Visible")));
			// 
			// toolBarButtonDevice
			// 
			this.toolBarButtonDevice.Enabled = ((bool)(resources.GetObject("toolBarButtonDevice.Enabled")));
			this.toolBarButtonDevice.ImageIndex = ((int)(resources.GetObject("toolBarButtonDevice.ImageIndex")));
			this.toolBarButtonDevice.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolBarButtonDevice.Text = resources.GetString("toolBarButtonDevice.Text");
			this.toolBarButtonDevice.ToolTipText = resources.GetString("toolBarButtonDevice.ToolTipText");
			this.toolBarButtonDevice.Visible = ((bool)(resources.GetObject("toolBarButtonDevice.Visible")));
			// 
			// imageList
			// 
			this.imageList.ImageSize = ((System.Drawing.Size)(resources.GetObject("imageList.ImageSize")));
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// statusBar
			// 
			this.statusBar.AccessibleDescription = resources.GetString("statusBar.AccessibleDescription");
			this.statusBar.AccessibleName = resources.GetString("statusBar.AccessibleName");
			this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("statusBar.Anchor")));
			this.statusBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusBar.BackgroundImage")));
			this.statusBar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("statusBar.Dock")));
			this.statusBar.Enabled = ((bool)(resources.GetObject("statusBar.Enabled")));
			this.statusBar.Font = ((System.Drawing.Font)(resources.GetObject("statusBar.Font")));
			this.statusBar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("statusBar.ImeMode")));
			this.statusBar.Location = ((System.Drawing.Point)(resources.GetObject("statusBar.Location")));
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						 this.statusBarPanelLog,
																						 this.statusBarPanelState,
																						 this.statusBarPanelDate,
																						 this.statusBarPanelTime});
			this.statusBar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("statusBar.RightToLeft")));
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = ((System.Drawing.Size)(resources.GetObject("statusBar.Size")));
			this.statusBar.TabIndex = ((int)(resources.GetObject("statusBar.TabIndex")));
			this.statusBar.Text = resources.GetString("statusBar.Text");
			this.statusBar.Visible = ((bool)(resources.GetObject("statusBar.Visible")));
			// 
			// statusBarPanelLog
			// 
			this.statusBarPanelLog.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("statusBarPanelLog.Alignment")));
			this.statusBarPanelLog.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanelLog.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanelLog.Icon")));
			this.statusBarPanelLog.MinWidth = ((int)(resources.GetObject("statusBarPanelLog.MinWidth")));
			this.statusBarPanelLog.Text = resources.GetString("statusBarPanelLog.Text");
			this.statusBarPanelLog.ToolTipText = resources.GetString("statusBarPanelLog.ToolTipText");
			this.statusBarPanelLog.Width = ((int)(resources.GetObject("statusBarPanelLog.Width")));
			// 
			// statusBarPanelState
			// 
			this.statusBarPanelState.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("statusBarPanelState.Alignment")));
			this.statusBarPanelState.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanelState.Icon")));
			this.statusBarPanelState.MinWidth = ((int)(resources.GetObject("statusBarPanelState.MinWidth")));
			this.statusBarPanelState.Text = resources.GetString("statusBarPanelState.Text");
			this.statusBarPanelState.ToolTipText = resources.GetString("statusBarPanelState.ToolTipText");
			this.statusBarPanelState.Width = ((int)(resources.GetObject("statusBarPanelState.Width")));
			// 
			// statusBarPanelDate
			// 
			this.statusBarPanelDate.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("statusBarPanelDate.Alignment")));
			this.statusBarPanelDate.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanelDate.Icon")));
			this.statusBarPanelDate.MinWidth = ((int)(resources.GetObject("statusBarPanelDate.MinWidth")));
			this.statusBarPanelDate.Text = resources.GetString("statusBarPanelDate.Text");
			this.statusBarPanelDate.ToolTipText = resources.GetString("statusBarPanelDate.ToolTipText");
			this.statusBarPanelDate.Width = ((int)(resources.GetObject("statusBarPanelDate.Width")));
			// 
			// statusBarPanelTime
			// 
			this.statusBarPanelTime.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("statusBarPanelTime.Alignment")));
			this.statusBarPanelTime.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanelTime.Icon")));
			this.statusBarPanelTime.MinWidth = ((int)(resources.GetObject("statusBarPanelTime.MinWidth")));
			this.statusBarPanelTime.Text = resources.GetString("statusBarPanelTime.Text");
			this.statusBarPanelTime.ToolTipText = resources.GetString("statusBarPanelTime.ToolTipText");
			this.statusBarPanelTime.Width = ((int)(resources.GetObject("statusBarPanelTime.Width")));
			// 
			// panelNavi
			// 
			this.panelNavi.AccessibleDescription = resources.GetString("panelNavi.AccessibleDescription");
			this.panelNavi.AccessibleName = resources.GetString("panelNavi.AccessibleName");
			this.panelNavi.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelNavi.Anchor")));
			this.panelNavi.AutoScroll = ((bool)(resources.GetObject("panelNavi.AutoScroll")));
			this.panelNavi.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelNavi.AutoScrollMargin")));
			this.panelNavi.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelNavi.AutoScrollMinSize")));
			this.panelNavi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNavi.BackgroundImage")));
			this.panelNavi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelNavi.Controls.Add(this.naviBar);
			this.panelNavi.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelNavi.Dock")));
			this.panelNavi.Enabled = ((bool)(resources.GetObject("panelNavi.Enabled")));
			this.panelNavi.Font = ((System.Drawing.Font)(resources.GetObject("panelNavi.Font")));
			this.panelNavi.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelNavi.ImeMode")));
			this.panelNavi.Location = ((System.Drawing.Point)(resources.GetObject("panelNavi.Location")));
			this.panelNavi.Name = "panelNavi";
			this.panelNavi.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelNavi.RightToLeft")));
			this.panelNavi.Size = ((System.Drawing.Size)(resources.GetObject("panelNavi.Size")));
			this.panelNavi.TabIndex = ((int)(resources.GetObject("panelNavi.TabIndex")));
			this.panelNavi.Text = resources.GetString("panelNavi.Text");
			this.panelNavi.Visible = ((bool)(resources.GetObject("panelNavi.Visible")));
			// 
			// naviBar
			// 
			this.naviBar.AccessibleDescription = resources.GetString("naviBar.AccessibleDescription");
			this.naviBar.AccessibleName = resources.GetString("naviBar.AccessibleName");
			this.naviBar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("naviBar.Anchor")));
			this.naviBar.AutoScroll = ((bool)(resources.GetObject("naviBar.AutoScroll")));
			this.naviBar.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("naviBar.AutoScrollMargin")));
			this.naviBar.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("naviBar.AutoScrollMinSize")));
			this.naviBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviBar.BackgroundImage")));
			this.naviBar.Buttons.AddRange(new itCampus.bb.Controls.NaviBarButton[] {
																					   this.naviBarButtonFrontends,
																					   this.naviBarButtonCampaigns,
																					   this.naviBarButtonConferences,
																					   this.naviBarButtonSites,
																					   this.naviBarButtonDevices});
			this.naviBar.ButtonSize = ((System.Drawing.Size)(resources.GetObject("naviBar.ButtonSize")));
			this.naviBar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("naviBar.Dock")));
			this.naviBar.Enabled = ((bool)(resources.GetObject("naviBar.Enabled")));
			this.naviBar.Font = ((System.Drawing.Font)(resources.GetObject("naviBar.Font")));
			this.naviBar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("naviBar.ImeMode")));
			this.naviBar.Location = ((System.Drawing.Point)(resources.GetObject("naviBar.Location")));
			this.naviBar.Name = "naviBar";
			this.naviBar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("naviBar.RightToLeft")));
			this.naviBar.Size = ((System.Drawing.Size)(resources.GetObject("naviBar.Size")));
			this.naviBar.TabIndex = ((int)(resources.GetObject("naviBar.TabIndex")));
			this.naviBar.Visible = ((bool)(resources.GetObject("naviBar.Visible")));
			this.naviBar.ButtonClick += new itCampus.bb.Controls.NaviBar.NaviBarClickEventHandler(this.naviBar_ButtonClick);
			// 
			// naviBarButtonFrontends
			// 
			this.naviBarButtonFrontends.Image = ((System.Drawing.Image)(resources.GetObject("naviBarButtonFrontends.Image")));
			this.naviBarButtonFrontends.Pushed = ((bool)(resources.GetObject("naviBarButtonFrontends.Pushed")));
			this.naviBarButtonFrontends.Style = ((itCampus.bb.Controls.NaviBarButtonStyle)(resources.GetObject("naviBarButtonFrontends.Style")));
			this.naviBarButtonFrontends.Tag = ((object)(resources.GetObject("naviBarButtonFrontends.Tag")));
			this.naviBarButtonFrontends.Text = resources.GetString("naviBarButtonFrontends.Text");
			// 
			// naviBarButtonCampaigns
			// 
			this.naviBarButtonCampaigns.Image = ((System.Drawing.Image)(resources.GetObject("naviBarButtonCampaigns.Image")));
			this.naviBarButtonCampaigns.Pushed = ((bool)(resources.GetObject("naviBarButtonCampaigns.Pushed")));
			this.naviBarButtonCampaigns.Style = ((itCampus.bb.Controls.NaviBarButtonStyle)(resources.GetObject("naviBarButtonCampaigns.Style")));
			this.naviBarButtonCampaigns.Tag = ((object)(resources.GetObject("naviBarButtonCampaigns.Tag")));
			this.naviBarButtonCampaigns.Text = resources.GetString("naviBarButtonCampaigns.Text");
			// 
			// naviBarButtonConferences
			// 
			this.naviBarButtonConferences.Image = ((System.Drawing.Image)(resources.GetObject("naviBarButtonConferences.Image")));
			this.naviBarButtonConferences.Pushed = ((bool)(resources.GetObject("naviBarButtonConferences.Pushed")));
			this.naviBarButtonConferences.Style = ((itCampus.bb.Controls.NaviBarButtonStyle)(resources.GetObject("naviBarButtonConferences.Style")));
			this.naviBarButtonConferences.Tag = ((object)(resources.GetObject("naviBarButtonConferences.Tag")));
			this.naviBarButtonConferences.Text = resources.GetString("naviBarButtonConferences.Text");
			// 
			// naviBarButtonSites
			// 
			this.naviBarButtonSites.Image = ((System.Drawing.Image)(resources.GetObject("naviBarButtonSites.Image")));
			this.naviBarButtonSites.Pushed = ((bool)(resources.GetObject("naviBarButtonSites.Pushed")));
			this.naviBarButtonSites.Style = ((itCampus.bb.Controls.NaviBarButtonStyle)(resources.GetObject("naviBarButtonSites.Style")));
			this.naviBarButtonSites.Tag = ((object)(resources.GetObject("naviBarButtonSites.Tag")));
			this.naviBarButtonSites.Text = resources.GetString("naviBarButtonSites.Text");
			// 
			// naviBarButtonDevices
			// 
			this.naviBarButtonDevices.Image = ((System.Drawing.Image)(resources.GetObject("naviBarButtonDevices.Image")));
			this.naviBarButtonDevices.Pushed = ((bool)(resources.GetObject("naviBarButtonDevices.Pushed")));
			this.naviBarButtonDevices.Style = ((itCampus.bb.Controls.NaviBarButtonStyle)(resources.GetObject("naviBarButtonDevices.Style")));
			this.naviBarButtonDevices.Tag = ((object)(resources.GetObject("naviBarButtonDevices.Tag")));
			this.naviBarButtonDevices.Text = resources.GetString("naviBarButtonDevices.Text");
			// 
			// splitterVertical
			// 
			this.splitterVertical.AccessibleDescription = resources.GetString("splitterVertical.AccessibleDescription");
			this.splitterVertical.AccessibleName = resources.GetString("splitterVertical.AccessibleName");
			this.splitterVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("splitterVertical.Anchor")));
			this.splitterVertical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitterVertical.BackgroundImage")));
			this.splitterVertical.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("splitterVertical.Dock")));
			this.splitterVertical.Enabled = ((bool)(resources.GetObject("splitterVertical.Enabled")));
			this.splitterVertical.Font = ((System.Drawing.Font)(resources.GetObject("splitterVertical.Font")));
			this.splitterVertical.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("splitterVertical.ImeMode")));
			this.splitterVertical.Location = ((System.Drawing.Point)(resources.GetObject("splitterVertical.Location")));
			this.splitterVertical.MinExtra = ((int)(resources.GetObject("splitterVertical.MinExtra")));
			this.splitterVertical.MinSize = ((int)(resources.GetObject("splitterVertical.MinSize")));
			this.splitterVertical.Name = "splitterVertical";
			this.splitterVertical.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("splitterVertical.RightToLeft")));
			this.splitterVertical.Size = ((System.Drawing.Size)(resources.GetObject("splitterVertical.Size")));
			this.splitterVertical.TabIndex = ((int)(resources.GetObject("splitterVertical.TabIndex")));
			this.splitterVertical.TabStop = false;
			this.splitterVertical.Visible = ((bool)(resources.GetObject("splitterVertical.Visible")));
			// 
			// panelPage
			// 
			this.panelPage.AccessibleDescription = resources.GetString("panelPage.AccessibleDescription");
			this.panelPage.AccessibleName = resources.GetString("panelPage.AccessibleName");
			this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelPage.Anchor")));
			this.panelPage.AutoScroll = ((bool)(resources.GetObject("panelPage.AutoScroll")));
			this.panelPage.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelPage.AutoScrollMargin")));
			this.panelPage.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelPage.AutoScrollMinSize")));
			this.panelPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPage.BackgroundImage")));
			this.panelPage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelPage.Dock")));
			this.panelPage.Enabled = ((bool)(resources.GetObject("panelPage.Enabled")));
			this.panelPage.Font = ((System.Drawing.Font)(resources.GetObject("panelPage.Font")));
			this.panelPage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelPage.ImeMode")));
			this.panelPage.Location = ((System.Drawing.Point)(resources.GetObject("panelPage.Location")));
			this.panelPage.Name = "panelPage";
			this.panelPage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelPage.RightToLeft")));
			this.panelPage.Size = ((System.Drawing.Size)(resources.GetObject("panelPage.Size")));
			this.panelPage.TabIndex = ((int)(resources.GetObject("panelPage.TabIndex")));
			this.panelPage.Text = resources.GetString("panelPage.Text");
			this.panelPage.Visible = ((bool)(resources.GetObject("panelPage.Visible")));
			// 
			// timerRefresh
			// 
			this.timerRefresh.Enabled = true;
			this.timerRefresh.Interval = 1000;
			this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
			// 
			// timerStopCoaching
			// 
			this.timerStopCoaching.Interval = 1;
			this.timerStopCoaching.Tick += new System.EventHandler(this.timerStopCoaching_Tick);
			// 
			// MainForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.panelPage);
			this.Controls.Add(this.splitterVertical);
			this.Controls.Add(this.panelNavi);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.toolBar);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.Menu = this.mainMenu;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "MainForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Closed += new System.EventHandler(this.MainForm_Closed);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelState)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelTime)).EndInit();
			this.panelNavi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.naviBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Formular --------------------------

		/// <summary>
		/// initialisiert Anwendung
		/// </summary>
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			try
			{
				// Hauptobjekt initialisieren
				_mainControl = new MainControl();
				_mainControl.OnAgentLost += new MainControl.OnAgentLostEventHandler(
					_mainControl_OnAgentLost);
				_mainControl.OnDeviceTerminated += new MainControl.OnDeviceTerminatedEventHandler(
					_mainControl_OnDeviceTerminated);
				_mainControl.OnConnectionLost += new MainControl.OnConnectionLostEventHandler(
					_mainControl_OnConnectionLost);

				// Frontendverwaltung referenzieren
				_frontendControl = _mainControl.FrontendControl;
				_frontendControl.OnRefreshFrontend += new FrontendControl.FrontendEventHandler(
					_frontendControl_OnRefreshFrontend);

				// Statusleiste initialisieren
				RefreshStatusBar();

				// Schaltfläche für Device initialisieren
				toolBarButtonDevice.Enabled = Settings.Instance.DeviceCode != "";

				// Kategorieseiten initialisieren
				_frontendPage = new FrontendPage(_mainControl.FrontendControl);
				_frontendPage.Dock = DockStyle.Fill;
				_frontendPage.ContextMenu = contextMenuFrontend;
				_frontendPage.OnSelectedItemChanged += new Page.OnSelectedItemChangedEventHandler(
					_frontendPage_OnSelectedItemChanged);
				_campaignPage = new CampaignPage(_mainControl.CampaignControl);
				_campaignPage.Dock = DockStyle.Fill;
				_conferencePage = new ConferencePage(_mainControl.ConferenceControl);
				_conferencePage.Dock = DockStyle.Fill;
				_sitePage = new SitePage(_mainControl.SiteControl);
				_sitePage.Dock = DockStyle.Fill;
				_sitePage.ContextMenu = contextMenuSite;
				_sitePage.SiteViewContextMenu = contextMenuDevice;
				_sitePage.OnSelectedItemChanged += new Page.OnSelectedItemChangedEventHandler(
					_sitePage_OnSelectedItemChanged);
				_sitePage.OnSelectedDeviceChanged +=
					new SitePage.OnSelectedDeviceChangedEventHandler(
					_sitePage_OnSelectedDeviceChanged);
				_devicePage = new DevicePage(_mainControl.DeviceControl);
				_devicePage.Dock = DockStyle.Fill;

				// Kategorieseiten zu Formular hinzufügen
				panelPage.Controls.Add(_frontendPage);
				panelPage.Controls.Add(_campaignPage);
				panelPage.Controls.Add(_conferencePage);
				panelPage.Controls.Add(_sitePage);
				panelPage.Controls.Add(_devicePage);

				// Frontendseite anzeigen
				SelectPage(0);

				// Steuerelemente aktualisieren
				RefreshControls();

				// Konfiguration laden
				_mainControl.LoadConfig();

				// Monitoring starten
				_mainControl.StartMonitoring();
			}
			catch (Exception ex)
			{
				// Meldung ausgeben
				MessageBox.Show(this, ex.Message + Environment.NewLine + ex.InnerException,
					Resources.GetString("MainForm.MessageBox.Caption.InitializeError"),
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Formular schließen
				this.Close();
			}
		}

		/// <summary>
		/// schließt Anwendung ab
		/// </summary>
		private void MainForm_Closed(object sender, System.EventArgs e)
		{
			// wenn Frontendverwaltung referenziert, freigeben
			if (_frontendControl != null)
			{
				_frontendControl.OnRefreshFrontend -= new FrontendControl.FrontendEventHandler(
					_frontendControl_OnRefreshFrontend);
				_frontendControl = null;
			}

			// wenn Hauptobjekt initialisiert
			if (_mainControl != null)
			{
				// Monitoring stoppen
				_mainControl.StopMonitoring();

				// Konfiguration speichern
				_mainControl.SaveConfig();

				// Hauptobjekt freigeben
				_mainControl.Dispose();
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Menü ------------------------------

		/// <summary>
		/// beendet Anwendung
		/// </summary>
		private void menuItemFileEnd_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// aktualisiert Anzeige
		/// </summary>
		private void menuItemViewRefresh_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Seiten aktualisieren
				_frontendPage.RefreshView();
				_campaignPage.RefreshView();
				_conferencePage.RefreshView();
				_devicePage.RefreshView();
				_sitePage.RefreshView();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing view.", ex);
			}
		}

		/// <summary>
		/// startet Coaching im Modus Silent Monitoring über ausgewähltes Frontend
		/// </summary>
		private void menuItemFrontendStartCoachingSilentMonitoring_Click(object sender,
			System.EventArgs e)
		{
			try
			{
				// ausgewähltes Frontend ermitteln
				Frontend frontend = _mainControl.FrontendControl[_frontendPage.SelectedItemTag];

				// wenn Frontend gefunden, Coaching starten
				if (frontend != null)
				{
					StartCoaching(frontend.AgentCode, CoachingMode.SilentMonitoring);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on starting coaching.", ex);
			}
		}

		/// <summary>
		/// startet Coaching im Modus Whispering über ausgewähltes Frontend
		/// </summary>
		private void menuItemFrontendStartCoachingWhispering_Click(object sender,
			System.EventArgs e)
		{
			try
			{
				// ausgewähltes Frontend ermitteln
				Frontend frontend = _mainControl.FrontendControl[_frontendPage.SelectedItemTag];

				// wenn Frontend gefunden, Coaching starten
				if (frontend != null)
				{
					StartCoaching(frontend.AgentCode, CoachingMode.Whispering);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on starting coaching.", ex);
			}
		}

		/// <summary>
		/// beendet Coaching
		/// </summary>
		private void menuItemFrontendStopCoaching_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Coaching beenden
				StopCoaching();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on stopping coaching.", ex);
			}
		}

		/// <summary>
		/// fügt Raum hinzu
		/// </summary>
		private void menuItemSiteAdd_Click(object sender, System.EventArgs e)
		{
			try
			{
				// leere Maske anzeigen
				new SiteForm(_mainControl, null).ShowDialog(this);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on adding site.", ex);
			}
		}

		/// <summary>
		/// bearbeitet Raum
		/// </summary>
		private void menuItemSiteEdit_Click(object sender, System.EventArgs e)
		{
			try
			{
				// ausgewählten Raum ermitteln
				Site site = _mainControl.SiteControl[_sitePage.SelectedItemTag];

				// wenn Raum gefunden, bearbeiten
				if (site != null)
				{
					new SiteForm(_mainControl, site).ShowDialog(this);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on editing site.", ex);
			}
		}

		/// <summary>
		/// entfernt Raum
		/// </summary>
		private void menuItemSiteRemove_Click(object sender, System.EventArgs e)
		{
			try
			{
				// ausgewählten Raum ermitteln
				Site site = _mainControl.SiteControl[_sitePage.SelectedItemTag];

				// wenn Raum gefunden, entfernen
				if (site != null)
				{
					site.Terminate();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on removing site.", ex);
			}
		}

		/// <summary>
		/// startet Coaching im Modus Silent Monitoring über ausgewähltes Device
		/// </summary>
		private void menuItemDeviceStartCoachingSilentMonitoring_Click(object sender,
			System.EventArgs e)
		{
			try
			{
				// ausgewähltes Device ermitteln
				Device device = _mainControl.DeviceControl[_sitePage.SelectedDeviceCode];

				// wenn Device gefunden und Frontend zugewiesen, Coaching starten
				if ((device != null) && (device.Frontend != null))
				{
					StartCoaching(device.Frontend.AgentCode, CoachingMode.SilentMonitoring);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on starting coaching.", ex);
			}
		}

		/// <summary>
		/// startet Coaching im Modus Whispering über ausgewähltes Device
		/// </summary>
		private void menuItemDeviceStartCoachingWhispering_Click(object sender, System.EventArgs e)
		{
			try
			{
				// ausgewähltes Device ermitteln
				Device device = _mainControl.DeviceControl[_sitePage.SelectedDeviceCode];

				// wenn Device gefunden und Frontend zugewiesen, Coaching starten
				if ((device != null) && (device.Frontend != null))
				{
					StartCoaching(device.Frontend.AgentCode, CoachingMode.Whispering);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on starting coaching.", ex);
			}
		}

		/// <summary>
		/// beendet Coaching
		/// </summary>
		private void menuItemDeviceStopCoaching_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Coaching beenden
				StopCoaching();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on stopping coaching.", ex);
			}
		}

		/// <summary>
		/// zeigt Info-Box an
		/// </summary>
		private void menuItemHelpInfo_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Info-Box anzeigen
				Tools.ShowInfo(Assembly.GetAssembly(this.GetType()));
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on showing info.", ex);
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Symbolleiste ----------------------

		/// <summary>
		/// passt Fensteransicht an und steuert Devicezugriff
		/// </summary>
		private void toolBar_ButtonClick(object sender,
			System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			try
			{
				// je nach gedrücktem Button
				switch (toolBar.Buttons.IndexOf(e.Button))
				{
					case 0:
					case 1:
					case 2:
						// Fensteransicht anpassen
						if (toolBarButtonDetails.Pushed)
						{
							toolBarButtonNavi.Enabled = false;
							toolBarButtonPreview.Enabled = false;
							panelNavi.Visible = false;
							splitterVertical.Visible = false;
							SetPageMode(PageMode.Detail);
						}
						else
						{
							toolBarButtonNavi.Enabled = true;
							toolBarButtonPreview.Enabled = true;
							panelNavi.Visible = toolBarButtonNavi.Pushed;
							splitterVertical.Visible = toolBarButtonNavi.Pushed;
							SetPageMode(toolBarButtonPreview.Pushed ? PageMode.Preview :
								PageMode.List);
						}
						break;
					case 4:
						// Devicezuordnung anpassen
						if (e.Button.Pushed)
						{
							e.Button.ImageIndex = 4;
							AssignDevice(Settings.Instance.DeviceCode);
						}
						else
						{
							e.Button.ImageIndex = 3;
							UnassignDevice();
						}
						break;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing toolbar button click.", ex);
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Navigationsleiste -----------------

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void naviBar_ButtonClick(object sender,
			itCampus.bb.Controls.NaviBarClickEventArgs e)
		{
			SelectPage(naviBar.Buttons.IndexOf(e.Button));
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Kategorieseiten -------------------

		/// <summary>
		/// aktualisiert Steuerelemente
		/// </summary>
		private void _frontendPage_OnSelectedItemChanged()
		{
			RefreshControls();
		}

		/// <summary>
		/// aktualisiert Steuerelemente
		/// </summary>
		private void _sitePage_OnSelectedItemChanged()
		{
			RefreshControls();
		}

		/// <summary>
		/// aktualisiert Steuerelemente
		/// </summary>
		private void _sitePage_OnSelectedDeviceChanged()
		{
			RefreshControls();
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Hauptobjekt -----------------------

		/// <summary>
		/// behandelt Verlieren des gecoachten Agenten
		/// </summary>
		private void _mainControl_OnAgentLost()
		{
			// Meldung ausgeben
			MessageBox.Show(this, Resources.GetString("MainForm.MessageBox.Text.AgentLost"),
				Resources.GetString("MainForm.MessageBox.Caption.AgentLost"),
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Steuerelemente aktualisieren
			RefreshControls();
		}

		/// <summary>
		/// behandelt Trennen des Devices
		/// </summary>
		private void _mainControl_OnDeviceTerminated()
		{
			// Meldung ausgeben
			MessageBox.Show(this, Resources.GetString("MainForm.MessageBox.Text.DeviceTerminated"),
				Resources.GetString("MainForm.MessageBox.Caption.DeviceTerminated"),
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Steuerelemente aktualisieren
			RefreshControls();
		}

		/// <summary>
		/// behandelt Trennen der Verbindung zum Dialer
		/// </summary>
		private void _mainControl_OnConnectionLost()
		{
			// Meldung ausgeben
			MessageBox.Show(this, Resources.GetString("MainForm.MessageBox.Text.ConnectionLost"),
				Resources.GetString("MainForm.MessageBox.Caption.ConnectionLost"),
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Formular schließen
			this.Close();
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Frontendverwaltung ----------------

		/// <summary>
		/// prüft Coachingerlaubnis und beendet Coaching ggf.
		/// </summary>
		private void _frontendControl_OnRefreshFrontend(Frontend frontend)
		{
			try
			{
				// wenn Coachingerlaubnis erforderlich und Agent gecoacht wird, spricht und keine
				// Coachingerlaubnis erteilt hat
				if ((Settings.Instance.CoachingPermissionRequired) &&
					(frontend.MonitorCode == Settings.Instance.MonitorCode) &&
					((frontend.State == FrontendState.Talking) ||
					(frontend.State == FrontendState.Conferencing)) &&
					(!frontend.CoachingPermission))
				{
					// Timer für Beenden des Coaching aktivieren
					timerStopCoaching.Start();
				}

				// wenn automatisches Coachingende aktiviert, Agent gecoacht wird und
				// Gesprächsende erreicht
				if ((Settings.Instance.AutoStopCoaching) &&
					(frontend.MonitorCode == Settings.Instance.MonitorCode) &&
					((frontend.LastState == FrontendState.Talking) ||
					(frontend.LastState == FrontendState.Conferencing)) &&
					(frontend.State != FrontendState.Talking) &&
					(frontend.State != FrontendState.Conferencing))
				{
					// Timer für Beenden des Coaching aktivieren
					timerStopCoaching.Start();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		#endregion

		#region----------------------------- Coaching ---------------------------------------------

		/// <summary>
		/// weist Device zu
		/// </summary>
		private void AssignDevice(string deviceCode)
		{
			try
			{
				// Device zuweisen
				_mainControl.AssignDevice(deviceCode);
			}
			catch (Exception ex)
			{
				// Fehler protokollieren
				Logger.Log.Error("Error on assigning device.", ex);

				// Meldung ausgeben
				MessageBox.Show(this, ex.Message + Environment.NewLine + ex.InnerException,
					Resources.GetString("MainForm.MessageBox.Caption.AssignDeviceError"),
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Steuerelemente aktualisieren
				RefreshControls();
			}
		}

		/// <summary>
		/// gibt Device frei
		/// </summary>
		private void UnassignDevice()
		{
			try
			{
				// Device freigeben
				_mainControl.UnassignDevice();
			}
			finally
			{
				// Steuerelemente aktualisieren
				RefreshControls();
			}
		}

		/// <summary>
		/// startet Coaching
		/// </summary>
		private void StartCoaching(string agentCode, CoachingMode coachingMode)
		{
			try
			{
				// Coaching starten
				_mainControl.StartCoaching(agentCode, coachingMode);
			}
			catch (Exception ex)
			{
				// Fehler protokollieren
				Logger.Log.Error("Error on starting coaching.", ex);

				// Meldung ausgeben
				MessageBox.Show(this, ex.Message + Environment.NewLine + ex.InnerException,
					Resources.GetString("MainForm.MessageBox.Caption.StartCoachingError"),
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Steuerelemente aktualisieren
				RefreshControls();
			}
		}

		/// <summary>
		/// beendet Coaching
		/// </summary>
		private void StopCoaching()
		{
			try
			{
				// Coaching beenden
				_mainControl.StopCoaching();
			}
			finally
			{
				// Steuerelemente aktualisieren
				RefreshControls();
			}
		}

		/// <summary>
		/// beendet Coaching
		/// </summary>
		private void timerStopCoaching_Tick(object sender, System.EventArgs e)
		{
			try
			{
				// wenn Coaching gestartet, beenden
				if (_mainControl.MonitorState == MonitorState.Coaching)
				{
					StopCoaching();
				}

				// Timer für Beenden des Coaching deaktivieren
				timerStopCoaching.Stop();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on stopping coaching.", ex);
			}
		}

		#endregion

		#region----------------------------- Aktualisierung Formular ------------------------------

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void SelectPage(int index)
		{
			// Sichtbarkeit aller Seiten und abhängigen Menüs aktualisieren
			_frontendPage.Visible = (index == 0);
			menuItemFrontend.Visible = (index == 0);
			_campaignPage.Visible = (index == 1);
			_conferencePage.Visible = (index == 2);
			_sitePage.Visible = (index == 3);
			menuItemSite.Visible = (index == 3);
			menuItemDevice.Visible = (index == 3);
			_devicePage.Visible = (index == 4);
		}

		/// <summary>
		/// stellt Modus aller Seiten ein
		/// </summary>
		private void SetPageMode(PageMode pageMode)
		{
			_frontendPage.Mode = pageMode;
			_campaignPage.Mode = pageMode;
			_sitePage.Mode = pageMode;
		}

		/// <summary>
		/// sperrt/entsperrt objektbezogene Steuerelemente
		/// </summary>
		private void RefreshControls()
		{
			// ausgewähltes Frontend ermitteln
			Frontend frontend = _mainControl.FrontendControl[_frontendPage.SelectedItemTag];

			// Hauptmenü Frontend aktualisieren
			menuItemFrontendStartCoachingSilentMonitoring.Enabled =
				IsCoachingAllowed(frontend, CoachingMode.SilentMonitoring);
			menuItemFrontendStartCoachingWhispering.Enabled =
				IsCoachingAllowed(frontend, CoachingMode.Whispering);
			menuItemFrontendStopCoaching.Enabled =
				_mainControl.MonitorState == MonitorState.Coaching;

			// Kontextmenü Frontend aktualisieren
			menuItemFrontendStartCoachingSilentMonitoringCtx.Enabled =
				menuItemFrontendStartCoachingSilentMonitoring.Enabled;
			menuItemFrontendStartCoachingWhisperingCtx.Enabled =
				menuItemFrontendStartCoachingWhispering.Enabled;
			menuItemFrontendStopCoachingCtx.Enabled = menuItemFrontendStopCoaching.Enabled;

			// ausgewählten Raum ermitteln
			Site site = _mainControl.SiteControl[_sitePage.SelectedItemTag];

			// Hauptmenü Raum aktualisieren
			menuItemSiteEdit.Enabled = (site != null);
			menuItemSiteRemove.Enabled = (site != null);

			// Kontextmenü Raum aktualisieren
			menuItemSiteEditCtx.Enabled = menuItemSiteEdit.Enabled;
			menuItemSiteRemoveCtx.Enabled = menuItemSiteRemove.Enabled;

			// ausgewähltes Device und zugeordnetes Frontend ermitteln
			Device device = _mainControl.DeviceControl[_sitePage.SelectedDeviceCode];
			frontend = device != null ? device.Frontend : null;

			// Hauptmenü Device aktualisieren
			menuItemDeviceStartCoachingSilentMonitoring.Enabled =
				IsCoachingAllowed(frontend, CoachingMode.SilentMonitoring);
			menuItemDeviceStartCoachingWhispering.Enabled =
				IsCoachingAllowed(frontend, CoachingMode.Whispering);
			menuItemDeviceStopCoaching.Enabled =
				_mainControl.MonitorState == MonitorState.Coaching;

			// Kontextmenü Device aktualisieren
			menuItemDeviceStartCoachingSilentMonitoringCtx.Enabled =
				menuItemDeviceStartCoachingSilentMonitoring.Enabled;
			menuItemDeviceStartCoachingWhisperingCtx.Enabled =
				menuItemDeviceStartCoachingWhispering.Enabled;
			menuItemDeviceStopCoachingCtx.Enabled = menuItemDeviceStopCoaching.Enabled;

			// Schaltfläche für Device aktualisieren
			toolBarButtonDevice.Pushed =
				((_mainControl.MonitorState == MonitorState.Assigned) ||
				(_mainControl.MonitorState == MonitorState.Coaching));
			toolBarButtonDevice.ImageIndex = toolBarButtonDevice.Pushed ? 4 : 3;

			// Statusleiste aktualisieren
			statusBarPanelState.Text = _mainControl.MonitorState.ToString();
		}

		/// <summary>
		/// ermittelt, ob Coaching für angegebenen Agent erlaubt ist
		/// </summary>
		private bool IsCoachingAllowed(Frontend frontend, CoachingMode coachingMode)
		{
			return ((_mainControl.MonitorState == MonitorState.Assigned) ||
				(_mainControl.MonitorState == MonitorState.Coaching)) &&
				(frontend != null) && (frontend.AgentCode != "") &&
				((frontend.MonitorCode == "") ||
				((frontend.MonitorCode == Settings.Instance.MonitorCode) &&
				(frontend.CoachingMode != coachingMode))) &&
				((!Settings.Instance.CoachingPermissionRequired) ||
				((frontend.State != FrontendState.Talking) &&
				(frontend.State != FrontendState.Conferencing)) ||
				frontend.CoachingPermission);
		}

		/// <summary>
		/// aktualisiert Formular
		/// </summary>
		private void timerRefresh_Tick(object sender, System.EventArgs e)
		{
			RefreshStatusBar();
		}

		/// <summary>
		/// aktualisiert Statusleiste
		/// </summary>
		private void RefreshStatusBar()
		{
			statusBarPanelDate.Text = DateTime.Now.ToShortDateString();
			statusBarPanelTime.Text = DateTime.Now.ToShortTimeString();
		}

		#endregion

		#endregion
	}
}
