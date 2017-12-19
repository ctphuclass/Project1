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
    public partial class fdoanhthu : Form
    {
        public fdoanhthu()
        {
            InitializeComponent();
            LoadDT();
            LoadTDT();
        }
        public void LoadDT()
        {
            List<DoanhThuDTO> DSDT = DoanhthuBUS.LoadDT();
            dataGridView1.DataSource = DSDT;
        }
        public void LoadTDT()
        {
            List<TongTienDTO> TDSDT = DoanhthuBUS.LoadTongDoanhThu();
            cbTT.DataSource = TDSDT;
            cbTT.DisplayMember = "TongTien";

        }
        //List<DoanhThuDTO> DoanhThuTheoPhong(string maphong)
        //{
        //    List<DoanhThuDTO> DSTP = DoanhthuBUS.LoadDTTheoPhong(maphong);
        //    return DSTP;

        //}
        List<TongTienDTO> TongDoanhThuTheoPhong(string maphong)
        {
            List<TongTienDTO> DSTP1 = DoanhthuBUS.LoadTongTienTheoPhong(maphong);
            return DSTP1;
        }
        void DoanhThuTheoPhong()
        {
            //dataGridView1.DataSource = DoanhThuTheoPhong(tbkeyword.Text);
        }
        void TongDoanhThuTheoPhong()
        {
            cbTT.DataSource = TongDoanhThuTheoPhong(tbkeyword.Text);
            cbTT.DisplayMember = "TongTien";
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if(tbkeyword.Text == "")
            {
                LoadDT();
            }
            try
            {
                string maphong = tbkeyword.Text;
                DataTable table = DoanhthuBUS.DoanhThuTheoPhong(maphong);
                MessageBox.Show(string.Format("Tìm thấy {0} Doanh Thu", table.Rows.Count), "ThongBao!");
                TongDoanhThuTheoPhong();
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("không tìm thấy Doanh Thu", "Thông Báo");
                    return;
                   
                }
                dataGridView1.DataSource = table;
            }
            catch (Exception )
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDT();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbTT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
