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
    public partial class ChucNangDichVu : Form
    {
        public ChucNangDichVu()
        {
            InitializeComponent();
           
            
        }
        public void LoadDichVu()
        {
            List<DichVuDTO> DSDV = DichVuBUS.LoadDV();
            dataGridView1.DataSource = DSDV;
        }
        

        public void LoadPhong()
        {
            flopPhong.Controls.Clear();
            List<PhongDTO> ListPhong = PhongBUS.LsP();
            foreach (PhongDTO item in ListPhong)
            {
                Button bn = new Button() { Width = PhongBUS.tablewidth, Height = PhongBUS.tableheight };
                bn.Text = item.maphong;
                bn.TextAlign = ContentAlignment.TopCenter;
                flopPhong.Controls.Add(bn);
                bn.Click += bn_Click;
                bn.Tag = item;
                bn.TextChanged += new EventHandler(MyHandler);
                bn.Image = Properties.Resources.Actions_go_home_icon;
                switch (item.tinhtrang)
                {
                    case "Trống":

                        bn.BackColor = Color.Red;
                        bn.BackgroundImageLayout = ImageLayout.Center;
                        
                        bn.ImageAlign = ContentAlignment.MiddleCenter;
                        break;
                    case "Hỏng":
                        bn.BackColor = Color.Black;
                        bn.Enabled = false;
                        bn.BackgroundImageLayout = ImageLayout.Center;
                        bn.ImageAlign = ContentAlignment.MiddleCenter;

                        break;
                    case "Hoạt Động":

                        bn.BackColor = Color.Yellow;
                        bn.BackgroundImageLayout = ImageLayout.Center;
                        break;
                }
            }

        }

        private void MyHandler(object sender, EventArgs e)
        {
        
        }


        public void PhongShow(string maphong)
        {
            listView1.Items.Clear();
            PhongDTO Phong = listView1.Tag as PhongDTO;
            int machiphi = ChiPhiBUS.kiemtrachiphi(Phong.maphong);
            float tong = 0;
            List<PhieuChiTietDTO> show = PhieuChiTietBUS.CPP(maphong, machiphi);
            foreach (PhieuChiTietDTO item in show)
            {
                ListViewItem lsvItem = new ListViewItem(item.madv.ToString());
                lsvItem.SubItems.Add(item.TenDichVu.ToString());
                lsvItem.SubItems.Add(item.dongia.ToString());
                lsvItem.SubItems.Add(item.soluong.ToString());
                lsvItem.SubItems.Add(item.TongTien.ToString());
                tong += item.TongTien;
                listView1.Items.Add(lsvItem);
            }
            tbTongTien.Text = tong.ToString();
        }
        private void bn_Click(object sender, EventArgs e)
        {
            string maphong = ((sender as Button).Tag as PhongDTO).maphong;
            label2.Text = maphong;
            listView1.Tag = (sender as Button).Tag;
            PhongShow(maphong);
        }

        private void ChucNangDichVu_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadDichVu();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            if (dr != null)
            {
                textBox1.Text = dr.Cells["TenDichVu"].Value.ToString();
            }
        }

        private void bnThanhToán_Click(object sender, EventArgs e)
        {
            PhongDTO Phong = listView1.Tag as PhongDTO;
            int machiphi = ChiPhiBUS.kiemtrachiphi(Phong.maphong);
            if (machiphi != 1)
            {
                ChiPhiBUS.TinhTien(machiphi);
                PhongShow(Phong.maphong);
                LoadPhong();
                MessageBox.Show("Thanh Toán Thành Công");
            }
        }

        private void bt_trảphòng_Click(object sender, EventArgs e)
        {
            PhongDTO Phong = listView1.Tag as PhongDTO;
            int machiphi = ChiPhiBUS.kiemtrachiphi(Phong.maphong);
            if (machiphi != 1)
            {
                ChiPhiBUS.TinhTien(machiphi);
                PhongShow(Phong.maphong);
               
                MessageBox.Show("Trả Thành Công");
                PhongBUS.TraPhong(Phong.maphong);
                LoadPhong();
            }
           
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PhongDTO Phong = listView1.Tag as PhongDTO;
                int machiphi = ChiPhiBUS.kiemtrachiphi(Phong.maphong);
                DataGridViewRow dgvr = dataGridView1.CurrentRow;
                string madv = dgvr.Cells["MaDichVu"].Value.ToString();
                int SL = (int)numericUpDown1.Value;
                if (machiphi == -1)
                {
                    ChiPhiBUS.ThemVaoChiPhi(Phong.maphong);

                    PhieuChiTietBUS.UpdateChiTietChiPhi(ChiPhiBUS.MaxChiTiet(), madv, SL);
                    MessageBox.Show("Thêm Thành Cộng!");
                }
                else

                {
                    PhieuChiTietBUS.UpdateChiTietChiPhi(machiphi, madv, SL);
                    MessageBox.Show("Cập Nhật Thành Công!");
                }
                PhongShow(Phong.maphong);
                LoadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn phòng trước khi thêm dịch vụ");
            }
        }
    }
}
