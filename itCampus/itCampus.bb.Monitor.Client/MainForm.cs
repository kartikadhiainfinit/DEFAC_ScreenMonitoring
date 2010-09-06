using System;
using System.Data;
using System.Diagnostics;
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
        //Tieto screen monitoring
        Tieto.MonitorClient.StartVNCViewer _vncViewer;


        // Steuerelemente
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemFileEnd;
        private System.Windows.Forms.MenuItem menuItemView;
        private System.Windows.Forms.MenuItem menuItemViewRefresh;
        private System.Windows.Forms.MenuItem menuItemFrontend;
        private MenuItem menuItemFrontendStartCoachingScreenAndSilentMonitoring;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoring;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhispering;
        private System.Windows.Forms.MenuItem menuItemFrontendStopCoaching;
        private System.Windows.Forms.MenuItem menuItemSite;
        private System.Windows.Forms.MenuItem menuItemSiteAdd;
        private System.Windows.Forms.MenuItem menuItemSiteEdit;
        private System.Windows.Forms.MenuItem menuItemSiteRemove;
        private System.Windows.Forms.MenuItem menuItemDevice;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoring;
        private MenuItem menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhispering;
        private System.Windows.Forms.MenuItem menuItemDeviceStopCoaching;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MenuItem menuItemHelpInfo;
        private System.Windows.Forms.ContextMenu contextMenuFrontend;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoringCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhisperingCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx;
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
        private MenuItem menuItemDeviceStartCoachingScreenAndSilentMonitoring;
        private MenuItem menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx;

        private MenuItem menuItemFrontendStartCoachingScreenMonitoringAndWhispering;
        private MenuItem menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx;
        private MenuItem menuItemDeviceStartCoachingScreenMonitoringAndWhispering;
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemFileEnd = new System.Windows.Forms.MenuItem();
            this.menuItemView = new System.Windows.Forms.MenuItem();
            this.menuItemViewRefresh = new System.Windows.Forms.MenuItem();
            this.menuItemFrontend = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingSilentMonitoring = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoring = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhispering = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhispering = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStopCoaching = new System.Windows.Forms.MenuItem();
            this.menuItemSite = new System.Windows.Forms.MenuItem();
            this.menuItemSiteAdd = new System.Windows.Forms.MenuItem();
            this.menuItemSiteEdit = new System.Windows.Forms.MenuItem();
            this.menuItemSiteRemove = new System.Windows.Forms.MenuItem();
            this.menuItemDevice = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingSilentMonitoring = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoring = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhispering = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhispering = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStopCoaching = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemHelpInfo = new System.Windows.Forms.MenuItem();
            this.contextMenuFrontend = new System.Windows.Forms.ContextMenu();
            this.menuItemFrontendStartCoachingSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhisperingCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStopCoachingCtx = new System.Windows.Forms.MenuItem();
            this.contextMenuSite = new System.Windows.Forms.ContextMenu();
            this.menuItemSiteAddCtx = new System.Windows.Forms.MenuItem();
            this.menuItemSiteEditCtx = new System.Windows.Forms.MenuItem();
            this.menuItemSiteRemoveCtx = new System.Windows.Forms.MenuItem();
            this.contextMenuDevice = new System.Windows.Forms.ContextMenu();
            this.menuItemDeviceStartCoachingSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhisperingCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx = new System.Windows.Forms.MenuItem();
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
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFileEnd});
            resources.ApplyResources(this.menuItemFile, "menuItemFile");
            // 
            // menuItemFileEnd
            // 
            this.menuItemFileEnd.Index = 0;
            resources.ApplyResources(this.menuItemFileEnd, "menuItemFileEnd");
            this.menuItemFileEnd.Click += new System.EventHandler(this.menuItemFileEnd_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.Index = 1;
            this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemViewRefresh});
            resources.ApplyResources(this.menuItemView, "menuItemView");
            // 
            // menuItemViewRefresh
            // 
            this.menuItemViewRefresh.Index = 0;
            resources.ApplyResources(this.menuItemViewRefresh, "menuItemViewRefresh");
            this.menuItemViewRefresh.Click += new System.EventHandler(this.menuItemViewRefresh_Click);
            // 
            // menuItemFrontend
            // 
            this.menuItemFrontend.Index = 2;
            this.menuItemFrontend.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFrontendStartCoachingSilentMonitoring,
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoring,
            this.menuItemFrontendStartCoachingWhispering,
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhispering,
            this.menuItemFrontendStopCoaching});
            resources.ApplyResources(this.menuItemFrontend, "menuItemFrontend");
            // 
            // menuItemFrontendStartCoachingSilentMonitoring
            // 
            this.menuItemFrontendStartCoachingSilentMonitoring.Index = 0;
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoring, "menuItemFrontendStartCoachingSilentMonitoring");
            this.menuItemFrontendStartCoachingSilentMonitoring.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoring_Click);
            // 
            // menuItemFrontendStartCoachingScreenAndSilentMonitoring
            // 
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoring.Index = 1;
            resources.ApplyResources(this.menuItemFrontendStartCoachingScreenAndSilentMonitoring, "menuItemFrontendStartCoachingScreenAndSilentMonitoring");
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoring.Click += new System.EventHandler(this.menuItemFrontendStartCoachingScreenAndSilentMonitoring_Click);
            // 
            // menuItemFrontendStartCoachingWhispering
            // 
            this.menuItemFrontendStartCoachingWhispering.Index = 2;
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhispering, "menuItemFrontendStartCoachingWhispering");
            this.menuItemFrontendStartCoachingWhispering.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhispering_Click);
            // 
            // menuItemFrontendStartCoachingScreenMonitoringAndWhispering
            // 
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhispering.Index = 3;
            resources.ApplyResources(this.menuItemFrontendStartCoachingScreenMonitoringAndWhispering, "menuItemFrontendStartCoachingScreenMonitoringAndWhispering");
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhispering.Click += new System.EventHandler(this.menuItemFrontendStartCoachingScreenMonitoringAndWhispering_Click);
            // 
            // menuItemFrontendStopCoaching
            // 
            this.menuItemFrontendStopCoaching.Index = 4;
            resources.ApplyResources(this.menuItemFrontendStopCoaching, "menuItemFrontendStopCoaching");
            this.menuItemFrontendStopCoaching.Click += new System.EventHandler(this.menuItemFrontendStopCoaching_Click);
            // 
            // menuItemSite
            // 
            this.menuItemSite.Index = 3;
            this.menuItemSite.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSiteAdd,
            this.menuItemSiteEdit,
            this.menuItemSiteRemove});
            resources.ApplyResources(this.menuItemSite, "menuItemSite");
            // 
            // menuItemSiteAdd
            // 
            this.menuItemSiteAdd.Index = 0;
            resources.ApplyResources(this.menuItemSiteAdd, "menuItemSiteAdd");
            this.menuItemSiteAdd.Click += new System.EventHandler(this.menuItemSiteAdd_Click);
            // 
            // menuItemSiteEdit
            // 
            this.menuItemSiteEdit.Index = 1;
            resources.ApplyResources(this.menuItemSiteEdit, "menuItemSiteEdit");
            this.menuItemSiteEdit.Click += new System.EventHandler(this.menuItemSiteEdit_Click);
            // 
            // menuItemSiteRemove
            // 
            this.menuItemSiteRemove.Index = 2;
            resources.ApplyResources(this.menuItemSiteRemove, "menuItemSiteRemove");
            this.menuItemSiteRemove.Click += new System.EventHandler(this.menuItemSiteRemove_Click);
            // 
            // menuItemDevice
            // 
            this.menuItemDevice.Index = 4;
            this.menuItemDevice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeviceStartCoachingSilentMonitoring,
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoring,
            this.menuItemDeviceStartCoachingWhispering,
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhispering,
            this.menuItemDeviceStopCoaching});
            resources.ApplyResources(this.menuItemDevice, "menuItemDevice");
            // 
            // menuItemDeviceStartCoachingSilentMonitoring
            // 
            this.menuItemDeviceStartCoachingSilentMonitoring.Index = 0;
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoring, "menuItemDeviceStartCoachingSilentMonitoring");
            this.menuItemDeviceStartCoachingSilentMonitoring.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoring_Click);
            // 
            // menuItemDeviceStartCoachingScreenAndSilentMonitoring
            // 
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoring.Index = 1;
            resources.ApplyResources(this.menuItemDeviceStartCoachingScreenAndSilentMonitoring, "menuItemDeviceStartCoachingScreenAndSilentMonitoring");
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoring.Click += new System.EventHandler(this.menuItemDeviceStartScreenAndCoachingSilentMonitoring_Click);
            // 
            // menuItemDeviceStartCoachingWhispering
            // 
            this.menuItemDeviceStartCoachingWhispering.Index = 2;
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhispering, "menuItemDeviceStartCoachingWhispering");
            this.menuItemDeviceStartCoachingWhispering.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhispering_Click);
            // 
            // menuItemDeviceStartCoachingScreenMonitoringAndWhispering
            // 
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhispering.Index = 3;
            resources.ApplyResources(this.menuItemDeviceStartCoachingScreenMonitoringAndWhispering, "menuItemDeviceStartCoachingScreenMonitoringAndWhispering");
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhispering.Click += new System.EventHandler(this.menuItemDeviceStartCoachingScreenMonitoringAndWhispering_Click);
            // 
            // menuItemDeviceStopCoaching
            // 
            this.menuItemDeviceStopCoaching.Index = 4;
            resources.ApplyResources(this.menuItemDeviceStopCoaching, "menuItemDeviceStopCoaching");
            this.menuItemDeviceStopCoaching.Click += new System.EventHandler(this.menuItemDeviceStopCoaching_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 5;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemHelpInfo});
            resources.ApplyResources(this.menuItemHelp, "menuItemHelp");
            // 
            // menuItemHelpInfo
            // 
            this.menuItemHelpInfo.Index = 0;
            resources.ApplyResources(this.menuItemHelpInfo, "menuItemHelpInfo");
            this.menuItemHelpInfo.Click += new System.EventHandler(this.menuItemHelpInfo_Click);
            // 
            // contextMenuFrontend
            // 
            this.contextMenuFrontend.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFrontendStartCoachingSilentMonitoringCtx,
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx,
            this.menuItemFrontendStartCoachingWhisperingCtx,
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx,
            this.menuItemFrontendStopCoachingCtx});
            // 
            // menuItemFrontendStartCoachingSilentMonitoringCtx
            // 
            this.menuItemFrontendStartCoachingSilentMonitoringCtx.Index = 0;
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoringCtx, "menuItemFrontendStartCoachingSilentMonitoringCtx");
            this.menuItemFrontendStartCoachingSilentMonitoringCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoring_Click);
            // 
            // menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx
            // 
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx.Index = 1;
            resources.ApplyResources(this.menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx, "menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx");
            this.menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingScreenAndSilentMonitoring_Click);
            // 
            // menuItemFrontendStartCoachingWhisperingCtx
            // 
            this.menuItemFrontendStartCoachingWhisperingCtx.Index = 2;
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhisperingCtx, "menuItemFrontendStartCoachingWhisperingCtx");
            this.menuItemFrontendStartCoachingWhisperingCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhispering_Click);
            // 
            // menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx
            // 
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx.Index = 3;
            resources.ApplyResources(this.menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx, "menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx");
            this.menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingScreenMonitoringAndWhispering_Click);
            // 
            // menuItemFrontendStopCoachingCtx
            // 
            this.menuItemFrontendStopCoachingCtx.Index = 4;
            resources.ApplyResources(this.menuItemFrontendStopCoachingCtx, "menuItemFrontendStopCoachingCtx");
            this.menuItemFrontendStopCoachingCtx.Click += new System.EventHandler(this.menuItemFrontendStopCoaching_Click);
            // 
            // contextMenuSite
            // 
            this.contextMenuSite.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSiteAddCtx,
            this.menuItemSiteEditCtx,
            this.menuItemSiteRemoveCtx});
            // 
            // menuItemSiteAddCtx
            // 
            this.menuItemSiteAddCtx.Index = 0;
            resources.ApplyResources(this.menuItemSiteAddCtx, "menuItemSiteAddCtx");
            this.menuItemSiteAddCtx.Click += new System.EventHandler(this.menuItemSiteAdd_Click);
            // 
            // menuItemSiteEditCtx
            // 
            this.menuItemSiteEditCtx.Index = 1;
            resources.ApplyResources(this.menuItemSiteEditCtx, "menuItemSiteEditCtx");
            this.menuItemSiteEditCtx.Click += new System.EventHandler(this.menuItemSiteEdit_Click);
            // 
            // menuItemSiteRemoveCtx
            // 
            this.menuItemSiteRemoveCtx.Index = 2;
            resources.ApplyResources(this.menuItemSiteRemoveCtx, "menuItemSiteRemoveCtx");
            this.menuItemSiteRemoveCtx.Click += new System.EventHandler(this.menuItemSiteRemove_Click);
            // 
            // contextMenuDevice
            // 
            this.contextMenuDevice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeviceStartCoachingSilentMonitoringCtx,
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx,
            this.menuItemDeviceStartCoachingWhisperingCtx,
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx,
            this.menuItemDeviceStopCoachingCtx});
            // 
            // menuItemDeviceStartCoachingSilentMonitoringCtx
            // 
            this.menuItemDeviceStartCoachingSilentMonitoringCtx.Index = 0;
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoringCtx, "menuItemDeviceStartCoachingSilentMonitoringCtx");
            this.menuItemDeviceStartCoachingSilentMonitoringCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoring_Click);
            // 
            // menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx
            // 
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx.Index = 1;
            resources.ApplyResources(this.menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx, "menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx");
            this.menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx.Click += new System.EventHandler(this.menuItemDeviceStartScreenAndCoachingSilentMonitoring_Click);
            // 
            // menuItemDeviceStartCoachingWhisperingCtx
            // 
            this.menuItemDeviceStartCoachingWhisperingCtx.Index = 2;
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhisperingCtx, "menuItemDeviceStartCoachingWhisperingCtx");
            this.menuItemDeviceStartCoachingWhisperingCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhispering_Click);
            // 
            // menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx
            // 
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx.Index = 3;
            resources.ApplyResources(this.menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx, "menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx");
            this.menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingScreenMonitoringAndWhispering_Click);
            // 
            // menuItemDeviceStopCoachingCtx
            // 
            this.menuItemDeviceStopCoachingCtx.Index = 4;
            resources.ApplyResources(this.menuItemDeviceStopCoachingCtx, "menuItemDeviceStopCoachingCtx");
            this.menuItemDeviceStopCoachingCtx.Click += new System.EventHandler(this.menuItemDeviceStopCoaching_Click);
            // 
            // toolBar
            // 
            resources.ApplyResources(this.toolBar, "toolBar");
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButtonNavi,
            this.toolBarButtonPreview,
            this.toolBarButtonDetails,
            this.toolBarButtonSeparator,
            this.toolBarButtonDevice});
            this.toolBar.ImageList = this.imageList;
            this.toolBar.Name = "toolBar";
            this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
            // 
            // toolBarButtonNavi
            // 
            resources.ApplyResources(this.toolBarButtonNavi, "toolBarButtonNavi");
            this.toolBarButtonNavi.Name = "toolBarButtonNavi";
            this.toolBarButtonNavi.Pushed = true;
            this.toolBarButtonNavi.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // toolBarButtonPreview
            // 
            resources.ApplyResources(this.toolBarButtonPreview, "toolBarButtonPreview");
            this.toolBarButtonPreview.Name = "toolBarButtonPreview";
            this.toolBarButtonPreview.Pushed = true;
            this.toolBarButtonPreview.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // toolBarButtonDetails
            // 
            resources.ApplyResources(this.toolBarButtonDetails, "toolBarButtonDetails");
            this.toolBarButtonDetails.Name = "toolBarButtonDetails";
            this.toolBarButtonDetails.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // toolBarButtonSeparator
            // 
            this.toolBarButtonSeparator.Name = "toolBarButtonSeparator";
            this.toolBarButtonSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButtonDevice
            // 
            resources.ApplyResources(this.toolBarButtonDevice, "toolBarButtonDevice");
            this.toolBarButtonDevice.Name = "toolBarButtonDevice";
            this.toolBarButtonDevice.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanelLog,
            this.statusBarPanelState,
            this.statusBarPanelDate,
            this.statusBarPanelTime});
            this.statusBar.ShowPanels = true;
            // 
            // statusBarPanelLog
            // 
            this.statusBarPanelLog.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            resources.ApplyResources(this.statusBarPanelLog, "statusBarPanelLog");
            // 
            // statusBarPanelState
            // 
            resources.ApplyResources(this.statusBarPanelState, "statusBarPanelState");
            // 
            // statusBarPanelDate
            // 
            resources.ApplyResources(this.statusBarPanelDate, "statusBarPanelDate");
            // 
            // statusBarPanelTime
            // 
            resources.ApplyResources(this.statusBarPanelTime, "statusBarPanelTime");
            // 
            // panelNavi
            // 
            this.panelNavi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNavi.Controls.Add(this.naviBar);
            resources.ApplyResources(this.panelNavi, "panelNavi");
            this.panelNavi.Name = "panelNavi";
            // 
            // naviBar
            // 
            this.naviBar.Buttons.AddRange(new itCampus.bb.Controls.NaviBarButton[] {
            this.naviBarButtonFrontends,
            this.naviBarButtonCampaigns,
            this.naviBarButtonConferences,
            this.naviBarButtonSites,
            this.naviBarButtonDevices});
            resources.ApplyResources(this.naviBar, "naviBar");
            this.naviBar.Name = "naviBar";
            this.naviBar.ButtonClick += new itCampus.bb.Controls.NaviBar.NaviBarClickEventHandler(this.naviBar_ButtonClick);
            // 
            // naviBarButtonFrontends
            // 
            resources.ApplyResources(this.naviBarButtonFrontends, "naviBarButtonFrontends");
            this.naviBarButtonFrontends.Tag = null;
            // 
            // naviBarButtonCampaigns
            // 
            resources.ApplyResources(this.naviBarButtonCampaigns, "naviBarButtonCampaigns");
            this.naviBarButtonCampaigns.Tag = null;
            // 
            // naviBarButtonConferences
            // 
            resources.ApplyResources(this.naviBarButtonConferences, "naviBarButtonConferences");
            this.naviBarButtonConferences.Tag = null;
            // 
            // naviBarButtonSites
            // 
            resources.ApplyResources(this.naviBarButtonSites, "naviBarButtonSites");
            this.naviBarButtonSites.Tag = null;
            // 
            // naviBarButtonDevices
            // 
            resources.ApplyResources(this.naviBarButtonDevices, "naviBarButtonDevices");
            this.naviBarButtonDevices.Tag = null;
            // 
            // splitterVertical
            // 
            resources.ApplyResources(this.splitterVertical, "splitterVertical");
            this.splitterVertical.Name = "splitterVertical";
            this.splitterVertical.TabStop = false;
            // 
            // panelPage
            // 
            resources.ApplyResources(this.panelPage, "panelPage");
            this.panelPage.Name = "panelPage";
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
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.splitterVertical);
            this.Controls.Add(this.panelNavi);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closed += new System.EventHandler(this.MainForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelTime)).EndInit();
            this.panelNavi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naviBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        /// startet Coaching mit Screen und Silent Modus
        /// </summary>
        private void menuItemFrontendStartCoachingScreenAndSilentMonitoring_Click(object sender, EventArgs e)
        {
            try
            {
                // ausgewähltes Frontend ermitteln
                Frontend frontend = _mainControl.FrontendControl[_frontendPage.SelectedItemTag];

                // wenn Frontend gefunden, Coaching starten
                if (frontend != null)
                {
                    StartCoaching(frontend.AgentCode, CoachingMode.SilentMonitoring);
                    if (!StartVNCViewer(frontend.AgentCode))
                    {
                        MessageBox.Show("Screen Monitoring could not be started" + System.Environment.NewLine +
                            "Please see log for detailed informations");
                        StopCoaching();
                    }
                    
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
        /// Startet Screen Coaching im Whipsering Modus über ausgewähltes Frontend
        /// </summary>
        private void menuItemFrontendStartCoachingScreenMonitoringAndWhispering_Click(object sender, EventArgs e)
        {
            try
            {
                // ausgewähltes Frontend ermitteln
                Frontend frontend = _mainControl.FrontendControl[_frontendPage.SelectedItemTag];

                // wenn Frontend gefunden, Coaching starten
                if (frontend != null)
                {
                    StartCoaching(frontend.AgentCode, CoachingMode.Whispering);
                    if (!StartVNCViewer(frontend.AgentCode))
                    {
                        MessageBox.Show("Screen Monitoring could not be started" + System.Environment.NewLine +
                            "Please see log for detailed informations");
                        StopCoaching();
                    }
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

        private void menuItemDeviceStartScreenAndCoachingSilentMonitoring_Click(object sender, EventArgs e)
        {
            try
            {
                // ausgewähltes Device ermitteln
                Device device = _mainControl.DeviceControl[_sitePage.SelectedDeviceCode];

                // wenn Device gefunden und Frontend zugewiesen, Coaching starten
                if ((device != null) && (device.Frontend != null))
                {
                    StartCoaching(device.Frontend.AgentCode, CoachingMode.SilentMonitoring);
                    //starts screen monitoring
                    if (!StartVNCViewer(device.Frontend.AgentCode))
                    {
                        MessageBox.Show("Screen Monitoring could not be started" + System.Environment.NewLine +
                            "Please see log for detailed informations");
                        StopCoaching();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on starting screen and silent coaching.", ex);
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
        /// Starts coaching with screen monitoring and in whispering modus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemDeviceStartCoachingScreenMonitoringAndWhispering_Click(object sender, EventArgs e)
        {
            try
            {
                // ausgewähltes Device ermitteln
                Device device = _mainControl.DeviceControl[_sitePage.SelectedDeviceCode];

                // wenn Device gefunden und Frontend zugewiesen, Coaching starten
                if ((device != null) && (device.Frontend != null))
                {
                    StartCoaching(device.Frontend.AgentCode, CoachingMode.Whispering);
                    if (!StartVNCViewer(device.Frontend.AgentCode))
                    {
                        MessageBox.Show("Screen Monitoring could not be started" + System.Environment.NewLine +
                            "Please see log for detailed informations");
                        StopCoaching();
                    }
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
                if (null != _vncViewer)
                {
                    //stops screen monitoring
                    _vncViewer.VNCViewer.Kill();
                }
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
            menuItemFrontendStartCoachingSilentMonitoring.Enabled = IsCoachingAllowed(frontend, CoachingMode.SilentMonitoring);
            menuItemFrontendStartCoachingScreenAndSilentMonitoring.Enabled = IsScreenMonitoringAllowed(frontend, CoachingMode.SilentMonitoring);
            menuItemFrontendStartCoachingWhispering.Enabled = IsCoachingAllowed(frontend, CoachingMode.Whispering);
            menuItemFrontendStartCoachingScreenMonitoringAndWhispering.Enabled = IsScreenMonitoringAllowed(frontend, CoachingMode.Whispering);
            menuItemFrontendStopCoaching.Enabled = _mainControl.MonitorState == MonitorState.Coaching;

            // Kontextmenü Frontend aktualisieren
            menuItemFrontendStartCoachingSilentMonitoringCtx.Enabled = menuItemFrontendStartCoachingSilentMonitoring.Enabled;
            menuItemFrontendStartCoachingScreenAndSilentMonitoringCtx.Enabled = menuItemFrontendStartCoachingScreenAndSilentMonitoring.Enabled;
            menuItemFrontendStartCoachingWhisperingCtx.Enabled = menuItemFrontendStartCoachingWhispering.Enabled;
            menuItemFrontendStartCoachingScreenMonitoringAndWhisperingCtx.Enabled = menuItemFrontendStartCoachingScreenMonitoringAndWhispering.Enabled;
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
            menuItemDeviceStartCoachingScreenAndSilentMonitoring.Enabled = IsScreenMonitoringAllowed(frontend, CoachingMode.SilentMonitoring);
            menuItemDeviceStartCoachingWhispering.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.Whispering);
            menuItemDeviceStartCoachingScreenMonitoringAndWhispering.Enabled = IsScreenMonitoringAllowed(frontend, CoachingMode.Whispering);
            menuItemDeviceStopCoaching.Enabled =
                _mainControl.MonitorState == MonitorState.Coaching;

            // Kontextmenü Device aktualisieren
            menuItemDeviceStartCoachingSilentMonitoringCtx.Enabled =
                menuItemDeviceStartCoachingSilentMonitoring.Enabled;
            menuItemDeviceStartCoachingScreenAndSilentMonitoringCtx.Enabled = 
                menuItemDeviceStartCoachingScreenAndSilentMonitoring.Enabled;
            menuItemDeviceStartCoachingScreenMonitoringAndWhisperingCtx.Enabled =
                menuItemDeviceStartCoachingScreenMonitoringAndWhispering.Enabled;
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

        private bool IsScreenMonitoringAllowed(Frontend frontend, CoachingMode coachingMode)
        {
            return (IsCoachingAllowed(frontend, coachingMode) && Settings.Instance.ScreenMonitoringAllowed);
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

        #region -------------------------- Starting VNC Viewer ----------------------------------
        /// <summary>
        /// starts VNC viewer
        /// </summary>
        /// <param name="AgentCode"></param>
        /// <returns></returns>
        private bool StartVNCViewer(string AgentCode)
        {
            //if (null != _vncViewer.VNCViewer)
            //{
            //    _vncViewer.VNCViewer = null;
            //}

            _vncViewer = new Tieto.MonitorClient.StartVNCViewer(AgentCode);
            if (null != _vncViewer.VNCViewer && ! _vncViewer.VNCViewer.HasExited)
            {
                Logger.Log.Info("Screen monitoring started on server: " + _vncViewer.VNCServer.HostName +
                                 " port number: " + _vncViewer.VNCServer.PortNumber.ToString() +
                                 " monitored Agent: " + AgentCode);
                _vncViewer.VNCViewer.Exited += new EventHandler(VNCViewer_Exited);
                return true;
            }
            else
            {
                Logger.Log.Error("Screen monitoring failed");
                return false;
            }
        }

        void VNCViewer_Exited(object sender, EventArgs e)
        {
            StopCoaching();
        }
        #endregion ----------------------- Starting VNC Viewer ----------------------------------

  

        #endregion
    }
}
