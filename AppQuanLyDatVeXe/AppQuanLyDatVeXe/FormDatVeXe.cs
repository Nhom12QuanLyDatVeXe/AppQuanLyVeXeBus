using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
using System.Security.Cryptography;



namespace AppQuanLyDatVeXe
{
    public partial class FormDatVeXe : Form
    {
        TuyenXe_BUL CX_BUL = new TuyenXe_BUL();
        TinhThanh_BUL bul_tinhthanh = new TinhThanh_BUL();
        PhuongTien_BUL bul_pt = new PhuongTien_BUL();
        PhieuDatVe_BUL bul_phieudv = new PhieuDatVe_BUL();
        public FormDatVeXe()
        {
            InitializeComponent();
        }

        private void FormDatVeXe_Load(object sender, EventArgs e)
        {
            LoadCX();
            loadDiemDi_den();
            loadComboKH();
            dgvDSTX.Width = 1550;
            cboDiemDen.DropDownStyle = ComboBoxStyle.DropDown;
            cboDiemDi.DropDownStyle = ComboBoxStyle.DropDown;
            dgvDSTX.AutoGenerateColumns = false;
            setNull(false);
        }

        void setNull(bool check)
        {
            panelThongTinDatve.Visible = check;
            panelDsGheChon.Visible = check;
            btnTangDuoi.Visible = check;
            btnTangTren.Visible = check;
        }
        public void LoadCX()
        {
            dgvDSTX.DataSource = null;
            dgvDSTX.DataSource = CX_BUL.GetTuyenXe();
        }
        void loadDiemDi_den()
        {
            cboDiemDi.DataSource = bul_tinhthanh.getAll();
            cboDiemDi.DisplayMember = "TenTinh";
            cboDiemDi.ValueMember = "MaTinh";


            cboDiemDen.DataSource = bul_tinhthanh.getAll();
            cboDiemDen.DisplayMember = "TenTinh";
            cboDiemDen.ValueMember = "MaTinh";

        }
        private void dgvDSTX_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSTX.Columns[e.ColumnIndex].Name == "ThoiGianDi" && e.Value is DateTime dateTime)
            {
                e.Value = dateTime.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private void cboDiemDi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
        public void LoadCX(string diemdi, string diemden, DateTime ngaydi)
        {
            dgvDSTX.DataSource = null;
            dgvDSTX.DataSource = CX_BUL.GetTuyenXe(diemdi, diemden, ngaydi);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboDiemDi.SelectedIndex < 0 || cboDiemDen.SelectedIndex < 0)
            { return; }    
            LoadCX(cboDiemDi.SelectedValue.ToString(), cboDiemDen.SelectedValue.ToString(), dtpNgayDi.Value);
        }



        private List<string> danhSachGheDaChon = new List<string>();


        void taoGhe(int soghe, bool tang) //true là dưới, false là trên
        {
            int top = 70;
            int left = 30;
            panelThongTinDatve.Controls.Clear();

            // Xác định màu nền và tiền tố tên nút dựa trên tầng
            Color backgroundColor = tang ? btnTangTren.BackColor : btnTangDuoi.BackColor;
            Color toggledColor = Color.Gray;
            string prefix = tang ? "SB" : "ST";

            // Lấy danh sách các ghế đã được đặt từ CSDL
            var gheDaDat = bul_phieudv.GetGheDaDat(matuyen);

            // Hiển thị ghế
            for (int i = 1; i <= soghe / 2; i++)
            {
                Button btn = new Button();
                btn.Text = $"{prefix}{i}";
                btn.Name = $"{prefix}{i}"; // Tạo tên duy nhất cho mỗi nút ghế
                btn.Width = 30;
                btn.Height = 40;
                btn.Left = left;
                btn.Top = top;

                btn.BackColor = Color.WhiteSmoke;

                // Kiểm tra nếu ghế đã được đặt
                if (gheDaDat.Contains(btn.Name))
                {
                    btn.BackColor = toggledColor;
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = backgroundColor; // Hiển thị màu sáng mặc định
                }

                if (danhSachGheDaChon.Contains(btn.Name))
                {
                    btn.BackColor = toggledColor; // Hiển thị màu "tối" nếu đã được chọn
                }
                else
                {
                    btn.BackColor = backgroundColor; // Hiển thị màu sáng mặc định
                }

                // Đăng ký sự kiện click
                btn.Click += (sender, e) =>
                {
                    Button clickedButton = sender as Button;

                    // Đổi màu nền giữa hai trạng thái
                    if (clickedButton.BackColor == backgroundColor)
                    {
                        clickedButton.BackColor = toggledColor; // Đổi sang màu tối
                        if (!danhSachGheDaChon.Contains(clickedButton.Name))
                        {
                            danhSachGheDaChon.Add(clickedButton.Name); // Thêm tên nút vào danh sách
                            tongtien += dongia;
                        }
                    }
                    else
                    {
                        clickedButton.BackColor = backgroundColor; // Đổi lại màu sáng
                        danhSachGheDaChon.Remove(clickedButton.Name);
                        tongtien -= dongia;
                    }

                    // Hiển thị danh sách ghế đã chọn (nếu cần)
                    lbDSGhe.Text = $"{string.Join(", ", danhSachGheDaChon)}";
                    lbTongTien.Text = $"{tongtien:N0} VND";
                };

                panelThongTinDatve.Controls.Add(btn);

                // Cập nhật vị trí nút tiếp theo
                if (i > 18)
                {
                    left += 30; // Khoảng cách hẹp hơn sau hàng thứ 18
                }
                else
                {
                    left += 60;
                }

                if (i % 3 == 0 && i <= 18)
                {
                    left = 30;
                    top += 50;
                }
            }
        }

        string biensoxe;
        string matuyen;
        int soghe = 0;
        double dongia = 0;
        double tongtien = 0;
        private void dgvDSTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvDSTX.Columns["btnChon"].Index && e.RowIndex >= 0)
            {
                var selectedRow = dgvDSTX.Rows[e.RowIndex]; //Dữ liệu dòng đã nhấn
                matuyen = selectedRow.Cells["MaTuyenXe"].Value.ToString();
                biensoxe = selectedRow.Cells["BienSo"].Value.ToString();
                dongia = double.Parse(selectedRow.Cells["DonGia"].Value.ToString());
                lbGioXuatBen.Text = "Giờ xuất bến: " +  selectedRow.Cells["GioXuatBen"].Value.ToString();
                lbBienSoXe.Text = "Biển số xe: " + biensoxe;
                lbTenTuyen.Text = "Tuyến: " + selectedRow.Cells["TenTuyen"].Value.ToString();
                lbNgayDi.Text = "Ngày đi: " + selectedRow.Cells["ThoiGianDi"].Value.ToString();

                PhuongTien_DTO phuongTien = bul_pt.GetPhuongTien(biensoxe);
                soghe = (int)phuongTien.SoGhe;

                taoGhe(soghe, true);

                dgvDSTX.Width = 1030;

                setNull(true);
                
            }
        }


        private void btnTangDuoi_Click(object sender, EventArgs e)
        {
            taoGhe(soghe, true);
        }

        private void btnTangTren_Click(object sender, EventArgs e)
        {
            taoGhe(soghe, false);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if(makh != "")
            {
                int soluongghe = danhSachGheDaChon.Count();
                if (makh.Length > 0 && soluongghe > 0 && tongtien > 0)
                {
                    //tạo mới phiếu đặt vé
                    if (bul_phieudv.createOne(soluongghe, tongtien, makh, matuyen, danhSachGheDaChon, dongia) == 1)
                    {
                        MessageBox.Show("Tạo phiếu đặt vé thành công!");
                        dgvDSTX.Width = 1550;
                        setNull(false);
                        danhSachGheDaChon = null;
                    }
                }
            }
            else
            { MessageBox.Show("Chưa chọn khách hàng!"); }
               
        }

        KhachHang_BUL bul_kh = new KhachHang_BUL();
        string makh;
        void loadComboKH()
        {
            cboKH.DataSource = bul_kh.GetKhachHang();
            cboKH.DisplayMember = "HoTen";
            cboKH.ValueMember = "MaKH";
        }
        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKH.SelectedIndex >= 0)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh = bul_kh.GetKhachHang(cboKH.SelectedValue.ToString());
                if (kh != null)
                {
                    txtSDT.Text = kh.SDT;
                    txtMaKH.Text = kh.MaKH;
                    makh = kh.MaKH;
                }
                else
                {
                    txtSDT.Text = "";
                    txtMaKH.Text = "";
                    makh = "";
                }

            }
        }

        //private void txtMaKH_TextChanged(object sender, EventArgs e)
        //{
        //    KhachHang_DTO kh = new KhachHang_DTO();
        //    kh = bul_kh.TimKHTheoMa(txtMaKH.Text);
        //    if(kh != null)
        //    {
        //        cboKH.SelectedValue = kh.MaKH;
        //        txtSDT.Text = kh.SDT;
        //        makh = kh.MaKH;
        //    }
        //    else
        //    {
        //        cboKH.SelectedIndex = -1;
        //        txtSDT.Text = "";
        //        makh = "";
        //    }

        //}

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       


        private void btnXuatVe_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh = bul_kh.TimKHTheoSDT(txtSDT.Text);
            if (kh != null)
            {
                cboKH.SelectedValue = kh.MaKH;
                txtMaKH.Text = kh.MaKH;
                makh = kh.MaKH;
            }
            else
            {
                cboKH.SelectedIndex = -1;
                txtMaKH.Text = "";
                makh = "";
            }
        }
    }
}
