namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapHoaDon = new Button();
            btnInHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnTim = new Button();
            btnXuat = new Button();
            label1 = new Label();
            txtTim = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1246, 423);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaHoaDon, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 35);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1240, 385);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
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
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã hóa đơn";
            MaHoaDon.MinimumWidth = 10;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 10;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 10;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 10;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 0, 192);
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 10;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            XemChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 10;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Location = new Point(97, 538);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(170, 46);
            btnLapHoaDon.TabIndex = 1;
            btnLapHoaDon.Text = "Lập hóa đơn";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(297, 538);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(150, 46);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(484, 538);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(663, 538);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(840, 538);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(619, 32);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 24;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(1013, 538);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 26;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 35);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 27;
            label1.Text = "Tìm kiếm:";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(178, 32);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(417, 39);
            txtTim.TabIndex = 28;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 623);
            Controls.Add(txtTim);
            Controls.Add(label1);
            Controls.Add(btnXuat);
            Controls.Add(btnTim);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLapHoaDon);
            Controls.Add(groupBox1);
            Name = "frmHoaDon";
            Text = "Hóa đơn";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private Button btnLapHoaDon;
        private Button btnInHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTim;
        private Button btnXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
        private Label label1;
        private TextBox txtTim;
    }
}