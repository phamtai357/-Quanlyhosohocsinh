namespace Quanlyhososinhcap3
{
    partial class frmkhoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkhoi));
            this.bt_huy = new Telerik.WinControls.UI.RadButton();
            this.bt_xoa = new Telerik.WinControls.UI.RadButton();
            this.bt_luu = new Telerik.WinControls.UI.RadButton();
            this.bt_sua = new Telerik.WinControls.UI.RadButton();
            this.bt_them = new Telerik.WinControls.UI.RadButton();
            this.gv_tt = new Telerik.WinControls.UI.RadGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenkhoi = new Telerik.WinControls.UI.RadTextBox();
            this.txt_makhoi = new Telerik.WinControls.UI.RadTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bt_huy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.PapayaWhip;
            this.bt_huy.Location = new System.Drawing.Point(779, 39);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(98, 35);
            this.bt_huy.TabIndex = 30;
            this.bt_huy.Text = "Hủy";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_xoa.BackColor = System.Drawing.Color.PapayaWhip;
            this.bt_xoa.Location = new System.Drawing.Point(655, 39);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(98, 35);
            this.bt_xoa.TabIndex = 30;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_luu.BackColor = System.Drawing.Color.PapayaWhip;
            this.bt_luu.Location = new System.Drawing.Point(515, 39);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(98, 35);
            this.bt_luu.TabIndex = 30;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_sua.BackColor = System.Drawing.Color.PapayaWhip;
            this.bt_sua.Location = new System.Drawing.Point(390, 39);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(98, 35);
            this.bt_sua.TabIndex = 30;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_them.BackColor = System.Drawing.Color.PapayaWhip;
            this.bt_them.Location = new System.Drawing.Point(261, 39);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(98, 35);
            this.bt_them.TabIndex = 29;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // gv_tt
            // 
            this.gv_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.gv_tt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_tt.Location = new System.Drawing.Point(0, 437);
            // 
            // 
            // 
            this.gv_tt.MasterTemplate.AllowAddNewRow = false;
            this.gv_tt.MasterTemplate.AllowDeleteRow = false;
            this.gv_tt.MasterTemplate.AllowEditRow = false;
            this.gv_tt.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gv_tt.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
            this.gv_tt.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gv_tt.Name = "gv_tt";
            this.gv_tt.ReadOnly = true;
            // 
            // 
            // 
            this.gv_tt.RootElement.AutoSize = true;
            this.gv_tt.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.gv_tt.Size = new System.Drawing.Size(1200, 213);
            this.gv_tt.TabIndex = 3;
            this.gv_tt.ThemeName = "ControlDefault";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên Khối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Khối";
            // 
            // txt_tenkhoi
            // 
            this.txt_tenkhoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkhoi.Location = new System.Drawing.Point(723, 234);
            this.txt_tenkhoi.Name = "txt_tenkhoi";
            this.txt_tenkhoi.ReadOnly = true;
            this.txt_tenkhoi.Size = new System.Drawing.Size(178, 25);
            this.txt_tenkhoi.TabIndex = 16;
            // 
            // txt_makhoi
            // 
            this.txt_makhoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhoi.Location = new System.Drawing.Point(275, 234);
            this.txt_makhoi.Name = "txt_makhoi";
            this.txt_makhoi.ReadOnly = true;
            this.txt_makhoi.Size = new System.Drawing.Size(178, 25);
            this.txt_makhoi.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Quanlyhososinhcap3.Properties.Resources.top1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 96);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_huy);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_luu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // frmkhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenkhoi);
            this.Controls.Add(this.txt_makhoi);
            this.Controls.Add(this.gv_tt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmkhoi";
            this.Load += new System.EventHandler(this.frmkhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt_huy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton bt_huy;
        private Telerik.WinControls.UI.RadButton bt_xoa;
        private Telerik.WinControls.UI.RadButton bt_luu;
        private Telerik.WinControls.UI.RadButton bt_sua;
        private Telerik.WinControls.UI.RadButton bt_them;
        private Telerik.WinControls.UI.RadGridView gv_tt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txt_tenkhoi;
        private Telerik.WinControls.UI.RadTextBox txt_makhoi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}