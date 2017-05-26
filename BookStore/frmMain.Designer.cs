﻿namespace BookStore {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPublisher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBillOrderOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBillOrderIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbBook = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.ptbAddCustomer = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.rtbMoneyWord = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCountMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(6, 224);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(609, 348);
            this.dgvData.TabIndex = 2;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnManager,
            this.mnSale,
            this.mnHelp,
            this.mnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnManager
            // 
            this.mnManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProduct,
            this.mnCategory,
            this.mnPublisher,
            this.mnStaff,
            this.mnProvider});
            this.mnManager.Image = global::BookStore.Properties.Resources._32_user_starred;
            this.mnManager.Name = "mnManager";
            this.mnManager.Size = new System.Drawing.Size(76, 20);
            this.mnManager.Text = "Quản lý";
            // 
            // mnProduct
            // 
            this.mnProduct.Image = global::BookStore.Properties.Resources._32_basket_full;
            this.mnProduct.Name = "mnProduct";
            this.mnProduct.Size = new System.Drawing.Size(152, 22);
            this.mnProduct.Text = "Sản phẩm";
            this.mnProduct.Click += new System.EventHandler(this.mnProduct_Click);
            // 
            // mnCategory
            // 
            this.mnCategory.Image = global::BookStore.Properties.Resources._32_folder_tag;
            this.mnCategory.Name = "mnCategory";
            this.mnCategory.Size = new System.Drawing.Size(152, 22);
            this.mnCategory.Text = "Danh mục";
            this.mnCategory.Click += new System.EventHandler(this.mnCategory_Click);
            // 
            // mnPublisher
            // 
            this.mnPublisher.Image = global::BookStore.Properties.Resources._32_user_starred1;
            this.mnPublisher.Name = "mnPublisher";
            this.mnPublisher.Size = new System.Drawing.Size(152, 22);
            this.mnPublisher.Text = "Nhà xuất bản";
            this.mnPublisher.Click += new System.EventHandler(this.mnPublisher_Click);
            // 
            // mnStaff
            // 
            this.mnStaff.Image = global::BookStore.Properties.Resources._32_user_favourite;
            this.mnStaff.Name = "mnStaff";
            this.mnStaff.Size = new System.Drawing.Size(152, 22);
            this.mnStaff.Text = "Nhân viên";
            this.mnStaff.Click += new System.EventHandler(this.mnStaff_Click);
            // 
            // mnProvider
            // 
            this.mnProvider.Image = global::BookStore.Properties.Resources._32_user_unstarred;
            this.mnProvider.Name = "mnProvider";
            this.mnProvider.Size = new System.Drawing.Size(152, 22);
            this.mnProvider.Text = "Nhà cung cấp";
            this.mnProvider.Click += new System.EventHandler(this.mnProvider_Click);
            // 
            // mnSale
            // 
            this.mnSale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCustomer,
            this.mnBillOrderOut,
            this.mnBillOrderIn});
            this.mnSale.Image = global::BookStore.Properties.Resources._32_basket_empty;
            this.mnSale.Name = "mnSale";
            this.mnSale.Size = new System.Drawing.Size(85, 20);
            this.mnSale.Text = "Bán hàng";
            // 
            // mnCustomer
            // 
            this.mnCustomer.Image = global::BookStore.Properties.Resources._32_user;
            this.mnCustomer.Name = "mnCustomer";
            this.mnCustomer.Size = new System.Drawing.Size(150, 22);
            this.mnCustomer.Text = "Khách hàng";
            this.mnCustomer.Click += new System.EventHandler(this.mnCustomer_Click);
            // 
            // mnBillOrderOut
            // 
            this.mnBillOrderOut.Image = global::BookStore.Properties.Resources._32_file;
            this.mnBillOrderOut.Name = "mnBillOrderOut";
            this.mnBillOrderOut.Size = new System.Drawing.Size(150, 22);
            this.mnBillOrderOut.Text = "Hoá đơn bán";
            this.mnBillOrderOut.Click += new System.EventHandler(this.mnBill_Click);
            // 
            // mnBillOrderIn
            // 
            this.mnBillOrderIn.Image = global::BookStore.Properties.Resources._32_note;
            this.mnBillOrderIn.Name = "mnBillOrderIn";
            this.mnBillOrderIn.Size = new System.Drawing.Size(150, 22);
            this.mnBillOrderIn.Text = "Hoá đơn nhập";
            this.mnBillOrderIn.Click += new System.EventHandler(this.mnBillOrderIn_Click);
            // 
            // mnHelp
            // 
            this.mnHelp.Image = global::BookStore.Properties.Resources._32_settings;
            this.mnHelp.Name = "mnHelp";
            this.mnHelp.Size = new System.Drawing.Size(79, 20);
            this.mnHelp.Text = "Trợ giúp";
            this.mnHelp.Click += new System.EventHandler(this.mnHelp_Click);
            // 
            // mnLogout
            // 
            this.mnLogout.Image = global::BookStore.Properties.Resources._32_arrow_refresh;
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(88, 20);
            this.mnLogout.Text = "Đăng xuất";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbBook);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(7, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 583);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            // 
            // ptbBook
            // 
            this.ptbBook.Image = global::BookStore.Properties.Resources.image;
            this.ptbBook.Location = new System.Drawing.Point(453, 23);
            this.ptbBook.Name = "ptbBook";
            this.ptbBook.Size = new System.Drawing.Size(160, 190);
            this.ptbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBook.TabIndex = 5;
            this.ptbBook.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::BookStore.Properties.Resources._32_user_search;
            this.pictureBox1.Location = new System.Drawing.Point(321, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(28, 109);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNameStaff);
            this.groupBox2.Controls.Add(this.ptbAddCustomer);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.rtbMoneyWord);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbCountMoney);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbbCustomer);
            this.groupBox2.Controls.Add(this.dtpDateOrder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(643, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 583);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNameStaff.Location = new System.Drawing.Point(513, 23);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(81, 21);
            this.lbNameStaff.TabIndex = 12;
            this.lbNameStaff.Text = "Dương Vũ";
            this.lbNameStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ptbAddCustomer
            // 
            this.ptbAddCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAddCustomer.Image = global::BookStore.Properties.Resources._32_user_add;
            this.ptbAddCustomer.Location = new System.Drawing.Point(402, 51);
            this.ptbAddCustomer.Name = "ptbAddCustomer";
            this.ptbAddCustomer.Size = new System.Drawing.Size(29, 29);
            this.ptbAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddCustomer.TabIndex = 6;
            this.ptbAddCustomer.TabStop = false;
            this.ptbAddCustomer.Click += new System.EventHandler(this.ptbAddCustomer_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Image = global::BookStore.Properties.Resources._32_basket_add;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(57, 485);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(146, 44);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // rtbMoneyWord
            // 
            this.rtbMoneyWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbMoneyWord.Location = new System.Drawing.Point(354, 505);
            this.rtbMoneyWord.Name = "rtbMoneyWord";
            this.rtbMoneyWord.Size = new System.Drawing.Size(245, 69);
            this.rtbMoneyWord.TabIndex = 10;
            this.rtbMoneyWord.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(274, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bằng chữ";
            // 
            // lbCountMoney
            // 
            this.lbCountMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountMoney.Location = new System.Drawing.Point(420, 454);
            this.lbCountMoney.Name = "lbCountMoney";
            this.lbCountMoney.Size = new System.Drawing.Size(181, 37);
            this.lbCountMoney.TabIndex = 9;
            this.lbCountMoney.Text = "0";
            this.lbCountMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(276, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng tiền";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOrder);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(14, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 291);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách mặt hàng";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 26);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(563, 259);
            this.dgvOrder.TabIndex = 6;
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.BackColor = System.Drawing.Color.White;
            this.cbbCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(151, 51);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(251, 29);
            this.cbbCustomer.TabIndex = 7;
            // 
            // dtpDateOrder
            // 
            this.dtpDateOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOrder.Location = new System.Drawing.Point(151, 112);
            this.dtpDateOrder.Name = "dtpDateOrder";
            this.dtpDateOrder.Size = new System.Drawing.Size(147, 29);
            this.dtpDateOrder.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày mua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khách hàng";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Hệ thống quản lý cửa hàng bán sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnManager;
        private System.Windows.Forms.ToolStripMenuItem mnProduct;
        private System.Windows.Forms.ToolStripMenuItem mnCategory;
        private System.Windows.Forms.ToolStripMenuItem mnPublisher;
        private System.Windows.Forms.ToolStripMenuItem mnStaff;
        private System.Windows.Forms.ToolStripMenuItem mnSale;
        private System.Windows.Forms.ToolStripMenuItem mnHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbMoneyWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCountMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.DateTimePicker dtpDateOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ToolStripMenuItem mnCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnBillOrderOut;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.ToolStripMenuItem mnProvider;
        private System.Windows.Forms.ToolStripMenuItem mnBillOrderIn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.PictureBox ptbBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbAddCustomer;
        private System.Windows.Forms.Label lbNameStaff;
    }
}

