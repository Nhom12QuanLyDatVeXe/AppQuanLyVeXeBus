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
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDSNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioXuatBen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoangCach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "> Danh sách chuyến xe";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1451, 154);
            this.guna2Panel1.TabIndex = 12;
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
            this.txtTimKiem.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(118)))), ((int)(((byte)(49)))));
            this.txtTimKiem.IconRight = global::AppQuanLyDatVeXe.Properties.Resources.icons8_find_26;
            this.txtTimKiem.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimKiem.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtTimKiem.Location = new System.Drawing.Point(931, 83);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(520, 65);
            this.txtTimKiem.TabIndex = 8;
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSNV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSNV.ColumnHeadersHeight = 42;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChuyen,
            this.tenTuyen,
            this.tgDi,
            this.diemDi,
            this.diemDen,
            this.gioXuatBen,
            this.gioDenNoi,
            this.khoangCach,
            this.donGia,
            this.bienSo,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNV.Location = new System.Drawing.Point(40, 168);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersVisible = false;
            this.dgvDSNV.RowHeadersWidth = 62;
            this.dgvDSNV.RowTemplate.Height = 28;
            this.dgvDSNV.Size = new System.Drawing.Size(1411, 829);
            this.dgvDSNV.TabIndex = 13;
            this.dgvDSNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSNV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDSNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvDSNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSNV.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvDSNV.ThemeStyle.ReadOnly = false;
            this.dgvDSNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSNV.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDSNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maChuyen
            // 
            this.maChuyen.HeaderText = "Mã chuyến xe";
            this.maChuyen.MinimumWidth = 8;
            this.maChuyen.Name = "maChuyen";
            // 
            // tenTuyen
            // 
            this.tenTuyen.HeaderText = "Tên tuyến ";
            this.tenTuyen.MinimumWidth = 8;
            this.tenTuyen.Name = "tenTuyen";
            // 
            // tgDi
            // 
            this.tgDi.HeaderText = "Thời gian đi";
            this.tgDi.MinimumWidth = 8;
            this.tgDi.Name = "tgDi";
            // 
            // diemDi
            // 
            this.diemDi.HeaderText = "Điểm đi";
            this.diemDi.MinimumWidth = 8;
            this.diemDi.Name = "diemDi";
            // 
            // diemDen
            // 
            this.diemDen.HeaderText = "Điểm đến";
            this.diemDen.MinimumWidth = 8;
            this.diemDen.Name = "diemDen";
            // 
            // gioXuatBen
            // 
            this.gioXuatBen.HeaderText = "Giờ xuất bến";
            this.gioXuatBen.MinimumWidth = 8;
            this.gioXuatBen.Name = "gioXuatBen";
            // 
            // gioDenNoi
            // 
            this.gioDenNoi.HeaderText = "Giờ đến nơi";
            this.gioDenNoi.MinimumWidth = 8;
            this.gioDenNoi.Name = "gioDenNoi";
            // 
            // khoangCach
            // 
            this.khoangCach.HeaderText = "Khoảng cách";
            this.khoangCach.MinimumWidth = 8;
            this.khoangCach.Name = "khoangCach";
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 8;
            this.donGia.Name = "donGia";
            // 
            // bienSo
            // 
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
            this.Column1.Text = "Sửa";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Text = "Xóa";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 40;
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 31;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomizableEdges.TopLeft = false;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.guna2Button3.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_add_26;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button3.Location = new System.Drawing.Point(53, 76);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button3.Size = new System.Drawing.Size(206, 65);
            this.guna2Button3.TabIndex = 9;
            this.guna2Button3.Text = "Thêm";
            this.guna2Button3.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FormChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1451, 1030);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvDSNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenXe";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioXuatBen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoangCach;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSo;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}