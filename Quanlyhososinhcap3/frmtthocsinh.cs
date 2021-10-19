using Quanlyhososinhcap3.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhososinhcap3
{
    public partial class frmtthocsinh : Form
    {
        QLHSHSSEntities6 hs = new QLHSHSSEntities6();
        public frmtthocsinh()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            this.Dispose();
        }
        bool them;
        private void unlocktext()
        {
            txt_mahs.ReadOnly = false;
            txt_tenhs.ReadOnly = false;
            txt_gioitinh.ReadOnly = false;
            dd_lop.ReadOnly = false;
            dd_khoi.ReadOnly = false;
            txt_diem.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            txt_diachi.ReadOnly = false;
            dt_ngaysinh.ReadOnly = false;
            bt_upimage.Enabled = true;
        }
        private void frmtthocsinh_Load(object sender, EventArgs e)
        {
            gv_tt.DataSource = hs.GetAllHocSinh();

            dd_khoi.DataSource = hs.GetAllKhoi();
            dd_khoi.ValueMember = "MaKhoi";
            dd_khoi.DisplayMember = "TenKhoi";

            dd_lop.DataSource = hs.GetAllLop();
            dd_lop.ValueMember = "MaLop";
            dd_lop.DisplayMember = "TenLop";
        }

        //convert image to bytearray
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        //convert bytearray to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {

            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void gv_tt_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            px_image.Image = byteArrayToImage((Byte[])gv_tt.SelectedRows[0].Cells[0].Value);
            txt_mahs.Text = gv_tt.SelectedRows[0].Cells[1].Value.ToString();
            txt_tenhs.Text = gv_tt.SelectedRows[0].Cells[2].Value.ToString();
            dt_ngaysinh.Text = gv_tt.SelectedRows[0].Cells[3].Value.ToString();
            txt_gioitinh.Text = gv_tt.SelectedRows[0].Cells[4].Value.ToString();
            dd_lop.Text = gv_tt.SelectedRows[0].Cells[5].Value.ToString();
            dd_khoi.Text = gv_tt.SelectedRows[0].Cells[6].Value.ToString();
            txt_diem.Text = gv_tt.SelectedRows[0].Cells[7].Value.ToString();
            txt_xeploai.Text = gv_tt.SelectedRows[0].Cells[8].Value.ToString();
            txt_diachi.Text = gv_tt.SelectedRows[0].Cells[9].Value.ToString();
            txt_sdt.Text = gv_tt.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            unlocktext();
            them = true;
            resettext();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            unlocktext();
            txt_mahs.Enabled = true;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(them == true)
            {
                hs.AddHocSinh(ImageToByteArray(px_image.Image),int.Parse(txt_mahs.Text), txt_tenhs.Text, int.Parse(dd_lop.SelectedValue.ToString()), txt_gioitinh.Text, DateTime.Parse(dt_ngaysinh.Text), txt_diachi.Text, int.Parse(txt_sdt.Text), double.Parse(txt_diem.Text));
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
                hs.UpdateHocSinh(ImageToByteArray(px_image.Image), int.Parse(txt_mahs.Text),txt_tenhs.Text, int.Parse(dd_lop.SelectedValue.ToString()), txt_gioitinh.Text, DateTime.Parse(dt_ngaysinh.Text), txt_diachi.Text, int.Parse(txt_sdt.Text), double.Parse(txt_diem.Text),txt_xeploai.Text);
                dd_khoi.DataSource = hs.GetAllKhoi();
                try
                {
                    MessageBox.Show("Bạn đã thêm học sinh thành công!!!");                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn thêm không thành công");
                    MessageBox.Show(ex.Message);
                }
            }
            gv_tt.DataSource = hs.GetAllHocSinh();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("bạn có muốn xóa dữ liệu?", "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                hs.DeleteHocSinh(int.Parse(txt_mahs.Text));
                try
                {
                    MessageBox.Show("Bạn đã xóa thành công!!!!!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dd_khoi.DataSource = hs.GetAllKhoi();
            }
        }

        private void bt_upimage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "image file (*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    px_image.Image = new Bitmap(dialog.FileName);
                }
            }
            catch (Exception en)
            {
                Console.WriteLine(en.Message);
            }
        }

        private void resettext()
        {
            txt_mahs.ResetText();
            txt_tenhs.ResetText();
            txt_gioitinh.ResetText();
            txt_diachi.ResetText();
            txt_diem.ResetText();
            txt_sdt.ResetText();
            txt_xeploai.ResetText();
            px_image.Image = null;
            dd_khoi.SelectedIndex = -1;
            dd_lop.SelectedIndex = -1;

        }
        private void bt_huy_Click(object sender, EventArgs e)
        {
            resettext();
            
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
                gv_tt.DataSource = hs.tmkiemmahocsinh(txt_timkiem.Text);
                gv_tt.DataSource = hs.tmkiemtenhocsinh(txt_timkiem.Text);
                gv_tt.DataSource = hs.tmkiemlophocsinh(txt_timkiem.Text);
                gv_tt.DataSource = hs.tmkiemkhoihocsinh(txt_timkiem.Text);
        }
        string ex;
        private void txt_mahs_Validating(object sender, CancelEventArgs ex)
        {

            if (string.IsNullOrEmpty(txt_mahs.Text) && them == true)
            {
                ex.Cancel = true;
                txt_mahs.Focus();
                erro_mahs.SetError(txt_mahs, "Mã học sinh không để trống!");
            }
            else
            {
                ex.Cancel = false;
                erro_mahs.SetError(txt_mahs, "");
            }
        }
    }
}
