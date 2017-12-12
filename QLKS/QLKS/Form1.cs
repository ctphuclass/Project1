using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhacSan_BUS;
namespace QuanLyKhachSan
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhanVien fnhanvien = new FrmNhanVien();
            fnhanvien.MdiParent = this;
            fnhanvien.Show();
        }

        private void btnThemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThemNhanVien fthemnhanvien = new FrmThemNhanVien();
            fthemnhanvien.MdiParent = this;
            fthemnhanvien.Show();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhachHang fkhachhang = new FrmKhachHang();
            fkhachhang.MdiParent = this;
            fkhachhang.Show();
        }

        private void btnPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhong fPhong = new FrmPhong();
            fPhong.MdiParent = this;
            fPhong.Show();
        }

        private void btnDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDichVu fDichVu = new FrmDichVu();
            fDichVu.MdiParent = this;
            fDichVu.Show();
        }

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThanhToan fThanhToan = new FrmThanhToan();
            fThanhToan.MdiParent = this;
            fThanhToan.Show();
        }

        private void btnGhiChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGhiChu fGhiChu = new FrmGhiChu();
            fGhiChu.MdiParent = this;
            fGhiChu.Show();
        }
    }
}
