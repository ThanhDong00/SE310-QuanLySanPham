namespace QuanLySanPham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnXoaSP = new Button();
            btnLuuSP = new Button();
            txbXuatXu = new TextBox();
            txbDonGia = new TextBox();
            txbSoLuong = new TextBox();
            txbTenSP = new TextBox();
            dtpkNgayHetHan = new DateTimePicker();
            txbMaSP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgvFind = new DataGridView();
            txbMax = new TextBox();
            txbMin = new TextBox();
            btnPriceFromTo = new Button();
            btnExpired = new Button();
            btnJapanSP = new Button();
            btnMaxPrice = new Button();
            groupBox3 = new GroupBox();
            dtgvAll = new DataGridView();
            groupBox4 = new GroupBox();
            rtxbFrom = new RichTextBox();
            btnDeleteExpired = new Button();
            btnDeleteAll = new Button();
            btnCheckExpired = new Button();
            btnDeleteFrom = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFind).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAll).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnXoaSP);
            groupBox1.Controls.Add(btnLuuSP);
            groupBox1.Controls.Add(txbXuatXu);
            groupBox1.Controls.Add(txbDonGia);
            groupBox1.Controls.Add(txbSoLuong);
            groupBox1.Controls.Add(txbTenSP);
            groupBox1.Controls.Add(dtpkNgayHetHan);
            groupBox1.Controls.Add(txbMaSP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(508, 286);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // btnXoaSP
            // 
            btnXoaSP.BackColor = SystemColors.ActiveBorder;
            btnXoaSP.Location = new Point(255, 229);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(100, 35);
            btnXoaSP.TabIndex = 13;
            btnXoaSP.Text = "Xóa SP";
            btnXoaSP.UseVisualStyleBackColor = false;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // btnLuuSP
            // 
            btnLuuSP.BackColor = SystemColors.ActiveBorder;
            btnLuuSP.Location = new Point(124, 229);
            btnLuuSP.Name = "btnLuuSP";
            btnLuuSP.Size = new Size(100, 35);
            btnLuuSP.TabIndex = 12;
            btnLuuSP.Text = "Lưu SP";
            btnLuuSP.UseVisualStyleBackColor = false;
            btnLuuSP.Click += btnLuuSP_Click;
            // 
            // txbXuatXu
            // 
            txbXuatXu.Location = new Point(124, 148);
            txbXuatXu.Name = "txbXuatXu";
            txbXuatXu.Size = new Size(376, 27);
            txbXuatXu.TabIndex = 11;
            // 
            // txbDonGia
            // 
            txbDonGia.Location = new Point(124, 118);
            txbDonGia.Name = "txbDonGia";
            txbDonGia.Size = new Size(376, 27);
            txbDonGia.TabIndex = 10;
            // 
            // txbSoLuong
            // 
            txbSoLuong.Location = new Point(124, 88);
            txbSoLuong.Name = "txbSoLuong";
            txbSoLuong.Size = new Size(376, 27);
            txbSoLuong.TabIndex = 9;
            // 
            // txbTenSP
            // 
            txbTenSP.Location = new Point(124, 58);
            txbTenSP.Name = "txbTenSP";
            txbTenSP.Size = new Size(376, 27);
            txbTenSP.TabIndex = 8;
            // 
            // dtpkNgayHetHan
            // 
            dtpkNgayHetHan.Location = new Point(124, 178);
            dtpkNgayHetHan.Name = "dtpkNgayHetHan";
            dtpkNgayHetHan.Size = new Size(376, 27);
            dtpkNgayHetHan.TabIndex = 7;
            // 
            // txbMaSP
            // 
            txbMaSP.Location = new Point(124, 28);
            txbMaSP.Name = "txbMaSP";
            txbMaSP.Size = new Size(376, 27);
            txbMaSP.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(8, 175);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(110, 30);
            label6.TabIndex = 5;
            label6.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(8, 145);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(72, 30);
            label5.TabIndex = 4;
            label5.Text = "Xuất xứ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(8, 115);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(75, 30);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(82, 30);
            label3.TabIndex = 2;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(65, 30);
            label2.TabIndex = 1;
            label2.Text = "Tên SP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(8, 25);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(63, 30);
            label1.TabIndex = 0;
            label1.Text = "Mã SP:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(dtgvFind);
            groupBox2.Controls.Add(txbMax);
            groupBox2.Controls.Add(txbMin);
            groupBox2.Controls.Add(btnPriceFromTo);
            groupBox2.Controls.Add(btnExpired);
            groupBox2.Controls.Add(btnJapanSP);
            groupBox2.Controls.Add(btnMaxPrice);
            groupBox2.Location = new Point(532, 14);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(716, 286);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn chức năng tìm kiếm";
            // 
            // dtgvFind
            // 
            dtgvFind.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFind.Location = new Point(6, 102);
            dtgvFind.Name = "dtgvFind";
            dtgvFind.RowHeadersWidth = 51;
            dtgvFind.Size = new Size(702, 178);
            dtgvFind.TabIndex = 6;
            // 
            // txbMax
            // 
            txbMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbMax.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMax.Location = new Point(598, 28);
            txbMax.Name = "txbMax";
            txbMax.Size = new Size(110, 65);
            txbMax.TabIndex = 5;
            // 
            // txbMin
            // 
            txbMin.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMin.Location = new Point(482, 28);
            txbMin.Name = "txbMin";
            txbMin.Size = new Size(110, 65);
            txbMin.TabIndex = 4;
            // 
            // btnPriceFromTo
            // 
            btnPriceFromTo.BackColor = SystemColors.ActiveBorder;
            btnPriceFromTo.Location = new Point(382, 26);
            btnPriceFromTo.Name = "btnPriceFromTo";
            btnPriceFromTo.Size = new Size(94, 70);
            btnPriceFromTo.TabIndex = 3;
            btnPriceFromTo.Text = "Xuất các SP có ĐG [a...b]";
            btnPriceFromTo.UseVisualStyleBackColor = false;
            btnPriceFromTo.Click += btnPriceFromTo_Click;
            // 
            // btnExpired
            // 
            btnExpired.BackColor = SystemColors.ActiveBorder;
            btnExpired.Location = new Point(206, 26);
            btnExpired.Name = "btnExpired";
            btnExpired.Size = new Size(94, 70);
            btnExpired.TabIndex = 2;
            btnExpired.Text = "Xuất bộ SP quá hạn";
            btnExpired.UseVisualStyleBackColor = false;
            btnExpired.Click += btnExpired_Click;
            // 
            // btnJapanSP
            // 
            btnJapanSP.BackColor = SystemColors.ActiveBorder;
            btnJapanSP.Location = new Point(106, 26);
            btnJapanSP.Name = "btnJapanSP";
            btnJapanSP.Size = new Size(94, 70);
            btnJapanSP.TabIndex = 1;
            btnJapanSP.Text = "1 SP từ Nhật Bản";
            btnJapanSP.UseVisualStyleBackColor = false;
            btnJapanSP.Click += btnJapanSP_Click;
            // 
            // btnMaxPrice
            // 
            btnMaxPrice.BackColor = SystemColors.ActiveBorder;
            btnMaxPrice.Location = new Point(6, 26);
            btnMaxPrice.Name = "btnMaxPrice";
            btnMaxPrice.Size = new Size(94, 70);
            btnMaxPrice.TabIndex = 0;
            btnMaxPrice.Text = "1 SP có ĐG cao nhất ";
            btnMaxPrice.UseVisualStyleBackColor = false;
            btnMaxPrice.Click += btnMaxPrice_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(dtgvAll);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(14, 310);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1234, 349);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // dtgvAll
            // 
            dtgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAll.Location = new Point(8, 28);
            dtgvAll.Name = "dtgvAll";
            dtgvAll.RowHeadersWidth = 51;
            dtgvAll.Size = new Size(879, 313);
            dtgvAll.TabIndex = 1;
            dtgvAll.CellClick += dtgvAll_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rtxbFrom);
            groupBox4.Controls.Add(btnDeleteExpired);
            groupBox4.Controls.Add(btnDeleteAll);
            groupBox4.Controls.Add(btnCheckExpired);
            groupBox4.Controls.Add(btnDeleteFrom);
            groupBox4.Location = new Point(895, 28);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(331, 313);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chọn thao tác";
            // 
            // rtxbFrom
            // 
            rtxbFrom.BorderStyle = BorderStyle.None;
            rtxbFrom.Location = new Point(170, 53);
            rtxbFrom.Name = "rtxbFrom";
            rtxbFrom.Size = new Size(155, 70);
            rtxbFrom.TabIndex = 4;
            rtxbFrom.Text = "";
            // 
            // btnDeleteExpired
            // 
            btnDeleteExpired.BackColor = SystemColors.ActiveBorder;
            btnDeleteExpired.Location = new Point(170, 205);
            btnDeleteExpired.Name = "btnDeleteExpired";
            btnDeleteExpired.Size = new Size(155, 70);
            btnDeleteExpired.TabIndex = 3;
            btnDeleteExpired.Text = "Xóa toàn bộ sản phẩm quá hạn";
            btnDeleteExpired.UseVisualStyleBackColor = false;
            btnDeleteExpired.Click += btnDeleteExpired_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = SystemColors.ActiveBorder;
            btnDeleteAll.Location = new Point(6, 205);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(155, 70);
            btnDeleteAll.TabIndex = 2;
            btnDeleteAll.Text = "Xóa toàn bộ sản phẩm trong kho";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnCheckExpired
            // 
            btnCheckExpired.BackColor = SystemColors.ActiveBorder;
            btnCheckExpired.Location = new Point(6, 129);
            btnCheckExpired.Name = "btnCheckExpired";
            btnCheckExpired.Size = new Size(319, 70);
            btnCheckExpired.TabIndex = 1;
            btnCheckExpired.Text = "Kiểm tra kho có sản phẩm quá hạn hay không?";
            btnCheckExpired.UseVisualStyleBackColor = false;
            btnCheckExpired.Click += btnExpired_Click;
            // 
            // btnDeleteFrom
            // 
            btnDeleteFrom.BackColor = SystemColors.ActiveBorder;
            btnDeleteFrom.Location = new Point(6, 53);
            btnDeleteFrom.Name = "btnDeleteFrom";
            btnDeleteFrom.Size = new Size(155, 70);
            btnDeleteFrom.TabIndex = 0;
            btnDeleteFrom.Text = "Xóa các sản phẩm theo xuất xứ bất kỳ";
            btnDeleteFrom.UseVisualStyleBackColor = false;
            btnDeleteFrom.Click += btnDeleteFrom_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFind).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAll).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnXoaSP;
        private Button btnLuuSP;
        private TextBox txbXuatXu;
        private TextBox txbDonGia;
        private TextBox txbSoLuong;
        private TextBox txbTenSP;
        private DateTimePicker dtpkNgayHetHan;
        private TextBox txbMaSP;
        private TextBox txbMax;
        private TextBox txbMin;
        private Button btnPriceFromTo;
        private Button btnExpired;
        private Button btnJapanSP;
        private Button btnMaxPrice;
        private DataGridView dtgvFind;
        private DataGridView dtgvAll;
        private Button btnDeleteExpired;
        private Button btnDeleteAll;
        private Button btnCheckExpired;
        private Button btnDeleteFrom;
        private RichTextBox rtxbFrom;
    }
}
