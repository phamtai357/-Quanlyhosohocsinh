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
    public partial class MDImain : Form
    {
        private int childFormNumber = 0;
        frmkhoi khoi;
        frmlop lop;
        frmtthocsinh hocsinh;
        public MDImain()
        {
            InitializeComponent();
        }
       private void itemfrmhocsinh_Click(object sender, EventArgs e)
        {

                frmtthocsinh csl = new frmtthocsinh();
                csl.MdiParent = this;
                csl.WindowState = FormWindowState.Maximized;
                csl.Show();


        }

        private void itemlop_Click(object sender, EventArgs e)
        {

                frmlop cs2 = new frmlop();
                cs2.MdiParent = this;
                cs2.WindowState = FormWindowState.Maximized;
                cs2.Show();

        }

        private void itemkhoi_Click(object sender, EventArgs e)
        {

                frmkhoi cs3 = new frmkhoi();
                cs3.MdiParent = this;
                cs3.WindowState = FormWindowState.Maximized;
                cs3.Show();
            


        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == Name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                }

            }
            return check;
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain mn = new frmmain();
            mn.Show();
            this.Hide();
        }
    }
}
