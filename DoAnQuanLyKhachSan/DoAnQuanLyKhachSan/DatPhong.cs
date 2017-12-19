using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSan
{
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void addkhachhang()
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.makh = txt_manv.Text;
            kh.tenkh = txt_ten.Text;
            kh.quoctinh = txt_qt.Text;
            kh.sdt = txt_sdt.Text;
            kh.CMND = txt_Cm.Text;
            kh.diachi = txt_diachi.Text;
            if (rd_nam.Checked == true)
            {
                kh.gioitinh = "Nam";
            }
            else
            {
                kh.gioitinh = "Nữ";
            }
            KhachHangBUS.ThemKhachHang(kh);
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            DatPhongBUS.insertPhieuDatPhong(tbMP.Text);
            ChiTietPDP_BUS.insertPhieuDatPhongChiTiet(DatPhongBUS.MaxPhieuDat(), txt_manv.Text, dateTimePicker1.Text,dateTimePicker2.Text, dateTimePicker3.Text);
            PhongBUS.DatPhong(tbMP.Text);
            MessageBox.Show("Đặt Phòng Thành Công");
            this.Close();
        }
    }
}
