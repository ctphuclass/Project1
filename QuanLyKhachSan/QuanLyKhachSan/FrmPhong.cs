using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan_DTO;
using QuanLyKhacSan_DAO;

namespace QuanLyKhachSan
{
    public partial class FrmPhong : Form
    {
        public FrmPhong()
        {
            InitializeComponent();
            LoadPhong();
        }
        void LoadPhong()
        {
            List<Phong_DTO> listphong = Phong_DAO.Instance.LoadPhong();

            foreach(Phong_DTO item in listphong)
            {
                Button btn = new Button() { Width = Phong_DAO.Phong_DAOWidth, Height = Phong_DAO.Phong_DAOHeight};
                btn.Text = item.Maphong + Environment.NewLine + item.Tinhtrang;
                btn.Click += Btn_Click;
                switch (item.Tinhtrang)
                {
                    case "trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        public void Btn_Click(object sender, EventArgs e)
        {
            FrmDatPhong fdatphong = new FrmDatPhong();
            fdatphong.ShowDialog();
        }
    }
}
