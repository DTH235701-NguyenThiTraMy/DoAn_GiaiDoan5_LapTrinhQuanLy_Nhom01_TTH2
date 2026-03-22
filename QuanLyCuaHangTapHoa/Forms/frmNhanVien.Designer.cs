namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnTim = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtHoVaTen = new TextBox();
            txtDienThoai = new TextBox();
            txtMaNhanVien = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1514, 316);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(723, 178);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(205, 40);
            cboQuyenHan.TabIndex = 22;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(723, 113);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(200, 39);
            txtMatKhau.TabIndex = 21;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(723, 49);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(200, 39);
            txtTenDangNhap.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(520, 176);
            label7.Name = "label7";
            label7.Size = new Size(137, 32);
            label7.TabIndex = 19;
            label7.Text = "Quyền hạn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(520, 113);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 18;
            label6.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 52);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
            label5.TabIndex = 17;
            label5.Text = "Tên đăng nhập:";
            // 
            // btnXuat
            // 
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(1342, 195);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1342, 135);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 15;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.HotTrack;
            btnLuu.Location = new Point(1177, 74);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(1342, 74);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 11;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1177, 198);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1177, 135);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(994, 198);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(994, 135);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(994, 74);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(166, 244);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(762, 39);
            txtDiaChi.TabIndex = 7;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(166, 113);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(295, 39);
            txtHoVaTen.TabIndex = 6;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(166, 173);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(295, 39);
            txtDienThoai.TabIndex = 5;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Location = new Point(269, 52);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(192, 39);
            txtMaNhanVien.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 247);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 176);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 2;
            label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 113);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 52);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã khách nhân viên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1523, 468);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaNhanVien, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 35);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1517, 430);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 10;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 10;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 10;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 10;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 10;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 827);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnTim;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private TextBox txtDienThoai;
        private TextBox txtMaNhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label5;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}