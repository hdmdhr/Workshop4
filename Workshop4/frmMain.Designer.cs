namespace Workshop4
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label packageIdLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.travelExpertsDataSet = new Workshop4.TravelExpertsDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new Workshop4.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new Workshop4.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.packagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.packagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            packageIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingNavigator)).BeginInit();
            this.packagesBindingNavigator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(758, 485);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Packages",
            "Products",
            "Suppliers",
            "Product Suppliers"});
            this.listBox1.Location = new System.Drawing.Point(0, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(151, 461);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 481);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(577, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suppliers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = this.packagesTableAdapter;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Workshop4.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.packagesBindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // packagesBindingNavigatorSaveItem
            // 
            this.packagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.packagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("packagesBindingNavigatorSaveItem.Image")));
            this.packagesBindingNavigatorSaveItem.Name = "packagesBindingNavigatorSaveItem";
            this.packagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.packagesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // packagesBindingNavigator
            // 
            this.packagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.packagesBindingNavigator.BindingSource = this.packagesBindingSource;
            this.packagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.packagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.packagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.packagesBindingNavigatorSaveItem});
            this.packagesBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.packagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.packagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.packagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.packagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.packagesBindingNavigator.Name = "packagesBindingNavigator";
            this.packagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.packagesBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this.packagesBindingNavigator.TabIndex = 14;
            this.packagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PackageId", true));
            this.packageIdTextBox.Location = new System.Drawing.Point(270, 3);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(200, 28);
            this.packageIdTextBox.TabIndex = 1;
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Dock = System.Windows.Forms.DockStyle.Right;
            pkgDescLabel.Location = new System.Drawing.Point(117, 240);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(82, 60);
            pkgDescLabel.TabIndex = 8;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pkgEndDateDateTimePicker.CalendarForeColor = System.Drawing.Color.Maroon;
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packagesBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(270, 183);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.pkgEndDateDateTimePicker.TabIndex = 7;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgDescTextBox.Location = new System.Drawing.Point(270, 243);
            this.pkgDescTextBox.MaximumSize = new System.Drawing.Size(200, 80);
            this.pkgDescTextBox.MinimumSize = new System.Drawing.Size(0, 40);
            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pkgDescTextBox.Size = new System.Drawing.Size(200, 45);
            this.pkgDescTextBox.TabIndex = 9;
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            pkgEndDateLabel.Location = new System.Drawing.Point(85, 180);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(114, 60);
            pkgEndDateLabel.TabIndex = 6;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            pkgBasePriceLabel.Location = new System.Drawing.Point(78, 300);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(121, 60);
            pkgBasePriceLabel.TabIndex = 10;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packagesBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(270, 123);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.pkgStartDateDateTimePicker.TabIndex = 5;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(270, 303);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 28);
            this.pkgBasePriceTextBox.TabIndex = 11;
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            pkgStartDateLabel.Location = new System.Drawing.Point(79, 120);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(120, 60);
            pkgStartDateLabel.TabIndex = 4;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(3, 360);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(196, 62);
            pkgAgencyCommissionLabel.TabIndex = 12;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(270, 63);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(200, 28);
            this.pkgNameTextBox.TabIndex = 3;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(270, 363);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 28);
            this.pkgAgencyCommissionTextBox.TabIndex = 13;
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            pkgNameLabel.Location = new System.Drawing.Point(109, 60);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(90, 60);
            pkgNameLabel.TabIndex = 2;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Dock = System.Windows.Forms.DockStyle.Right;
            packageIdLabel.Location = new System.Drawing.Point(104, 0);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(95, 60);
            packageIdLabel.TabIndex = 0;
            packageIdLabel.Text = "Package Id:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(packageIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(pkgNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pkgAgencyCommissionTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pkgNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(pkgAgencyCommissionLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(pkgStartDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pkgBasePriceTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pkgStartDateDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(pkgBasePriceLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(pkgEndDateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pkgDescTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pkgEndDateDateTimePicker, 1, 3);
            this.tableLayoutPanel1.Controls.Add(pkgDescLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.packageIdTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 422);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(577, 453);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 485);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingNavigator)).EndInit();
            this.packagesBindingNavigator.ResumeLayout(false);
            this.packagesBindingNavigator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.BindingNavigator packagesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton packagesBindingNavigatorSaveItem;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

