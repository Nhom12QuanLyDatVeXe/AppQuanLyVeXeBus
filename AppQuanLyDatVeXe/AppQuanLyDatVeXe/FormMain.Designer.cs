namespace AppQuanLyDatVeXe
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDatVe = new Guna.UI2.WinForms.Guna2Button();
            this.labelTenNguoiDung = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhuongTien = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnVeXe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChuyenXe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(201)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.btnDatVe);
            this.guna2Panel1.Controls.Add(this.labelTenNguoiDung);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.btnNhanVien);
            this.guna2Panel1.Controls.Add(this.btnPhuongTien);
            this.guna2Panel1.Controls.Add(this.btnHoaDon);
            this.guna2Panel1.Controls.Add(this.btnKhachHang);
            this.guna2Panel1.Controls.Add(this.btnVeXe);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnChuyenXe);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(394, 1106);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDatVe
            // 
            this.btnDatVe.AutoRoundedCorners = true;
            this.btnDatVe.BorderRadius = 35;
            this.btnDatVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDatVe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnDatVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatVe.CustomizableEdges.BottomRight = false;
            this.btnDatVe.CustomizableEdges.TopRight = false;
            this.btnDatVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatVe.FillColor = System.Drawing.Color.White;
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.ForeColor = System.Drawing.Color.Black;
            this.btnDatVe.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_ticket_26;
            this.btnDatVe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDatVe.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDatVe.Location = new System.Drawing.Point(14, 445);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatVe.Size = new System.Drawing.Size(376, 72);
            this.btnDatVe.TabIndex = 9;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDatVe.TextOffset = new System.Drawing.Point(30, 0);
            this.btnDatVe.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // labelTenNguoiDung
            // 
            this.labelTenNguoiDung.AutoSize = true;
            this.labelTenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNguoiDung.Location = new System.Drawing.Point(102, 237);
            this.labelTenNguoiDung.Name = "labelTenNguoiDung";
            this.labelTenNguoiDung.Size = new System.Drawing.Size(175, 26);
            this.labelTenNguoiDung.TabIndex = 8;
            this.labelTenNguoiDung.Text = "Tên người dùng";
            this.labelTenNguoiDung.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.BorderRadius = 35;
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnExit.Checked = true;
            this.btnExit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomizableEdges.BottomLeft = false;
            this.btnExit.CustomizableEdges.TopLeft = false;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_exit_26__1_;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnExit.Location = new System.Drawing.Point(2, 1002);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.PressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(262, 72);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.TextOffset = new System.Drawing.Point(30, 0);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AutoRoundedCorners = true;
            this.btnNhanVien.BorderRadius = 35;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.CustomizableEdges.BottomRight = false;
            this.btnNhanVien.CustomizableEdges.TopRight = false;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_employee_50;
            this.btnNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnNhanVien.Location = new System.Drawing.Point(14, 837);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(376, 72);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.TextOffset = new System.Drawing.Point(30, 0);
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnPhuongTien
            // 
            this.btnPhuongTien.AutoRoundedCorners = true;
            this.btnPhuongTien.BorderRadius = 35;
            this.btnPhuongTien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhuongTien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnPhuongTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhuongTien.CustomizableEdges.BottomRight = false;
            this.btnPhuongTien.CustomizableEdges.TopRight = false;
            this.btnPhuongTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhuongTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhuongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhuongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhuongTien.FillColor = System.Drawing.Color.White;
            this.btnPhuongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhuongTien.ForeColor = System.Drawing.Color.Black;
            this.btnPhuongTien.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_public_transportation_26;
            this.btnPhuongTien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhuongTien.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnPhuongTien.Location = new System.Drawing.Point(14, 758);
            this.btnPhuongTien.Name = "btnPhuongTien";
            this.btnPhuongTien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPhuongTien.Size = new System.Drawing.Size(376, 72);
            this.btnPhuongTien.TabIndex = 5;
            this.btnPhuongTien.Text = "Phương tiện";
            this.btnPhuongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhuongTien.TextOffset = new System.Drawing.Point(30, 0);
            this.btnPhuongTien.Click += new System.EventHandler(this.btnPhuongTien_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AutoRoundedCorners = true;
            this.btnHoaDon.BorderRadius = 35;
            this.btnHoaDon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHoaDon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.CustomizableEdges.BottomRight = false;
            this.btnHoaDon.CustomizableEdges.TopRight = false;
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.FillColor = System.Drawing.Color.White;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_bill_26;
            this.btnHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoaDon.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnHoaDon.Location = new System.Drawing.Point(14, 680);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(376, 72);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoaDon.TextOffset = new System.Drawing.Point(30, 0);
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AutoRoundedCorners = true;
            this.btnKhachHang.BorderRadius = 35;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.CustomizableEdges.BottomRight = false;
            this.btnKhachHang.CustomizableEdges.TopRight = false;
            this.btnKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHang.FillColor = System.Drawing.Color.White;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_user_account_26;
            this.btnKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnKhachHang.Location = new System.Drawing.Point(14, 602);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(376, 72);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Thông tin khách hàng";
            this.btnKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.TextOffset = new System.Drawing.Point(30, 0);
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnVeXe
            // 
            this.btnVeXe.AutoRoundedCorners = true;
            this.btnVeXe.BorderRadius = 35;
            this.btnVeXe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVeXe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnVeXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeXe.CustomizableEdges.BottomRight = false;
            this.btnVeXe.CustomizableEdges.TopRight = false;
            this.btnVeXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVeXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVeXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVeXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVeXe.FillColor = System.Drawing.Color.White;
            this.btnVeXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeXe.ForeColor = System.Drawing.Color.Black;
            this.btnVeXe.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_ticket_26;
            this.btnVeXe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVeXe.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnVeXe.Location = new System.Drawing.Point(14, 523);
            this.btnVeXe.Name = "btnVeXe";
            this.btnVeXe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVeXe.Size = new System.Drawing.Size(376, 72);
            this.btnVeXe.TabIndex = 2;
            this.btnVeXe.Text = "Thông tin vé xe";
            this.btnVeXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVeXe.TextOffset = new System.Drawing.Point(30, 0);
            this.btnVeXe.Click += new System.EventHandler(this.btnVeXe_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2PictureBox1.Image = global::AppQuanLyDatVeXe.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(88, 57);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 165);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnChuyenXe
            // 
            this.btnChuyenXe.AutoRoundedCorners = true;
            this.btnChuyenXe.BorderRadius = 35;
            this.btnChuyenXe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChuyenXe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnChuyenXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenXe.CustomizableEdges.BottomRight = false;
            this.btnChuyenXe.CustomizableEdges.TopRight = false;
            this.btnChuyenXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyenXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyenXe.FillColor = System.Drawing.Color.White;
            this.btnChuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenXe.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenXe.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_bus_26;
            this.btnChuyenXe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChuyenXe.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnChuyenXe.Location = new System.Drawing.Point(14, 366);
            this.btnChuyenXe.Name = "btnChuyenXe";
            this.btnChuyenXe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChuyenXe.Size = new System.Drawing.Size(376, 72);
            this.btnChuyenXe.TabIndex = 0;
            this.btnChuyenXe.Text = "Chuyến xe";
            this.btnChuyenXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChuyenXe.TextOffset = new System.Drawing.Point(30, 0);
            this.btnChuyenXe.Click += new System.EventHandler(this.btnChuyenXe_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.guna2Panel2.Controls.Add(this.btnMin);
            this.guna2Panel2.Controls.Add(this.btnMax);
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel2.Location = new System.Drawing.Point(394, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(992, 75);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(201)))));
            this.btnMin.IconColor = System.Drawing.Color.Black;
            this.btnMin.Location = new System.Drawing.Point(766, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(66, 45);
            this.btnMin.TabIndex = 2;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(201)))));
            this.btnMax.IconColor = System.Drawing.Color.Black;
            this.btnMax.Location = new System.Drawing.Point(838, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(66, 45);
            this.btnMax.TabIndex = 1;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(201)))));
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(910, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 45);
            this.btnClose.TabIndex = 0;
            // 
            // CenterPanel
            // 
            this.CenterPanel.AutoScroll = true;
            this.CenterPanel.CustomizableEdges.TopRight = false;
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CenterPanel.Location = new System.Drawing.Point(394, 75);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(992, 1031);
            this.CenterPanel.TabIndex = 99;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-employee-50.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 1106);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnChuyenXe;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPhuongTien;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnVeXe;
        private Guna.UI2.WinForms.Guna2ControlBox btnMin;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label labelTenNguoiDung;
        private Guna.UI2.WinForms.Guna2Button btnDatVe;
    }
}

