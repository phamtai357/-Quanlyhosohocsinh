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
    public partial class frmkhoi : Form
    {
        QLHSHSSEntities6 hs = new QLHSHSSEntities6();
        public frmkhoi()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            this.Dispose();
        }
        private void unlocktext()
        {
            txt_makhoi.ReadOnly = false;
            txt_tenkhoi.ReadOnly = false;
        }
        bool them;

        private void frmkhoi_Load(object sender, EventArgs e)
        {
            gv_tt.DataSource = hs.GetAllLop();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            unlocktext();
            them = true;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            unlocktext();
            txt_makhoi.ReadOnly = true;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                hs.AddKhoi(int.Parse(txt_makhoi.Text), txt_tenkhoi.Text);
                try
                {
                    MessageBox.Show("Bạn đã thêm học thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn thêm không thành công");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                hs.UpdateKhoi(int.Parse(txt_makhoi.Text), txt_tenkhoi.Text);
                try
                {
                    MessageBox.Show("Bạn đã thêm học thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn thêm không thành công");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            hs.DeleteKhoi(int.Parse(txt_makhoi.Text));
            try
            {
                MessageBox.Show("Bạn đã xóa thành công!!!!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gv_tt.DataSource = hs.GetAllLop();
        }

        private void bt_huy_Click(object sender, EventArgs e, Control form)
        {
            txt_makhoi.ResetText();
            txt_tenkhoi.ResetText();
        }
    }
}
