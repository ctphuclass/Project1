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
    public partial class flogin : Form
    {
        public int Id;
        int iLoginFailed;
        const int cNumberLoginFailed = 3;

        public flogin()
        {
            InitializeComponent();
            iLoginFailed = 1;

        }
       
        private void bt_dn_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        public void DangNhap()
        {
            ResultMessage_DTO result;
            UserDTO user = new UserDTO();
            user.TaiKhoan = tbTK.Text;
            user.MatKhau = tbMK.Text;

            UserBUS userbs = new UserBUS();
            result = userbs.CheckUserLoginBUS(user);
            if (result.ResultCode > 0)
            {
                fMain fView = new fMain();
                Id = result.ResultCode;
                
                MessageBox.Show(result.ResultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (UserBUS.CheckPermission(user) == true)
                {
                    if (user.ChucVu == "True")
                    {
                        NhanVien();
                    }
                    else
                    {
                        Admin();
                    }
                }
                fView.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result.ResultMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tbTK.Text = "";
                //tbMK.Text = "";
                //if (iLoginFailed < cNumberLoginFailed)
                //{
                //    iLoginFailed += 1;
                //    this.DialogResult = DialogResult.None;
                //}
                //else
                //{
                //    this.DialogResult = DialogResult.Cancel;
                //}
            }
        }
        public void Admin()
        {

        }
        public void NhanVien()
        {

        }

    }
}
