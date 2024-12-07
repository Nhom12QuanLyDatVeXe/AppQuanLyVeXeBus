namespace AppQuanLyDatVeXe
{
    partial class FormVeXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDSVX = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvCTPDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbBienSoXe = new System.Windows.Forms.Label();
            this.lbKH = new System.Windows.Forms.Label();
            this.lbGioXuatBen = new System.Windows.Forms.Label();
            this.lbNgayDi = new System.Windows.Forms.Label();
            this.lbTuyenXe = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnXuatVe = new Guna.UI2.WinForms.Guna2Button();
            this.mp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSVX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPDV)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "> Danh sách vé xe";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnXuatExcel);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1618, 128);
            this.guna2Panel1.TabIndex = 14;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AutoRoundedCorners = true;
            this.btnXuatExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatExcel.BorderRadius = 29;
            this.btnXuatExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(35, 62);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(225, 60);
            this.btnXuatExcel.TabIndex = 9;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(201)))));
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderThickness = 3;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(118)))), ((int)(((byte)(49)))));
            this.txtTimKiem.IconRight = global::AppQuanLyDatVeXe.Properties.Resources.icons8_find_26;
            this.txtTimKiem.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimKiem.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtTimKiem.Location = new System.Drawing.Point(769, 69);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(432, 53);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextOffset = new System.Drawing.Point(20, 0);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvDSVX
            // 
            this.dgvDSVX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSVX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSVX.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSVX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSVX.ColumnHeadersHeight = 42;
            this.dgvDSVX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSVX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieu,
            this.maKH,
            this.slGhe,
            this.tongTien,
            this.TrangThai,
            this.btnHuy,
            this.btnThanhToan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSVX.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSVX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSVX.Location = new System.Drawing.Point(35, 132);
            this.dgvDSVX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSVX.Name = "dgvDSVX";
            this.dgvDSVX.ReadOnly = true;
            this.dgvDSVX.RowHeadersVisible = false;
            this.dgvDSVX.RowHeadersWidth = 62;
            this.dgvDSVX.RowTemplate.Height = 28;
            this.dgvDSVX.Size = new System.Drawing.Size(1167, 282);
            this.dgvDSVX.TabIndex = 15;
            this.dgvDSVX.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSVX.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSVX.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSVX.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSVX.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSVX.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDSVX.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSVX.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvDSVX.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSVX.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSVX.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSVX.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSVX.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvDSVX.ThemeStyle.ReadOnly = true;
            this.dgvDSVX.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSVX.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSVX.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSVX.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSVX.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDSVX.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSVX.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSVX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellContentClick);
            // 
            // maPhieu
            // 
            this.maPhieu.DataPropertyName = "MaPhieu";
            this.maPhieu.FillWeight = 74.03846F;
            this.maPhieu.HeaderText = "Mã phiếu";
            this.maPhieu.MinimumWidth = 8;
            this.maPhieu.Name = "maPhieu";
            this.maPhieu.ReadOnly = true;
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "MaKH";
            this.maKH.FillWeight = 74.03846F;
            this.maKH.HeaderText = "Mã khách hàng";
            this.maKH.MinimumWidth = 8;
            this.maKH.Name = "maKH";
            this.maKH.ReadOnly = true;
            // 
            // slGhe
            // 
            this.slGhe.DataPropertyName = "SoLuongGhe";
            this.slGhe.FillWeight = 74.03846F;
            this.slGhe.HeaderText = "Số lượng ghế";
            this.slGhe.MinimumWidth = 8;
            this.slGhe.Name = "slGhe";
            this.slGhe.ReadOnly = true;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "TongTien";
            this.tongTien.FillWeight = 74.03846F;
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 8;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnHuy.FillWeight = 50F;
            this.btnHuy.HeaderText = "";
            this.btnHuy.MinimumWidth = 8;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ReadOnly = true;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseColumnTextForButtonValue = true;
            this.btnHuy.Width = 40;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnThanhToan.FillWeight = 50F;
            this.btnThanhToan.HeaderText = "";
            this.btnThanhToan.MinimumWidth = 8;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ReadOnly = true;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseColumnTextForButtonValue = true;
            this.btnThanhToan.Width = 140;
            // 
            // dgvCTPDV
            // 
            this.dgvCTPDV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCTPDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTPDV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTPDV.ColumnHeadersHeight = 42;
            this.dgvCTPDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTPDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mp,
            this.mg,
            this.dg});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPDV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTPDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTPDV.Location = new System.Drawing.Point(32, 430);
            this.dgvCTPDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCTPDV.Name = "dgvCTPDV";
            this.dgvCTPDV.ReadOnly = true;
            this.dgvCTPDV.RowHeadersVisible = false;
            this.dgvCTPDV.RowHeadersWidth = 62;
            this.dgvCTPDV.RowTemplate.Height = 28;
            this.dgvCTPDV.Size = new System.Drawing.Size(634, 330);
            this.dgvCTPDV.TabIndex = 16;
            this.dgvCTPDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTPDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTPDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTPDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTPDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTPDV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCTPDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTPDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvCTPDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTPDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCTPDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTPDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTPDV.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvCTPDV.ThemeStyle.ReadOnly = true;
            this.dgvCTPDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTPDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTPDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCTPDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTPDV.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCTPDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTPDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lbBienSoXe);
            this.guna2Panel2.Controls.Add(this.lbKH);
            this.guna2Panel2.Controls.Add(this.lbGioXuatBen);
            this.guna2Panel2.Controls.Add(this.lbNgayDi);
            this.guna2Panel2.Controls.Add(this.lbTuyenXe);
            this.guna2Panel2.Location = new System.Drawing.Point(689, 494);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(513, 330);
            this.guna2Panel2.TabIndex = 17;
            // 
            // lbBienSoXe
            // 
            this.lbBienSoXe.AutoSize = true;
            this.lbBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienSoXe.ForeColor = System.Drawing.Color.Black;
            this.lbBienSoXe.Location = new System.Drawing.Point(52, 102);
            this.lbBienSoXe.Name = "lbBienSoXe";
            this.lbBienSoXe.Size = new System.Drawing.Size(109, 25);
            this.lbBienSoXe.TabIndex = 27;
            this.lbBienSoXe.Text = "Biển số xe:";
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKH.ForeColor = System.Drawing.Color.Black;
            this.lbKH.Location = new System.Drawing.Point(52, 270);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(124, 25);
            this.lbKH.TabIndex = 27;
            this.lbKH.Text = "Khách hàng:";
            // 
            // lbGioXuatBen
            // 
            this.lbGioXuatBen.AutoSize = true;
            this.lbGioXuatBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioXuatBen.ForeColor = System.Drawing.Color.Black;
            this.lbGioXuatBen.Location = new System.Drawing.Point(52, 223);
            this.lbGioXuatBen.Name = "lbGioXuatBen";
            this.lbGioXuatBen.Size = new System.Drawing.Size(128, 25);
            this.lbGioXuatBen.TabIndex = 27;
            this.lbGioXuatBen.Text = "Giờ xuất bến:";
            // 
            // lbNgayDi
            // 
            this.lbNgayDi.AutoSize = true;
            this.lbNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDi.ForeColor = System.Drawing.Color.Black;
            this.lbNgayDi.Location = new System.Drawing.Point(52, 165);
            this.lbNgayDi.Name = "lbNgayDi";
            this.lbNgayDi.Size = new System.Drawing.Size(84, 25);
            this.lbNgayDi.TabIndex = 27;
            this.lbNgayDi.Text = "Ngày đi:";
            // 
            // lbTuyenXe
            // 
            this.lbTuyenXe.AutoSize = true;
            this.lbTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuyenXe.ForeColor = System.Drawing.Color.Black;
            this.lbTuyenXe.Location = new System.Drawing.Point(52, 45);
            this.lbTuyenXe.Name = "lbTuyenXe";
            this.lbTuyenXe.Size = new System.Drawing.Size(100, 25);
            this.lbTuyenXe.TabIndex = 27;
            this.lbTuyenXe.Text = "Tuyến xe:";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(2002, 985);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(10, 10);
            this.guna2CustomGradientPanel1.TabIndex = 18;
            // 
            // btnXuatVe
            // 
            this.btnXuatVe.AutoRoundedCorners = true;
            this.btnXuatVe.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatVe.BorderRadius = 29;
            this.btnXuatVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnXuatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatVe.ForeColor = System.Drawing.Color.White;
            this.btnXuatVe.Location = new System.Drawing.Point(708, 419);
            this.btnXuatVe.Name = "btnXuatVe";
            this.btnXuatVe.Size = new System.Drawing.Size(225, 60);
            this.btnXuatVe.TabIndex = 19;
            this.btnXuatVe.Text = "Xuất Vé Xe";
            this.btnXuatVe.Click += new System.EventHandler(this.btnXuatVe_Click);
            // 
            // mp
            // 
            this.mp.DataPropertyName = "MaPhieu";
            this.mp.HeaderText = "Mã phiếu";
            this.mp.MinimumWidth = 8;
            this.mp.Name = "mp";
            this.mp.ReadOnly = true;
            // 
            // mg
            // 
            this.mg.DataPropertyName = "MaGhe";
            this.mg.HeaderText = "Mã ghế";
            this.mg.MinimumWidth = 8;
            this.mg.Name = "mg";
            this.mg.ReadOnly = true;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "DonGia";
            this.dg.HeaderText = "Đơn giá";
            this.dg.MinimumWidth = 8;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            // 
            // FormVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1618, 918);
            this.Controls.Add(this.btnXuatVe);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.dgvCTPDV);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvDSVX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVeXe";
            this.Text = "FormVeXe";
            this.Load += new System.EventHandler(this.FormVeXe_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSVX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPDV)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSVX;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCTPDV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lbBienSoXe;
        private System.Windows.Forms.Label lbGioXuatBen;
        private System.Windows.Forms.Label lbNgayDi;
        private System.Windows.Forms.Label lbTuyenXe;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn slGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn btnHuy;
        private System.Windows.Forms.DataGridViewButtonColumn btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Button btnXuatVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
    }
}