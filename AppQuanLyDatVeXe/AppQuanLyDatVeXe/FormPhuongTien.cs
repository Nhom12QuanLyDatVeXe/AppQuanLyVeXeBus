using AppQuanLyDatVeXe.FormChiTiet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using System.Web.WebSockets;

namespace AppQuanLyDatVeXe
{
    public partial class FormPhuongTien : Form
    {
        public FormPhuongTien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTPT ctpt=new FormCTPT();
            ctpt.Owner = this;
            ctpt.ShowDialog();
        }

        PhuongTien_BUL PT_BUL = new PhuongTien_BUL();
        private void FormPhuongTien_Load(object sender, EventArgs e)
        {
            loadPT();
        }

        public void loadPT()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = PT_BUL.GetPhuongTien();
            dgvDSPT.DataSource = bindingSource;

            //dgvDSPT.DataSource = null;
            //dgvDSPT.DataSource = PT_BUL.GetPhuongTien();

        }

        private void dgvDSPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDSPT.Columns["btnSua"].Index && e.RowIndex>=0)
            {
                try
                {
                    DataGridViewRow row = dgvDSPT.Rows[e.RowIndex];
                    PhuongTien_DTO pt = new PhuongTien_DTO
                    {
                        BienSoXe = row.Cells["bienSo"].Value.ToString(),
                        TaiXeChinh = row.Cells["taiXeChinh"].Value.ToString(),
                        TaiXePhu = row.Cells["taiXePhu"].Value.ToString(),
                        SoGhe = Convert.ToInt32(row.Cells["soGhe"].Value),
                    };
                    bool result = PT_BUL.SuaPT(pt);
                    if(result)
                    {
                        MessageBox.Show("Cập nhật phương tiện thành công");
                        loadPT();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phương tiện thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
            else if(e.ColumnIndex == dgvDSPT.Columns["btnXoa"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDSPT.Rows[e.RowIndex];
                    DialogResult dialogResult = MessageBox.Show(
                       "Bạn có chắc chắn muốn xóa phương tiện này không?",
                       "Xác nhận xóa",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning
                   );

                    if (dialogResult == DialogResult.Yes)
                    {
                        PhuongTien_DTO pt = new PhuongTien_DTO
                        {
                            BienSoXe = row.Cells["bienSo"].Value.ToString(),
                        };

                        bool result = PT_BUL.XoaPT(pt);
                        if (result)
                        {
                            MessageBox.Show("Xóa phương tiện thành công", "Thông báo");
                            loadPT();
                        }
                        else
                        {
                            MessageBox.Show("Xóa phương tiện thất bại", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hủy thao tác.", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = PT_BUL.GetPhuongTiens(txtTimKiem.Text);
            dgvDSPT.DataSource = bindingSource;
        }
    }
}
