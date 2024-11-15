namespace AppQuanLyDatVeXe
{
    partial class FormDangKy
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkDN = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongBaoPass = new System.Windows.Forms.Label();
            this.lblThongBaoSDT = new System.Windows.Forms.Label();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ckcHienPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.lblThongBaoNhapLai = new System.Windows.Forms.Label();
            this.txtNhapLaiPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckxHienPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppQuanLyDatVeXe.Properties.Resources.Screenshot_2024_10_25_105843;
            this.pictureBox1.Location = new System.Drawing.Point(446, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkDN
            // 
            this.linkDN.AutoSize = true;
            this.linkDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDN.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(82)))), ((int)(((byte)(34)))));
            this.linkDN.Location = new System.Drawing.Point(156, 546);
            this.linkDN.Name = "linkDN";
            this.linkDN.Size = new System.Drawing.Size(118, 26);
            this.linkDN.TabIndex = 32;
            this.linkDN.TabStop = true;
            this.linkDN.Text = "Đăng nhập";
            this.linkDN.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkDN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDN_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Đã có tài khoản?";
            // 
            // lblThongBaoPass
            // 
            this.lblThongBaoPass.AutoSize = true;
            this.lblThongBaoPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBaoPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.lblThongBaoPass.Location = new System.Drawing.Point(30, 303);
            this.lblThongBaoPass.Name = "lblThongBaoPass";
            this.lblThongBaoPass.Size = new System.Drawing.Size(57, 25);
            this.lblThongBaoPass.TabIndex = 30;
            this.lblThongBaoPass.Text = "lblTB";
            this.lblThongBaoPass.Visible = false;
            // 
            // lblThongBaoSDT
            // 
            this.lblThongBaoSDT.AutoSize = true;
            this.lblThongBaoSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBaoSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.lblThongBaoSDT.Location = new System.Drawing.Point(30, 180);
            this.lblThongBaoSDT.Name = "lblThongBaoSDT";
            this.lblThongBaoSDT.Size = new System.Drawing.Size(57, 25);
            this.lblThongBaoSDT.TabIndex = 29;
            this.lblThongBaoSDT.Text = "lblTB";
            this.lblThongBaoSDT.Visible = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 30;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(82)))), ((int)(((byte)(34)))));
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(24, 463);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(390, 56);
            this.btnDangKy.TabIndex = 28;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtPass
            // 
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPass.BorderRadius = 10;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txtPass.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txtPass.IconLeft = global::AppQuanLyDatVeXe.Properties.Resources.icons8_password_26;
            this.txtPass.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPass.Location = new System.Drawing.Point(24, 242);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(13);
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "Nhập mật khẩu";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(390, 57);
            this.txtPass.TabIndex = 27;
            this.txtPass.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(82)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(29, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTenUser
            // 
            this.txtTenUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTenUser.BorderRadius = 10;
            this.txtTenUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenUser.DefaultText = "";
            this.txtTenUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txtTenUser.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txtTenUser.IconLeft = global::AppQuanLyDatVeXe.Properties.Resources.icons8_user_26;
            this.txtTenUser.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtTenUser.Location = new System.Drawing.Point(24, 119);
            this.txtTenUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenUser.Name = "txtTenUser";
            this.txtTenUser.Padding = new System.Windows.Forms.Padding(13);
            this.txtTenUser.PasswordChar = '\0';
            this.txtTenUser.PlaceholderText = "Nhập tên người dùng";
            this.txtTenUser.SelectedText = "";
            this.txtTenUser.Size = new System.Drawing.Size(390, 57);
            this.txtTenUser.TabIndex = 25;
            this.txtTenUser.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(82)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Đăng ký tài khoản";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1071, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(65, 43);
            this.guna2ControlBox3.TabIndex = 22;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1136, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(65, 43);
            this.guna2ControlBox1.TabIndex = 21;
            // 
            // ckcHienPass
            // 
            this.ckcHienPass.CheckedState.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_eye_50;
            this.ckcHienPass.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_invisible_50;
            this.ckcHienPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.ckcHienPass.ImageRotate = 0F;
            this.ckcHienPass.Location = new System.Drawing.Point(367, 254);
            this.ckcHienPass.Name = "ckcHienPass";
            this.ckcHienPass.Size = new System.Drawing.Size(41, 32);
            this.ckcHienPass.TabIndex = 33;
            this.ckcHienPass.CheckedChanged += new System.EventHandler(this.ckcHienPass_CheckedChanged);
            // 
            // lblThongBaoNhapLai
            // 
            this.lblThongBaoNhapLai.AutoSize = true;
            this.lblThongBaoNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBaoNhapLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.lblThongBaoNhapLai.Location = new System.Drawing.Point(25, 426);
            this.lblThongBaoNhapLai.Name = "lblThongBaoNhapLai";
            this.lblThongBaoNhapLai.Size = new System.Drawing.Size(57, 25);
            this.lblThongBaoNhapLai.TabIndex = 36;
            this.lblThongBaoNhapLai.Text = "lblTB";
            this.lblThongBaoNhapLai.Visible = false;
            // 
            // txtNhapLaiPass
            // 
            this.txtNhapLaiPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNhapLaiPass.BorderRadius = 10;
            this.txtNhapLaiPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiPass.DefaultText = "";
            this.txtNhapLaiPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLaiPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLaiPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNhapLaiPass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txtNhapLaiPass.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txtNhapLaiPass.IconLeft = global::AppQuanLyDatVeXe.Properties.Resources.icons8_password_26;
            this.txtNhapLaiPass.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtNhapLaiPass.Location = new System.Drawing.Point(20, 365);
            this.txtNhapLaiPass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNhapLaiPass.Name = "txtNhapLaiPass";
            this.txtNhapLaiPass.Padding = new System.Windows.Forms.Padding(13);
            this.txtNhapLaiPass.PasswordChar = '*';
            this.txtNhapLaiPass.PlaceholderText = "Nhập lại mật khẩu";
            this.txtNhapLaiPass.SelectedText = "";
            this.txtNhapLaiPass.Size = new System.Drawing.Size(390, 57);
            this.txtNhapLaiPass.TabIndex = 35;
            this.txtNhapLaiPass.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(82)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(25, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nhập lại mật khẩu";
            // 
            // ckxHienPass
            // 
            this.ckxHienPass.CheckedState.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_eye_50;
            this.ckxHienPass.Image = global::AppQuanLyDatVeXe.Properties.Resources.icons8_invisible_50;
            this.ckxHienPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.ckxHienPass.ImageRotate = 0F;
            this.ckxHienPass.Location = new System.Drawing.Point(367, 378);
            this.ckxHienPass.Name = "ckxHienPass";
            this.ckxHienPass.Size = new System.Drawing.Size(41, 32);
            this.ckxHienPass.TabIndex = 37;
            this.ckxHienPass.CheckedChanged += new System.EventHandler(this.ckxHienPass_CheckedChanged);
            // 
            // FormDangKy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 597);
            this.Controls.Add(this.ckxHienPass);
            this.Controls.Add(this.lblThongBaoNhapLai);
            this.Controls.Add(this.txtNhapLaiPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckcHienPass);
            this.Controls.Add(this.linkDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblThongBaoPass);
            this.Controls.Add(this.lblThongBaoSDT);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangKy";
            this.Text = "FormDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongBaoPass;
        private System.Windows.Forms.Label lblThongBaoSDT;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTenUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox ckcHienPass;
        private Guna.UI2.WinForms.Guna2ImageCheckBox ckxHienPass;
        private System.Windows.Forms.Label lblThongBaoNhapLai;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiPass;
        private System.Windows.Forms.Label label6;
    }
}