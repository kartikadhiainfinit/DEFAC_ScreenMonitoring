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
        //Tieto screen monitoring
        Tieto.MonitorClient.StartVNCViewer _vncViewer;

        // Steuerelemente
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemFileEnd;
        private System.Windows.Forms.MenuItem menuItemView;
        private System.Windows.Forms.MenuItem menuItemViewRefresh;
        private System.Windows.Forms.MenuItem menuItemFrontend;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoring;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoringOneWay;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoringMixed;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhispering;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhisperingOneWay;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhisperingMixed;
        private System.Windows.Forms.MenuItem menuItemFrontendStopCoaching;
        private System.Windows.Forms.MenuItem menuItemSite;
        private System.Windows.Forms.MenuItem menuItemSiteAdd;
        private System.Windows.Forms.MenuItem menuItemSiteEdit;
        private System.Windows.Forms.MenuItem menuItemSiteRemove;
        private System.Windows.Forms.MenuItem menuItemDevice;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoring;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoringOneWay;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoringMixed;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhispering;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhisperingOneWay;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhisperingMixed;
        private System.Windows.Forms.MenuItem menuItemDeviceStopCoaching;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MenuItem menuItemHelpInfo;
        private System.Windows.Forms.ContextMenu contextMenuFrontend;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoringCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoringOneWayCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingSilentMonitoringMixedCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhisperingCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhisperingOneWayCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStartCoachingWhisperingMixedCtx;
        private System.Windows.Forms.MenuItem menuItemFrontendStopCoachingCtx;
        private System.Windows.Forms.ContextMenu contextMenuSite;
        private System.Windows.Forms.MenuItem menuItemSiteAddCtx;
        private System.Windows.Forms.MenuItem menuItemSiteEditCtx;
        private System.Windows.Forms.MenuItem menuItemSiteRemoveCtx;
        private System.Windows.Forms.ContextMenu contextMenuDevice;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoringCtx;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoringOneWayCtx;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingSilentMonitoringMixedCtx;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhisperingCtx;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhisperingOneWayCtx;
        private System.Windows.Forms.MenuItem menuItemDeviceStartCoachingWhisperingMixedCtx;
        private System.Windows.Forms.MenuItem menuItemDeviceStopCoachingCtx;
        private System.Windows.Forms.ToolBar toolBar;
        private System.Windows.Forms.ToolBarButton toolBarButtonNavi;
        private System.Windows.Forms.ToolBarButton toolBarButtonPreview;
        private System.Windows.Forms.ToolBarButton toolBarButtonDetails;
        private System.Windows.Forms.ToolBarButton toolBarButtonSeparator1;
        private System.Windows.Forms.ToolBarButton toolBarButtonDevice;
        private System.Windows.Forms.ToolBarButton toolBarButtonSeparator2;
        private System.Windows.Forms.ToolBarButton toolBarButtonFrontendFilter;
        private System.Windows.Forms.ContextMenu contextMenuFrontendFilter;
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

        // Kampagnenverwaltung
        private CampaignControl _campaignControl;

        // Kategorieseiten
        private FrontendPage _frontendPage;
        private CampaignPage _campaignPage;
        private ConferencePage _conferencePage;
        private SitePage _sitePage;
        private DevicePage _devicePage;

        // Zuordnungstabellen für Frontendfilter
        private Hashtable _frontendFilterCampaigns = new Hashtable();
        private Hashtable _frontendFilterMenuItems = new Hashtable();
        private MenuItem menuItemFrontendStartScreenSilentCoaching;
        private MenuItem menuItemDeviceScreenSilentCoaching;
        private MenuItem menuItemFrontendStartScreenSilentCoachingCtx;
        private MenuItem menuItemDeviceScreenSilentCoachingCtx;

        // letzte für Frontendfilter ausgewählte Kampagne
        private Campaign _frontendFilterLastCampaign;

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
            this.menuItemFrontendStartCoachingSilentMonitoringOneWay = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingSilentMonitoringMixed = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhispering = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhisperingOneWay = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhisperingMixed = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartScreenSilentCoaching = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStopCoaching = new System.Windows.Forms.MenuItem();
            this.menuItemSite = new System.Windows.Forms.MenuItem();
            this.menuItemSiteAdd = new System.Windows.Forms.MenuItem();
            this.menuItemSiteEdit = new System.Windows.Forms.MenuItem();
            this.menuItemSiteRemove = new System.Windows.Forms.MenuItem();
            this.menuItemDevice = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingSilentMonitoring = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingSilentMonitoringOneWay = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingSilentMonitoringMixed = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhispering = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhisperingOneWay = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhisperingMixed = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceScreenSilentCoaching = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStopCoaching = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemHelpInfo = new System.Windows.Forms.MenuItem();
            this.contextMenuFrontend = new System.Windows.Forms.ContextMenu();
            this.menuItemFrontendStartCoachingSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingSilentMonitoringOneWayCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingSilentMonitoringMixedCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhisperingCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhisperingOneWayCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartCoachingWhisperingMixedCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStartScreenSilentCoachingCtx = new System.Windows.Forms.MenuItem();
            this.menuItemFrontendStopCoachingCtx = new System.Windows.Forms.MenuItem();
            this.contextMenuSite = new System.Windows.Forms.ContextMenu();
            this.menuItemSiteAddCtx = new System.Windows.Forms.MenuItem();
            this.menuItemSiteEditCtx = new System.Windows.Forms.MenuItem();
            this.menuItemSiteRemoveCtx = new System.Windows.Forms.MenuItem();
            this.contextMenuDevice = new System.Windows.Forms.ContextMenu();
            this.menuItemDeviceStartCoachingSilentMonitoringCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingSilentMonitoringOneWayCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingSilentMonitoringMixedCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhisperingCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhisperingOneWayCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStartCoachingWhisperingMixedCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceScreenSilentCoachingCtx = new System.Windows.Forms.MenuItem();
            this.menuItemDeviceStopCoachingCtx = new System.Windows.Forms.MenuItem();
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.toolBarButtonNavi = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonPreview = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonDetails = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonDevice = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonFrontendFilter = new System.Windows.Forms.ToolBarButton();
            this.contextMenuFrontendFilter = new System.Windows.Forms.ContextMenu();
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
            this.menuItemFrontendStartCoachingWhispering,
            this.menuItemFrontendStartScreenSilentCoaching,
            this.menuItemFrontendStopCoaching});
            resources.ApplyResources(this.menuItemFrontend, "menuItemFrontend");
            // 
            // menuItemFrontendStartCoachingSilentMonitoring
            // 
            this.menuItemFrontendStartCoachingSilentMonitoring.Index = 0;
            this.menuItemFrontendStartCoachingSilentMonitoring.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFrontendStartCoachingSilentMonitoringOneWay,
            this.menuItemFrontendStartCoachingSilentMonitoringMixed});
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoring, "menuItemFrontendStartCoachingSilentMonitoring");
            // 
            // menuItemFrontendStartCoachingSilentMonitoringOneWay
            // 
            this.menuItemFrontendStartCoachingSilentMonitoringOneWay.Index = 0;
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoringOneWay, "menuItemFrontendStartCoachingSilentMonitoringOneWay");
            this.menuItemFrontendStartCoachingSilentMonitoringOneWay.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoringOneWay_Click);
            // 
            // menuItemFrontendStartCoachingSilentMonitoringMixed
            // 
            this.menuItemFrontendStartCoachingSilentMonitoringMixed.Index = 1;
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoringMixed, "menuItemFrontendStartCoachingSilentMonitoringMixed");
            this.menuItemFrontendStartCoachingSilentMonitoringMixed.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoringMixed_Click);
            // 
            // menuItemFrontendStartCoachingWhispering
            // 
            this.menuItemFrontendStartCoachingWhispering.Index = 1;
            this.menuItemFrontendStartCoachingWhispering.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFrontendStartCoachingWhisperingOneWay,
            this.menuItemFrontendStartCoachingWhisperingMixed});
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhispering, "menuItemFrontendStartCoachingWhispering");
            // 
            // menuItemFrontendStartCoachingWhisperingOneWay
            // 
            this.menuItemFrontendStartCoachingWhisperingOneWay.Index = 0;
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhisperingOneWay, "menuItemFrontendStartCoachingWhisperingOneWay");
            this.menuItemFrontendStartCoachingWhisperingOneWay.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhisperingOneWay_Click);
            // 
            // menuItemFrontendStartCoachingWhisperingMixed
            // 
            this.menuItemFrontendStartCoachingWhisperingMixed.Index = 1;
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhisperingMixed, "menuItemFrontendStartCoachingWhisperingMixed");
            this.menuItemFrontendStartCoachingWhisperingMixed.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhisperingMixed_Click);
            // 
            // menuItemFrontendStartScreenSilentCoaching
            // 
            this.menuItemFrontendStartScreenSilentCoaching.Index = 2;
            resources.ApplyResources(this.menuItemFrontendStartScreenSilentCoaching, "menuItemFrontendStartScreenSilentCoaching");
            this.menuItemFrontendStartScreenSilentCoaching.Click += new System.EventHandler(this.menuItemFrontendStartScreenSilentMixed_Click);
            // 
            // menuItemFrontendStopCoaching
            // 
            this.menuItemFrontendStopCoaching.Index = 3;
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
            this.menuItemDeviceStartCoachingWhispering,
            this.menuItemDeviceScreenSilentCoaching,
            this.menuItemDeviceStopCoaching});
            resources.ApplyResources(this.menuItemDevice, "menuItemDevice");
            // 
            // menuItemDeviceStartCoachingSilentMonitoring
            // 
            this.menuItemDeviceStartCoachingSilentMonitoring.Index = 0;
            this.menuItemDeviceStartCoachingSilentMonitoring.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeviceStartCoachingSilentMonitoringOneWay,
            this.menuItemDeviceStartCoachingSilentMonitoringMixed});
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoring, "menuItemDeviceStartCoachingSilentMonitoring");
            // 
            // menuItemDeviceStartCoachingSilentMonitoringOneWay
            // 
            this.menuItemDeviceStartCoachingSilentMonitoringOneWay.Index = 0;
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoringOneWay, "menuItemDeviceStartCoachingSilentMonitoringOneWay");
            this.menuItemDeviceStartCoachingSilentMonitoringOneWay.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoringOneWay_Click);
            // 
            // menuItemDeviceStartCoachingSilentMonitoringMixed
            // 
            this.menuItemDeviceStartCoachingSilentMonitoringMixed.Index = 1;
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoringMixed, "menuItemDeviceStartCoachingSilentMonitoringMixed");
            this.menuItemDeviceStartCoachingSilentMonitoringMixed.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoringMixed_Click);
            // 
            // menuItemDeviceStartCoachingWhispering
            // 
            this.menuItemDeviceStartCoachingWhispering.Index = 1;
            this.menuItemDeviceStartCoachingWhispering.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeviceStartCoachingWhisperingOneWay,
            this.menuItemDeviceStartCoachingWhisperingMixed});
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhispering, "menuItemDeviceStartCoachingWhispering");
            // 
            // menuItemDeviceStartCoachingWhisperingOneWay
            // 
            this.menuItemDeviceStartCoachingWhisperingOneWay.Index = 0;
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhisperingOneWay, "menuItemDeviceStartCoachingWhisperingOneWay");
            this.menuItemDeviceStartCoachingWhisperingOneWay.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhisperingOneWay_Click);
            // 
            // menuItemDeviceStartCoachingWhisperingMixed
            // 
            this.menuItemDeviceStartCoachingWhisperingMixed.Index = 1;
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhisperingMixed, "menuItemDeviceStartCoachingWhisperingMixed");
            this.menuItemDeviceStartCoachingWhisperingMixed.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhisperingMixed_Click);
            // 
            // menuItemDeviceScreenSilentCoaching
            // 
            this.menuItemDeviceScreenSilentCoaching.Index = 2;
            resources.ApplyResources(this.menuItemDeviceScreenSilentCoaching, "menuItemDeviceScreenSilentCoaching");
            this.menuItemDeviceScreenSilentCoaching.Click += new System.EventHandler(this.menuItemDeviceStartScreenSilentMixed_Click);
            // 
            // menuItemDeviceStopCoaching
            // 
            this.menuItemDeviceStopCoaching.Index = 3;
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
            this.menuItemFrontendStartCoachingWhisperingCtx,
            this.menuItemFrontendStartScreenSilentCoachingCtx,
            this.menuItemFrontendStopCoachingCtx});
            // 
            // menuItemFrontendStartCoachingSilentMonitoringCtx
            // 
            this.menuItemFrontendStartCoachingSilentMonitoringCtx.Index = 0;
            this.menuItemFrontendStartCoachingSilentMonitoringCtx.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFrontendStartCoachingSilentMonitoringOneWayCtx,
            this.menuItemFrontendStartCoachingSilentMonitoringMixedCtx});
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoringCtx, "menuItemFrontendStartCoachingSilentMonitoringCtx");
            // 
            // menuItemFrontendStartCoachingSilentMonitoringOneWayCtx
            // 
            this.menuItemFrontendStartCoachingSilentMonitoringOneWayCtx.Index = 0;
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoringOneWayCtx, "menuItemFrontendStartCoachingSilentMonitoringOneWayCtx");
            this.menuItemFrontendStartCoachingSilentMonitoringOneWayCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoringOneWay_Click);
            // 
            // menuItemFrontendStartCoachingSilentMonitoringMixedCtx
            // 
            this.menuItemFrontendStartCoachingSilentMonitoringMixedCtx.Index = 1;
            resources.ApplyResources(this.menuItemFrontendStartCoachingSilentMonitoringMixedCtx, "menuItemFrontendStartCoachingSilentMonitoringMixedCtx");
            this.menuItemFrontendStartCoachingSilentMonitoringMixedCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingSilentMonitoringMixed_Click);
            // 
            // menuItemFrontendStartCoachingWhisperingCtx
            // 
            this.menuItemFrontendStartCoachingWhisperingCtx.Index = 1;
            this.menuItemFrontendStartCoachingWhisperingCtx.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFrontendStartCoachingWhisperingOneWayCtx,
            this.menuItemFrontendStartCoachingWhisperingMixedCtx});
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhisperingCtx, "menuItemFrontendStartCoachingWhisperingCtx");
            // 
            // menuItemFrontendStartCoachingWhisperingOneWayCtx
            // 
            this.menuItemFrontendStartCoachingWhisperingOneWayCtx.Index = 0;
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhisperingOneWayCtx, "menuItemFrontendStartCoachingWhisperingOneWayCtx");
            this.menuItemFrontendStartCoachingWhisperingOneWayCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhisperingOneWay_Click);
            // 
            // menuItemFrontendStartCoachingWhisperingMixedCtx
            // 
            this.menuItemFrontendStartCoachingWhisperingMixedCtx.Index = 1;
            resources.ApplyResources(this.menuItemFrontendStartCoachingWhisperingMixedCtx, "menuItemFrontendStartCoachingWhisperingMixedCtx");
            this.menuItemFrontendStartCoachingWhisperingMixedCtx.Click += new System.EventHandler(this.menuItemFrontendStartCoachingWhisperingMixed_Click);
            // 
            // menuItemFrontendStartScreenSilentCoachingCtx
            // 
            this.menuItemFrontendStartScreenSilentCoachingCtx.Index = 2;
            resources.ApplyResources(this.menuItemFrontendStartScreenSilentCoachingCtx, "menuItemFrontendStartScreenSilentCoachingCtx");
            this.menuItemFrontendStartScreenSilentCoachingCtx.Click += new System.EventHandler(this.menuItemFrontendStartScreenSilentMixed_Click);
            // 
            // menuItemFrontendStopCoachingCtx
            // 
            this.menuItemFrontendStopCoachingCtx.Index = 3;
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
            this.menuItemDeviceStartCoachingWhisperingCtx,
            this.menuItemDeviceScreenSilentCoachingCtx,
            this.menuItemDeviceStopCoachingCtx});
            // 
            // menuItemDeviceStartCoachingSilentMonitoringCtx
            // 
            this.menuItemDeviceStartCoachingSilentMonitoringCtx.Index = 0;
            this.menuItemDeviceStartCoachingSilentMonitoringCtx.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeviceStartCoachingSilentMonitoringOneWayCtx,
            this.menuItemDeviceStartCoachingSilentMonitoringMixedCtx});
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoringCtx, "menuItemDeviceStartCoachingSilentMonitoringCtx");
            // 
            // menuItemDeviceStartCoachingSilentMonitoringOneWayCtx
            // 
            this.menuItemDeviceStartCoachingSilentMonitoringOneWayCtx.Index = 0;
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoringOneWayCtx, "menuItemDeviceStartCoachingSilentMonitoringOneWayCtx");
            this.menuItemDeviceStartCoachingSilentMonitoringOneWayCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoringOneWay_Click);
            // 
            // menuItemDeviceStartCoachingSilentMonitoringMixedCtx
            // 
            this.menuItemDeviceStartCoachingSilentMonitoringMixedCtx.Index = 1;
            resources.ApplyResources(this.menuItemDeviceStartCoachingSilentMonitoringMixedCtx, "menuItemDeviceStartCoachingSilentMonitoringMixedCtx");
            this.menuItemDeviceStartCoachingSilentMonitoringMixedCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingSilentMonitoringMixed_Click);
            // 
            // menuItemDeviceStartCoachingWhisperingCtx
            // 
            this.menuItemDeviceStartCoachingWhisperingCtx.Index = 1;
            this.menuItemDeviceStartCoachingWhisperingCtx.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeviceStartCoachingWhisperingOneWayCtx,
            this.menuItemDeviceStartCoachingWhisperingMixedCtx});
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhisperingCtx, "menuItemDeviceStartCoachingWhisperingCtx");
            // 
            // menuItemDeviceStartCoachingWhisperingOneWayCtx
            // 
            this.menuItemDeviceStartCoachingWhisperingOneWayCtx.Index = 0;
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhisperingOneWayCtx, "menuItemDeviceStartCoachingWhisperingOneWayCtx");
            this.menuItemDeviceStartCoachingWhisperingOneWayCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhisperingOneWay_Click);
            // 
            // menuItemDeviceStartCoachingWhisperingMixedCtx
            // 
            this.menuItemDeviceStartCoachingWhisperingMixedCtx.Index = 1;
            resources.ApplyResources(this.menuItemDeviceStartCoachingWhisperingMixedCtx, "menuItemDeviceStartCoachingWhisperingMixedCtx");
            this.menuItemDeviceStartCoachingWhisperingMixedCtx.Click += new System.EventHandler(this.menuItemDeviceStartCoachingWhisperingMixed_Click);
            // 
            // menuItemDeviceScreenSilentCoachingCtx
            // 
            this.menuItemDeviceScreenSilentCoachingCtx.Index = 2;
            resources.ApplyResources(this.menuItemDeviceScreenSilentCoachingCtx, "menuItemDeviceScreenSilentCoachingCtx");
            this.menuItemDeviceScreenSilentCoachingCtx.Click += new System.EventHandler(this.menuItemDeviceStartScreenSilentMixed_Click);
            // 
            // menuItemDeviceStopCoachingCtx
            // 
            this.menuItemDeviceStopCoachingCtx.Index = 3;
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
            this.toolBarButtonSeparator1,
            this.toolBarButtonDevice,
            this.toolBarButtonSeparator2,
            this.toolBarButtonFrontendFilter});
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
            // toolBarButtonSeparator1
            // 
            this.toolBarButtonSeparator1.Name = "toolBarButtonSeparator1";
            this.toolBarButtonSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButtonDevice
            // 
            resources.ApplyResources(this.toolBarButtonDevice, "toolBarButtonDevice");
            this.toolBarButtonDevice.Name = "toolBarButtonDevice";
            this.toolBarButtonDevice.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // toolBarButtonSeparator2
            // 
            this.toolBarButtonSeparator2.Name = "toolBarButtonSeparator2";
            this.toolBarButtonSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButtonFrontendFilter
            // 
            this.toolBarButtonFrontendFilter.DropDownMenu = this.contextMenuFrontendFilter;
            resources.ApplyResources(this.toolBarButtonFrontendFilter, "toolBarButtonFrontendFilter");
            this.toolBarButtonFrontendFilter.Name = "toolBarButtonFrontendFilter";
            this.toolBarButtonFrontendFilter.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
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
            this.imageList.Images.SetKeyName(5, "");
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
                _mainControl.OnDeviceConnected += new MainControl.OnDeviceConnectedEventHandler(
                    _mainControl_OnDeviceConnected);
                _mainControl.OnDeviceDisconnected +=
                    new MainControl.OnDeviceDisconnectedEventHandler(
                    _mainControl_OnDeviceDisconnected);
                _mainControl.OnAgentLost += new MainControl.OnAgentLostEventHandler(
                    _mainControl_OnAgentLost);
                _mainControl.OnConnectionLost += new MainControl.OnConnectionLostEventHandler(
                    _mainControl_OnConnectionLost);

                // Frontendverwaltung referenzieren
                _frontendControl = _mainControl.FrontendControl;
                _frontendControl.OnRefreshFrontend += new FrontendControl.FrontendEventHandler(
                    _frontendControl_OnRefreshFrontend);

                // Kampagnenverwaltung referenzieren
                _campaignControl = _mainControl.CampaignControl;
                _campaignControl.OnAddCampaign += new CampaignControl.CampaignEventHandler(
                    _campaignControl_OnAddCampaign);
                _campaignControl.OnRefreshCampaign += new CampaignControl.CampaignEventHandler(
                    _campaignControl_OnRefreshCampaign);
                _campaignControl.OnRemoveCampaign += new CampaignControl.CampaignEventHandler(
                    _campaignControl_OnRemoveCampaign);

                // Statusleiste initialisieren
                RefreshStatusBar();

                // Schaltfläche für Device initialisieren
                toolBarButtonDevice.Enabled = (Settings.Instance.DeviceCode != "") &&
                    ((CoachingLevel)Settings.Instance.CoachingLevel != CoachingLevel.Disabled);

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

                // Konfiguration laden
                _mainControl.LoadConfig();

                // Monitoring starten
                _mainControl.StartMonitoring();

                // Steuerelemente aktualisieren
                RefreshControls();
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
            // wenn Kampagnenverwaltung referenziert, freigeben
            if (_campaignControl != null)
            {
                _campaignControl.OnAddCampaign -= new CampaignControl.CampaignEventHandler(
                    _campaignControl_OnAddCampaign);
                _campaignControl.OnRefreshCampaign -= new CampaignControl.CampaignEventHandler(
                    _campaignControl_OnRefreshCampaign);
                _campaignControl.OnRemoveCampaign -= new CampaignControl.CampaignEventHandler(
                    _campaignControl_OnRemoveCampaign);
                _campaignControl = null;
            }

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
        /// startet screen monitoring in mixed mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemFrontendStartScreenSilentMixed_Click(object sender, EventArgs e)
        {
            try
            {
                // ausgewähltes Frontend ermitteln
                Frontend frontend = _mainControl.FrontendControl[_frontendPage.SelectedItemTag];

                // wenn Frontend gefunden, Coaching starten
                if (frontend != null)
                {
                    StartCoaching(frontend.AgentCode, CoachingMode.SilentMonitoringMixed);
                }
                else
                {
                    throw new Exception("No Agent selected");
                }

                // Starting screen monitoring if defined in ini file
                if (Settings.Instance.ScreenMonitoringAllowed)
                {
                    if (!StartVNCViewer(frontend.AgentCode))
                    {
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
        /// Screen monitoring in mixed mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemDeviceStartScreenSilentMixed_Click(object sender, EventArgs e)
        {
            try
            {
                // ausgewähltes Device ermitteln
                Device device = _mainControl.DeviceControl[_sitePage.SelectedDeviceCode];

                // wenn Device gefunden und Frontend zugewiesen, Coaching starten
                if ((device != null) && (device.Frontend != null))
                {
                    StartCoaching(device.Frontend.AgentCode, CoachingMode.SilentMonitoringMixed);
                }
                else
                {
                    throw new Exception("No device selected");
                }

                // Starting screen monitoring if defined in ini file
                if (Settings.Instance.ScreenMonitoringAllowed)
                {
                    if (!StartVNCViewer(device.Frontend.AgentCode))
                    {
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
        /// startet Coaching im Modus Silent Monitoring OneWay über ausgewähltes Frontend
        /// </summary>
        private void menuItemFrontendStartCoachingSilentMonitoringOneWay_Click(object sender,
            System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Frontend starten
                StartCoachingBySelectedFrontend(CoachingMode.SilentMonitoringOneWay);
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on starting coaching.", ex);
            }
        }

        /// <summary>
        /// startet Coaching im Modus Silent Monitoring Mixed über ausgewähltes Frontend
        /// </summary>
        private void menuItemFrontendStartCoachingSilentMonitoringMixed_Click(object sender,
            System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Frontend starten
                StartCoachingBySelectedFrontend(CoachingMode.SilentMonitoringMixed);
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on starting coaching.", ex);
            }
        }

        /// <summary>
        /// startet Coaching im Modus Whispering OneWay über ausgewähltes Frontend
        /// </summary>
        private void menuItemFrontendStartCoachingWhisperingOneWay_Click(object sender,
            System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Frontend starten
                StartCoachingBySelectedFrontend(CoachingMode.WhisperingOneWay);
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on starting coaching.", ex);
            }
        }

        /// <summary>
        /// startet Coaching im Modus Whispering Mixed über ausgewähltes Frontend
        /// </summary>
        private void menuItemFrontendStartCoachingWhisperingMixed_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Frontend starten
                StartCoachingBySelectedFrontend(CoachingMode.WhisperingMixed);
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
        /// startet Coaching im Modus Silent Monitoring OneWay über ausgewähltes Device
        /// </summary>
        private void menuItemDeviceStartCoachingSilentMonitoringOneWay_Click(object sender,
            System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Device starten
                StartCoachingBySelectedDevice(CoachingMode.SilentMonitoringOneWay);
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on starting coaching.", ex);
            }
        }

        /// <summary>
        /// startet Coaching im Modus Silent Monitoring Mixed über ausgewähltes Device
        /// </summary>
        private void menuItemDeviceStartCoachingSilentMonitoringMixed_Click(object sender,
            System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Device starten
                StartCoachingBySelectedDevice(CoachingMode.SilentMonitoringMixed);
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on starting coaching.", ex);
            }
        }

        /// <summary>
        /// startet Coaching im Modus Whispering OneWay über ausgewähltes Device
        /// </summary>
        private void menuItemDeviceStartCoachingWhisperingOneWay_Click(object sender,
            System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Device starten
                StartCoachingBySelectedDevice(CoachingMode.WhisperingOneWay);
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on starting coaching.", ex);
            }
        }

        /// <summary>
        /// startet Coaching im Modus Whispering Mixed über ausgewähltes Device
        /// </summary>
        private void menuItemDeviceStartCoachingWhisperingMixed_Click(object sender,
            System.EventArgs e)
        {
            try
            {
                // Coaching über ausgewähltes Device starten
                StartCoachingBySelectedDevice(CoachingMode.WhisperingMixed);
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
        /// passt Fensteransicht an, steuert Devicezugriff und Frontendfilter
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
                        // wenn Schaltfläche für Device gedrückt
                        if (e.Button.Pushed)
                        {
                            // Schaltfläche aktualisieren
                            e.Button.ImageIndex = 4;

                            // je nach Devicetyp
                            switch ((DeviceType)Settings.Instance.DeviceType)
                            {
                                case DeviceType.DialIn:
                                    // Device zuweisen
                                    AssignDevice(Settings.Instance.DeviceCode);
                                    break;
                                case DeviceType.DialOut:
                                    // Device aufbauen
                                    CallDevice(Settings.Instance.DeviceCode);
                                    break;
                            }
                        }
                        else
                        {
                            // sonst Schaltfläche aktualisieren
                            e.Button.ImageIndex = 3;

                            // je nach Devicetyp
                            switch ((DeviceType)Settings.Instance.DeviceType)
                            {
                                case DeviceType.DialIn:
                                    // Device freigeben
                                    UnassignDevice();
                                    break;
                                case DeviceType.DialOut:
                                    // Device trennen
                                    HangupDevice();
                                    break;
                            }
                        }
                        break;
                    case 6:
                        {
                            // wenn Schaltfläche für Frontendfilter gedrückt
                            if (toolBarButtonFrontendFilter.Pushed)
                            {
                                // Frontendfilter deaktivieren
                                SetFrontendFilter(null);
                            }
                            else
                            {
                                // sonst Frontendfilter für letzte ausgewählte Kampagne aktivieren
                                SetFrontendFilter(_frontendFilterLastCampaign);
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on processing toolbar button click.", ex);
            }
        }

        /// <summary>
        /// aktiviert Frontendfilter
        /// </summary>
        private void menuItemFrontendFilter_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Kampagne zu Menüeintrag suchen
                Campaign campaign = (Campaign)_frontendFilterCampaigns[sender];

                // wenn Kampagne gefunden, Frontendfilter aktivieren
                if (campaign != null)
                {
                    SetFrontendFilter(campaign);
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error("Error on changing frontend filter.", ex);
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
        /// behandelt Verbinden des Devices
        /// </summary>
        private void _mainControl_OnDeviceConnected()
        {
            // Steuerelemente aktualisieren
            RefreshControls();
        }

        /// <summary>
        /// behandelt Trennen des Devices
        /// </summary>
        private void _mainControl_OnDeviceDisconnected(DeviceResult deviceResult)
        {
            // Meldung ausgeben
            MessageBox.Show(this, GetDeviceDisconnectedMessage(deviceResult),
                Resources.GetString("MainForm.MessageBox.Caption.DeviceDisconnected"),
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Steuerelemente aktualisieren
            RefreshControls();
        }

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
                // wenn Agent gecoacht wird und spricht, Coachingerlaubnis erforderlich aber nicht
                // erteilt
                if ((frontend.MonitorCode == Settings.Instance.MonitorCode) &&
                    ((frontend.State == FrontendState.Talking) ||
                    (frontend.State == FrontendState.Conferencing)) &&
                    IsCoachingPermissionRequired(frontend.CoachingMode) &&
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

        #region----------------------------- Ereignisbehandlung Kampagnenverwaltung ---------------

        /// <summary>
        /// fügt Kampagne zu Frontendfilter hinzu
        /// </summary>
        private void _campaignControl_OnAddCampaign(Campaign campaign)
        {
            // Menüeintrag zu Kampagne initialisieren
            MenuItem menuItemFrontendFilter = new MenuItem();
            menuItemFrontendFilter.Text = campaign.DisplayName;
            menuItemFrontendFilter.Click += new EventHandler(menuItemFrontendFilter_Click);

            // Menüeintrag und Kampagne zu Zuordungstabellen für Frontendfilter hinzufügen
            _frontendFilterCampaigns.Add(menuItemFrontendFilter, campaign);
            _frontendFilterMenuItems.Add(campaign, menuItemFrontendFilter);

            // Menüeintrag zu Kontextmenü für Frontendfilter hinzufügen
            contextMenuFrontendFilter.MenuItems.Add(menuItemFrontendFilter);

            // Kontextmenü für Frontendfilter sortieren
            SortMenu(contextMenuFrontendFilter);

            // Steuerelemente aktualisieren
            RefreshControls();
        }

        /// <summary>
        /// aktualisiert Kampagne in Frontendfilter
        /// </summary>
        private void _campaignControl_OnRefreshCampaign(Campaign campaign)
        {
            // Menüeintrag zu Kampagne suchen
            MenuItem menuItemFrontendFilter = (MenuItem)_frontendFilterMenuItems[campaign];

            // wenn Menüeintrag gefunden und veraltet
            if ((menuItemFrontendFilter != null) &&
                (menuItemFrontendFilter.Text != campaign.DisplayName))
            {
                // Menüeintrag aktualisieren
                menuItemFrontendFilter.Text = campaign.DisplayName;

                // Kontextmenü für Frontendfilter sortieren
                SortMenu(contextMenuFrontendFilter);

                // wenn Frontendfilter für Kampagne aktiviert, Frontendfilter aktualisieren
                if ((toolBarButtonFrontendFilter.Pushed) &&
                    (_frontendFilterLastCampaign == campaign))
                {
                    SetFrontendFilter(campaign);
                }
            }
        }

        /// <summary>
        /// entfernt Kampagne von Frontendfilter
        /// </summary>
        private void _campaignControl_OnRemoveCampaign(Campaign campaign)
        {
            // wenn letzte für Frontendfilter ausgewählte Kampagne entfernt wird
            if (_frontendFilterLastCampaign == campaign)
            {
                // wenn Frontendfilter aktiviert, deaktivieren
                if (toolBarButtonFrontendFilter.Pushed)
                {
                    SetFrontendFilter(null);
                }

                // letzte für Frontendfilter ausgewählte Kampagne zurücksetzen
                _frontendFilterLastCampaign = null;
            }

            // Menüeintrag für Kampagne suchen
            MenuItem menuItemFrontendFilter = (MenuItem)_frontendFilterMenuItems[campaign];

            // Menüeintrag aus Kontextmenü entfernen
            contextMenuFrontendFilter.MenuItems.Remove(menuItemFrontendFilter);

            // Menüeintrag freigeben
            menuItemFrontendFilter.Click -= new EventHandler(menuItemFrontendFilter_Click);

            // Menüeintrag und Kampagne aus Zuordungstabellen für Frontendfilter entfernen
            _frontendFilterMenuItems.Remove(campaign);
            _frontendFilterCampaigns.Remove(menuItemFrontendFilter);

            // Steuerelemente aktualisieren
            RefreshControls();
        }

        #endregion

        #region----------------------------- Coaching ---------------------------------------------

        /// <summary>
        /// baut Device auf
        /// </summary>
        private void CallDevice(string deviceCode)
        {
            try
            {
                // Device aufbauen
                _mainControl.CallDevice(deviceCode);
            }
            catch (Exception ex)
            {
                // Fehler protokollieren
                Logger.Log.Error("Error on calling device.", ex);

                // Meldung ausgeben
                MessageBox.Show(this, ex.Message + Environment.NewLine + ex.InnerException,
                    Resources.GetString("MainForm.MessageBox.Caption.CallDeviceError"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Steuerelemente aktualisieren
                RefreshControls();
            }
        }

        /// <summary>
        /// trennt Device
        /// </summary>
        private void HangupDevice()
        {
            try
            {
                // Device trennen
                _mainControl.HangupDevice();
            }
            finally
            {
                // Steuerelemente aktualisieren
                RefreshControls();
            }
        }

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
        /// startet Coaching im angegebenen Modus über ausgewähltes Frontend
        /// </summary>
        private void StartCoachingBySelectedFrontend(CoachingMode coachingMode)
        {
            // ausgewähltes Frontend ermitteln
            Frontend frontend = _mainControl.FrontendControl[_frontendPage.SelectedItemTag];

            // wenn Frontend gefunden, Coaching starten
            if (frontend != null)
            {
                StartCoaching(frontend.AgentCode, coachingMode);
            }
        }

        /// <summary>
        /// startet Coaching im angegebenen Modus über ausgewähltes Device
        /// </summary>
        private void StartCoachingBySelectedDevice(CoachingMode coachingMode)
        {
            // ausgewähltes Device ermitteln
            Device device = _mainControl.DeviceControl[_sitePage.SelectedDeviceCode];

            // wenn Device gefunden und Frontend zugewiesen, Coaching starten
            if ((device != null) && (device.Frontend != null))
            {
                StartCoaching(device.Frontend.AgentCode, coachingMode);
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

        #region----------------------------- Frontendfilter ---------------------------------------

        /// <summary>
        /// sortiert Einträge des übergebenen Menüs
        /// </summary>
        private void SortMenu(Menu menu)
        {
            // alle Menüeinträge alphabetisch sortieren
            for (int i = 0; i < menu.MenuItems.Count; i++)
            {
                for (int j = i + 1; j < menu.MenuItems.Count; j++)
                {
                    if (menu.MenuItems[j].Text.CompareTo(menu.MenuItems[i].Text) < 0)
                    {
                        menu.MenuItems[j].Index = i;
                    }
                }
            }
        }

        /// <summary>
        /// stellt Frontendfilter ein
        /// </summary>
        private void SetFrontendFilter(Campaign campaign)
        {
            // wenn Kampagne angegeben
            if (campaign != null)
            {
                // Schaltfläche für Frontendfilter einrasten
                toolBarButtonFrontendFilter.Pushed = true;

                // Frontendfilter aktivieren oder aktualisieren
                _frontendPage.SetFrontendFilter(campaign.Code, campaign.DisplayName);

                // letzte für Frontendfilter ausgewählte Kampagne aktualisieren
                _frontendFilterLastCampaign = campaign;
            }
            else
            {
                // sonst Frontendfilter deaktivieren
                _frontendPage.SetFrontendFilter("", "");

                // Schaltfläche für Frontendfilter lösen
                toolBarButtonFrontendFilter.Pushed = false;
            }

            // Auswahlhaken in Kontextmenü für Frontendfilter aktualisieren
            foreach (MenuItem menuItem in contextMenuFrontendFilter.MenuItems)
            {
                menuItem.Checked = _frontendFilterCampaigns[menuItem] == campaign;
            }
        }

        #endregion

        #region----------------------------- Aktualisierung Formular ------------------------------

        /// <summary>
        /// zeigt ausgewählte Seite an
        /// </summary>
        private void SelectPage(int index)
        {
            // Sichtbarkeit aller Seiten aktualisieren
            _frontendPage.Visible = (index == 0);
            _campaignPage.Visible = (index == 1);
            _conferencePage.Visible = (index == 2);
            _sitePage.Visible = (index == 3);
            _devicePage.Visible = (index == 4);

            // abhängige Menüs aktualisieren
            menuItemFrontend.Visible = (index == 0);
            menuItemSite.Visible = (index == 3);
            menuItemDevice.Visible = (index == 3);

            // abhängige Schaltflächen aktualisieren
            toolBarButtonSeparator2.Visible = (index == 0);
            toolBarButtonFrontendFilter.Visible = (index == 0);
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
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringOneWay) ||
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringMixed);
            menuItemFrontendStartCoachingSilentMonitoringOneWay.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringOneWay);
            menuItemFrontendStartCoachingSilentMonitoringMixed.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringMixed);
            menuItemFrontendStartCoachingWhispering.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.WhisperingOneWay) ||
                IsCoachingAllowed(frontend, CoachingMode.WhisperingMixed);
            menuItemFrontendStartCoachingWhisperingOneWay.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.WhisperingOneWay);
            menuItemFrontendStartCoachingWhisperingMixed.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.WhisperingMixed);
            menuItemFrontendStartScreenSilentCoaching.Enabled =
                IsScreenMonitoringAllowed(frontend, CoachingMode.SilentMonitoringMixed);
            menuItemFrontendStopCoaching.Enabled =
                _mainControl.MonitorState == MonitorState.Coaching;

            // Kontextmenü Frontend aktualisieren
            menuItemFrontendStartCoachingSilentMonitoringCtx.Enabled =
                menuItemFrontendStartCoachingSilentMonitoring.Enabled;
            menuItemFrontendStartCoachingSilentMonitoringOneWayCtx.Enabled =
                menuItemFrontendStartCoachingSilentMonitoringOneWay.Enabled;
            menuItemFrontendStartCoachingSilentMonitoringMixedCtx.Enabled =
                menuItemFrontendStartCoachingSilentMonitoringMixed.Enabled;
            menuItemFrontendStartCoachingWhisperingCtx.Enabled =
                menuItemFrontendStartCoachingWhispering.Enabled;
            menuItemFrontendStartCoachingWhisperingOneWayCtx.Enabled =
                menuItemFrontendStartCoachingWhisperingOneWay.Enabled;
            menuItemFrontendStartCoachingWhisperingMixedCtx.Enabled =
                menuItemFrontendStartCoachingWhisperingMixed.Enabled;
            menuItemFrontendStartScreenSilentCoachingCtx.Enabled =
                menuItemFrontendStartScreenSilentCoaching.Enabled;
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
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringOneWay) ||
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringMixed);
            menuItemDeviceStartCoachingSilentMonitoringOneWay.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringOneWay);
            menuItemDeviceStartCoachingSilentMonitoringMixed.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.SilentMonitoringMixed);
            menuItemDeviceStartCoachingWhispering.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.WhisperingOneWay) ||
                IsCoachingAllowed(frontend, CoachingMode.WhisperingMixed);
            menuItemDeviceStartCoachingWhisperingOneWay.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.WhisperingOneWay);
            menuItemDeviceStartCoachingWhisperingMixed.Enabled =
                IsCoachingAllowed(frontend, CoachingMode.WhisperingMixed);
            menuItemDeviceScreenSilentCoaching.Enabled =
                IsScreenMonitoringAllowed(frontend, CoachingMode.SilentMonitoringMixed);
            menuItemDeviceStopCoaching.Enabled =
                _mainControl.MonitorState == MonitorState.Coaching;

            // Kontextmenü Device aktualisieren
            menuItemDeviceStartCoachingSilentMonitoringCtx.Enabled =
                menuItemDeviceStartCoachingSilentMonitoring.Enabled;
            menuItemDeviceStartCoachingSilentMonitoringOneWayCtx.Enabled =
                menuItemDeviceStartCoachingSilentMonitoringOneWay.Enabled;
            menuItemDeviceStartCoachingSilentMonitoringMixedCtx.Enabled =
                menuItemDeviceStartCoachingSilentMonitoringMixed.Enabled;
            menuItemDeviceStartCoachingWhisperingCtx.Enabled =
                menuItemDeviceStartCoachingWhispering.Enabled;
            menuItemDeviceStartCoachingWhisperingOneWayCtx.Enabled =
                menuItemDeviceStartCoachingWhisperingOneWay.Enabled;
            menuItemDeviceStartCoachingWhisperingMixedCtx.Enabled =
                menuItemDeviceStartCoachingWhisperingMixed.Enabled;
            menuItemDeviceScreenSilentCoachingCtx.Enabled =
                menuItemDeviceScreenSilentCoaching.Enabled;
            menuItemDeviceStopCoachingCtx.Enabled = menuItemDeviceStopCoaching.Enabled;

            // Schaltfläche für Device aktualisieren
            toolBarButtonDevice.Pushed =
                ((_mainControl.MonitorState == MonitorState.Calling) ||
                (_mainControl.MonitorState == MonitorState.Assigned) ||
                (_mainControl.MonitorState == MonitorState.Coaching));
            toolBarButtonDevice.ImageIndex = toolBarButtonDevice.Pushed ? 4 : 3;

            // Schaltfläche für Frontendfilter aktualisieren
            toolBarButtonFrontendFilter.Enabled = contextMenuFrontendFilter.MenuItems.Count > 0;

            // Statusleiste aktualisieren
            statusBarPanelState.Text = _mainControl.MonitorState.ToString();
        }

        /// <summary>
        /// ermittelt, ob Coaching für angegebenen Agent erlaubt ist
        /// </summary>
        private bool IsCoachingAllowed(Frontend frontend, CoachingMode coachingMode)
        {
            // Freigabeebene Coaching ermitteln
            CoachingLevel coachingLevel = (CoachingLevel)Settings.Instance.CoachingLevel;

            // aktuellen Monitorstatus, aktuellen Devicestatus und Coachingstatus des Agenten,
            // angegebenen Coachingmodus und Coachingerlaubnis prüfen und Ergebnis zurückgeben
            return ((_mainControl.MonitorState == MonitorState.Assigned) ||
                (_mainControl.MonitorState == MonitorState.Coaching)) &&
                (frontend != null) &&
                ((frontend.DeviceState == DeviceState.Assigned) ||
                (frontend.DeviceState == DeviceState.Reserved)) &&
                ((frontend.MonitorCode == "") ||
                ((frontend.MonitorCode == Settings.Instance.MonitorCode) &&
                (frontend.CoachingMode != coachingMode))) &&
                (((coachingLevel == CoachingLevel.OneWay) &&
                ((coachingMode == CoachingMode.SilentMonitoringOneWay) ||
                (coachingMode == CoachingMode.WhisperingOneWay))) ||
                (coachingLevel == CoachingLevel.Mixed)) &&
                ((!IsCoachingPermissionRequired(coachingMode)) ||
                ((frontend.State != FrontendState.Talking) &&
                (frontend.State != FrontendState.Conferencing)) ||
                frontend.CoachingPermission);
        }

        /// <summary>
        /// Ermittelt ob Screen Monitoring erlaubt ist
        /// </summary>
        /// <param name="frontend"></param>
        /// <param name="coachingMode"></param>
        /// <returns></returns>
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

        #region----------------------------- sonstige Methoden ------------------------------------

        /// <summary>
        /// gibt Meldung für getrenntes Device zurück
        /// </summary>
        private string GetDeviceDisconnectedMessage(DeviceResult deviceResult)
        {
            return _mainControl.LastMonitorState == MonitorState.Calling ?
                Resources.GetString("MainForm.MessageBox.Text.DeviceDisconnectedCalling") + " " +
                GetDeviceResultMessage(deviceResult) :
                Resources.GetString("MainForm.MessageBox.Text.DeviceDisconnectedAssigned");
        }

        /// <summary>
        /// gibt Meldung für Ergebnis Deviceanruf zurück
        /// </summary>
        private string GetDeviceResultMessage(DeviceResult deviceResult)
        {
            switch (deviceResult)
            {
                case DeviceResult.NormalClearing:
                    return Resources.GetString("MainForm.MessageBox.Text.NormalClearing");
                case DeviceResult.Busy:
                    return Resources.GetString("MainForm.MessageBox.Text.Busy");
                case DeviceResult.NoAnswer:
                    return Resources.GetString("MainForm.MessageBox.Text.NoAnswer");
                case DeviceResult.WrongNumber:
                    return Resources.GetString("MainForm.MessageBox.Text.WrongNumber");
                case DeviceResult.PSTNFailure:
                    return Resources.GetString("MainForm.MessageBox.Text.PSTNFailure");
                case DeviceResult.TelcoOverload:
                    return Resources.GetString("MainForm.MessageBox.Text.TelcoOverload");
                case DeviceResult.Reset:
                    return Resources.GetString("MainForm.MessageBox.Text.Reset");
                default:
                    throw new Exception("DeviceResult unknown.");
            }
        }

        /// <summary>
        /// ermittelt, ob Coachingerlaubnis für angegebenen Coachingmodus erforderlich
        /// </summary>
        private bool IsCoachingPermissionRequired(CoachingMode coachingMode)
        {
            // Erfordernis Coachingerlaubnis ermitteln
            CoachingPermissionLevel coachingPermissionLevel =
                (CoachingPermissionLevel)Settings.Instance.CoachingPermissionLevel;

            // Coachingmodus prüfen und Ergebnis zurückgeben
            return ((coachingPermissionLevel == CoachingPermissionLevel.OneWay) ||
                ((coachingPermissionLevel == CoachingPermissionLevel.Mixed) &&
                ((coachingMode == CoachingMode.SilentMonitoringMixed) ||
                (coachingMode == CoachingMode.WhisperingMixed))));
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
            _vncViewer = new Tieto.MonitorClient.StartVNCViewer(AgentCode);
            if (null != _vncViewer.VNCViewer && !_vncViewer.VNCViewer.HasExited)
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
