namespace Quanlyhososinhcap3
{
    partial class frmlop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new Telerik.WinControls.UI.RadButton();
            this.bt_huy = new Telerik.WinControls.UI.RadButton();
            this.bt_them = new Telerik.WinControls.UI.RadButton();
            this.bt_sua = new Telerik.WinControls.UI.RadButton();
            this.bt_luu = new Telerik.WinControls.UI.RadButton();
            this.gv_tt = new Telerik.WinControls.UI.RadGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenlop = new Telerik.WinControls.UI.RadTextBox();
            this.txt_malop = new Telerik.WinControls.UI.RadTextBox();
            this.dd_khoi = new Telerik.WinControls.UI.RadDropDownList();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_huy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_malop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dd_khoi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Quanlyhososinhcap3.Properties.Resources.top1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 63);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
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
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.PapayaWhip;
            this.bt_huy.Location = new System.Drawing.Point(779, 39);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(98, 35);
            this.bt_huy.TabIndex = 30;
            this.bt_huy.Text = "Hủy";
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
            // gv_tt
            // 
            this.gv_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.gv_tt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_tt.Location = new System.Drawing.Point(0, 405);
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
            this.gv_tt.Size = new System.Drawing.Size(1184, 206);
            this.gv_tt.TabIndex = 32;
            this.gv_tt.ThemeName = "ControlDefault";
            this.gv_tt.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gv_tt_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã Lớp";
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenlop.Location = new System.Drawing.Point(542, 179);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.ReadOnly = true;
            this.txt_tenlop.Size = new System.Drawing.Size(178, 25);
            this.txt_tenlop.TabIndex = 35;
            // 
            // txt_malop
            // 
            this.txt_malop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_malop.Location = new System.Drawing.Point(216, 179);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.ReadOnly = true;
            this.txt_malop.Size = new System.Drawing.Size(178, 25);
            this.txt_malop.TabIndex = 34;
            // 
            // dd_khoi
            // 
            this.dd_khoi.Enabled = false;
            this.dd_khoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd_khoi.Location = new System.Drawing.Point(852, 179);
            this.dd_khoi.Name = "dd_khoi";
            this.dd_khoi.ReadOnly = true;
            this.dd_khoi.Size = new System.Drawing.Size(178, 25);
            this.dd_khoi.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Khối";
            // 
            // frmlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.dd_khoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenlop);
            this.Controls.Add(this.txt_malop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gv_tt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlop";
            this.Text = "frmlop";
            this.Load += new System.EventHandler(this.frmlop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_huy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_malop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dd_khoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton bt_xoa;
        private Telerik.WinControls.UI.RadButton bt_huy;
        private Telerik.WinControls.UI.RadButton bt_them;
        private Telerik.WinControls.UI.RadButton bt_sua;
        private Telerik.WinControls.UI.RadButton bt_luu;
        private Telerik.WinControls.UI.RadGridView gv_tt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txt_tenlop;
        private Telerik.WinControls.UI.RadTextBox txt_malop;
        private Telerik.WinControls.UI.RadDropDownList dd_khoi;
        private System.Windows.Forms.Label label5;
    }
}