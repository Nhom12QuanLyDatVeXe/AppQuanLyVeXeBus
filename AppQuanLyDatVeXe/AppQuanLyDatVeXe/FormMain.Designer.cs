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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnPhuongTien = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnVeXe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChuyenXe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnPhuongTien);
            this.guna2Panel1.Controls.Add(this.btnHoaDon);
            this.guna2Panel1.Controls.Add(this.btnKhachHang);
            this.guna2Panel1.Controls.Add(this.btnVeXe);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnChuyenXe);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(326, 742);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.Controls.Add(this.btnMin);
            this.guna2Panel2.Controls.Add(this.btnMax);
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel2.Location = new System.Drawing.Point(326, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1174, 76);
            this.guna2Panel2.TabIndex = 1;
            // 
            // CenterPanel
            // 
            this.CenterPanel.CustomizableEdges.TopRight = false;
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CenterPanel.Location = new System.Drawing.Point(326, 76);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1174, 666);
            this.CenterPanel.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1095, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 44);
            this.btnClose.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1023, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(66, 44);
            this.btnMax.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(951, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(66, 44);
            this.btnMin.TabIndex = 2;
            // 
            // btnPhuongTien
            // 
            this.btnPhuongTien.AutoRoundedCorners = true;
            this.btnPhuongTien.BorderRadius = 35;
            this.btnPhuongTien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhuongTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhuongTien.CustomizableEdges.BottomRight = false;
            this.btnPhuongTien.CustomizableEdges.TopRight = false;
            this.btnPhuongTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhuongTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhuongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhuongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhuongTien.FillColor = System.Drawing.Color.White;
            this.btnPhuongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhuongTien.ForeColor = System.Drawing.Color.Black;
            this.btnPhuongTien.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_public_transportation_26;
            this.btnPhuongTien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhuongTien.Location = new System.Drawing.Point(41, 514);
            this.btnPhuongTien.Name = "btnPhuongTien";
            this.btnPhuongTien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPhuongTien.Size = new System.Drawing.Size(285, 72);
            this.btnPhuongTien.TabIndex = 5;
            this.btnPhuongTien.Text = "Phương tiện";
            this.btnPhuongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhuongTien.TextOffset = new System.Drawing.Point(20, 0);
            this.btnPhuongTien.Click += new System.EventHandler(this.btnPhuongTien_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AutoRoundedCorners = true;
            this.btnHoaDon.BorderRadius = 35;
            this.btnHoaDon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.CustomizableEdges.BottomRight = false;
            this.btnHoaDon.CustomizableEdges.TopRight = false;
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.FillColor = System.Drawing.Color.White;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_bill_26;
            this.btnHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoaDon.Location = new System.Drawing.Point(41, 438);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(285, 72);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoaDon.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AutoRoundedCorners = true;
            this.btnKhachHang.BorderRadius = 35;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.CustomizableEdges.BottomRight = false;
            this.btnKhachHang.CustomizableEdges.TopRight = false;
            this.btnKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHang.FillColor = System.Drawing.Color.White;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_user_account_26;
            this.btnKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.Location = new System.Drawing.Point(41, 362);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(285, 72);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Thông tin khách hàng";
            this.btnKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.TextOffset = new System.Drawing.Point(20, 0);
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnVeXe
            // 
            this.btnVeXe.AutoRoundedCorners = true;
            this.btnVeXe.BorderRadius = 35;
            this.btnVeXe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVeXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeXe.CustomizableEdges.BottomRight = false;
            this.btnVeXe.CustomizableEdges.TopRight = false;
            this.btnVeXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVeXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVeXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVeXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVeXe.FillColor = System.Drawing.Color.White;
            this.btnVeXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVeXe.ForeColor = System.Drawing.Color.Black;
            this.btnVeXe.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_ticket_26;
            this.btnVeXe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVeXe.Location = new System.Drawing.Point(41, 286);
            this.btnVeXe.Name = "btnVeXe";
            this.btnVeXe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVeXe.Size = new System.Drawing.Size(285, 72);
            this.btnVeXe.TabIndex = 2;
            this.btnVeXe.Text = "Vé xe";
            this.btnVeXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVeXe.TextOffset = new System.Drawing.Point(20, 0);
            this.btnVeXe.Click += new System.EventHandler(this.btnVeXe_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(65, 49);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(157, 133);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnChuyenXe
            // 
            this.btnChuyenXe.AutoRoundedCorners = true;
            this.btnChuyenXe.BorderRadius = 35;
            this.btnChuyenXe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChuyenXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenXe.CustomizableEdges.BottomRight = false;
            this.btnChuyenXe.CustomizableEdges.TopRight = false;
            this.btnChuyenXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyenXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyenXe.FillColor = System.Drawing.Color.White;
            this.btnChuyenXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenXe.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenXe.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_bus_26;
            this.btnChuyenXe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChuyenXe.Location = new System.Drawing.Point(41, 210);
            this.btnChuyenXe.Name = "btnChuyenXe";
            this.btnChuyenXe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChuyenXe.Size = new System.Drawing.Size(285, 72);
            this.btnChuyenXe.TabIndex = 0;
            this.btnChuyenXe.Text = "Chuyến xe";
            this.btnChuyenXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChuyenXe.TextOffset = new System.Drawing.Point(20, 0);
            this.btnChuyenXe.Click += new System.EventHandler(this.btnChuyenXe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 742);
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
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
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
    }
}

