using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DTO;
using BUL;

namespace AppQuanLyDatVeXe
{
    public partial class FormBaoCao : Form
    {
        NhanVien_DTO nhanvien = new NhanVien_DTO();
        public FormBaoCao(NhanVien_DTO nv)
        {
            nhanvien = nv;
            InitializeComponent();
        }
        PhieuDatVe_BUL bul_pdv = new PhieuDatVe_BUL();
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            showChartPhieuDatVe();
        }

        private void showChartPhieuDatVe()
        {
            // Lấy dữ liệu
            var dataDatVe = bul_pdv.GetPhieuDatVe_DaDat_TrongTuan();
            var dataDaHuy = bul_pdv.GetPhieuDatVe_Dahuy_TrongTuan();
            var dataDaThanhToan = bul_pdv.GetPhieuDatVe_DaThanhToan_TrongTuan();

            // Tính tổng số phiếu cho từng loại trong tuần hiện tại
            int totalDatVe = dataDatVe.Sum(x => x.Count);
            int totalDaHuy = dataDaHuy.Sum(x => x.Count);
            int totalDaThanhToan = dataDaThanhToan.Sum(x => x.Count);

            // Tổng số phiếu
            int total = totalDatVe + totalDaHuy + totalDaThanhToan;

            // Cấu hình biểu đồ tròn
            ChartPhieuDatVeTrongTuan.Series.Clear();
            ChartPhieuDatVeTrongTuan.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Tắt trục X
            ChartPhieuDatVeTrongTuan.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Tắt trục Y

            // Tạo một series cho biểu đồ tròn
            var pieSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Phiếu")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, // Biểu đồ tròn
                IsValueShownAsLabel = true, // Hiển thị giá trị
                LabelFormat = "#PERCENT", // Hiển thị phần trăm
                BorderWidth = 2, // Đặt độ rộng của viền cho các miếng của biểu đồ tròn
                BorderColor = System.Drawing.Color.Black // Đặt màu viền cho các miếng
            };

            // Thêm dữ liệu vào biểu đồ tròn
            pieSeries.Points.AddXY("Phiếu đã đặt", totalDatVe);
            pieSeries.Points.AddXY("Phiếu đã hủy", totalDaHuy);
            pieSeries.Points.AddXY("Phiếu đã thanh toán", totalDaThanhToan);

            // Đặt màu sắc cho từng phần của biểu đồ
            pieSeries.Points[0].Color = System.Drawing.Color.BlueViolet; // Màu xanh dương cho "Phiếu đã đặt"
            pieSeries.Points[1].Color = System.Drawing.Color.OrangeRed; // Màu đỏ cho "Phiếu đã hủy"
            pieSeries.Points[2].Color = System.Drawing.Color.LightGreen; // Màu xanh lá cho "Phiếu đã thanh toán"

            // Thêm series vào biểu đồ
            ChartPhieuDatVeTrongTuan.Series.Add(pieSeries);

            // Bật chế độ hiển thị phần trăm
            foreach (var point in pieSeries.Points)
            {
                point.Label = $"{point.AxisLabel}: {point.YValues[0]:0}%"; // Hiển thị tên loại phiếu và phần trăm
            }

            ChartPhieuDatVeTrongTuan.Titles.Clear(); // Xóa tiêu đề cũ nếu có
            var title = new System.Windows.Forms.DataVisualization.Charting.Title("Thống kê số lượng vé trong tuần",
                    System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                    new Font("Arial", 12, FontStyle.Bold),
                    Color.Black);
            ChartPhieuDatVeTrongTuan.Titles.Add(title);
        }





    }
}
