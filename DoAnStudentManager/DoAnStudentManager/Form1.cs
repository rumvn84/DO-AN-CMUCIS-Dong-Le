using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;


namespace DoAnStudentManager
{
    public partial class Form1 : Form
    {
        // Tạo một danh sách tạm để lưu trữ sinh viên (Giả lập Database)
        List<Student> danhSachSV = new List<Student>();
        private string currentFilePath = "";


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

        private void btnDTB_Click(object sender, EventArgs e)
        {
            if (danhSachSV.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double tongDiem = danhSachSV.Sum(sv => sv.Diem);
            double diemTrungBinh = tongDiem / danhSachSV.Count;
            MessageBox.Show($"Điểm trung bình của tất cả sinh viên là: {diemTrungBinh:F2}", "Điểm Trung Bình", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Lấy tên cột vừa bấm
            var senderGrid = (DataGridView)sender;

            // 2. Kiểm tra xem người dùng có bấm vào cột "btnSua" hay không?
            // (Và đảm bảo không bấm vào tiêu đề cột - hàng âm)
            if (senderGrid.Columns[e.ColumnIndex].Name == "btnSua" && e.RowIndex >= 0)
            {
                // 3. Lấy dòng hiện tại
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                // 4. Đổ dữ liệu ngược lên Textbox (giống hệt logic cũ)
                // Lưu ý: Kiểm tra kỹ tên cột dữ liệu ("MaSV", "HoTen"...) phải đúng với thiết kế
                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtLop.Text = row.Cells["Lop"].Value.ToString();
                float diemLayRa = float.Parse(row.Cells["Diem"].Value.ToString());
                txtDiem.Text = diemLayRa.ToString("0.##");
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e) // FR khi click vào cột nào thì đỗ thông tin lại lên textbox (nhưng chưa cần )
        {
            // 1. Nếu người dùng bấm vào tiêu đề cột (hàng -1) thì thoát, không làm gì cả
            if (e.RowIndex == -1) return;

            // 2. Lấy dòng hiện tại đang được chọn
            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            // 3. Đổ dữ liệu từ bảng ngược lên các ô Textbox
            // Lưu ý: Các tên trong ngoặc vuông ["MaSV"] phải khớp với tên thuộc tính trong Class Student
            txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtLop.Text = row.Cells["Lop"].Value.ToString();

            // 4. Xử lý riêng cho ĐIỂM để tránh bị lỗi số dài ngoằng (VD: 2.30000019...)
            // Chúng ta lấy giá trị ra, ép về số, rồi định dạng lại cho đẹp
            string giaTriDiem = row.Cells["Diem"].Value.ToString();
            float diemSo;

            if (float.TryParse(giaTriDiem, out diemSo))
            {
                // "0.##": Chỉ lấy tối đa 2 số lẻ. Ví dụ 2.3 -> 2.3; 2.391 -> 2.39
                txtDiem.Text = diemSo.ToString("0.##");
            }
            else
            {
                txtDiem.Text = giaTriDiem;
            }
        }



        private void btnXoaSV_Click_1(object sender, EventArgs e)
        {
            // =======================================================================
            // BƯỚC 1: NGƯỜI DÙNG NHẤN NÚT XÓA (SỰ KIỆN CLICK)
            // =======================================================================

            // Lấy ID từ textbox (Giả định người dùng đã click vào bảng và dữ liệu đã đổ lên đây)
            string maSVCanXoa = txtMaSV.Text.Trim();

            // =======================================================================
            // BƯỚC 2: KIỂM TRA (VALIDATION)
            // =======================================================================

            // Đáp ứng TC-08: Xóa khi chưa chọn sinh viên / Danh sách trống
            if (string.IsNullOrEmpty(maSVCanXoa))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên trên bảng để xóa!",
                                "Chưa chọn sinh viên",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Dừng lại, không làm gì tiếp
            }

            // Kiểm tra kỹ hơn: Tìm xem sinh viên này có thực sự tồn tại trong danh sách không?
            // (Tránh trường hợp người dùng tự gõ bừa một mã không có rồi bấm xóa)
            var svCanXoa = danhSachSV.SingleOrDefault(sv => sv.MaSV == maSVCanXoa);

            if (svCanXoa == null)
            {
                MessageBox.Show($"Không tìm thấy sinh viên có mã {maSVCanXoa} trong hệ thống!",
                                "Lỗi dữ liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // =======================================================================
            // BƯỚC 3: YÊU CẦU XÁC NHẬN (CONFIRMATION)
            // =======================================================================

            DialogResult xacNhan = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sinh viên:\n" +
                $"Họ tên: {svCanXoa.HoTen}\n" +
                $"Mã số: {svCanXoa.MaSV}\n\n" +
                "Hành động này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo, // Hiển thị nút Yes/No
                MessageBoxIcon.Question);

            // Nếu chọn NO: Hủy bỏ
            if (xacNhan == DialogResult.No)
            {
                return;
            }

            // Nếu chọn YES: Chuyển sang Bước 4

            // =======================================================================
            // BƯỚC 4: THỰC HIỆN XÓA (EXECUTION)
            // =======================================================================

            // 1. Xóa đối tượng khỏi danh sách gốc (List)
            danhSachSV.Remove(svCanXoa);

            // 2. Xóa dòng tương ứng trên giao diện bảng (Cập nhật lại nguồn dữ liệu)
            CapNhatBang(); // Hàm này sẽ load lại list mới (đã mất người vừa xóa) lên dgv

            // 3. Xóa trắng các ô nhập liệu (Clean UI) để tránh xóa nhầm lần nữa
            ResetForm();

            // =======================================================================
            // BƯỚC 5: THÔNG BÁO THÀNH CÔNG
            // =======================================================================

            // Đáp ứng TC-02: Xóa sinh viên thành công
            MessageBox.Show("Đã xóa thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            // ============================================================
            // BƯỚC 1: LẤY DỮ LIỆU TỪ 4 Ô NHẬP LIỆU
            // ============================================================

            // Chuyển hết về chữ thường (ToLower) để tìm không phân biệt hoa thường
            string maCanTim = txtMaSV.Text.Trim().ToLower();
            string tenCanTim = txtHoTen.Text.Trim().ToLower();
            string lopCanTim = txtLop.Text.Trim().ToLower();
            string diemCanTim = txtDiem.Text.Trim(); // Điểm giữ nguyên để so sánh chuỗi

            // ============================================================
            // BƯỚC 2: THỰC HIỆN LỌC (LOGIC KẾT HỢP - AND)
            // ============================================================

            // Logic: Duyệt danh sách, giữ lại những người thỏa mãn TẤT CẢ các ô ĐANG CÓ DỮ LIỆU.
            // Nếu ô nào để trống => Coi như bỏ qua điều kiện đó (luôn đúng).

            var ketQua = danhSachSV.Where(sv =>
                (string.IsNullOrEmpty(maCanTim) || sv.MaSV.ToLower().Contains(maCanTim)) &&
                (string.IsNullOrEmpty(tenCanTim) || sv.HoTen.ToLower().Contains(tenCanTim)) &&
                (string.IsNullOrEmpty(lopCanTim) || sv.Lop.ToLower().Contains(lopCanTim)) &&
                (string.IsNullOrEmpty(diemCanTim) || sv.Diem.ToString().Contains(diemCanTim))
            ).ToList();

            // ============================================================
            // BƯỚC 3: XỬ LÝ KẾT QUẢ (TC-11)
            // ============================================================

            if (ketQua.Count == 0)
            {
                // TC-11: Không tìm thấy kết quả
                MessageBox.Show("Không tìm thấy sinh viên nào khớp với thông tin đã nhập!",
                                "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tùy chọn: Xóa bảng hoặc giữ nguyên bảng cũ
                dgvSinhVien.DataSource = null;
            }
            else
            {
                // TC-09 & TC-10: Có kết quả -> Hiển thị lên bảng
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = ketQua;

                // Định dạng lại cột điểm cho đẹp (nếu cần)
                if (dgvSinhVien.Columns["Diem"] != null)
                {
                    dgvSinhVien.Columns["Diem"].DefaultCellStyle.Format = "0.00";
                }

                MessageBox.Show($"Tìm thấy {ketQua.Count} sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // ============================================================
            // BƯỚC 1: LẤY DỮ LIỆU TỪ FORM
            // ============================================================

            // Cắt khoảng trắng thừa 2 đầu
            string maSV = txtMaSV.Text.Trim();

            // Chuẩn hóa font chữ cho Tên (Khắc phục lỗi font tiếng Việt)
            string hoTen = txtHoTen.Text.Trim().Normalize(System.Text.NormalizationForm.FormC);
            string lop = txtLop.Text.Trim();
            string strDiem = txtDiem.Text.Trim();

            // ============================================================
            // BƯỚC 2: KIỂM TRA DỮ LIỆU ĐẦU VÀO (VALIDATION)
            // ============================================================

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(lop) || string.IsNullOrEmpty(strDiem))
            {
                MessageBox.Show("Vui lòng chọn sinh viên trên bảng và nhập đầy đủ thông tin!",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Tìm sinh viên cần sửa trong danh sách (Dựa theo Mã SV)
            // Đây là bước quan trọng nhất: Phải tìm ra đối tượng cũ để sửa đổi nó
            var svCanSua = danhSachSV.SingleOrDefault(sv => sv.MaSV == maSV);

            if (svCanSua == null)
            {
                MessageBox.Show($"Không tìm thấy sinh viên có mã {maSV}!\n(Lưu ý: Không được sửa Mã Sinh Viên).",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Kiểm tra Tên (Logic "Phương pháp loại trừ" - Chấp nhận mọi tên Tiếng Việt)
            if (hoTen.Length > 200)
            {
                MessageBox.Show("Tên quá dài (tối đa 200 ký tự)!", "Lỗi độ dài", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (char c in hoTen)
            {
                // Nếu ký tự là SỐ hoặc KÝ TỰ ĐẶC BIỆT hoặc DẤU CÂU (Trừ khoảng trắng)
                if (char.IsDigit(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    MessageBox.Show($"Tên không hợp lệ! Phát hiện ký tự lạ: '{c}'",
                                    "Lỗi tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                    return;
                }
            }

            // 4. Kiểm tra Điểm
            float diemMoi;
            if (!float.TryParse(strDiem, out diemMoi))
            {
                MessageBox.Show("Điểm phải là SỐ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }

            if (diemMoi < 0 || diemMoi > 10)
            {
                MessageBox.Show("Điểm phải từ 0 đến 10!", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }

            // ============================================================
            // BƯỚC 3: THỰC HIỆN CẬP NHẬT (UPDATE)
            // ============================================================

            // Hỏi xác nhận cho chắc chắn (Đáp ứng trải nghiệm người dùng tốt)
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn cập nhật thông tin cho sinh viên {svCanSua.MaSV} không?",
                                                  "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gán dữ liệu MỚI vào đối tượng CŨ
                // Lưu ý: Chúng ta KHÔNG sửa MaSV (vì đó là khóa chính để tìm kiếm)
                svCanSua.HoTen = hoTen;
                svCanSua.Lop = lop;
                svCanSua.Diem = diemMoi;

                // ============================================================
                // BƯỚC 4: LÀM MỚI GIAO DIỆN
                // ============================================================

                CapNhatBang(); // Vẽ lại bảng với dữ liệu mới

                // (Tùy chọn) Có thể xóa trắng textbox sau khi sửa xong
                // ResetForm(); 

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            {
                // TC-14: Kiểm tra danh sách trống
                if (danhSachSV.Count == 0)
                {
                    MessageBox.Show("Danh sách đang trống, không có gì để lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu chưa có file (chưa từng Open hoặc Save trước đó) -> Phải Tạo file mới
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    SaveFileDialog saveDlg = new SaveFileDialog();
                    saveDlg.Filter = "Text File|*.txt|All Files|*.*"; // Chỉ cho lưu file .txt
                    saveDlg.Title = "Lưu danh sách sinh viên";

                    if (saveDlg.ShowDialog() == DialogResult.OK)
                    {
                        currentFilePath = saveDlg.FileName; // Lưu đường dẫn lại để lần sau dùng tiếp
                    }
                    else
                    {
                        return; // Người dùng bấm Cancel thì thôi
                    }
                }

                // TC-25: Xử lý ngoại lệ (File đang mở, ổ cứng đầy, không có quyền ghi...)
                try
                {
                    // Ghi file với mã hóa UTF8 để không lỗi font Tiếng Việt
                    using (StreamWriter sw = new StreamWriter(currentFilePath, false, System.Text.Encoding.UTF8))
                    {
                        foreach (var sv in danhSachSV)
                        {
                            // Định dạng dòng: MaSV | HoTen | Lop | Diem
                            // Dùng dấu gạch đứng "|" để ngăn cách vì tên người ít khi có dấu này
                            string line = $"{sv.MaSV}|{sv.HoTen}|{sv.Lop}|{sv.Diem}";
                            sw.WriteLine(line);
                        }
                    }

                    MessageBox.Show($"Lưu thành công vào file:\n{currentFilePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Text File|*.txt|All Files|*.*";
            openDlg.Title = "Mở file dữ liệu sinh viên";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                string path = openDlg.FileName;

                // TC-17: Kiểm tra file rỗng
                FileInfo fi = new FileInfo(path);
                if (fi.Length == 0)
                {
                    MessageBox.Show("File này không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo một list tạm để chứa dữ liệu đọc được
                // (Tránh trường hợp đang đọc thì lỗi, làm hỏng luôn danh sách hiện tại)
                List<Student> listTam = new List<Student>();

                // TC-26: Chặn lỗi đọc file (File hỏng, đang bị phần mềm khác khóa...)
                try
                {
                    string[] lines = File.ReadAllLines(path, System.Text.Encoding.UTF8);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();
                        if (string.IsNullOrEmpty(line)) continue; // Bỏ qua dòng trống

                        // Cắt chuỗi bằng dấu "|"
                        string[] parts = line.Split('|');

                        // TC-16: Kiểm tra định dạng (Phải đủ 4 phần: Mã, Tên, Lớp, Điểm)
                        if (parts.Length != 4)
                        {
                            MessageBox.Show($"Dòng số {i + 1} bị sai định dạng!\nNội dung: {line}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Dừng lại không đọc nữa
                        }

                        // Parse dữ liệu
                        Student sv = new Student();
                        sv.MaSV = parts[0].Trim();
                        sv.HoTen = parts[1].Trim();
                        sv.Lop = parts[2].Trim();

                        // Kiểm tra điểm có phải số không
                        if (!float.TryParse(parts[3].Trim(), out float diem))
                        {
                            MessageBox.Show($"Lỗi định dạng điểm ở dòng {i + 1}!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        sv.Diem = diem;

                        listTam.Add(sv);
                    }

                    // Đọc xong hết ngon lành thì mới gán vào danh sách chính
                    danhSachSV = listTam;

                    // Cập nhật đường dẫn hiện tại (để lát bấm Save thì lưu đè vào đây luôn)
                    currentFilePath = path;

                    // Cập nhật lên bảng
                    CapNhatBang();
                    MessageBox.Show("Mở file hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đọc file: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label10_Click_2(object sender, EventArgs e)
        {

        }

        private void cbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng chọn chưa (tránh lỗi khi chưa chọn gì)
            if (cbTieuChi.SelectedIndex == -1)
            {
                return;
            }

            // 2. Lấy chỉ số mục được chọn (0, 1, 2, 3)
            int luaChon = cbTieuChi.SelectedIndex;

            // 3. Thực hiện sắp xếp ngay lập tức
            switch (luaChon)
            {
                case 0: // Điểm tăng dần
                    danhSachSV = danhSachSV.OrderBy(sv => sv.Diem).ToList();
                    break;

                case 1: // Điểm giảm dần
                    danhSachSV = danhSachSV.OrderByDescending(sv => sv.Diem).ToList();
                    break;

                case 2: // Tên A -> Z (Sắp xếp theo Tên thật)
                    danhSachSV = danhSachSV.OrderBy(sv => LayTen(sv.HoTen)).ToList();
                    break;

                case 3: // Tên Z -> A
                    danhSachSV = danhSachSV.OrderByDescending(sv => LayTen(sv.HoTen)).ToList();
                    break;
            }

            // 4. Cập nhật lại bảng
            CapNhatBang();
        }
        // --- HÀM PHỤ TRỢ: TÁCH TÊN ĐỂ SẮP XẾP ---
        // Hàm này giúp lấy chữ cái cuối cùng của tên (Ví dụ: "Nguyễn Văn A" -> Lấy chữ "A")
        private string LayTen(string hoTenDayDu)
        {
            if (string.IsNullOrEmpty(hoTenDayDu)) return "";

            // Cắt chuỗi bằng dấu cách
            string[] cacTu = hoTenDayDu.Trim().Split(' ');

            // Trả về từ cuối cùng (Tên thật)
            return cacTu[cacTu.Length - 1];
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (danhSachSV.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int tongSV = danhSachSV.Count;
            int svDat = danhSachSV.Count(sv => sv.Diem >= 5.0);
            int svKhongDat = danhSachSV.Count(sv => sv.Diem < 5.0);
            //Hiển thị thông tin thống kê trên label 
            lblTongSV.Text = $"#Tổng số sinh viên: {tongSV}";
            lblDat.Text = $"#Số sinh viên đạt: {svDat}";
            lblKhongDat.Text = $"#Số sinh viên không đạt: {svKhongDat}";
            // Mở Form biểu đồ thống kê
            FormThongKe frmThongKe = new FormThongKe(tongSV, svDat, svKhongDat);
            frmThongKe.ShowDialog();
        }
    }
}
        
    



