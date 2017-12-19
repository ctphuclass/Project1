namespace DoAnQuanLyKhachSan
{
    partial class SuLyPhieuDatPhong
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
            this.tbMP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_NP = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMP
            // 
            this.tbMP.BackColor = System.Drawing.SystemColors.Control;
            this.tbMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMP.Enabled = false;
            this.tbMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMP.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbMP.Location = new System.Drawing.Point(500, 64);
            this.tbMP.Margin = new System.Windows.Forms.Padding(4);
            this.tbMP.Name = "tbMP";
            this.tbMP.Size = new System.Drawing.Size(131, 19);
            this.tbMP.TabIndex = 768;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(350, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 767;
            this.label12.Text = "Mã Phòng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(416, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 37);
            this.button1.TabIndex = 770;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_NP
            // 
            this.bt_NP.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_NP.Location = new System.Drawing.Point(283, 108);
            this.bt_NP.Margin = new System.Windows.Forms.Padding(4);
            this.bt_NP.Name = "bt_NP";
            this.bt_NP.Size = new System.Drawing.Size(221, 37);
            this.bt_NP.TabIndex = 769;
            this.bt_NP.Text = "Nhận Phòng";
            this.bt_NP.UseVisualStyleBackColor = false;
            this.bt_NP.Click += new System.EventHandler(this.bt_NP_Click);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btHuy.Location = new System.Drawing.Point(529, 108);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(221, 37);
            this.btHuy.TabIndex = 769;
            this.btHuy.Text = "Hủy Phòng";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // SuLyPhieuDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.bt_NP);
            this.Controls.Add(this.tbMP);
            this.Controls.Add(this.label12);
            this.Name = "SuLyPhieuDatPhong";
            this.Text = "SuLyPhieuDatPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbMP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_NP;
        private System.Windows.Forms.Button btHuy;
    }
}