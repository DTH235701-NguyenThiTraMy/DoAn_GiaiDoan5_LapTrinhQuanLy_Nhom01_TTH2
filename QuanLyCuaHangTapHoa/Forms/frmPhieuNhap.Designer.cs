namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmPhieuNhap
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(472, 32);
            label1.Name = "label1";
            label1.Size = new Size(248, 50);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1183, 326);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaPhieuNhap, TenNhanVien, NgayNhap, TongTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 35);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1177, 288);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            MaPhieuNhap.MinimumWidth = 10;
            MaPhieuNhap.Name = "MaPhieuNhap";
            MaPhieuNhap.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân viên";
            TenNhanVien.MinimumWidth = 10;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 10;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 10;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(816, 466);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(570, 466);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(358, 466);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(138, 466);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 584);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(btnXoa);
            Controls.Add(label1);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "frmPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập";
            Load += frmPhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTien;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}