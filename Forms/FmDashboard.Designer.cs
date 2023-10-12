namespace REMAS.Forms
{
    partial class FmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDashboard));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.salesContainer = new System.Windows.Forms.Panel();
            this.pnReport = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnTrans = new System.Windows.Forms.Panel();
            this.btnTrans = new System.Windows.Forms.Button();
            this.pnMaster = new System.Windows.Forms.Panel();
            this.btnMaster = new System.Windows.Forms.Button();
            this.masterContainer = new System.Windows.Forms.Panel();
            this.pnCust = new System.Windows.Forms.Panel();
            this.btnCust = new System.Windows.Forms.Button();
            this.pnSales = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.pnPurchase = new System.Windows.Forms.Panel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.pnInventory = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnUtility = new System.Windows.Forms.Panel();
            this.btnUtility = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnHrd = new System.Windows.Forms.Panel();
            this.btnHrd = new System.Windows.Forms.Button();
            this.pnAccounting = new System.Windows.Forms.Panel();
            this.btnAccounting = new System.Windows.Forms.Button();
            this.pnProduction = new System.Windows.Forms.Panel();
            this.btnProduction = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.subTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnDashboard.SuspendLayout();
            this.salesContainer.SuspendLayout();
            this.pnReport.SuspendLayout();
            this.pnTrans.SuspendLayout();
            this.pnMaster.SuspendLayout();
            this.masterContainer.SuspendLayout();
            this.pnCust.SuspendLayout();
            this.pnSales.SuspendLayout();
            this.pnPurchase.SuspendLayout();
            this.pnInventory.SuspendLayout();
            this.pnUtility.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnHrd.SuspendLayout();
            this.pnAccounting.SuspendLayout();
            this.pnProduction.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sidebarPanel.Controls.Add(this.pictureBox1);
            this.sidebarPanel.Controls.Add(this.pnDashboard);
            this.sidebarPanel.Controls.Add(this.salesContainer);
            this.sidebarPanel.Controls.Add(this.pnPurchase);
            this.sidebarPanel.Controls.Add(this.pnHrd);
            this.sidebarPanel.Controls.Add(this.pnProduction);
            this.sidebarPanel.Controls.Add(this.pnAccounting);
            this.sidebarPanel.Controls.Add(this.pnUtility);
            this.sidebarPanel.Controls.Add(this.pnInventory);
            this.sidebarPanel.Controls.Add(this.pnLogout);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.MaximumSize = new System.Drawing.Size(200, 591);
            this.sidebarPanel.MinimumSize = new System.Drawing.Size(55, 591);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 591);
            this.sidebarPanel.TabIndex = 0;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.pnDashboard.Controls.Add(this.btnDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(3, 36);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(197, 37);
            this.pnDashboard.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-13, -6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(228, 56);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // salesContainer
            // 
            this.salesContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesContainer.Controls.Add(this.pnReport);
            this.salesContainer.Controls.Add(this.pnTrans);
            this.salesContainer.Controls.Add(this.pnMaster);
            this.salesContainer.Controls.Add(this.pnSales);
            this.salesContainer.Location = new System.Drawing.Point(3, 79);
            this.salesContainer.MaximumSize = new System.Drawing.Size(197, 159);
            this.salesContainer.MinimumSize = new System.Drawing.Size(197, 35);
            this.salesContainer.Name = "salesContainer";
            this.salesContainer.Size = new System.Drawing.Size(197, 35);
            this.salesContainer.TabIndex = 1;
            // 
            // pnReport
            // 
            this.pnReport.Controls.Add(this.btnReport);
            this.pnReport.Location = new System.Drawing.Point(-7, 109);
            this.pnReport.Name = "pnReport";
            this.pnReport.Size = new System.Drawing.Size(220, 37);
            this.pnReport.TabIndex = 6;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReport.Image = global::REMAS.Properties.Resources.Ellipse_1;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(3, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(212, 40);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "          Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // pnTrans
            // 
            this.pnTrans.Controls.Add(this.btnTrans);
            this.pnTrans.Location = new System.Drawing.Point(-8, 76);
            this.pnTrans.Name = "pnTrans";
            this.pnTrans.Size = new System.Drawing.Size(218, 37);
            this.pnTrans.TabIndex = 5;
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTrans.Image = global::REMAS.Properties.Resources.Ellipse_1;
            this.btnTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrans.Location = new System.Drawing.Point(3, 0);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTrans.Size = new System.Drawing.Size(212, 40);
            this.btnTrans.TabIndex = 0;
            this.btnTrans.Text = "          Transaction";
            this.btnTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrans.UseVisualStyleBackColor = false;
            // 
            // pnMaster
            // 
            this.pnMaster.Controls.Add(this.btnMaster);
            this.pnMaster.Controls.Add(this.masterContainer);
            this.pnMaster.Location = new System.Drawing.Point(-6, 39);
            this.pnMaster.Name = "pnMaster";
            this.pnMaster.Size = new System.Drawing.Size(218, 37);
            this.pnMaster.TabIndex = 4;
            // 
            // btnMaster
            // 
            this.btnMaster.BackColor = System.Drawing.SystemColors.Control;
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaster.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMaster.Image = global::REMAS.Properties.Resources.Ellipse_1;
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.Location = new System.Drawing.Point(0, 1);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMaster.Size = new System.Drawing.Size(218, 40);
            this.btnMaster.TabIndex = 0;
            this.btnMaster.Text = "          Master";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.UseVisualStyleBackColor = false;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // masterContainer
            // 
            this.masterContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.masterContainer.Controls.Add(this.pnCust);
            this.masterContainer.Location = new System.Drawing.Point(9, 1);
            this.masterContainer.MaximumSize = new System.Drawing.Size(197, 159);
            this.masterContainer.MinimumSize = new System.Drawing.Size(197, 35);
            this.masterContainer.Name = "masterContainer";
            this.masterContainer.Size = new System.Drawing.Size(197, 35);
            this.masterContainer.TabIndex = 1;
            // 
            // pnCust
            // 
            this.pnCust.Controls.Add(this.btnCust);
            this.pnCust.Location = new System.Drawing.Point(3, 37);
            this.pnCust.Name = "pnCust";
            this.pnCust.Size = new System.Drawing.Size(218, 37);
            this.pnCust.TabIndex = 5;
            // 
            // btnCust
            // 
            this.btnCust.BackColor = System.Drawing.SystemColors.Control;
            this.btnCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCust.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCust.Image = global::REMAS.Properties.Resources.Ellipse_1;
            this.btnCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCust.Location = new System.Drawing.Point(0, -3);
            this.btnCust.Name = "btnCust";
            this.btnCust.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCust.Size = new System.Drawing.Size(218, 40);
            this.btnCust.TabIndex = 0;
            this.btnCust.Text = "          Customer";
            this.btnCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCust.UseVisualStyleBackColor = false;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // pnSales
            // 
            this.pnSales.Controls.Add(this.btnSales);
            this.pnSales.Location = new System.Drawing.Point(0, 2);
            this.pnSales.Name = "pnSales";
            this.pnSales.Size = new System.Drawing.Size(197, 37);
            this.pnSales.TabIndex = 3;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSales.Image = global::REMAS.Properties.Resources.Menu_PPIC;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(-16, -11);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(228, 56);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "          Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // pnPurchase
            // 
            this.pnPurchase.Controls.Add(this.btnPurchase);
            this.pnPurchase.Location = new System.Drawing.Point(3, 120);
            this.pnPurchase.Name = "pnPurchase";
            this.pnPurchase.Size = new System.Drawing.Size(197, 37);
            this.pnPurchase.TabIndex = 3;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPurchase.Image = global::REMAS.Properties.Resources.Basket;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(-13, -6);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPurchase.Size = new System.Drawing.Size(228, 56);
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.Text = "          Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // pnInventory
            // 
            this.pnInventory.Controls.Add(this.btnInventory);
            this.pnInventory.Location = new System.Drawing.Point(3, 335);
            this.pnInventory.Name = "pnInventory";
            this.pnInventory.Size = new System.Drawing.Size(197, 37);
            this.pnInventory.TabIndex = 3;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInventory.Image = global::REMAS.Properties.Resources.Icon_Inventory;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(-13, -6);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(228, 56);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "          Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // pnUtility
            // 
            this.pnUtility.Controls.Add(this.btnUtility);
            this.pnUtility.Location = new System.Drawing.Point(3, 292);
            this.pnUtility.Name = "pnUtility";
            this.pnUtility.Size = new System.Drawing.Size(197, 37);
            this.pnUtility.TabIndex = 3;
            // 
            // btnUtility
            // 
            this.btnUtility.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtility.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUtility.Image = global::REMAS.Properties.Resources.Gear;
            this.btnUtility.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtility.Location = new System.Drawing.Point(-13, -6);
            this.btnUtility.Name = "btnUtility";
            this.btnUtility.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUtility.Size = new System.Drawing.Size(228, 56);
            this.btnUtility.TabIndex = 0;
            this.btnUtility.Text = "          Utility";
            this.btnUtility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtility.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(3, 378);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(197, 37);
            this.pnLogout.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogout.Image = global::REMAS.Properties.Resources.Icon_Logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-13, -6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(228, 56);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnHrd
            // 
            this.pnHrd.Controls.Add(this.btnHrd);
            this.pnHrd.Location = new System.Drawing.Point(3, 163);
            this.pnHrd.Name = "pnHrd";
            this.pnHrd.Size = new System.Drawing.Size(197, 37);
            this.pnHrd.TabIndex = 3;
            // 
            // btnHrd
            // 
            this.btnHrd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHrd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHrd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHrd.Image = global::REMAS.Properties.Resources.PersonBadge;
            this.btnHrd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHrd.Location = new System.Drawing.Point(-13, -6);
            this.btnHrd.Name = "btnHrd";
            this.btnHrd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHrd.Size = new System.Drawing.Size(228, 56);
            this.btnHrd.TabIndex = 0;
            this.btnHrd.Text = "          HRD";
            this.btnHrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHrd.UseVisualStyleBackColor = false;
            // 
            // pnAccounting
            // 
            this.pnAccounting.Controls.Add(this.btnAccounting);
            this.pnAccounting.Location = new System.Drawing.Point(3, 249);
            this.pnAccounting.Name = "pnAccounting";
            this.pnAccounting.Size = new System.Drawing.Size(197, 37);
            this.pnAccounting.TabIndex = 3;
            // 
            // btnAccounting
            // 
            this.btnAccounting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounting.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAccounting.Image = global::REMAS.Properties.Resources.Calculator;
            this.btnAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounting.Location = new System.Drawing.Point(-13, -6);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAccounting.Size = new System.Drawing.Size(228, 56);
            this.btnAccounting.TabIndex = 0;
            this.btnAccounting.Text = "          Accounting";
            this.btnAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounting.UseVisualStyleBackColor = false;
            // 
            // pnProduction
            // 
            this.pnProduction.Controls.Add(this.btnProduction);
            this.pnProduction.Location = new System.Drawing.Point(3, 206);
            this.pnProduction.Name = "pnProduction";
            this.pnProduction.Size = new System.Drawing.Size(197, 37);
            this.pnProduction.TabIndex = 3;
            // 
            // btnProduction
            // 
            this.btnProduction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduction.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProduction.Image = global::REMAS.Properties.Resources.Menu_PPIC__1_;
            this.btnProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.Location = new System.Drawing.Point(-13, -6);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProduction.Size = new System.Drawing.Size(228, 56);
            this.btnProduction.TabIndex = 0;
            this.btnProduction.Text = "          Production";
            this.btnProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.UseVisualStyleBackColor = false;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnMenu.Controls.Add(this.sidebarPanel);
            this.pnMenu.Location = new System.Drawing.Point(-3, 26);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(955, 591);
            this.pnMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(198, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(899, 30);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(757, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(757, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::REMAS.Properties.Resources.IconList;
            this.menuButton.Location = new System.Drawing.Point(3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(26, 27);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // homeTimer
            // 
            this.homeTimer.Interval = 10;
            this.homeTimer.Tick += new System.EventHandler(this.homeTimer_Tick);
            // 
            // subTimer
            // 
            this.subTimer.Interval = 10;
            this.subTimer.Tick += new System.EventHandler(this.subTimer_Tick);
            // 
            // FmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(951, 614);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmDashboard";
            this.Load += new System.EventHandler(this.FmDashboard_Load);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnDashboard.ResumeLayout(false);
            this.salesContainer.ResumeLayout(false);
            this.pnReport.ResumeLayout(false);
            this.pnTrans.ResumeLayout(false);
            this.pnMaster.ResumeLayout(false);
            this.masterContainer.ResumeLayout(false);
            this.pnCust.ResumeLayout(false);
            this.pnSales.ResumeLayout(false);
            this.pnPurchase.ResumeLayout(false);
            this.pnInventory.ResumeLayout(false);
            this.pnUtility.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnHrd.ResumeLayout(false);
            this.pnAccounting.ResumeLayout(false);
            this.pnProduction.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnSales;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel pnPurchase;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Panel pnInventory;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnHrd;
        private System.Windows.Forms.Button btnHrd;
        private System.Windows.Forms.Panel pnProduction;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Panel pnAccounting;
        private System.Windows.Forms.Button btnAccounting;
        private System.Windows.Forms.Panel pnUtility;
        private System.Windows.Forms.Button btnUtility;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel salesContainer;
        private System.Windows.Forms.Panel pnMaster;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Panel pnTrans;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Panel pnReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel masterContainer;
        private System.Windows.Forms.Panel pnCust;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.Timer subTimer;
    }
}