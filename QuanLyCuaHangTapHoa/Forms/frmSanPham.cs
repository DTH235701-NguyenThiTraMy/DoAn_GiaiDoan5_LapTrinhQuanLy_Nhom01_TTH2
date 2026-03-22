using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyCuaHangTapHoa.Data;
using System.Linq;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmSanPham : Form
    {
        QLTHDbContext context = new QLTHDbContext();
        bool xuLyThem = false;
        int id;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            txtMaSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuongTon.Enabled = giaTri;
            numDonGiaBan.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnDoiAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTim.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            List<SanPham> sp = context.SanPham.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            // Binding
            txtMaSanPham.DataBindings.Clear();
            txtMaSanPham.DataBindings.Add("Text", bindingSource, "MaSanPham", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSoLuongTon.DataBindings.Clear();
            numSoLuongTon.DataBindings.Add("Value", bindingSource, "SoLuongTon", false, DataSourceUpdateMode.Never);

            numDonGiaBan.DataBindings.Clear();
            numDonGiaBan.DataBindings.Add("Value", bindingSource, "DonGiaBan", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            // Hình ảnh cho PictureBox
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnhBinding = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnhBinding.Format += (s, ev) =>
            {
                if (ev.Value != null)
                    ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnhBinding);

            dataGridView.DataSource = bindingSource;

            // Ẩn cột ID
            if (dataGridView.Columns["ID"] != null)
                dataGridView.Columns["ID"].Visible = false;
        }
        // ==================== HIỂN THỊ ẢNH NHỎ TRONG DATAGRIDVIEW ====================
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                try
                {
                    string fullPath = Path.Combine(imagesFolder, e.Value.ToString());
                    if (File.Exists(fullPath))
                    {
                        Image img = Image.FromFile(fullPath);
                        e.Value = new Bitmap(img, 40, 40);  // ảnh nhỏ 40x40
                    }
                }
                catch { e.Value = null; }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaSanPham.Text = MaTuDong.SinhMaSanPham();
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuongTon.Value = 0;
            numDonGiaBan.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numSoLuongTon.Value <= 0)
            {
                MessageBox.Show("Số lượng tồn phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numDonGiaBan.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                SanPham sp = new SanPham
                {
                    MaSanPham = txtMaSanPham.Text,
                    TenSanPham = txtTenSanPham.Text,
                    SoLuongTon = (int)numSoLuongTon.Value,
                    DonGiaBan = (int)numDonGiaBan.Value,
                    MoTa = txtMoTa.Text,
                    HinhAnh = picHinhAnh.Image != null ? Path.GetFileName(picHinhAnh.ImageLocation) : null
                };
                context.SanPham.Add(sp);
            }
            else
            {
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    sp.MaSanPham = txtMaSanPham.Text;
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.SoLuongTon = (int)numSoLuongTon.Value;
                    sp.DonGiaBan = (int)numDonGiaBan.Value;
                    sp.MoTa = txtMoTa.Text;
                    if (picHinhAnh.Image != null)
                        sp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                }
            }

            context.SaveChanges();
            frmSanPham_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                SanPham sp = context.SanPham.Find(id);
                if (sp != null) context.SanPham.Remove(sp);

                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(dlg.FileName);
                string destPath = Path.Combine(imagesFolder, fileName);

                // Nếu file đã tồn tại thì thêm số
                if (File.Exists(destPath))
                {
                    fileName = Path.GetFileNameWithoutExtension(fileName) + "_" +
                               DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(fileName);
                    destPath = Path.Combine(imagesFolder, fileName);
                }

                File.Copy(dlg.FileName, destPath, true);

                picHinhAnh.ImageLocation = destPath;

                // Nếu đang sửa thì cập nhật luôn vào DB
                if (!xuLyThem && dataGridView.CurrentRow != null)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.HinhAnh = fileName;
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
