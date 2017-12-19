using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DoAnQuanLyKhachSan
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            fKhachHang f = new fKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void btnPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fphong f = new fphong();
            f.MdiParent = this;
            f.Show();
        }

        private void btnDatPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            DatPhong f = new DatPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void btnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNangDichVu f = new ChucNangDichVu();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            fdichvu f = new fdichvu();
            f.MdiParent = this;
            f.Show();
        }

        private void btnDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            fdoanhthu f = new fdoanhthu();
            f.MdiParent = this;
            f.Show();
        }
    }
}