namespace AppQuanLyDatVeXe
{
    partial class FormDatVeXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayDi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboDiemDen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDiemDi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTX)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.dtpNgayDi);
            this.guna2Panel1.Controls.Add(this.cboDiemDen);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.cboDiemDi);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1309, 157);
            this.guna2Panel1.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoRoundedCorners = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderRadius = 17;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(828, 83);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 36);
            this.btnTimKiem.TabIndex = 81;
            this.btnTimKiem.Text = "Tìm chuyến xe";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(564, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Ngày đi";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.BorderRadius = 15;
            this.dtpNgayDi.Checked = true;
            this.dtpNgayDi.CustomFormat = "";
            this.dtpNgayDi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(552, 83);
            this.dtpNgayDi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(197, 36);
            this.dtpNgayDi.TabIndex = 79;
            this.dtpNgayDi.Value = new System.DateTime(2024, 11, 16, 16, 28, 50, 632);
            // 
            // cboDiemDen
            // 
            this.cboDiemDen.BackColor = System.Drawing.Color.Transparent;
            this.cboDiemDen.BorderColor = System.Drawing.Color.Gray;
            this.cboDiemDen.BorderRadius = 15;
            this.cboDiemDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDiemDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDiemDen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboDiemDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDiemDen.ItemHeight = 30;
            this.cboDiemDen.Location = new System.Drawing.Point(292, 83);
            this.cboDiemDen.Name = "cboDiemDen";
            this.cboDiemDen.Size = new System.Drawing.Size(199, 36);
            this.cboDiemDen.TabIndex = 76;
            this.cboDiemDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDiemDi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(302, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Điểm đến";
            // 
            // cboDiemDi
            // 
            this.cboDiemDi.BackColor = System.Drawing.Color.Transparent;
            this.cboDiemDi.BorderColor = System.Drawing.Color.Gray;
            this.cboDiemDi.BorderRadius = 15;
            this.cboDiemDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDiemDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDiemDi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDiemDi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboDiemDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDiemDi.ItemHeight = 30;
            this.cboDiemDi.Location = new System.Drawing.Point(28, 83);
            this.cboDiemDi.Name = "cboDiemDi";
            this.cboDiemDi.Size = new System.Drawing.Size(199, 36);
            this.cboDiemDi.TabIndex = 74;
            this.cboDiemDi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDiemDi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Điểm đi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "> Danh sách chuyến xe còn vé";
            // 
            // dgvDSTX
            // 
            this.dgvDSTX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDSTX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSTX.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSTX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTX.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSTX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSTX.Location = new System.Drawing.Point(28, 161);
            this.dgvDSTX.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSTX.Name = "dgvDSTX";
            this.dgvDSTX.RowHeadersVisible = false;
            this.dgvDSTX.RowHeadersWidth = 62;
            this.dgvDSTX.RowTemplate.Height = 28;
            this.dgvDSTX.Size = new System.Drawing.Size(945, 517);
            this.dgvDSTX.TabIndex = 15;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Chọn";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 40;
            // 
            // FormDatVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 689);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvDSTX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatVeXe";
            this.Text = "FormDatVeXe";
            this.Load += new System.EventHandler(this.FormDatVeXe_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboDiemDen;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cboDiemDi;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayDi;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
    }
}