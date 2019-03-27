namespace Workshop4
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(758, 485);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "hello";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(352, 485);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
<<<<<<< HEAD
            // button1
=======
<<<<<<< HEAD
            // button1
=======
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(Travel_Experts.Package);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.productDataGridView);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(packageIdLabel);
            this.tabPage2.Controls.Add(this.packageIdComboBox);
            this.tabPage2.Controls.Add(pkgAgencyCommissionLabel);
            this.tabPage2.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.tabPage2.Controls.Add(pkgBasePriceLabel);
            this.tabPage2.Controls.Add(this.pkgBasePriceTextBox);
            this.tabPage2.Controls.Add(pkgDescLabel);
            this.tabPage2.Controls.Add(this.pkgDescTextBox);
            this.tabPage2.Controls.Add(pkgEndDateLabel);
            this.tabPage2.Controls.Add(this.pkgEndDateDateTimePicker);
            this.tabPage2.Controls.Add(pkgNameLabel);
            this.tabPage2.Controls.Add(this.pkgNameTextBox);
            this.tabPage2.Controls.Add(pkgStartDateLabel);
            this.tabPage2.Controls.Add(this.pkgStartDateDateTimePicker);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(487, 14);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(389, 407);
            this.productDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Travel_Experts.Product);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(332, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // packageIdComboBox
            // 
            this.packageIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdComboBox.FormattingEnabled = true;
            this.packageIdComboBox.Location = new System.Drawing.Point(232, 14);
            this.packageIdComboBox.Name = "packageIdComboBox";
            this.packageIdComboBox.Size = new System.Drawing.Size(200, 47);
            this.packageIdComboBox.TabIndex = 1;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(232, 49);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 47);
            this.pkgAgencyCommissionTextBox.TabIndex = 3;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(232, 82);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 47);
            this.pkgBasePriceTextBox.TabIndex = 5;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(232, 115);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(200, 47);
            this.pkgDescTextBox.TabIndex = 7;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(232, 148);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 47);
            this.pkgEndDateDateTimePicker.TabIndex = 9;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(232, 181);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(200, 47);
            this.pkgNameTextBox.TabIndex = 11;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(232, 214);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(200, 47);
            this.pkgStartDateDateTimePicker.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.productListBox);
            this.tabPage3.Controls.Add(packageIdLabel1);
            this.tabPage3.Controls.Add(this.packageIdComboBox1);
            this.tabPage3.Controls.Add(pkgAgencyCommissionLabel1);
            this.tabPage3.Controls.Add(this.pkgAgencyCommissionTextBox1);
            this.tabPage3.Controls.Add(pkgBasePriceLabel1);
            this.tabPage3.Controls.Add(this.pkgBasePriceTextBox1);
            this.tabPage3.Controls.Add(pkgDescLabel1);
            this.tabPage3.Controls.Add(this.pkgDescTextBox1);
            this.tabPage3.Controls.Add(pkgEndDateLabel1);
            this.tabPage3.Controls.Add(this.pkgEndDateDateTimePicker1);
            this.tabPage3.Controls.Add(pkgNameLabel1);
            this.tabPage3.Controls.Add(this.pkgNameTextBox1);
            this.tabPage3.Controls.Add(pkgStartDateLabel1);
            this.tabPage3.Controls.Add(this.pkgStartDateDateTimePicker1);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1020, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create New";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
>>>>>>> parent of 1b29a45... remove product.cs
>>>>>>> parent of e718074... commit
            // 
            this.button1.Location = new System.Drawing.Point(71, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 257);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 384);
            this.label2.Name = "label2";
<<<<<<< HEAD
            this.label2.Size = new System.Drawing.Size(172, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "changes";
=======
<<<<<<< HEAD
            this.label2.Size = new System.Drawing.Size(172, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "changes";
=======
            this.label2.Size = new System.Drawing.Size(287, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Product(s):";
            // 
            // productListBox
            // 
            this.productListBox.DataSource = this.productBindingSource1;
            this.productListBox.DisplayMember = "ProdName";
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 39;
            this.productListBox.Location = new System.Drawing.Point(51, 309);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(405, 121);
            this.productListBox.TabIndex = 14;
            this.productListBox.ValueMember = "ProdName";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Travel_Experts.Product);
            // 
            // packageIdComboBox1
            // 
            this.packageIdComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdComboBox1.FormattingEnabled = true;
            this.packageIdComboBox1.Location = new System.Drawing.Point(256, 40);
            this.packageIdComboBox1.Name = "packageIdComboBox1";
            this.packageIdComboBox1.Size = new System.Drawing.Size(200, 47);
            this.packageIdComboBox1.TabIndex = 1;
            // 
            // pkgAgencyCommissionTextBox1
            // 
            this.pkgAgencyCommissionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox1.Location = new System.Drawing.Point(256, 75);
            this.pkgAgencyCommissionTextBox1.Name = "pkgAgencyCommissionTextBox1";
            this.pkgAgencyCommissionTextBox1.Size = new System.Drawing.Size(200, 47);
            this.pkgAgencyCommissionTextBox1.TabIndex = 3;
            // 
            // pkgBasePriceTextBox1
            // 
            this.pkgBasePriceTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox1.Location = new System.Drawing.Point(256, 108);
            this.pkgBasePriceTextBox1.Name = "pkgBasePriceTextBox1";
            this.pkgBasePriceTextBox1.Size = new System.Drawing.Size(200, 47);
            this.pkgBasePriceTextBox1.TabIndex = 5;
            // 
            // pkgDescTextBox1
            // 
            this.pkgDescTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox1.Location = new System.Drawing.Point(256, 141);
            this.pkgDescTextBox1.Name = "pkgDescTextBox1";
            this.pkgDescTextBox1.Size = new System.Drawing.Size(200, 47);
            this.pkgDescTextBox1.TabIndex = 7;
            // 
            // pkgEndDateDateTimePicker1
            // 
            this.pkgEndDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker1.Location = new System.Drawing.Point(256, 174);
            this.pkgEndDateDateTimePicker1.Name = "pkgEndDateDateTimePicker1";
            this.pkgEndDateDateTimePicker1.Size = new System.Drawing.Size(200, 47);
            this.pkgEndDateDateTimePicker1.TabIndex = 9;
            // 
            // pkgNameTextBox1
            // 
            this.pkgNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox1.Location = new System.Drawing.Point(256, 207);
            this.pkgNameTextBox1.Name = "pkgNameTextBox1";
            this.pkgNameTextBox1.Size = new System.Drawing.Size(200, 47);
            this.pkgNameTextBox1.TabIndex = 11;
            // 
            // pkgStartDateDateTimePicker1
            // 
            this.pkgStartDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker1.Location = new System.Drawing.Point(256, 240);
            this.pkgStartDateDateTimePicker1.Name = "pkgStartDateDateTimePicker1";
            this.pkgStartDateDateTimePicker1.Size = new System.Drawing.Size(200, 47);
            this.pkgStartDateDateTimePicker1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 48);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Ivory;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(802, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "SIGN OUT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
>>>>>>> parent of 1b29a45... remove product.cs
>>>>>>> parent of e718074... commit
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 52F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 485);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

