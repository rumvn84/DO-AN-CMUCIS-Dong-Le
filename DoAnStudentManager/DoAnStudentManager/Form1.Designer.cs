namespace DoAnStudentManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label10 = new Label();
            cbTieuChi = new ComboBox();
            button13 = new Button();
            btnThongKe = new Button();
            label9 = new Label();
            button12 = new Button();
            btnDTB = new Button();
            button11 = new Button();
            button10 = new Button();
            btnMoFile = new Button();
            btnLuuFile = new Button();
            lblKhongDat = new Label();
            dgvSinhVien = new DataGridView();
            btnSua = new DataGridViewButtonColumn();
            lblTongSV = new Label();
            lblDat = new Label();
            panel2 = new Panel();
            btnClear = new Button();
            btnTimKiemSV = new Button();
            txtDiem = new TextBox();
            txtLop = new TextBox();
            btnCapNhat = new Button();
            btnXoaSV = new Button();
            btnThem = new Button();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            fontDialog1 = new FontDialog();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5592289F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 513F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.85214F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbTieuChi);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(btnDTB);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(btnMoFile);
            panel1.Controls.Add(btnLuuFile);
            panel1.Controls.Add(lblKhongDat);
            panel1.Controls.Add(dgvSinhVien);
            panel1.Controls.Add(lblTongSV);
            panel1.Controls.Add(lblDat);
            panel1.Location = new Point(266, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 420);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(224, 224, 224);
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(352, 74);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 23;
            label10.Text = "SORT";
            label10.Click += label10_Click_2;
            // 
            // cbTieuChi
            // 
            cbTieuChi.BackColor = SystemColors.WindowText;
            cbTieuChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTieuChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTieuChi.ForeColor = Color.Transparent;
            cbTieuChi.FormattingEnabled = true;
            cbTieuChi.Items.AddRange(new object[] { "Điểm tăng", "Điểm giảm", "A -> Z", "Z -> A" });
            cbTieuChi.Location = new Point(348, 71);
            cbTieuChi.Name = "cbTieuChi";
            cbTieuChi.Size = new Size(66, 25);
            cbTieuChi.TabIndex = 22;
            cbTieuChi.SelectedIndexChanged += cbTieuChi_SelectedIndexChanged;
            // 
            // button13
            // 
            button13.BackColor = Color.AliceBlue;
            button13.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(-279, 213);
            button13.Name = "button13";
            button13.Size = new Size(221, 26);
            button13.TabIndex = 6;
            button13.Text = "Tìm kiếm sinh viên";
            button13.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnThongKe.BackColor = Color.White;
            btnThongKe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.ForeColor = Color.Red;
            btnThongKe.Location = new Point(420, 241);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(67, 78);
            btnThongKe.TabIndex = 20;
            btnThongKe.Text = "THỐNG KÊ";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(113, 7);
            label9.Name = "label9";
            label9.Size = new Size(283, 30);
            label9.TabIndex = 2;
            label9.Text = "Hệ Thống Quản Lý Sinh Viên";
            label9.Click += label9_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.InactiveBorder;
            button12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.Firebrick;
            button12.Location = new Point(-251, 271);
            button12.Name = "button12";
            button12.Size = new Size(161, 37);
            button12.TabIndex = 7;
            button12.Text = "Cập nhập";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button3_Click;
            // 
            // btnDTB
            // 
            btnDTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDTB.BackColor = Color.White;
            btnDTB.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDTB.ForeColor = Color.Red;
            btnDTB.Location = new Point(420, 143);
            btnDTB.Name = "btnDTB";
            btnDTB.Size = new Size(67, 78);
            btnDTB.TabIndex = 18;
            btnDTB.Text = "ĐIỂM TRUNG BÌNH";
            btnDTB.UseVisualStyleBackColor = false;
            btnDTB.Click += btnDTB_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ActiveCaption;
            button11.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(-157, 143);
            button11.Name = "button11";
            button11.Size = new Size(99, 40);
            button11.TabIndex = 5;
            button11.Text = "Xóa sinh viên";
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.BackgroundImageLayout = ImageLayout.Center;
            button10.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(-279, 143);
            button10.Name = "button10";
            button10.Size = new Size(102, 40);
            button10.TabIndex = 4;
            button10.Text = "Thêm sinh viên";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnThem_Click;
            // 
            // btnMoFile
            // 
            btnMoFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoFile.BackColor = SystemColors.Control;
            btnMoFile.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMoFile.Image = Properties.Resources.open2;
            btnMoFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnMoFile.Location = new Point(21, 65);
            btnMoFile.Name = "btnMoFile";
            btnMoFile.Size = new Size(72, 29);
            btnMoFile.TabIndex = 16;
            btnMoFile.Text = "OPEN";
            btnMoFile.TextAlign = ContentAlignment.MiddleRight;
            btnMoFile.UseVisualStyleBackColor = false;
            btnMoFile.Click += btnMoFile_Click;
            // 
            // btnLuuFile
            // 
            btnLuuFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuuFile.BackColor = SystemColors.Control;
            btnLuuFile.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuuFile.Image = Properties.Resources.sav2e;
            btnLuuFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuFile.Location = new Point(99, 65);
            btnLuuFile.Name = "btnLuuFile";
            btnLuuFile.Size = new Size(72, 29);
            btnLuuFile.TabIndex = 13;
            btnLuuFile.Text = "SAVE";
            btnLuuFile.TextAlign = ContentAlignment.MiddleRight;
            btnLuuFile.UseVisualStyleBackColor = false;
            btnLuuFile.Click += btnLuuFile_Click;
            // 
            // lblKhongDat
            // 
            lblKhongDat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblKhongDat.AutoSize = true;
            lblKhongDat.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKhongDat.ForeColor = Color.Crimson;
            lblKhongDat.Location = new Point(295, 389);
            lblKhongDat.Name = "lblKhongDat";
            lblKhongDat.Size = new Size(157, 19);
            lblKhongDat.TabIndex = 15;
            lblKhongDat.Text = "# Sinh viên không đạt : ";
            lblKhongDat.Click += label8_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSinhVien.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { btnSua });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSinhVien.Location = new Point(21, 100);
            dgvSinhVien.Name = "dgvSinhVien";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvSinhVien.RowHeadersWidth = 62;
            dgvSinhVien.Size = new Size(393, 274);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            dgvSinhVien.RowPostPaint += dgvSinhVien_RowPostPaint;
            // 
            // btnSua
            // 
            btnSua.HeaderText = "";
            btnSua.MinimumWidth = 8;
            btnSua.Name = "btnSua";
            btnSua.Text = "Sửa";
            btnSua.UseColumnTextForButtonValue = true;
            btnSua.Width = 50;
            // 
            // lblTongSV
            // 
            lblTongSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongSV.AutoSize = true;
            lblTongSV.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTongSV.ForeColor = Color.SaddleBrown;
            lblTongSV.Location = new Point(12, 389);
            lblTongSV.Name = "lblTongSV";
            lblTongSV.Size = new Size(141, 19);
            lblTongSV.TabIndex = 13;
            lblTongSV.Text = "# Tổng số sinh viên : ";
            lblTongSV.Click += label6_Click;
            // 
            // lblDat
            // 
            lblDat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDat.AutoSize = true;
            lblDat.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDat.ForeColor = SystemColors.MenuHighlight;
            lblDat.Location = new Point(170, 389);
            lblDat.Name = "lblDat";
            lblDat.Size = new Size(114, 19);
            lblDat.TabIndex = 14;
            lblDat.Text = "# Sinh viên đạt : ";
            lblDat.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(0, 0, 3, 51);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnTimKiemSV);
            panel2.Controls.Add(txtDiem);
            panel2.Controls.Add(txtLop);
            panel2.Controls.Add(btnCapNhat);
            panel2.Controls.Add(btnXoaSV);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtMaSV);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 420);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Window;
            btnClear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Crimson;
            btnClear.Location = new Point(15, 335);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(224, 28);
            btnClear.TabIndex = 8;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnTimKiemSV
            // 
            btnTimKiemSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnTimKiemSV.BackColor = Color.White;
            btnTimKiemSV.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiemSV.ForeColor = Color.Firebrick;
            btnTimKiemSV.Location = new Point(15, 278);
            btnTimKiemSV.Name = "btnTimKiemSV";
            btnTimKiemSV.Size = new Size(102, 45);
            btnTimKiemSV.TabIndex = 6;
            btnTimKiemSV.Text = "Tìm kiếm sinh viên";
            btnTimKiemSV.UseVisualStyleBackColor = false;
            btnTimKiemSV.Click += btnTimKiemSV_Click;
            // 
            // txtDiem
            // 
            txtDiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiem.Location = new Point(137, 171);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(100, 23);
            txtDiem.TabIndex = 3;
            txtDiem.KeyDown += Input_KeyDown;
            // 
            // txtLop
            // 
            txtLop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLop.Location = new Point(137, 127);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(100, 23);
            txtLop.TabIndex = 2;
            txtLop.KeyDown += Input_KeyDown;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCapNhat.BackColor = Color.White;
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Firebrick;
            btnCapNhat.Location = new Point(137, 277);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(102, 45);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "Cập nhập";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaSV
            // 
            btnXoaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaSV.BackColor = Color.White;
            btnXoaSV.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaSV.ForeColor = Color.Firebrick;
            btnXoaSV.Location = new Point(137, 222);
            btnXoaSV.Name = "btnXoaSV";
            btnXoaSV.Size = new Size(102, 45);
            btnXoaSV.TabIndex = 5;
            btnXoaSV.Text = "Xóa sinh viên";
            btnXoaSV.UseVisualStyleBackColor = false;
            btnXoaSV.Click += btnXoaSV_Click_1;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnThem.BackColor = Color.White;
            btnThem.BackgroundImageLayout = ImageLayout.Center;
            btnThem.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Firebrick;
            btnThem.Location = new Point(15, 222);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 45);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm sinh viên";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaSV
            // 
            txtMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Location = new Point(137, 86);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(100, 23);
            txtMaSV.TabIndex = 1;
            txtMaSV.KeyDown += Input_KeyDown;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Location = new Point(137, 50);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(100, 23);
            txtHoTen.TabIndex = 0;
            txtHoTen.KeyDown += Input_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 88);
            label5.Name = "label5";
            label5.Size = new Size(113, 19);
            label5.TabIndex = 4;
            label5.Text = "Mã Số Sinh Viên";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 3;
            label4.Text = "Điểm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 129);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 2;
            label3.Text = "Lớp";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(50, 14);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Sinh Viên";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "StudentManager";
            Load += Form1_Load;
            KeyDown += Input_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgvSinhVien;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnThem;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button3;
        private Label lblTongSV;
        private Label lblDat;
        private Label lblKhongDat;
        private Button button5;
        private Button button8;
        private Button button6;
        private Label label9;
        private FontDialog fontDialog1;
        private TextBox txtLop;
        private TextBox txtDiem;
        private Button button4;
        private Button button9;
        private Button button7;
        private Button btnSapXep;
        private Button btnThongKe;
        private Button btnDTB;
        private Button btnMoFile;
        private Button btnLuuFile;
        private Button btnTimKiemSV;
        private Button btnCapNhat;
        private Button btnXoaSV;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private DataGridViewButtonColumn btnSua;
        private ComboBox cbTieuChi;
        private Label label10;
        private Button btnClear;
    }
}
