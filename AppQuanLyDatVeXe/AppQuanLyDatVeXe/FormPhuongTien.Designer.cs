namespace AppQuanLyDatVeXe
{
    partial class FormPhuongTien
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
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDSPT = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiXeChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiXePhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).BeginInit();
            this.SuspendLayout();
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
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(172, 54);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(10, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "> Danh sách phương tiện";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnThem);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1209, 128);
            this.guna2Panel1.TabIndex = 10;
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
            // 
            // dgvDSPT
            // 
            this.dgvDSPT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSPT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSPT.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSPT.ColumnHeadersHeight = 42;
            this.dgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bienSo,
            this.taiXeChinh,
            this.taiXePhu,
            this.soGhe,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSPT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSPT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSPT.Location = new System.Drawing.Point(33, 140);
            this.dgvDSPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSPT.Name = "dgvDSPT";
            this.dgvDSPT.RowHeadersVisible = false;
            this.dgvDSPT.RowHeadersWidth = 62;
            this.dgvDSPT.RowTemplate.Height = 28;
            this.dgvDSPT.Size = new System.Drawing.Size(1176, 691);
            this.dgvDSPT.TabIndex = 11;
            this.dgvDSPT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSPT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSPT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSPT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSPT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSPT.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDSPT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSPT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvDSPT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSPT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSPT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSPT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSPT.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvDSPT.ThemeStyle.ReadOnly = false;
            this.dgvDSPT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSPT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSPT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSPT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSPT.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDSPT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSPT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // bienSo
            // 
            this.bienSo.DataPropertyName = "BienSoXe";
            this.bienSo.HeaderText = "Biển số xe";
            this.bienSo.MinimumWidth = 8;
            this.bienSo.Name = "bienSo";
            // 
            // taiXeChinh
            // 
            this.taiXeChinh.DataPropertyName = "TaiXeChinh";
            this.taiXeChinh.HeaderText = "Tài xế chính";
            this.taiXeChinh.MinimumWidth = 8;
            this.taiXeChinh.Name = "taiXeChinh";
            // 
            // taiXePhu
            // 
            this.taiXePhu.DataPropertyName = "TaiXePhu";
            this.taiXePhu.HeaderText = "Tài xế phụ";
            this.taiXePhu.MinimumWidth = 8;
            this.taiXePhu.Name = "taiXePhu";
            // 
            // soGhe
            // 
            this.soGhe.DataPropertyName = "SoGhe";
            this.soGhe.HeaderText = "Số ghế";
            this.soGhe.MinimumWidth = 8;
            this.soGhe.Name = "soGhe";
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
            // FormPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 858);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvDSPT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPhuongTien";
            this.Text = "FormPhuongTien";
            this.Load += new System.EventHandler(this.FormPhuongTien_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiXeChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiXePhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGhe;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}