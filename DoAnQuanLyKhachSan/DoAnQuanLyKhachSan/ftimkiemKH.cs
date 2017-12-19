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
    public partial class ftimkiemKH : Form
    {
        static DataTable table;
        public ftimkiemKH()
        {
            InitializeComponent();

        }
        public void LoadKH()
        {
            table  = KhachHangBUS.Loadkh();
            dataGridView1.DataSource = table;
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {

        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (tbsearch.Text == "")
            {
                MessageBox.Show("Hãy Nhập từ khóa cần tìm!", "Thông Báo");
                return;
            }
            string tk = tbsearch.Text;
            table = KhachHangBUS.TimKH(tk);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("không tìm thấy khách hàng","Thông Báo");
                return;
            }
            MessageBox.Show(string.Format("Tìm thấy {0} khách hàng", table.Rows.Count), "ThongBao!");
            dataGridView1.DataSource = table;

        }

        private void ftimkiemKH_Load(object sender, EventArgs e)
        {
          
        }
    }
}
