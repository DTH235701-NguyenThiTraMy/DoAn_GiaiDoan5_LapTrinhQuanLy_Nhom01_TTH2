namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnDoiAnh = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnTim = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            picHinhAnh = new PictureBox();
            numDonGiaBan = new NumericUpDown();
            numSoLuongTon = new NumericUpDown();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            txtMaSanPham = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            HinhAnh = new DataGridViewImageColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGiaBan);
            groupBox1.Controls.Add(numSoLuongTon);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1504, 345);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1181, 34);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(150, 46);
            btnDoiAnh.TabIndex = 26;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(1338, 268);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 25;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1182, 268);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 24;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.HotTrack;
            btnLuu.Location = new Point(535, 268);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(1026, 269);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 20;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(870, 269);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(704, 268);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 21;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(368, 268);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(197, 268);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(28, 268);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(965, 28);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(200, 207);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 10;
            picHinhAnh.TabStop = false;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(719, 124);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(193, 39);
            numDonGiaBan.TabIndex = 9;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongTon
            // 
            numSoLuongTon.Location = new Point(719, 50);
            numSoLuongTon.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongTon.Name = "numSoLuongTon";
            numSoLuongTon.Size = new Size(193, 39);
            numSoLuongTon.TabIndex = 8;
            numSoLuongTon.ThousandsSeparator = true;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(239, 196);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(673, 39);
            txtMoTa.TabIndex = 7;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(239, 120);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(279, 39);
            txtTenSanPham.TabIndex = 6;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Enabled = false;
            txtMaSanPham.Location = new Point(239, 49);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(279, 39);
            txtMaSanPham.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(580, 124);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(580, 52);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 3;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 196);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 2;
            label3.Text = "Mô tả sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 48);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 378);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1515, 459);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] {ID, MaSanPham, TenSanPham, SoLuongTon, DonGiaBan, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 35);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1509, 421);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 10;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "NO";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            DonGiaBan.HeaderText = "Đơn giá";
            DonGiaBan.MinimumWidth = 10;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            DonGiaBan.DefaultCellStyle.Format = "N0";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "NO";
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle1;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 10;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            SoLuongTon.DefaultCellStyle.Format="N0";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 10;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            MaSanPham.HeaderText = "Mã sản phẩm";
            MaSanPham.MinimumWidth = 10;
            MaSanPham.Name = "MaSanPham";
            MaSanPham.ReadOnly = true;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 849);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongTon;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private TextBox txtMaSanPham;
        private Label label5;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnTim;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnDoiAnh;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewImageColumn HinhAnh;
    }
}