using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace DoAnQuanLyKhachSan
{
    public partial class KiemTraDatPhong : Form
    {
        public KiemTraDatPhong()
        {
            InitializeComponent();
            PhongDat();
        }
        public void PhongDat()
        {
            List<KiemTraDatPhongDTO> LKT = KiemTraDatPhongBUS.KiemTraDatPhong();
            dataGridView1.DataSource = LKT;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuLyPhieuDatPhong sl = new SuLyPhieuDatPhong();
            sl.tbMP.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            sl.ShowDialog();
            PhongDat();
        }
    }
}
