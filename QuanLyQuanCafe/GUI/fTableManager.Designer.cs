namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            btnPrintBill = new Button();
            cbMergeTable = new ComboBox();
            btnMergeTable = new Button();
            label2 = new Label();
            label1 = new Label();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDisCount = new NumericUpDown();
            btnCheckOut = new Button();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).BeginInit();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(447, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 281);
            panel2.TabIndex = 1;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 1);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(428, 280);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPrintBill);
            panel3.Controls.Add(cbMergeTable);
            panel3.Controls.Add(btnMergeTable);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDisCount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(447, 394);
            panel3.Name = "panel3";
            panel3.Size = new Size(587, 87);
            panel3.TabIndex = 2;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = SystemColors.ActiveCaption;
            btnPrintBill.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrintBill.Location = new Point(440, 3);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(144, 33);
            btnPrintBill.TabIndex = 13;
            btnPrintBill.Text = "In hóa đơn";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // cbMergeTable
            // 
            cbMergeTable.FormattingEnabled = true;
            cbMergeTable.Location = new Point(113, 16);
            cbMergeTable.Name = "cbMergeTable";
            cbMergeTable.Size = new Size(98, 23);
            cbMergeTable.TabIndex = 12;
            // 
            // btnMergeTable
            // 
            btnMergeTable.BackColor = Color.FromArgb(128, 128, 255);
            btnMergeTable.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMergeTable.Location = new Point(113, 45);
            btnMergeTable.Name = "btnMergeTable";
            btnMergeTable.Size = new Size(98, 39);
            btnMergeTable.TabIndex = 11;
            btnMergeTable.Text = "Gộp bàn";
            btnMergeTable.UseVisualStyleBackColor = false;
            btnMergeTable.Click += btnMergeTable_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(237, 65);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 10;
            label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 30);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 9;
            label1.Text = "Giảm giá(%):";
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.BackColor = Color.FromArgb(192, 255, 255);
            txbTotalPrice.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalPrice.ForeColor = Color.FromArgb(192, 64, 0);
            txbTotalPrice.Location = new Point(311, 59);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(123, 25);
            txbTotalPrice.TabIndex = 8;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(11, 16);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(96, 23);
            cbSwitchTable.TabIndex = 7;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = Color.FromArgb(128, 128, 255);
            btnSwitchTable.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSwitchTable.Location = new Point(11, 45);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(96, 39);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nmDisCount
            // 
            nmDisCount.BackColor = SystemColors.InactiveCaption;
            nmDisCount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nmDisCount.Location = new Point(343, 31);
            nmDisCount.Name = "nmDisCount";
            nmDisCount.Size = new Size(91, 23);
            nmDisCount.TabIndex = 5;
            nmDisCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.Goldenrod;
            btnCheckOut.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckOut.Location = new Point(440, 41);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(144, 43);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1034, 27);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.BackColor = Color.PaleGoldenrod;
            adminToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(78, 23);
            adminToolStripMenuItem.Text = "ADMIN";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(136, 23);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(184, 24);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(184, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(447, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(431, 63);
            panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            nmFoodCount.BackColor = SystemColors.InactiveCaption;
            nmFoodCount.Location = new Point(328, 23);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(91, 23);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.TextAlign = HorizontalAlignment.Center;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Teal;
            btnAddFood.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFood.ForeColor = SystemColors.ButtonFace;
            btnAddFood.Location = new Point(196, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(126, 57);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(13, 32);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(177, 23);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(13, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(177, 23);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 47);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(432, 434);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 480);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phầm mềm quản lý nhà hàng";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private Panel panel4;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private NumericUpDown nmFoodCount;
        private Button btnAddFood;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nmDisCount;
        private Button btnCheckOut;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private Label label2;
        private Label label1;
        private ComboBox cbMergeTable;
        private Button btnMergeTable;
        private Button btnPrintBill;
    }
}