namespace Quanlyhososinhcap3
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.bttths = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.btngdung = new System.Windows.Forms.Button();
            this.tenngdung = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttths
            // 
            this.bttths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttths.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttths.ForeColor = System.Drawing.Color.Salmon;
            this.bttths.Location = new System.Drawing.Point(76, 57);
            this.bttths.Name = "bttths";
            this.bttths.Size = new System.Drawing.Size(253, 50);
            this.bttths.TabIndex = 0;
            this.bttths.Text = "Thông tin học sinh";
            this.bttths.UseVisualStyleBackColor = true;
            this.bttths.Click += new System.EventHandler(this.bttths_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btexit);
            this.panel2.Controls.Add(this.btlogout);
            this.panel2.Controls.Add(this.btngdung);
            this.panel2.Controls.Add(this.bttths);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 434);
            this.panel2.TabIndex = 2;
            // 
            // btexit
            // 
            this.btexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.ForeColor = System.Drawing.Color.Salmon;
            this.btexit.Location = new System.Drawing.Point(76, 323);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(253, 50);
            this.btexit.TabIndex = 5;
            this.btexit.Text = "Thoát";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btlogout
            // 
            this.btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.ForeColor = System.Drawing.Color.Salmon;
            this.btlogout.Location = new System.Drawing.Point(76, 236);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(253, 50);
            this.btlogout.TabIndex = 4;
            this.btlogout.Text = "Đăng xuất";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btngdung
            // 
            this.btngdung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngdung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngdung.ForeColor = System.Drawing.Color.Salmon;
            this.btngdung.Location = new System.Drawing.Point(76, 143);
            this.btngdung.Name = "btngdung";
            this.btngdung.Size = new System.Drawing.Size(253, 50);
            this.btngdung.TabIndex = 3;
            this.btngdung.Text = "Thông tin người dùng";
            this.btngdung.UseVisualStyleBackColor = true;
            this.btngdung.Click += new System.EventHandler(this.btngdung_Click);
            // 
            // tenngdung
            // 
            this.tenngdung.AutoSize = true;
            this.tenngdung.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenngdung.Location = new System.Drawing.Point(59, 282);
            this.tenngdung.Name = "tenngdung";
            this.tenngdung.Size = new System.Drawing.Size(42, 14);
            this.tenngdung.TabIndex = 6;
            this.tenngdung.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Quanlyhososinhcap3.Properties.Resources.st;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.tenngdung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 236);
            this.panel1.TabIndex = 1;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(420, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttths;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btngdung;
        private System.Windows.Forms.Label tenngdung;
    }
}