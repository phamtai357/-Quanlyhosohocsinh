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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttths_Click(object sender, EventArgs e)
        {
            MDImain mD = new MDImain();
            mD.Show();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btngdung_Click(object sender, EventArgs e)
        {
            if (tenngdung.Text == "admin")
            {
                frmnguoidung ngdung = new frmnguoidung();
                ngdung.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!!");
                btngdung.Enabled = false;
            }

        }
        public string fr;
        private void frmmain_Load(object sender, EventArgs e)
        {
            tenngdung.Text = fr;
        }
    }
}
