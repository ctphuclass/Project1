using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace DoAnQuanLyKhachSan
{
    public partial class fTimPhong : Form
    {
        public fTimPhong()
        {
            InitializeComponent();
            LoadPhongTrong();
        }
        public void LoadPhongTrong()
        {
            List<PhongDTO> TDSDT = PhongBUS.KiemTraThuePhong();
            dataGridView1.DataSource = TDSDT;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fPhieuThue ft = new fPhieuThue();
            ft.tbMP.Text= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ft.tblp.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ft.tbSC.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            ft.tbG.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ft.ShowDialog();
            LoadPhongTrong();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button ==MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                flogin lg = new flogin();
                lg.ShowDialog();
            }

        }
    }
}
