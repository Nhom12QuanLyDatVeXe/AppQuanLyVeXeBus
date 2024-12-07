namespace AppQuanLyDatVeXe
{
    partial class FormChuyenXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDSTX = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaTuyenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioXuatBen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoangCach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "> Danh sách chuyến xe";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnThem);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1352, 128);
            this.guna2Panel1.TabIndex = 12;
            //this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 26;
            this.btnThem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.CustomizableEdges.TopLeft = false;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_add_26;
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnThem.Location = new System.Drawing.Point(44, 63);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(172, 54);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(10, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.txtTimKiem.Location = new System.Drawing.Point(776, 69);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(433, 54);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextOffset = new System.Drawing.Point(20, 0);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvDSTX
            // 
            this.dgvDSTX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSTX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSTX.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSTX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSTX.ColumnHeadersHeight = 42;
            this.dgvDSTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSTX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTuyenXe,
            this.tenTuyen,
            this.ThoiGianDi,
            this.diemDi,
            this.diemDen,
            this.gioXuatBen,
            this.gioDenNoi,
            this.khoangCach,
            this.donGia,
            this.bienSo,
            this.btnSua,
            this.btnXoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTX.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSTX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSTX.Location = new System.Drawing.Point(33, 140);
            this.dgvDSTX.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSTX.Name = "dgvDSTX";
            this.dgvDSTX.RowHeadersVisible = false;
            this.dgvDSTX.RowHeadersWidth = 62;
            this.dgvDSTX.RowTemplate.Height = 28;
            this.dgvDSTX.Size = new System.Drawing.Size(1167, 750);
            this.dgvDSTX.TabIndex = 13;
            this.dgvDSTX.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSTX.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSTX.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSTX.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSTX.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSTX.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDSTX.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSTX.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvDSTX.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSTX.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSTX.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSTX.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSTX.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvDSTX.ThemeStyle.ReadOnly = false;
            this.dgvDSTX.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSTX.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSTX.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSTX.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSTX.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDSTX.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSTX.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSTX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTX_CellContentClick);
            this.dgvDSTX.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSTX_CellFormatting);
            // 
            // MaTuyenXe
            // 
            this.MaTuyenXe.DataPropertyName = "MaTuyenXe";
            this.MaTuyenXe.HeaderText = "Mã chuyến xe";
            this.MaTuyenXe.MinimumWidth = 8;
            this.MaTuyenXe.Name = "MaTuyenXe";
            // 
            // tenTuyen
            // 
            this.tenTuyen.DataPropertyName = "TenTuyen";
            this.tenTuyen.HeaderText = "Tên tuyến ";
            this.tenTuyen.MinimumWidth = 8;
            this.tenTuyen.Name = "tenTuyen";
            // 
            // ThoiGianDi
            // 
            this.ThoiGianDi.DataPropertyName = "ThoiGianDi";
            this.ThoiGianDi.HeaderText = "Thời gian đi";
            this.ThoiGianDi.MinimumWidth = 8;
            this.ThoiGianDi.Name = "ThoiGianDi";
            // 
            // diemDi
            // 
            this.diemDi.DataPropertyName = "DiemDi";
            this.diemDi.HeaderText = "Điểm đi";
            this.diemDi.MinimumWidth = 8;
            this.diemDi.Name = "diemDi";
            // 
            // diemDen
            // 
            this.diemDen.DataPropertyName = "DiemDen";
            this.diemDen.HeaderText = "Điểm đến";
            this.diemDen.MinimumWidth = 8;
            this.diemDen.Name = "diemDen";
            // 
            // gioXuatBen
            // 
            this.gioXuatBen.DataPropertyName = "GioXuatBen";
            this.gioXuatBen.HeaderText = "Giờ xuất bến";
            this.gioXuatBen.MinimumWidth = 8;
            this.gioXuatBen.Name = "gioXuatBen";
            // 
            // gioDenNoi
            // 
            this.gioDenNoi.DataPropertyName = "GioDenNoi";
            this.gioDenNoi.HeaderText = "Giờ đến nơi";
            this.gioDenNoi.MinimumWidth = 8;
            this.gioDenNoi.Name = "gioDenNoi";
            // 
            // khoangCach
            // 
            this.khoangCach.DataPropertyName = "KhoangCach";
            this.khoangCach.HeaderText = "Khoảng cách";
            this.khoangCach.MinimumWidth = 8;
            this.khoangCach.Name = "khoangCach";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "DonGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 8;
            this.donGia.Name = "donGia";
            // 
            // bienSo
            // 
            this.bienSo.DataPropertyName = "BienSoXe";
            this.bienSo.HeaderText = "Biển số xe";
            this.bienSo.MinimumWidth = 8;
            this.bienSo.Name = "bienSo";
            // 
            // btnSua
            // 
            this.btnSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnSua.DataPropertyName = "btnSua";
            this.btnSua.FillWeight = 50F;
            this.btnSua.HeaderText = "";
            this.btnSua.MinimumWidth = 8;
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Sửa";
            this.btnSua.UseColumnTextForButtonValue = true;
            this.btnSua.Width = 40;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnXoa.DataPropertyName = "btnXoa";
            this.btnXoa.FillWeight = 50F;
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 8;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
            this.btnXoa.Width = 40;
            // 
            // FormChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1352, 918);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvDSTX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenXe";
            this.Load += new System.EventHandler(this.FormChuyenXe_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTuyenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioXuatBen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoangCach;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSo;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}