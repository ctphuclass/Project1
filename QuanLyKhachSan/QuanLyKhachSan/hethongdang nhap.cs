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

namespace QuanLyKhachSan
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butonlogin_Click(object sender, EventArgs e)
        {
            if (tbuser.Text == "" || tbpass.Text == "")
            {
                MessageBox.Show("Xin nhập User name và Pass word");
                return;
            }
            try
            {
                //Create connection string
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select * from dbo.[User] where Username=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Username", tbuser.Text);
                cmd.Parameters.AddWithValue("@Password", tbpass.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void butonextit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (tbuser.Text == "" || tbpass.Text == "")
            {
                MessageBox.Show("Xin nhập User name và Pass word");
                return;
            }
            this.Close();
        }

     
        
    }
}
