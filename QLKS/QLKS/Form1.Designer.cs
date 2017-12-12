namespace QuanLyKhachSan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThanhToan = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiChu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPGNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPGThemNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPGKhachHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPGPhong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPGDichVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPGThanhToan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPGGhiChu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.ExpandCollapseItem.Id = 0;
            this.ribbon1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ribbon1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon1.ExpandCollapseItem,
            this.btnNhanVien,
            this.btnThemNhanVien,
            this.btnKhachHang,
            this.btnPhong,
            this.btnDichVu,
            this.btnThanhToan,
            this.btnGhiChu});
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon1.MaxItemId = 8;
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPNhanVien,
            this.ribbonPNghiepVu});
            this.ribbon1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon1.Size = new System.Drawing.Size(1164, 166);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Id = 1;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Id = 2;
            this.btnThemNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThemNhanVien.LargeGlyph")));
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNhanVien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Id = 3;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnPhong
            // 
            this.btnPhong.Id = 4;
            this.btnPhong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhong.LargeGlyph")));
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhong_ItemClick);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Id = 5;
            this.btnDichVu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDichVu.LargeGlyph")));
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDichVu_ItemClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Id = 6;
            this.btnThanhToan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.LargeGlyph")));
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThanhToan_ItemClick);
            // 
            // btnGhiChu
            // 
            this.btnGhiChu.Id = 7;
            this.btnGhiChu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGhiChu.LargeGlyph")));
            this.btnGhiChu.Name = "btnGhiChu";
            this.btnGhiChu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiChu_ItemClick);
            // 
            // ribbonPNhanVien
            // 
            this.ribbonPNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPGNhanVien,
            this.ribbonPGThemNhanVien});
            this.ribbonPNhanVien.Name = "ribbonPNhanVien";
            this.ribbonPNhanVien.Text = "Quản lý nhân viên";
            // 
            // ribbonPGNhanVien
            // 
            this.ribbonPGNhanVien.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPGNhanVien.Name = "ribbonPGNhanVien";
            this.ribbonPGNhanVien.Text = "Nhân viên";
            // 
            // ribbonPGThemNhanVien
            // 
            this.ribbonPGThemNhanVien.ItemLinks.Add(this.btnThemNhanVien);
            this.ribbonPGThemNhanVien.Name = "ribbonPGThemNhanVien";
            this.ribbonPGThemNhanVien.Text = "Thêm Nhân Viên";
            // 
            // ribbonPNghiepVu
            // 
            this.ribbonPNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPGKhachHang,
            this.ribbonPGPhong,
            this.ribbonPGDichVu,
            this.ribbonPGThanhToan,
            this.ribbonPGGhiChu});
            this.ribbonPNghiepVu.Name = "ribbonPNghiepVu";
            this.ribbonPNghiepVu.Text = "Nghiệp vụ";
            // 
            // ribbonPGKhachHang
            // 
            this.ribbonPGKhachHang.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPGKhachHang.Name = "ribbonPGKhachHang";
            this.ribbonPGKhachHang.Text = "Khách hàng";
            // 
            // ribbonPGPhong
            // 
            this.ribbonPGPhong.ItemLinks.Add(this.btnPhong);
            this.ribbonPGPhong.Name = "ribbonPGPhong";
            this.ribbonPGPhong.Text = "Phòng";
            // 
            // ribbonPGDichVu
            // 
            this.ribbonPGDichVu.ItemLinks.Add(this.btnDichVu);
            this.ribbonPGDichVu.Name = "ribbonPGDichVu";
            this.ribbonPGDichVu.Text = "Dịch Vụ";
            // 
            // ribbonPGThanhToan
            // 
            this.ribbonPGThanhToan.ItemLinks.Add(this.btnThanhToan);
            this.ribbonPGThanhToan.Name = "ribbonPGThanhToan";
            this.ribbonPGThanhToan.Text = "Thanh toán";
            // 
            // ribbonPGGhiChu
            // 
            this.ribbonPGGhiChu.ItemLinks.Add(this.btnGhiChu);
            this.ribbonPGGhiChu.Name = "ribbonPGGhiChu";
            this.ribbonPGGhiChu.Text = "Ghi chú";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 547);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbon1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnThemNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGThemNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnPhong;
        private DevExpress.XtraBars.BarButtonItem btnDichVu;
        private DevExpress.XtraBars.BarButtonItem btnThanhToan;
        private DevExpress.XtraBars.BarButtonItem btnGhiChu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGPhong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGDichVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGThanhToan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGGhiChu;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}

