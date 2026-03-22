using QuanLyCuaHangTapHoa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static QuanLyCuaHangTapHoa.Data.HoaDon;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmHoaDon : Form
    {
        QLTHDbContext db = new QLTHDbContext();
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            var ds = db.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                MaHoaDon = r.MaHoaDon,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                HoVaTenKhachHang = r.KhachHang != null ? r.KhachHang.HoVaTen: "",
                NgayLap = r.NgayLap,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(c => c.SoLuongBan * c.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = ds;

            // Định dạng cột Tổng tiền
            if (dataGridView.Columns["TongTienHoaDon"] != null)
            {
                dataGridView.Columns["TongTienHoaDon"].DefaultCellStyle.Format = "N0";
                dataGridView.Columns["TongTienHoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dataGridView.Columns["ID"] != null)
                dataGridView.Columns["ID"].Visible = false;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet())
            {
                f.ShowDialog();
            }
            frmHoaDon_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            using (frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(id))
            {
                f.ShowDialog();
            }

            frmHoaDon_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Xóa hóa đơn này (và toàn bộ chi tiết)?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                var hd = db.HoaDon.Find(id);

                if (hd != null)
                {
                    var chiTiet = db.HoaDon_ChiTiet.Where(c => c.HoaDonID == id).ToList();

                    // Trả lại tồn kho
                    foreach (var item in chiTiet)
                    {
                        var sp = db.SanPham.Find(item.SanPhamID);
                        if (sp != null)
                            sp.SoLuongTon += item.SoLuongBan;
                    }

                    db.HoaDon_ChiTiet.RemoveRange(chiTiet);
                    db.HoaDon.Remove(hd);

                    db.SaveChanges();
                }

                frmHoaDon_Load(sender, e);
            }
        }
        // ================== XEM CHI TIẾT ==================
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                using (frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(id))
                {
                    f.ShowDialog();
                }

                frmHoaDon_Load(sender, e);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
