using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DTO;
using System.Windows.Forms;
using QuanLyKhacSan_BUS;

namespace QuanLyKhachSan
{
    public partial class FrmDatPhong : Form
    {
        public FrmDatPhong()
        {
            InitializeComponent();
        }
        /// <summary>
        /// đăng kí phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if ((tbMaKhachHang.Text == "" )||( tbTenKhachHang.Text == ""))
            {
                MessageBox.Show("Thông tin không được phép để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhachHang_DTO khachhang = new KhachHang_DTO();
            khachhang.makhachhang = tbMaKhachHang.Text;
            khachhang.tenkhachang = tbTenKhachHang.Text;
            khachhang.soCMND = Convert.ToInt32(tbSoCMT.Text).ToString();
            khachhang.soDT = Convert.ToInt32(tbSoDT.Text).ToString();
            khachhang.quoctich = tbQuocTich.Text;
            khachhang.gioitinh = tbGioiTinh.Text;
            khachhang.diachi = tbDiaChi.Text;
            khachhang.ngaynhanphong = Convert.ToDateTime(dtpkNgayNhanPhong.Text);
            khachhang.ngaytraphong = Convert.ToDateTime(dtpkNgayTra.Text);
            if (KhachHang_BUS.AddKH(khachhang) == true)
            {
                MessageBox.Show("Đăng kí thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(KhachHang_BUS.AddKH(khachhang) == false)
            {
                MessageBox.Show("Đăng kí không thành công");
            }
        }
        /// <summary>
        /// thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
