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
    public partial class frmlop : Form
    {
        QLHSHSSEntities6 hs = new QLHSHSSEntities6();
        public frmlop()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            this.Dispose();
        }
        // cho phép viết vào textbox
        private void unlocktext()
        {
            txt_malop.ReadOnly = false;
            txt_tenlop.ReadOnly = false;
            dd_khoi.Enabled = true;
        }
        bool them;

        private void frmlop_Load(object sender, EventArgs e)
        {
            gv_tt.DataSource = hs.GetAllLop();

            dd_khoi.DataSource = hs.GetAllKhoi();
            dd_khoi.ValueMember = "MaKhoi";
            dd_khoi.DisplayMember = "TenKhoi";
        }

        private void gv_tt_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            txt_malop.Text = gv_tt.SelectedRows[0].Cells[0].Value.ToString();
            txt_tenlop.Text = gv_tt.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            unlocktext();
            them = true;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            unlocktext();
            txt_malop.ReadOnly = true;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                hs.AddLop(int.Parse(txt_malop.Text), txt_tenlop.Text, int.Parse(dd_khoi.Text));
                dd_khoi.DataSource = hs.GetAllKhoi();
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
                hs.UpdateLop(int.Parse(txt_malop.Text), txt_tenlop.Text, int.Parse(dd_khoi.Text));
                dd_khoi.DataSource = hs.GetAllKhoi();
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
            hs.DeleteLop(int.Parse(txt_malop.Text));
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
    }
}
