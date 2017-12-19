using BUS;
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
    public partial class SuLyPhieuDatPhong : Form
    {
        public SuLyPhieuDatPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_NP_Click(object sender, EventArgs e)
        {
            PhongBUS.NhanPhong1(tbMP.Text);
            PhongBUS.NhanPhong2(tbMP.Text);
            MessageBox.Show("Đã Nhận Phòng Thành Công");
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            PhongBUS.HuyPhong(tbMP.Text);
            MessageBox.Show("Bạn Đã Hủy Phiếu Đặt");
            this.Close();
        }
    }
}
