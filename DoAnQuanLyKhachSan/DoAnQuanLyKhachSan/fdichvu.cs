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
using BUS;
namespace DoAnQuanLyKhachSan
{
    public partial class fdichvu : Form
    {
        public fdichvu()
        {
            InitializeComponent();
           
        }
        public void LoadDV()
        {
             List<DichVuDTO> DS = DichVuBUS.LoadDV();
            dgvdv.DataSource = DS;
        }
        public void clear()
        {
            tbtdv.Text = "";
            tbgia.Text = "";
            tbmadv.Text = "";
            tbldv.Text = "";
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tbmadv.Text == "" || tbtdv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }
            DichVuDTO dv = new DichVuDTO();
            dv.madichvu = tbmadv.Text;
            dv.tendichvu = tbtdv.Text;
            dv.gia = tbgia.Text;
            dv.loai = tbldv.Text;


            if (DichVuBUS.ThemDichVu(dv) == true)
            {
                MessageBox.Show("Thêm Thành Công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Thất bại ! Dịch Vụ này đã tồn tại !", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            LoadDV();
            clear();
        }

        private void fdichvu_Load(object sender, EventArgs e)
        {
            LoadDV();
        }

        private void dgvdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgrv = dgvdv.CurrentRow;
            tbmadv.Text = dgrv.Cells["Madichvu"].Value.ToString();
            tbtdv.Text = dgrv.Cells["Tendichvu"].Value.ToString();
            tbgia.Text = dgrv.Cells["Gia"].Value.ToString();
            tbldv.Text = dgrv.Cells["Loai"].Value.ToString();
        }



        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (tbmadv.Text == "" || tbtdv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }
            DichVuDTO dv = new DichVuDTO();
            ResultMessage_DTO result;
            dv.madichvu = tbmadv.Text;
            dv.tendichvu = tbtdv.Text;
            dv.gia = tbgia.Text;
            dv.loai = tbldv.Text;
            result = DichVuBUS.SuaDV(dv);
            if (result.ResultCode_DV == dv.madichvu)
            {
                MessageBox.Show(result.ResultMessage_DV, "Sua That Bai");

            }
            else
            {
                MessageBox.Show(result.ResultMessage_DV, "Sua Thanh Cong");

            }
            LoadDV();
            clear();
        }

        private void bnxóa_Click(object sender, EventArgs e)
        {
            if (tbmadv.Text == "" || tbtdv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }
            DichVuDTO dv = new DichVuDTO();
            dv.madichvu = tbmadv.Text;

            if (DichVuBUS.XoaDV(dv) == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa Thất bại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            LoadDV();
            clear();
        }
    }
}
