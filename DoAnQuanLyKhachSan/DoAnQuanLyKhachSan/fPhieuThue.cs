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
    public partial class fPhieuThue : Form
    {
        public fPhieuThue()
        {
            InitializeComponent();
           
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
            addkhachhang();
            
            PhieuThuePhongBUS.ThemMaPhieuTheoKH(txt_manv.Text);
            ChiTietPTP_BUS.ThemCTphieu(PhieuThuePhongBUS.MaxPhieuThue(), tbMP.Text, dateTimePicker1.Text);
            PhongBUS.NhanPhong(tbMP.Text);
            MessageBox.Show("Thêm Thành Công");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
