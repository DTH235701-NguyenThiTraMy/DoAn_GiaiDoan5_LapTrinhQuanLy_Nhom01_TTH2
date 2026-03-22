using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangTapHoa.Data;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmKhachHang : Form
    {
        QLTHDbContext context = new QLTHDbContext();
        bool xuLyThem = false;
        int id;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        // ==================== BẬT/TẮT CHỨC NĂNG ====================
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            txtMaKhachHang.Enabled = giaTri;   // tạm thời cho sửa
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTim.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        // ==================== TẢI FORM ====================
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> kh = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            // Binding các TextBox
            txtMaKhachHang.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Add("Text", bindingSource, "MaKhachHang", false, DataSourceUpdateMode.Never);

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;

            // Ẩn cột ID
            if (dataGridView.Columns["ID"] != null)
                dataGridView.Columns["ID"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaKhachHang.Text = MaTuDong.SinhMaKhachHang();
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                KhachHang kh = context.KhachHang.Find(id);

                if (kh != null)
                    context.KhachHang.Remove(kh);

                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = txtMaKhachHang.Text;   // tạm thời (sau mình sẽ tự động sinh)
                kh.HoVaTen = txtHoVaTen.Text;
                kh.DienThoai = txtDienThoai.Text;
                kh.DiaChi = txtDiaChi.Text;

                context.KhachHang.Add(kh);
            }
            else
            {
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    kh.MaKhachHang = txtMaKhachHang.Text;
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;

                    context.KhachHang.Update(kh);
                }
            }

            context.SaveChanges();
            frmKhachHang_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
