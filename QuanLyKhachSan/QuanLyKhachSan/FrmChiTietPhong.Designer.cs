namespace QuanLyKhachSan
{
    partial class FrmChiTietPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietPhong));
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.tbMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.tbTinhTrang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThongTinPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(11, 35);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(82, 20);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại phòng";
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrang.Location = new System.Drawing.Point(640, 35);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(84, 20);
            this.lbTinhTrang.TabIndex = 2;
            this.lbTinhTrang.Text = "Tình trạng";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(102, 34);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(130, 22);
            this.tbMaPhong.TabIndex = 3;
            // 
            // tbMaLoaiPhong
            // 
            this.tbMaLoaiPhong.Location = new System.Drawing.Point(413, 35);
            this.tbMaLoaiPhong.Name = "tbMaLoaiPhong";
            this.tbMaLoaiPhong.Size = new System.Drawing.Size(130, 22);
            this.tbMaLoaiPhong.TabIndex = 4;
            // 
            // tbTinhTrang
            // 
            this.tbTinhTrang.Location = new System.Drawing.Point(735, 34);
            this.tbTinhTrang.Name = "tbTinhTrang";
            this.tbTinhTrang.Size = new System.Drawing.Size(130, 22);
            this.tbTinhTrang.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTinhTrang);
            this.panel1.Controls.Add(this.tbMaLoaiPhong);
            this.panel1.Controls.Add(this.tbMaPhong);
            this.panel1.Controls.Add(this.lbTinhTrang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbMaPhong);
            this.panel1.Location = new System.Drawing.Point(13, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 85);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbThongTinPhong);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 252);
            this.panel2.TabIndex = 7;
            // 
            // lbThongTinPhong
            // 
            this.lbThongTinPhong.AutoSize = true;
            this.lbThongTinPhong.BackColor = System.Drawing.Color.Transparent;
            this.lbThongTinPhong.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinPhong.ForeColor = System.Drawing.Color.Blue;
            this.lbThongTinPhong.Location = new System.Drawing.Point(282, 117);
            this.lbThongTinPhong.Name = "lbThongTinPhong";
            this.lbThongTinPhong.Size = new System.Drawing.Size(339, 41);
            this.lbThongTinPhong.TabIndex = 0;
            this.lbThongTinPhong.Text = "Thông tin chi tiết phòng";
            // 
            // FrmChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChiTietPhong";
            this.Text = "FrmChiTietPhong";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.TextBox tbMaLoaiPhong;
        private System.Windows.Forms.TextBox tbTinhTrang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbThongTinPhong;
    }
}