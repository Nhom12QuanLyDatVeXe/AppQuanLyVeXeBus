using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyDatVeXe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.AutoSize = true;
            f.AutoScaleMode = AutoScaleMode.Dpi;
            f.Dock= DockStyle.Fill;
            f.Show();
        }
        private void btnChuyenXe_Click(object sender, EventArgs e)
        {
            AddControls(new FormChuyenXe());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in CenterPanel.Controls)
            {
                ctrl.Dock = DockStyle.Fill;
            }
        }

        private void btnVeXe_Click(object sender, EventArgs e)
        {
            AddControls(new FormVeXe());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            AddControls(new FormThongTinKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            AddControls(new FormHoaDon());
        }

        private void btnPhuongTien_Click(object sender, EventArgs e)
        {
            AddControls(new FormPhuongTien());
        }
    }
}
