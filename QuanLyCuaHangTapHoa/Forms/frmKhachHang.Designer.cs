namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmKhachHang
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
            txtMaKhachHang = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaKhachHang = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1373, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnXuat
            // 
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(1213, 169);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1213, 109);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 15;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.HotTrack;
            btnLuu.Location = new Point(1048, 48);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(1213, 48);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 11;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1048, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1048, 109);
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
            btnXoa.Location = new Point(865, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(865, 109);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(865, 48);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(232, 174);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(601, 39);
            txtDiaChi.TabIndex = 7;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(232, 110);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(601, 39);
            txtHoVaTen.TabIndex = 6;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(579, 52);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(254, 39);
            txtDienThoai.TabIndex = 5;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Enabled = false;
            txtMaKhachHang.Location = new Point(232, 52);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(177, 39);
            txtMaKhachHang.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 177);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 55);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 2;
            label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 113);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 55);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1373, 402);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaKhachHang, HoVaTen, DienThoai, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 35);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1367, 364);
            dataGridView.TabIndex = 0;
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
            // MaKhachHang
            // 
            MaKhachHang.DataPropertyName = "MaKhachHang";
            MaKhachHang.HeaderText = "Mã khách hàng";
            MaKhachHang.MinimumWidth = 10;
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.ReadOnly = true;
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
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 717);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnThoat;
        private Button btnHuy;
        private Button btnTim;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private TextBox txtDienThoai;
        private TextBox txtMaKhachHang;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}