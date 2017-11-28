namespace QuanLyKhachSan
{
    partial class hethong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hethong));
            this.ibuser = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.ibpass = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butonextit = new System.Windows.Forms.Button();
            this.butonlogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngKiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đôiMâuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibuser
            // 
            this.ibuser.AutoSize = true;
            this.ibuser.Location = new System.Drawing.Point(132, 16);
            this.ibuser.Name = "ibuser";
            this.ibuser.Size = new System.Drawing.Size(58, 13);
            this.ibuser.TabIndex = 0;
            this.ibuser.Text = "User name";
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(248, 16);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(100, 20);
            this.tbuser.TabIndex = 1;
            this.tbuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ibpass
            // 
            this.ibpass.AutoSize = true;
            this.ibpass.Location = new System.Drawing.Point(137, 74);
            this.ibpass.Name = "ibpass";
            this.ibpass.Size = new System.Drawing.Size(53, 13);
            this.ibpass.TabIndex = 2;
            this.ibpass.Text = "Password";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(248, 67);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butonextit);
            this.groupBox1.Controls.Add(this.butonlogin);
            this.groupBox1.Controls.Add(this.ibuser);
            this.groupBox1.Controls.Add(this.tbpass);
            this.groupBox1.Controls.Add(this.ibpass);
            this.groupBox1.Controls.Add(this.tbuser);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = resources.GetString("groupBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // butonextit
            // 
            this.butonextit.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.icons8_logout_rounded_up_50;
            this.butonextit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butonextit.Cursor = System.Windows.Forms.Cursors.Help;
            this.butonextit.ImageKey = "(none)";
            this.butonextit.Location = new System.Drawing.Point(294, 132);
            this.butonextit.Name = "butonextit";
            this.butonextit.Size = new System.Drawing.Size(74, 21);
            this.butonextit.TabIndex = 6;
            this.butonextit.UseVisualStyleBackColor = true;
            this.butonextit.Click += new System.EventHandler(this.butonextit_Click);
            // 
            // butonlogin
            // 
            this.butonlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butonlogin.Location = new System.Drawing.Point(184, 131);
            this.butonlogin.Name = "butonlogin";
            this.butonlogin.Size = new System.Drawing.Size(75, 23);
            this.butonlogin.TabIndex = 4;
            this.butonlogin.Text = "Đăng nhập";
            this.butonlogin.UseVisualStyleBackColor = true;
            this.butonlogin.Click += new System.EventHandler(this.butonlogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngKiToolStripMenuItem
            // 
            this.đăngKiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đôiMâuToolStripMenuItem,
            this.đăngKiToolStripMenuItem1});
            this.đăngKiToolStripMenuItem.Name = "đăngKiToolStripMenuItem";
            this.đăngKiToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.đăngKiToolStripMenuItem.Text = "Tài khoản";
            // 
            // đôiMâuToolStripMenuItem
            // 
            this.đôiMâuToolStripMenuItem.Name = "đôiMâuToolStripMenuItem";
            this.đôiMâuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đôiMâuToolStripMenuItem.Text = "Đổi mẩu";
            // 
            // đăngKiToolStripMenuItem1
            // 
            this.đăngKiToolStripMenuItem1.Name = "đăngKiToolStripMenuItem1";
            this.đăngKiToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.đăngKiToolStripMenuItem1.Text = "Đăng kí ";
            // 
            // hethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.butonlogin;
            this.ClientSize = new System.Drawing.Size(461, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "hethong";
            this.Text = "hethong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibuser;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label ibpass;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonextit;
        private System.Windows.Forms.Button butonlogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngKiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đôiMâuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKiToolStripMenuItem1;
    }
}