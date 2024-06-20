namespace REMAS.Forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.subTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrPurchase = new System.Windows.Forms.Timer(this.components);
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnSales = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.pnDropDownPurchase = new System.Windows.Forms.Panel();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.pnlReportinngsDropdown = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnReportings = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.circularPictureBox1 = new REMAS.Contoller.CircularPictureBox();
            this.pnlHistoricalDropdown = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFinishOrders = new System.Windows.Forms.Button();
            this.btnHistorical = new System.Windows.Forms.Button();
            this.btnMassSuppl = new System.Windows.Forms.Button();
            this.btnPurchaseOrders = new System.Windows.Forms.Button();
            this.btnPurchaseQuotations = new System.Windows.Forms.Button();
            this.btnInternalPurchaseRequest = new System.Windows.Forms.Button();
            this.btnProductsServices = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.pnInventory = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnHrd = new System.Windows.Forms.Panel();
            this.btnHrd = new System.Windows.Forms.Button();
            this.pnProduction = new System.Windows.Forms.Panel();
            this.btnProduction = new System.Windows.Forms.Button();
            this.pnAccounting = new System.Windows.Forms.Panel();
            this.btnAccounting = new System.Windows.Forms.Button();
            this.pnUtility = new System.Windows.Forms.Panel();
            this.btnUtility = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrHistorical = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new REMAS.Contoller.UPanel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.uPanel1 = new REMAS.Contoller.UPanel();
            this.tmrReportings = new System.Windows.Forms.Timer(this.components);
            this.pnDashboard.SuspendLayout();
            this.pnSales.SuspendLayout();
            this.pnDropDownPurchase.SuspendLayout();
            this.pnlReportinngsDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.pnlHistoricalDropdown.SuspendLayout();
            this.pnInventory.SuspendLayout();
            this.pnHrd.SuspendLayout();
            this.pnProduction.SuspendLayout();
            this.pnAccounting.SuspendLayout();
            this.pnUtility.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // homeTimer
            // 
            this.homeTimer.Interval = 10;
            // 
            // subTimer
            // 
            this.subTimer.Interval = 10;
            // 
            // tmrPurchase
            // 
            this.tmrPurchase.Interval = 15;
            this.tmrPurchase.Tick += new System.EventHandler(this.tmrPurchase_Tick);
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnDashboard.Controls.Add(this.btnDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(4, 57);
            this.pnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(296, 92);
            this.pnDashboard.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(296, 94);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnSales
            // 
            this.pnSales.Controls.Add(this.btnSales);
            this.pnSales.Location = new System.Drawing.Point(4, 159);
            this.pnSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnSales.Name = "pnSales";
            this.pnSales.Size = new System.Drawing.Size(296, 92);
            this.pnSales.TabIndex = 3;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSales.Image = global::REMAS.Properties.Resources.Menu_PPIC;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 2);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(296, 86);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "          Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // pnDropDownPurchase
            // 
            this.pnDropDownPurchase.Controls.Add(this.btnConfiguration);
            this.pnDropDownPurchase.Controls.Add(this.pnlReportinngsDropdown);
            this.pnDropDownPurchase.Controls.Add(this.circularPictureBox1);
            this.pnDropDownPurchase.Controls.Add(this.pnlHistoricalDropdown);
            this.pnDropDownPurchase.Controls.Add(this.btnMassSuppl);
            this.pnDropDownPurchase.Controls.Add(this.btnPurchaseOrders);
            this.pnDropDownPurchase.Controls.Add(this.btnPurchaseQuotations);
            this.pnDropDownPurchase.Controls.Add(this.btnInternalPurchaseRequest);
            this.pnDropDownPurchase.Controls.Add(this.btnProductsServices);
            this.pnDropDownPurchase.Controls.Add(this.btnContacts);
            this.pnDropDownPurchase.Controls.Add(this.btnSuppliers);
            this.pnDropDownPurchase.Controls.Add(this.btnPurchase);
            this.pnDropDownPurchase.Location = new System.Drawing.Point(4, 261);
            this.pnDropDownPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnDropDownPurchase.MaximumSize = new System.Drawing.Size(296, 1200);
            this.pnDropDownPurchase.MinimumSize = new System.Drawing.Size(296, 69);
            this.pnDropDownPurchase.Name = "pnDropDownPurchase";
            this.pnDropDownPurchase.Size = new System.Drawing.Size(296, 69);
            this.pnDropDownPurchase.TabIndex = 3;
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguration.FlatAppearance.BorderSize = 0;
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguration.Location = new System.Drawing.Point(0, 751);
            this.btnConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConfiguration.Size = new System.Drawing.Size(296, 69);
            this.btnConfiguration.TabIndex = 10;
            this.btnConfiguration.Text = "          Configuration";
            this.btnConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // pnlReportinngsDropdown
            // 
            this.pnlReportinngsDropdown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlReportinngsDropdown.Controls.Add(this.button6);
            this.pnlReportinngsDropdown.Controls.Add(this.btnReportings);
            this.pnlReportinngsDropdown.Controls.Add(this.button5);
            this.pnlReportinngsDropdown.Controls.Add(this.button3);
            this.pnlReportinngsDropdown.Controls.Add(this.button4);
            this.pnlReportinngsDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportinngsDropdown.Location = new System.Drawing.Point(0, 682);
            this.pnlReportinngsDropdown.MaximumSize = new System.Drawing.Size(296, 393);
            this.pnlReportinngsDropdown.MinimumSize = new System.Drawing.Size(296, 69);
            this.pnlReportinngsDropdown.Name = "pnlReportinngsDropdown";
            this.pnlReportinngsDropdown.Size = new System.Drawing.Size(296, 69);
            this.pnlReportinngsDropdown.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 316);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(296, 69);
            this.button6.TabIndex = 15;
            this.button6.Text = "          Supplier Map";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnReportings
            // 
            this.btnReportings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportings.FlatAppearance.BorderSize = 0;
            this.btnReportings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportings.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReportings.Image = global::REMAS.Properties.Resources.expand_arrow_20;
            this.btnReportings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportings.Location = new System.Drawing.Point(0, 0);
            this.btnReportings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportings.Name = "btnReportings";
            this.btnReportings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportings.Size = new System.Drawing.Size(296, 69);
            this.btnReportings.TabIndex = 9;
            this.btnReportings.Text = "          Reportings";
            this.btnReportings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportings.UseVisualStyleBackColor = false;
            this.btnReportings.Click += new System.EventHandler(this.btnReportings_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 237);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(296, 69);
            this.button5.TabIndex = 14;
            this.button5.Text = "          Purchase orders";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 79);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(296, 69);
            this.button3.TabIndex = 12;
            this.button3.Text = "          Purchase Buyer";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 158);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(296, 69);
            this.button4.TabIndex = 13;
            this.button4.Text = "          Purchase Manager";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.White;
            this.circularPictureBox1.Image = global::REMAS.Properties.Resources.Basket;
            this.circularPictureBox1.Location = new System.Drawing.Point(18, 2);
            this.circularPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(60, 69);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox1.TabIndex = 4;
            this.circularPictureBox1.TabStop = false;
            // 
            // pnlHistoricalDropdown
            // 
            this.pnlHistoricalDropdown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHistoricalDropdown.Controls.Add(this.button2);
            this.pnlHistoricalDropdown.Controls.Add(this.btnFinishOrders);
            this.pnlHistoricalDropdown.Controls.Add(this.btnHistorical);
            this.pnlHistoricalDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoricalDropdown.Location = new System.Drawing.Point(0, 602);
            this.pnlHistoricalDropdown.MaximumSize = new System.Drawing.Size(296, 200);
            this.pnlHistoricalDropdown.MinimumSize = new System.Drawing.Size(296, 80);
            this.pnlHistoricalDropdown.Name = "pnlHistoricalDropdown";
            this.pnlHistoricalDropdown.Size = new System.Drawing.Size(296, 80);
            this.pnlHistoricalDropdown.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(296, 69);
            this.button2.TabIndex = 12;
            this.button2.Text = "          Canceled orders";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnFinishOrders
            // 
            this.btnFinishOrders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinishOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinishOrders.FlatAppearance.BorderSize = 0;
            this.btnFinishOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrders.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFinishOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinishOrders.Location = new System.Drawing.Point(0, 69);
            this.btnFinishOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinishOrders.Name = "btnFinishOrders";
            this.btnFinishOrders.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFinishOrders.Size = new System.Drawing.Size(296, 69);
            this.btnFinishOrders.TabIndex = 12;
            this.btnFinishOrders.Text = "          Finish orders";
            this.btnFinishOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinishOrders.UseVisualStyleBackColor = false;
            this.btnFinishOrders.Click += new System.EventHandler(this.btnFinishOrders_Click);
            // 
            // btnHistorical
            // 
            this.btnHistorical.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistorical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorical.FlatAppearance.BorderSize = 0;
            this.btnHistorical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorical.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorical.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHistorical.Image = global::REMAS.Properties.Resources.expand_arrow_20;
            this.btnHistorical.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorical.Location = new System.Drawing.Point(0, 0);
            this.btnHistorical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHistorical.Name = "btnHistorical";
            this.btnHistorical.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHistorical.Size = new System.Drawing.Size(296, 69);
            this.btnHistorical.TabIndex = 8;
            this.btnHistorical.Text = "          Historical";
            this.btnHistorical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorical.UseVisualStyleBackColor = false;
            this.btnHistorical.Click += new System.EventHandler(this.btnHistorical_Click);
            // 
            // btnMassSuppl
            // 
            this.btnMassSuppl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMassSuppl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMassSuppl.FlatAppearance.BorderSize = 0;
            this.btnMassSuppl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMassSuppl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMassSuppl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMassSuppl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMassSuppl.Location = new System.Drawing.Point(0, 522);
            this.btnMassSuppl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMassSuppl.Name = "btnMassSuppl";
            this.btnMassSuppl.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMassSuppl.Size = new System.Drawing.Size(296, 80);
            this.btnMassSuppl.TabIndex = 7;
            this.btnMassSuppl.Text = "          Mass Suppl. Stock \r\n          Move Invoicing";
            this.btnMassSuppl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMassSuppl.UseVisualStyleBackColor = false;
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchaseOrders.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrders.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPurchaseOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrders.Location = new System.Drawing.Point(0, 453);
            this.btnPurchaseOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPurchaseOrders.Size = new System.Drawing.Size(296, 69);
            this.btnPurchaseOrders.TabIndex = 6;
            this.btnPurchaseOrders.Text = "          Purchase orders";
            this.btnPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrders.UseVisualStyleBackColor = false;
            this.btnPurchaseOrders.Click += new System.EventHandler(this.btnPurchaseOrders_Click);
            // 
            // btnPurchaseQuotations
            // 
            this.btnPurchaseQuotations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurchaseQuotations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchaseQuotations.FlatAppearance.BorderSize = 0;
            this.btnPurchaseQuotations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseQuotations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseQuotations.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPurchaseQuotations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseQuotations.Location = new System.Drawing.Point(0, 373);
            this.btnPurchaseQuotations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPurchaseQuotations.Name = "btnPurchaseQuotations";
            this.btnPurchaseQuotations.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPurchaseQuotations.Size = new System.Drawing.Size(296, 80);
            this.btnPurchaseQuotations.TabIndex = 5;
            this.btnPurchaseQuotations.Text = "          Purchase \r\n          Quotations";
            this.btnPurchaseQuotations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseQuotations.UseVisualStyleBackColor = false;
            this.btnPurchaseQuotations.Click += new System.EventHandler(this.btnPurchaseQuotations_Click);
            // 
            // btnInternalPurchaseRequest
            // 
            this.btnInternalPurchaseRequest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInternalPurchaseRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInternalPurchaseRequest.FlatAppearance.BorderSize = 0;
            this.btnInternalPurchaseRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternalPurchaseRequest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternalPurchaseRequest.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInternalPurchaseRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternalPurchaseRequest.Location = new System.Drawing.Point(0, 287);
            this.btnInternalPurchaseRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInternalPurchaseRequest.Name = "btnInternalPurchaseRequest";
            this.btnInternalPurchaseRequest.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInternalPurchaseRequest.Size = new System.Drawing.Size(296, 86);
            this.btnInternalPurchaseRequest.TabIndex = 4;
            this.btnInternalPurchaseRequest.Text = "          Internal \r\n          purchase request";
            this.btnInternalPurchaseRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternalPurchaseRequest.UseVisualStyleBackColor = false;
            this.btnInternalPurchaseRequest.Click += new System.EventHandler(this.btnInternalPurchaseRequest_Click);
            // 
            // btnProductsServices
            // 
            this.btnProductsServices.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductsServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductsServices.FlatAppearance.BorderSize = 0;
            this.btnProductsServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductsServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsServices.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProductsServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsServices.Location = new System.Drawing.Point(0, 207);
            this.btnProductsServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsServices.Name = "btnProductsServices";
            this.btnProductsServices.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProductsServices.Size = new System.Drawing.Size(296, 80);
            this.btnProductsServices.TabIndex = 3;
            this.btnProductsServices.Text = "          Products and \r\n          services";
            this.btnProductsServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsServices.UseVisualStyleBackColor = false;
            this.btnProductsServices.Click += new System.EventHandler(this.btnProductsServices_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.Location = new System.Drawing.Point(0, 138);
            this.btnContacts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnContacts.Size = new System.Drawing.Size(296, 69);
            this.btnContacts.TabIndex = 2;
            this.btnContacts.Text = "          Contacts";
            this.btnContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 69);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSuppliers.Size = new System.Drawing.Size(296, 69);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "          Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.White;
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPurchase.Image = global::REMAS.Properties.Resources.expand_arrow_20;
            this.btnPurchase.Location = new System.Drawing.Point(0, 0);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPurchase.Size = new System.Drawing.Size(296, 69);
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.Text = "          Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // pnInventory
            // 
            this.pnInventory.Controls.Add(this.btnInventory);
            this.pnInventory.Location = new System.Drawing.Point(4, 340);
            this.pnInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnInventory.Name = "pnInventory";
            this.pnInventory.Size = new System.Drawing.Size(296, 92);
            this.pnInventory.TabIndex = 3;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInventory.Image = global::REMAS.Properties.Resources.Icon_Inventory;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 2);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(296, 86);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "          Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // pnHrd
            // 
            this.pnHrd.Controls.Add(this.btnHrd);
            this.pnHrd.Location = new System.Drawing.Point(4, 442);
            this.pnHrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnHrd.Name = "pnHrd";
            this.pnHrd.Size = new System.Drawing.Size(296, 92);
            this.pnHrd.TabIndex = 3;
            // 
            // btnHrd
            // 
            this.btnHrd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHrd.FlatAppearance.BorderSize = 0;
            this.btnHrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHrd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHrd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHrd.Image = global::REMAS.Properties.Resources.PersonBadge;
            this.btnHrd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHrd.Location = new System.Drawing.Point(3, 2);
            this.btnHrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHrd.Name = "btnHrd";
            this.btnHrd.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHrd.Size = new System.Drawing.Size(296, 86);
            this.btnHrd.TabIndex = 0;
            this.btnHrd.Text = "          HRD";
            this.btnHrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHrd.UseVisualStyleBackColor = false;
            this.btnHrd.Click += new System.EventHandler(this.btnHrd_Click);
            // 
            // pnProduction
            // 
            this.pnProduction.Controls.Add(this.btnProduction);
            this.pnProduction.Location = new System.Drawing.Point(4, 544);
            this.pnProduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnProduction.Name = "pnProduction";
            this.pnProduction.Size = new System.Drawing.Size(296, 92);
            this.pnProduction.TabIndex = 3;
            // 
            // btnProduction
            // 
            this.btnProduction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduction.FlatAppearance.BorderSize = 0;
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduction.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProduction.Image = global::REMAS.Properties.Resources.Menu_PPIC__1_;
            this.btnProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.Location = new System.Drawing.Point(0, 0);
            this.btnProduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProduction.Size = new System.Drawing.Size(296, 86);
            this.btnProduction.TabIndex = 0;
            this.btnProduction.Text = "          Production";
            this.btnProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.UseVisualStyleBackColor = false;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // pnAccounting
            // 
            this.pnAccounting.Controls.Add(this.btnAccounting);
            this.pnAccounting.Location = new System.Drawing.Point(4, 646);
            this.pnAccounting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnAccounting.Name = "pnAccounting";
            this.pnAccounting.Size = new System.Drawing.Size(296, 92);
            this.pnAccounting.TabIndex = 3;
            // 
            // btnAccounting
            // 
            this.btnAccounting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccounting.FlatAppearance.BorderSize = 0;
            this.btnAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounting.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAccounting.Image = global::REMAS.Properties.Resources.Calculator;
            this.btnAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounting.Location = new System.Drawing.Point(0, 2);
            this.btnAccounting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAccounting.Size = new System.Drawing.Size(296, 86);
            this.btnAccounting.TabIndex = 0;
            this.btnAccounting.Text = "          Accounting";
            this.btnAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounting.UseVisualStyleBackColor = false;
            // 
            // pnUtility
            // 
            this.pnUtility.Controls.Add(this.btnUtility);
            this.pnUtility.Location = new System.Drawing.Point(4, 748);
            this.pnUtility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnUtility.Name = "pnUtility";
            this.pnUtility.Size = new System.Drawing.Size(296, 92);
            this.pnUtility.TabIndex = 3;
            // 
            // btnUtility
            // 
            this.btnUtility.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUtility.FlatAppearance.BorderSize = 0;
            this.btnUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtility.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUtility.Image = global::REMAS.Properties.Resources.Gear;
            this.btnUtility.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtility.Location = new System.Drawing.Point(0, 0);
            this.btnUtility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUtility.Name = "btnUtility";
            this.btnUtility.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUtility.Size = new System.Drawing.Size(296, 86);
            this.btnUtility.TabIndex = 0;
            this.btnUtility.Text = "          Utility";
            this.btnUtility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtility.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(4, 850);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(296, 92);
            this.pnLogout.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogout.Image = global::REMAS.Properties.Resources.Icon_Logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(296, 86);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // tmrSidebar
            // 
            this.tmrSidebar.Interval = 10;
            this.tmrSidebar.Tick += new System.EventHandler(this.tmrSidebar_Tick);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.AutoScroll = true;
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sidebarPanel.Controls.Add(this.pictureBox1);
            this.sidebarPanel.Controls.Add(this.pnDashboard);
            this.sidebarPanel.Controls.Add(this.pnSales);
            this.sidebarPanel.Controls.Add(this.pnDropDownPurchase);
            this.sidebarPanel.Controls.Add(this.pnInventory);
            this.sidebarPanel.Controls.Add(this.pnHrd);
            this.sidebarPanel.Controls.Add(this.pnProduction);
            this.sidebarPanel.Controls.Add(this.pnAccounting);
            this.sidebarPanel.Controls.Add(this.pnUtility);
            this.sidebarPanel.Controls.Add(this.pnLogout);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 49);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(344, 1000);
            this.sidebarPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrHistorical
            // 
            this.tmrHistorical.Interval = 10;
            this.tmrHistorical.Tick += new System.EventHandler(this.tmrHistorical_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.menuButton);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(344, 49);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1456, 49);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::REMAS.Properties.Resources.IconList;
            this.menuButton.Location = new System.Drawing.Point(4, 3);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(39, 42);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // uPanel1
            // 
            this.uPanel1.BackColor = System.Drawing.Color.Red;
            this.uPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uPanel1.Location = new System.Drawing.Point(0, 0);
            this.uPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Size = new System.Drawing.Size(1800, 49);
            this.uPanel1.TabIndex = 1;
            // 
            // tmrReportings
            // 
            this.tmrReportings.Interval = 10;
            this.tmrReportings.Tick += new System.EventHandler(this.tmrReportings_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1800, 1049);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.uPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnDashboard.ResumeLayout(false);
            this.pnSales.ResumeLayout(false);
            this.pnDropDownPurchase.ResumeLayout(false);
            this.pnlReportinngsDropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.pnlHistoricalDropdown.ResumeLayout(false);
            this.pnInventory.ResumeLayout(false);
            this.pnHrd.ResumeLayout(false);
            this.pnProduction.ResumeLayout(false);
            this.pnAccounting.ResumeLayout(false);
            this.pnUtility.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Timer subTimer;
        private System.Windows.Forms.Timer tmrPurchase;
        private Contoller.UPanel uPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnSales;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel pnDropDownPurchase;
        private Contoller.CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnReportings;
        private System.Windows.Forms.Button btnHistorical;
        private System.Windows.Forms.Button btnMassSuppl;
        private System.Windows.Forms.Button btnPurchaseOrders;
        private System.Windows.Forms.Button btnPurchaseQuotations;
        private System.Windows.Forms.Button btnInternalPurchaseRequest;
        private System.Windows.Forms.Button btnProductsServices;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnSuppliers;
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
        private Contoller.UPanel pnlTop;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private System.Windows.Forms.Panel pnlHistoricalDropdown;
        private System.Windows.Forms.Button btnFinishOrders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlReportinngsDropdown;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer tmrHistorical;
        private System.Windows.Forms.Timer tmrReportings;
    }
}