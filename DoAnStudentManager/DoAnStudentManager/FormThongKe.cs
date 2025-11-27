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


namespace DoAnStudentManager
{
    public partial class FormThongKe : Form
    {
        private Chart chartThongKe;
        private Series seriesCot;
        private Series seriesTron;

        private int tongSV, svDat, svKhongDat;
        public FormThongKe(int tongSV, int svDat, int svKhongDat)
        {
            InitializeComponent();
            this.tongSV = tongSV;
            this.svDat = svDat;
            this.svKhongDat = svKhongDat;

            this.Text = "Biểu đồ thống kê sinh viên";
            this.Width = 900;
            this.Height = 600;

            // Tạo biểu đồ
            Chart chartThongKe = new Chart();
            chartThongKe.Dock = DockStyle.Fill;
            chartThongKe.BackColor = System.Drawing.Color.WhiteSmoke;

            //Tạo chú thích cho biểu đồ
            Legend legend = new Legend();
            legend.Docking = Docking.Bottom;
            legend.Alignment = System.Drawing.StringAlignment.Center;
            legend.Font = new System.Drawing.Font("Segoe UI", 9);
            chartThongKe.Legends.Add(legend);
            //Tạo vùng hiển thị (Chart Area)
            ChartArea chartAreaCot = new ChartArea("ChartCot");
            ChartArea chartAreaTron = new ChartArea("ChartTron");
            //Đặt vị trí cho 2 chart area (chia đôi form)
            chartAreaCot.Position = new ElementPosition(0, 0, 50, 90);   // bên trái
            chartAreaTron.Position = new ElementPosition(50, 0, 50, 90); // bên phải
            //Hiển thị trục rõ ràng 
            chartAreaCot.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            chartAreaCot.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9);

            chartThongKe.ChartAreas.Add(chartAreaCot);
            chartThongKe.ChartAreas.Add(chartAreaTron);

            //Biểu đồ cột
            Series seriesCot = new Series("Biểu đồ cột")
            { 
                ChartType = SeriesChartType.Column,
                ChartArea = "ChartCot",
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Segoe UI", 9),
                Color = System.Drawing.Color.SeaGreen
            };
            seriesCot.Points.AddXY("Tổng SV", tongSV);
            seriesCot.Points.AddXY("SV Đạt", svDat);
            seriesCot.Points.AddXY("SV Không đạt", svKhongDat);
            chartThongKe.Series.Add(seriesCot);
            //Biểu đồ tròn
            var seriesTron = new Series("Biểu đồ tròn")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "ChartTron",
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Segoe UI", 9),
                LegendText = "#VALX (#PERCENT)"
            };
            int p1 = seriesTron.Points.AddXY("Đạt", svDat);
            seriesTron.Points[p1].Color = System.Drawing.Color.RoyalBlue;
            int p2 = seriesTron.Points.AddXY("Không đạt", svKhongDat);
            seriesTron.Points[p2].Color = System.Drawing.Color.Tomato;
            chartThongKe.Series.Add(seriesTron);
            //Tạo tiêu đề cho biểu đồ
            Title title = new Title
            {
                Text = "THỐNG KÊ SINH VIÊN",
                Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.DarkGreen,
                Docking = Docking.Top,
                Alignment = System.Drawing.ContentAlignment.TopCenter
            };

            chartThongKe.Titles.Add(title);
            //Animation 
            chartThongKe.Annotations.Clear();
            //Animation cho từng biểu đồ
            
            seriesCot["AnimationType"] = "All";
            seriesCot["AnimationStartTime"] = "0";
            seriesCot["AnimationDuration"] = "1.5";

            
            seriesTron["AnimationType"] = "All";
            seriesTron["AnimationStartTime"] = "0";
            seriesTron["AnimationDuration"] = "2";
            //Thêm vào form
            this.Controls.Add(chartThongKe);
            

        }
    }
}
