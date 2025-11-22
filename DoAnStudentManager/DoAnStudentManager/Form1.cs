using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace DoAnStudentManager
{
    public partial class Form1 : Form
    {
        // Tạo một danh sách tạm để lưu trữ sinh viên (Giả lập Database)
        List<Student> danhSachSV = new List<Student>();


        public class Student  // Class đại diện cho Sinh viên
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public string Lop { get; set; }
            public double Diem { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            // 1. Gán chữ "STT" cho ô góc trên cùng bên trái
            dgvSinhVien.TopLeftHeaderCell.Value = "STT";
            // 2. Căn giữa chữ "STT" cho đẹp
            dgvSinhVien.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSinhVien.RowHeadersWidth = 50;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string lop = txtLop.Text.Trim();
            string strDiem = txtDiem.Text.Trim();

            // ============================================================
            // KIỂM TRA RỖNG (Bắt buộc nhập đủ 4 ô)
            // ============================================================
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(lop) || string.IsNullOrEmpty(strDiem))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng ngay lập tức
            }

            // ============================================================
            // BƯỚC 2: KIỂM TRA MÃ SINH VIÊN
            // ============================================================

            // Kiểm tra độ dài
            if (maSV.Length > 30)
            {
                MessageBox.Show("Mã sinh viên không được quá 30 chữ Số!", "Lỗi độ dài", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            // Kiểm tra định dạng (Chỉ số)
            if (!Regex.IsMatch(maSV, @"^[0-9]+$"))
            {
                MessageBox.Show("Mã sinh viên chỉ được nhập SỐ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            // Kiểm tra trùng lặp
            if (danhSachSV.Any(sv => sv.MaSV == maSV))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.Focus();
                return;
            }

            // ============================================================
            // BƯỚC 3: KIỂM TRA HỌ TÊN
            // ============================================================

            // Kiểm tra độ dài
            if (hoTen.Length > 200)
            {
                MessageBox.Show("Tên quá dài (tối đa 200 ký tự)!", "Lỗi độ dài", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Duyệt từng ký tự để tìm "Kẻ phá hoại"
            foreach (char c in hoTen)
            {
                // Logic: Nếu ký tự là SỐ hoặc KÝ TỰ ĐẶC BIỆT hoặc DẤU CÂU (!,?,@,...)
                // Lưu ý: Code này cho phép dấu tiếng Việt và khoảng trắng đi qua
                if (char.IsDigit(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    // Gợi ý lỗi cụ thể cho người dùng biết sai ở đâu
                    MessageBox.Show($"Tên không hợp lệ!",
                                    "Lỗi tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                    return; // Dừng ngay
                }
            }

            // ============================================================
            // BƯỚC 4: KIỂM TRA ĐIỂM SỐ
            // ============================================================

            // Lúc này strDiem chắc chắn không rỗng (đã check ở Bước 1)
            // Nên ta chỉ cần check xem có phải số hợp lệ không

            float diemSo;
            // TryParse sẽ trả về false nếu người dùng nhập chữ (ví dụ: "8a")
            if (!float.TryParse(strDiem, out diemSo))
            {
                MessageBox.Show("Điểm phải là một SỐ thực (Ví dụ: 8.5)!", "Lỗi định dạng điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                txtDiem.SelectAll();
                return;
            }

            if (diemSo < 0 || diemSo > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi giá trị điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                txtDiem.SelectAll();
                return;
            }
            diemSo = (float)Math.Round(diemSo, 2);

            // ============================================================
            // BƯỚC 5: THÊM THÀNH CÔNG
            // ============================================================

            Student newSV = new Student()
            {
                MaSV = maSV,
                HoTen = hoTen,
                Lop = lop,
                Diem = diemSo
            };

            danhSachSV.Add(newSV);
            CapNhatBang();
            ResetForm();

            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm hiển thị dữ liệu lên bảng
        private void CapNhatBang()
        {
            // Gán DataSource
            dgvSinhVien.DataSource = null; // Xóa nguồn cũ
            dgvSinhVien.DataSource = danhSachSV; // Gán nguồn mới

            // Kiểm tra xem cột "Diem" có tồn tại không để tránh lỗi
            if (dgvSinhVien.Columns["Diem"] != null)
            {
                // "N2" nghĩa là Number với 2 số thập phân. 
                // Hoặc dùng "0.00" để luôn hiện 2 số (3.2 -> 3.20)
                dgvSinhVien.Columns["Diem"].DefaultCellStyle.Format = "0.00";
            }
        }

        // Hàm xóa trắng các ô nhập
        private void ResetForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            // Nếu phím được nhấn là Enter
            if (e.KeyCode == Keys.Enter)
            {
                // 1. Ngăn không cho tiếng "ding" (âm thanh hệ thống) kêu lên
                e.SuppressKeyPress = true;

                // 2. Tự động nhảy sang ô tiếp theo (theo thứ tự TabIndex)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dgvSinhVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy index của dòng hiện tại (bắt đầu từ 0) và cộng thêm 1
            string stt = (e.RowIndex + 1).ToString();

            // Tạo font chữ và brush (màu chữ)
            // SystemFonts.DefaultFont: Font mặc định của hệ thống
            // Brushes.Black: Màu đen
            using (System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(dgvSinhVien.RowHeadersDefaultCellStyle.ForeColor))
            {
                // Vẽ số STT lên phần RowHeader (cái cột xám xám trống ở bên trái ngoài cùng)
                e.Graphics.DrawString(stt, dgvSinhVien.DefaultCellStyle.Font, b,
                                      e.RowBounds.Location.X + 10, // Căn lề trái 10px
                                      e.RowBounds.Location.Y + 4); // Căn lề trên 4px
            }
        }
    }
}
        
    



