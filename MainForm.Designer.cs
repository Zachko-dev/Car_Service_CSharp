namespace carserviceapp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteService = new System.Windows.Forms.Button();
            this.addService = new System.Windows.Forms.Button();
            this.servicePriceNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceLabelTb = new System.Windows.Forms.TextBox();
            this.servicesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewOrderBtn = new System.Windows.Forms.Button();
            this.deleteOrderBtn = new System.Windows.Forms.Button();
            this.refreshOrdersTable = new System.Windows.Forms.Button();
            this.ordersDGV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addServiceToCartBtb = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.overpriceNud = new System.Windows.Forms.NumericUpDown();
            this.cartDGV = new System.Windows.Forms.DataGridView();
            this.cartCb = new System.Windows.Forms.ComboBox();
            this.orderTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.orderServicesDGV = new System.Windows.Forms.DataGridView();
            this.updateStatusBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceNud)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overpriceNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderServicesDGV)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 13F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.editBtn);
            this.tabPage1.Controls.Add(this.deleteService);
            this.tabPage1.Controls.Add(this.addService);
            this.tabPage1.Controls.Add(this.servicePriceNud);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.serviceLabelTb);
            this.tabPage1.Controls.Add(this.servicesListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Види послуг";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(409, 131);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(135, 32);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Редагувати";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteService
            // 
            this.deleteService.BackColor = System.Drawing.Color.Salmon;
            this.deleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteService.Location = new System.Drawing.Point(291, 131);
            this.deleteService.Name = "deleteService";
            this.deleteService.Size = new System.Drawing.Size(112, 32);
            this.deleteService.TabIndex = 7;
            this.deleteService.Text = "Видалити";
            this.deleteService.UseVisualStyleBackColor = false;
            this.deleteService.Click += new System.EventHandler(this.deleteService_Click);
            // 
            // addService
            // 
            this.addService.BackColor = System.Drawing.Color.Cornsilk;
            this.addService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addService.Location = new System.Drawing.Point(550, 131);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(96, 32);
            this.addService.TabIndex = 6;
            this.addService.Text = "Додати";
            this.addService.UseVisualStyleBackColor = false;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // servicePriceNud
            // 
            this.servicePriceNud.DecimalPlaces = 3;
            this.servicePriceNud.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.servicePriceNud.Location = new System.Drawing.Point(260, 96);
            this.servicePriceNud.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.servicePriceNud.Name = "servicePriceNud";
            this.servicePriceNud.Size = new System.Drawing.Size(386, 29);
            this.servicePriceNud.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вартість послуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва послуги";
            // 
            // serviceLabelTb
            // 
            this.serviceLabelTb.Location = new System.Drawing.Point(260, 39);
            this.serviceLabelTb.Name = "serviceLabelTb";
            this.serviceLabelTb.Size = new System.Drawing.Size(386, 29);
            this.serviceLabelTb.TabIndex = 1;
            this.serviceLabelTb.Text = "и";
            // 
            // servicesListView
            // 
            this.servicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.servicesListView.FullRowSelect = true;
            this.servicesListView.HideSelection = false;
            this.servicesListView.Location = new System.Drawing.Point(8, 14);
            this.servicesListView.MultiSelect = false;
            this.servicesListView.Name = "servicesListView";
            this.servicesListView.Size = new System.Drawing.Size(230, 212);
            this.servicesListView.TabIndex = 0;
            this.servicesListView.UseCompatibleStateImageBehavior = false;
            this.servicesListView.View = System.Windows.Forms.View.List;
            this.servicesListView.SelectedIndexChanged += new System.EventHandler(this.servicesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Назва";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Вартість";
            this.columnHeader2.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.ordersDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблиця замовлень";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.viewOrderBtn);
            this.panel1.Controls.Add(this.deleteOrderBtn);
            this.panel1.Controls.Add(this.refreshOrdersTable);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 49);
            this.panel1.TabIndex = 2;
            // 
            // viewOrderBtn
            // 
            this.viewOrderBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.viewOrderBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.viewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrderBtn.Location = new System.Drawing.Point(452, 8);
            this.viewOrderBtn.Name = "viewOrderBtn";
            this.viewOrderBtn.Size = new System.Drawing.Size(155, 33);
            this.viewOrderBtn.TabIndex = 3;
            this.viewOrderBtn.Text = "Переглянути";
            this.viewOrderBtn.UseVisualStyleBackColor = false;
            this.viewOrderBtn.Click += new System.EventHandler(this.viewOrderBtn_Click);
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.BackColor = System.Drawing.Color.Salmon;
            this.deleteOrderBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.deleteOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrderBtn.Location = new System.Drawing.Point(316, 8);
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.Size = new System.Drawing.Size(130, 33);
            this.deleteOrderBtn.TabIndex = 2;
            this.deleteOrderBtn.Text = "Видалити";
            this.deleteOrderBtn.UseVisualStyleBackColor = false;
            this.deleteOrderBtn.Click += new System.EventHandler(this.deleteOrderBtn_Click);
            // 
            // refreshOrdersTable
            // 
            this.refreshOrdersTable.BackColor = System.Drawing.Color.SpringGreen;
            this.refreshOrdersTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.refreshOrdersTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshOrdersTable.Location = new System.Drawing.Point(613, 8);
            this.refreshOrdersTable.Name = "refreshOrdersTable";
            this.refreshOrdersTable.Size = new System.Drawing.Size(106, 33);
            this.refreshOrdersTable.TabIndex = 1;
            this.refreshOrdersTable.Text = "Оновити";
            this.refreshOrdersTable.UseVisualStyleBackColor = false;
            this.refreshOrdersTable.Click += new System.EventHandler(this.refreshOrdersTable_Click);
            // 
            // ordersDGV
            // 
            this.ordersDGV.AllowUserToAddRows = false;
            this.ordersDGV.AllowUserToDeleteRows = false;
            this.ordersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ordersDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersDGV.BackgroundColor = System.Drawing.Color.Beige;
            this.ordersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDGV.Location = new System.Drawing.Point(3, 58);
            this.ordersDGV.Name = "ordersDGV";
            this.ordersDGV.ReadOnly = true;
            this.ordersDGV.RowHeadersVisible = false;
            this.ordersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDGV.Size = new System.Drawing.Size(725, 344);
            this.ordersDGV.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(731, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Нове замовлення";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.addServiceToCartBtb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.overpriceNud);
            this.groupBox1.Controls.Add(this.cartDGV);
            this.groupBox1.Controls.Add(this.cartCb);
            this.groupBox1.Controls.Add(this.orderTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новий заказ";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(171, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Видалити послугу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.remove_service_click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Додайте послугу";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(345, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вартість всього: -";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addServiceToCartBtb
            // 
            this.addServiceToCartBtb.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addServiceToCartBtb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addServiceToCartBtb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addServiceToCartBtb.Location = new System.Drawing.Point(10, 219);
            this.addServiceToCartBtb.Name = "addServiceToCartBtb";
            this.addServiceToCartBtb.Size = new System.Drawing.Size(155, 30);
            this.addServiceToCartBtb.TabIndex = 10;
            this.addServiceToCartBtb.Text = "Додати послугу";
            this.addServiceToCartBtb.UseVisualStyleBackColor = false;
            this.addServiceToCartBtb.Click += new System.EventHandler(this.addServiceToCartBtb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Націнка (%)";
            // 
            // overpriceNud
            // 
            this.overpriceNud.Location = new System.Drawing.Point(10, 124);
            this.overpriceNud.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.overpriceNud.Name = "overpriceNud";
            this.overpriceNud.Size = new System.Drawing.Size(318, 29);
            this.overpriceNud.TabIndex = 8;
            this.overpriceNud.ValueChanged += new System.EventHandler(this.overpriceNud_ValueChanged);
            // 
            // cartDGV
            // 
            this.cartDGV.AllowUserToAddRows = false;
            this.cartDGV.AllowUserToDeleteRows = false;
            this.cartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cartDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cartDGV.BackgroundColor = System.Drawing.Color.Beige;
            this.cartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDGV.Location = new System.Drawing.Point(345, 28);
            this.cartDGV.MultiSelect = false;
            this.cartDGV.Name = "cartDGV";
            this.cartDGV.ReadOnly = true;
            this.cartDGV.RowHeadersVisible = false;
            this.cartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDGV.Size = new System.Drawing.Size(364, 221);
            this.cartDGV.TabIndex = 7;
            // 
            // cartCb
            // 
            this.cartCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartCb.FormattingEnabled = true;
            this.cartCb.Location = new System.Drawing.Point(10, 185);
            this.cartCb.Name = "cartCb";
            this.cartCb.Size = new System.Drawing.Size(318, 28);
            this.cartCb.TabIndex = 3;
            // 
            // orderTb
            // 
            this.orderTb.Location = new System.Drawing.Point(10, 67);
            this.orderTb.Name = "orderTb";
            this.orderTb.Size = new System.Drawing.Size(318, 29);
            this.orderTb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Назва заказу";
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(509, 344);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Створити заказ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.orderServicesDGV);
            this.tabPage4.Controls.Add(this.updateStatusBtn);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.statusCb);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.statusStrip1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(731, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Перегляд замовлення";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // orderServicesDGV
            // 
            this.orderServicesDGV.AllowUserToAddRows = false;
            this.orderServicesDGV.AllowUserToDeleteRows = false;
            this.orderServicesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderServicesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderServicesDGV.BackgroundColor = System.Drawing.Color.Beige;
            this.orderServicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderServicesDGV.Location = new System.Drawing.Point(12, 35);
            this.orderServicesDGV.Name = "orderServicesDGV";
            this.orderServicesDGV.ReadOnly = true;
            this.orderServicesDGV.RowHeadersVisible = false;
            this.orderServicesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderServicesDGV.Size = new System.Drawing.Size(361, 321);
            this.orderServicesDGV.TabIndex = 6;
            // 
            // updateStatusBtn
            // 
            this.updateStatusBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.updateStatusBtn.Enabled = false;
            this.updateStatusBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.updateStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStatusBtn.Location = new System.Drawing.Point(498, 94);
            this.updateStatusBtn.Name = "updateStatusBtn";
            this.updateStatusBtn.Size = new System.Drawing.Size(106, 33);
            this.updateStatusBtn.TabIndex = 5;
            this.updateStatusBtn.Text = "Змінити";
            this.updateStatusBtn.UseVisualStyleBackColor = false;
            this.updateStatusBtn.Click += new System.EventHandler(this.updateStatusBtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(401, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статус замовлення";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusCb
            // 
            this.statusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Location = new System.Drawing.Point(401, 60);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(203, 28);
            this.statusCb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Послуги замовлення";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(731, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(135, 17);
            this.statusLabel.Text = "Замовлення не обрано";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 438);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ІС СТО v1.0 (by Illya Zaichko)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceNud)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overpriceNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderServicesDGV)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ordersDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView servicesListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serviceLabelTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown servicePriceNud;
        private System.Windows.Forms.Button deleteService;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshOrdersTable;
        private System.Windows.Forms.Button deleteOrderBtn;
        private System.Windows.Forms.Button viewOrderBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.Button updateStatusBtn;
        private System.Windows.Forms.DataGridView orderServicesDGV;
        private System.Windows.Forms.TextBox orderTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown overpriceNud;
        private System.Windows.Forms.DataGridView cartDGV;
        private System.Windows.Forms.ComboBox cartCb;
        private System.Windows.Forms.Button addServiceToCartBtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

