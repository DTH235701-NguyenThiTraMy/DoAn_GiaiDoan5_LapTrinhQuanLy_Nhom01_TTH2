using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyCuaHangTapHoa.Data;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmNhanVien : Form
    {
        QLTHDbContext context = new QLTHDbContext();
        bool xuLyThem = false;
        int id;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            txtMaNhanVien.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTim.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            List<NhanVien> nv = context.NhanVien.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            // Binding
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", bindingSource, "MaNhanVien", false, DataSourceUpdateMode.Never);

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;

            // Ẩn cột ID
            if (dataGridView.Columns["ID"] != null)
                dataGridView.Columns["ID"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaNhanVien.Text = MaTuDong.SinhMaNhanVien();
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboQuyenHan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn quyền hạn?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                NhanVien nv = new NhanVien();
                nv.MaNhanVien = txtMaNhanVien.Text;           // sau sẽ tự động sinh
                nv.HoVaTen = txtHoVaTen.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                nv.QuyenHan = cboQuyenHan.SelectedIndex == 0;

                context.NhanVien.Add(nv);
            }
            else
            {
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.MaNhanVien = txtMaNhanVien.Text;
                    nv.HoVaTen = txtHoVaTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.QuyenHan = cboQuyenHan.SelectedIndex == 0;

                    if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);

                    context.NhanVien.Update(nv);
                }
            }

            context.SaveChanges();
            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null) context.NhanVien.Remove(nv);

                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
