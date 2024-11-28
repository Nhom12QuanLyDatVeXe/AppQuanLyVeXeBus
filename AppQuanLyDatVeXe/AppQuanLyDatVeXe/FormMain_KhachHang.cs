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
    public partial class FormMain_KhachHang : Form
    {
        public FormMain_KhachHang()
        {
            InitializeComponent();
        }

        private void FormMain_KhachHang_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }
    }
}
