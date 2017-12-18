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
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_manv.Text == "" || txt_ten.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu!");
                    return;
                }


                KhachHangDTO kh = new KhachHangDTO();
                kh.makh = txt_manv.Text;
                kh.tenkh = txt_ten.Text;
                kh.quoctinh = txt_qt.Text;
                kh.sdt = txt_sdt.Text;
                kh.CMND = txt_cm.Text;
                kh.diachi = txt_diachi.Text;
                if(rd_nam.Checked == true)
                {
                    kh.gioitinh = "Nam";
                }
                else
                {
                    kh.gioitinh = "Nữ";
                }
                
                if (KhachHangBUS.ThemKhachHang(kh) == true)
                {
                    MessageBox.Show("Thêm Thành Công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Thất bại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                LoadKH();
               
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public void clear()
        {
            txt_ten.Text = "";
            txt_cm.Text = "";
            txt_diachi.Text = "";
            txt_manv.Text = "";
            txt_qt.Text = "";
            txt_sdt.Text = "";
        }
        public void LoadKH()
        {
             DataTable table = KhachHangBUS.Loadkh();
            dataGridView1.DataSource = table;
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text == "" || txt_ten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }
            KhachHangDTO kh = new KhachHangDTO();
            ResultMessage_DTO result;
            result = KhachHangBUS.SuaKH(kh);
            if (result.ResultCode_KH == kh.makh)
            {
                MessageBox.Show(result.ResultMessage_DV, "Sua That Bai");

            }
            else
            {
                MessageBox.Show(result.ResultMessage_DV, "Sua Thanh Cong");

            }
            LoadKH();
            clear();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.makh = txt_manv.Text;
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này?", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DataTable tb = KhachHangBUS.XoaKhachHang(kh);
                LoadKH();
                clear();
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_cm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }
    }
}
