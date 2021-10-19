using Quanlyhososinhcap3.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhososinhcap3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        QLHSHSSEntities6 hs = new QLHSHSSEntities6();

        private DangNhap login(string username, string password)
        {
            var login = hs.DangNhaps.SingleOrDefault(async => async.TaiKhoan.Equals(username));
            if (login != null)
            {
                return login;
            }
            return null;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            frmmain frmmain = new frmmain();
            var account = login(txt_username.Text, txt_password.Text);
            if (account == null)
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            else
            {
                if (txt_username.Text == "admin")
                {
                    MessageBox.Show("Đăng nhập thành công dưới quyền ban giám hiệu");
                 
                    frmmain.fr = txt_username.Text;
                    this.Hide();
                    frmmain.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    frmmain.Show();
                }


            }
            txt_username.ResetText();
            txt_password.ResetText();
            txt_username.Focus();
        }
    }
}
