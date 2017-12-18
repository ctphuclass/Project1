using QuanLyKhachSan_DTO;
using QuanLyKhacSan_BUS;
using QuanLyKhacSan_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmDangNhap : Form
    {
        public int UserID;
        int iLoginFailed;
        const int cNumberLoginFailed = 3;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ResultMessageBO result;
            UserBO userBO = new UserBO();
            UserBL userBL = new UserBL();
            userBO.Username = tbTenDangNhap.Text;
            userBO.Password = tbMatKhau.Text;
            result = userBL.CheckUserLoginBL(userBO);
            if (result.ResultCode > 0)
            {
                UserID = result.ResultCode;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ResultMessage);
                if (iLoginFailed < cNumberLoginFailed)
                {
                    iLoginFailed += 1;
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            UserID = 0;
            this.Close();
        }
    }
}
