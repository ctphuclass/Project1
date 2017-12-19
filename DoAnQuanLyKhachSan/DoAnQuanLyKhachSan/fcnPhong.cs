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
    public partial class fphong : Form
    {
        public fphong()
        {
            InitializeComponent();
            LoadP();
        }
        public void clear()
        {
            tbmap.Text = "";
           
            tbtt.Text = "";
            tblp.Text = "";
           
        }
        public void LoadP()
        {
            List<PhongDTO> DSP = PhongBUS.LsP();
            dgvP.DataSource = DSP;
        }

        private void tbG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (tbmap.Text == "" || tblp.Text == "")
            {

            }
            PhongDTO Phong = new PhongDTO();
            Phong.maphong = tbmap.Text;
            Phong.tinhtrang = tbtt.Text;
            Phong.maloaiphong = tblp.Text;
            
            
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgrv = dgvP.CurrentRow;
            tbmap.Text = dgrv.Cells["MaPhong"].Value.ToString();
            tbtt.Text = dgrv.Cells["TinhTrang"].Value.ToString();
            tblp.Text = dgrv.Cells["MaLoaiPhong"].Value.ToString();
        }
    }
}
