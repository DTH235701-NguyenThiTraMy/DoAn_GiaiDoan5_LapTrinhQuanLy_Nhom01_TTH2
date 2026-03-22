using QuanLyCuaHangTapHoa.Data;
using System;
using System.Linq;
using System.Windows.Forms;


namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmPhieuNhap : Form
    {
        QLTHDbContext db = new QLTHDbContext();
        int id;
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            var ds = db.PhieuNhap
                .OrderByDescending(p => p.ID) // mới nhất lên đầu
                .Select(p => new
                {
                    p.ID,
                    p.MaPhieuNhap,
                    TenNhanVien = p.NhanVien.HoVaTen,
                    p.NgayNhap,
                    TongTien = p.PhieuNhap_ChiTiet.Sum(c => c.SoLuongNhap * c.DonGiaNhap)
                })
                .ToList();

            dataGridView.DataSource = ds;

            // Ẩn ID
            if (dataGridView.Columns["ID"] != null)
                dataGridView.Columns["ID"].Visible = false;

            // Format tiền
            if (dataGridView.Columns["TongTien"] != null)
            {
                dataGridView.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                dataGridView.Columns["TongTien"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            // Format ngày
            if (dataGridView.Columns["NgayNhap"] != null)
            {
                dataGridView.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // Auto size đẹp
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmPhieuNhap_ChiTiet f = new frmPhieuNhap_ChiTiet())
            {
                f.ShowDialog();
                frmPhieuNhap_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            using (frmPhieuNhap_ChiTiet f = new frmPhieuNhap_ChiTiet(id))
            {
                f.ShowDialog();
                frmPhieuNhap_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                var pn = db.PhieuNhap.Find(id);
                if (pn != null)
                {
                    var chiTiet = db.PhieuNhap_ChiTiet
                        .Where(c => c.PhieuNhapID == id)
                        .ToList();

                    // ❗ Trừ lại tồn kho
                    foreach (var c in chiTiet)
                    {
                        var sp = db.SanPham.Find(c.SanPhamID);
                        if (sp != null)
                            sp.SoLuongTon -= c.SoLuongNhap;
                    }

                    db.PhieuNhap_ChiTiet.RemoveRange(chiTiet);
                    db.PhieuNhap.Remove(pn);

                    db.SaveChanges();
                }

                frmPhieuNhap_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
