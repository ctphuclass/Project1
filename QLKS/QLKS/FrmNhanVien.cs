using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhacSan_BUS;
using QuanLyKhachSan_DTO;

namespace QuanLyKhachSan
   
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable data = NhanVien_BUS.LoadNhanVien();
            dtgvNhanVien.DataSource = data;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvNhanVien.CurrentRow;
            tbMaNhanVien.Text = row.Cells["MA_NHAN_VIEN"].Value.ToString();
            tbHoTen.Text = row.Cells["TEN_NHAN_VIEN"].Value.ToString();
            tbChucVu.Text = row.Cells["CHUC_VU"].Value.ToString();
            tbNamSinh.Text = row.Cells["NAM_SINH"].Value.ToString();
            tbGioiTinh.Text = row.Cells["GIOI_TINH"].Value.ToString();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (tbHoTen.Text == "")
            {
                MessageBox.Show("Họ tên nhân viên không được để trống");
                return;
            }
            NhanVien_DTO nhanvien = new NhanVien_DTO();
            nhanvien.namsinh = DateTime.Parse(tbNamSinh.Text);
            nhanvien.chucvu = tbChucVu.Text;
            nhanvien.hoten = tbHoTen.Text;
            nhanvien.gioitinh = tbGioiTinh.Text;
            nhanvien.manhanvien = tbMaNhanVien.Text;
            if (NhanVien_BUS.EditNhanVien(nhanvien) == true)
            {
                MessageBox.Show("Sửa thành công!!!");
                btnLoad_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống");
                return;
            }
            NhanVien_DTO nhanvien = new NhanVien_DTO();
            nhanvien.manhanvien = tbMaNhanVien.Text;
            nhanvien.hoten = tbHoTen.Text;
            nhanvien.chucvu = tbChucVu.Text;
            nhanvien.gioitinh = tbGioiTinh.Text;
            nhanvien.namsinh = DateTime.Parse(tbNamSinh.Text);
            if (NhanVien_BUS.AddNhanVien(nhanvien) == true)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                btnLoad_Click(sender, e);
            }
            else if (NhanVien_BUS.AddNhanVien(nhanvien)==false)
            {
                MessageBox.Show("Thêm nhân viên thất bại!!!!");
            }
        }
    }
}
