namespace Quanlyhososinhcap3
{
    partial class MDImain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDImain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemfrmhocsinh = new System.Windows.Forms.ToolStripMenuItem();
            this.itemlop = new System.Windows.Forms.ToolStripMenuItem();
            this.itemkhoi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::Quanlyhososinhcap3.Properties.Resources.top1;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemfrmhocsinh,
            this.itemlop,
            this.itemkhoi,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1300, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // itemfrmhocsinh
            // 
            this.itemfrmhocsinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemfrmhocsinh.BackgroundImage")));
            this.itemfrmhocsinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemfrmhocsinh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemfrmhocsinh.ForeColor = System.Drawing.Color.Orange;
            this.itemfrmhocsinh.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.itemfrmhocsinh.Name = "itemfrmhocsinh";
            this.itemfrmhocsinh.Size = new System.Drawing.Size(132, 22);
            this.itemfrmhocsinh.Text = "Thông tin học sinh";
            this.itemfrmhocsinh.Click += new System.EventHandler(this.itemfrmhocsinh_Click);
            // 
            // itemlop
            // 
            this.itemlop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemlop.BackgroundImage")));
            this.itemlop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemlop.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemlop.ForeColor = System.Drawing.Color.Orange;
            this.itemlop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.itemlop.Name = "itemlop";
            this.itemlop.Size = new System.Drawing.Size(92, 22);
            this.itemlop.Text = "Quản lý lớp";
            this.itemlop.Click += new System.EventHandler(this.itemlop_Click);
            // 
            // itemkhoi
            // 
            this.itemkhoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemkhoi.BackgroundImage")));
            this.itemkhoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemkhoi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemkhoi.ForeColor = System.Drawing.Color.Orange;
            this.itemkhoi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.itemkhoi.Name = "itemkhoi";
            this.itemkhoi.Size = new System.Drawing.Size(97, 22);
            this.itemkhoi.Text = "Quản lý khối";
            this.itemkhoi.Click += new System.EventHandler(this.itemkhoi_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 23);
            this.toolStripMenuItem1.Text = "Hệ thống";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.quayLạiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.quayLạiToolStripMenuItem.Text = "Quay Lại";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // MDImain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDImain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDImain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem itemfrmhocsinh;
        private System.Windows.Forms.ToolStripMenuItem itemlop;
        private System.Windows.Forms.ToolStripMenuItem itemkhoi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
    }
}



