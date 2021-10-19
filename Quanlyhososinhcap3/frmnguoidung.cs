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
    public partial class frmnguoidung : Form
    {
        QLHSHSSEntities6 hs = new QLHSHSSEntities6();
        public frmnguoidung()
        {
            InitializeComponent();
        }

        private void frmnguoidung_Load(object sender, EventArgs e)
        {
            gv_tt.DataSource = hs.GetAllngdung();
        }
        private void gv_tt_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            txt_id.Text = gv_tt.SelectedRows[0].Cells[0].Value.ToString();
            txt_taikhoan.Text = gv_tt.SelectedRows[0].Cells[1].Value.ToString();
            txt_matkhau.Text = gv_tt.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void unlocktext()
        {
            txt_id.ReadOnly = false;
            txt_taikhoan.ReadOnly = false;
            txt_matkhau.ReadOnly = false;
        }
        bool them;


        private void bt_them_Click(object sender, EventArgs e)
        {
            unlocktext();
            them = true;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            unlocktext();
            txt_id.ReadOnly = true;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                hs.Addngdung(int.Parse(txt_id.Text), txt_taikhoan.Text,txt_matkhau.Text);
                try
                {
                    MessageBox.Show("Bạn đã thêm thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn thêm không thành công");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                hs.Updatengdung(int.Parse(txt_id.Text),txt_taikhoan.Text, txt_matkhau.Text);
                try
                {
                    MessageBox.Show("Bạn đã thêm thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn thêm không thành công");
                    MessageBox.Show(ex.Message);
                }
            }
            gv_tt.DataSource = hs.GetAllngdung();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            hs.Deletengdung(int.Parse(txt_id.Text));
            try
            {
                MessageBox.Show("Bạn đã xóa thành công!!!!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gv_tt.DataSource = hs.GetAllngdung();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            txt_id.ResetText();
            txt_taikhoan.ResetText();
            txt_matkhau.ResetText();
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            frmmain main = new frmmain();
            main.Show();
            this.Hide();
        }



    }
}
