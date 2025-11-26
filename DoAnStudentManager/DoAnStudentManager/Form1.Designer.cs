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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            button13 = new Button();
            btnSapXep = new Button();
            btnThongKe = new Button();
            label9 = new Label();
            button12 = new Button();
            btnDTB = new Button();
            button11 = new Button();
            button10 = new Button();
            btnMoFile = new Button();
            btnLuuFile = new Button();
            label8 = new Label();
            dgvSinhVien = new DataGridView();
            btnSua = new DataGridViewButtonColumn();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 733F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(17, 20);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.85214F));
            tableLayoutPanel1.Size = new Size(1109, 710);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button13);
            panel1.Controls.Add(btnSapXep);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(btnDTB);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(btnMoFile);
            panel1.Controls.Add(btnLuuFile);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dgvSinhVien);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(382, 5);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 700);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button13
            // 
            button13.BackColor = Color.AliceBlue;
            button13.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(-399, 355);
            button13.Margin = new Padding(4, 5, 4, 5);
            button13.Name = "button13";
            button13.Size = new Size(316, 43);
            button13.TabIndex = 6;
            button13.Text = "Tìm kiếm sinh viên";
            button13.UseVisualStyleBackColor = false;
            // 
            // btnSapXep
            // 
            btnSapXep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSapXep.BackColor = SystemColors.ControlLight;
            btnSapXep.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSapXep.Location = new Point(504, 118);
            btnSapXep.Margin = new Padding(4, 5, 4, 5);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(87, 38);
            btnSapXep.TabIndex = 21;
            btnSapXep.Text = "SORT";
            btnSapXep.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnThongKe.BackColor = Color.SteelBlue;
            btnThongKe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(600, 402);
            btnThongKe.Margin = new Padding(4, 5, 4, 5);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(96, 131);
            btnThongKe.TabIndex = 20;
            btnThongKe.Text = "THỐNG KÊ";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(161, 12);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(438, 45);
            label9.TabIndex = 2;
            label9.Text = "Hệ Thống Quản Lý Sinh Viên";
            label9.Click += label9_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.InactiveBorder;
            button12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.Firebrick;
            button12.Location = new Point(-359, 452);
            button12.Margin = new Padding(4, 5, 4, 5);
            button12.Name = "button12";
            button12.Size = new Size(230, 62);
            button12.TabIndex = 7;
            button12.Text = "Cập nhập";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button3_Click;
            // 
            // btnDTB
            // 
            btnDTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDTB.BackColor = Color.SteelBlue;
            btnDTB.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDTB.Location = new Point(600, 238);
            btnDTB.Margin = new Padding(4, 5, 4, 5);
            btnDTB.Name = "btnDTB";
            btnDTB.Size = new Size(96, 131);
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
            button11.Location = new Point(-224, 238);
            button11.Margin = new Padding(4, 5, 4, 5);
            button11.Name = "button11";
            button11.Size = new Size(141, 67);
            button11.TabIndex = 5;
            button11.Text = "Xóa sinh viên";
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.BackgroundImageLayout = ImageLayout.Center;
            button10.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(-399, 238);
            button10.Margin = new Padding(4, 5, 4, 5);
            button10.Name = "button10";
            button10.Size = new Size(146, 67);
            button10.TabIndex = 4;
            button10.Text = "Thêm sinh viên";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnThem_Click;
            // 
            // btnMoFile
            // 
            btnMoFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoFile.BackColor = SystemColors.ControlLight;
            btnMoFile.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMoFile.Location = new Point(30, 118);
            btnMoFile.Margin = new Padding(4, 5, 4, 5);
            btnMoFile.Name = "btnMoFile";
            btnMoFile.Size = new Size(87, 38);
            btnMoFile.TabIndex = 16;
            btnMoFile.Text = "OPEN";
            btnMoFile.UseVisualStyleBackColor = false;
            btnMoFile.Click += button6_Click;
            // 
            // btnLuuFile
            // 
            btnLuuFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuuFile.BackColor = SystemColors.ControlLight;
            btnLuuFile.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuuFile.Location = new Point(136, 118);
            btnLuuFile.Margin = new Padding(4, 5, 4, 5);
            btnLuuFile.Name = "btnLuuFile";
            btnLuuFile.Size = new Size(87, 38);
            btnLuuFile.TabIndex = 13;
            btnLuuFile.Text = "SAVE";
            btnLuuFile.UseVisualStyleBackColor = false;
            btnLuuFile.Click += button5_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(421, 648);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(218, 28);
            label8.TabIndex = 15;
            label8.Text = "# Sinh viên không đạt : ";
            label8.Click += label8_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSinhVien.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { btnSua });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSinhVien.Location = new Point(30, 167);
            dgvSinhVien.Margin = new Padding(4, 5, 4, 5);
            dgvSinhVien.Name = "dgvSinhVien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSinhVien.RowHeadersWidth = 62;
            dgvSinhVien.Size = new Size(561, 457);
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
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(17, 648);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(197, 28);
            label6.TabIndex = 13;
            label6.Text = "# Tổng số sinh viên : ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(243, 648);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(158, 28);
            label7.TabIndex = 14;
            label7.Text = "# Sinh viên đạt : ";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(0, 0, 3, 51);
            panel2.BorderStyle = BorderStyle.Fixed3D;
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
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 700);
            panel2.TabIndex = 1;
            // 
            // btnTimKiemSV
            // 
            btnTimKiemSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnTimKiemSV.BackColor = Color.AliceBlue;
            btnTimKiemSV.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiemSV.ForeColor = Color.Black;
            btnTimKiemSV.Location = new Point(21, 487);
            btnTimKiemSV.Margin = new Padding(4, 5, 4, 5);
            btnTimKiemSV.Name = "btnTimKiemSV";
            btnTimKiemSV.Size = new Size(316, 46);
            btnTimKiemSV.TabIndex = 6;
            btnTimKiemSV.Text = "Tìm kiếm sinh viên";
            btnTimKiemSV.UseVisualStyleBackColor = false;
            // 
            // txtDiem
            // 
            txtDiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiem.Location = new Point(196, 285);
            txtDiem.Margin = new Padding(4, 5, 4, 5);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(141, 31);
            txtDiem.TabIndex = 3;
            txtDiem.KeyDown += Input_KeyDown;
            // 
            // txtLop
            // 
            txtLop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLop.Location = new Point(196, 212);
            txtLop.Margin = new Padding(4, 5, 4, 5);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(141, 31);
            txtLop.TabIndex = 2;
            txtLop.KeyDown += Input_KeyDown;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCapNhat.BackColor = SystemColors.InactiveBorder;
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Firebrick;
            btnCapNhat.Location = new Point(61, 583);
            btnCapNhat.Margin = new Padding(4, 5, 4, 5);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(230, 65);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "Cập nhập";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += button3_Click;
            // 
            // btnXoaSV
            // 
            btnXoaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaSV.BackColor = SystemColors.ActiveCaption;
            btnXoaSV.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaSV.ForeColor = Color.Black;
            btnXoaSV.Location = new Point(196, 370);
            btnXoaSV.Margin = new Padding(4, 5, 4, 5);
            btnXoaSV.Name = "btnXoaSV";
            btnXoaSV.Size = new Size(141, 70);
            btnXoaSV.TabIndex = 5;
            btnXoaSV.Text = "Xóa sinh viên";
            btnXoaSV.UseVisualStyleBackColor = false;
            btnXoaSV.Click += btnXoaSV_Click_1;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.BackgroundImageLayout = ImageLayout.Center;
            btnThem.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(21, 370);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 70);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm sinh viên";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaSV
            // 
            txtMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Location = new Point(196, 143);
            txtMaSV.Margin = new Padding(4, 5, 4, 5);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(141, 31);
            txtMaSV.TabIndex = 1;
            txtMaSV.KeyDown += Input_KeyDown;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Location = new Point(196, 83);
            txtHoTen.Margin = new Padding(4, 5, 4, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(141, 31);
            txtHoTen.TabIndex = 0;
            txtHoTen.KeyDown += Input_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 147);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 28);
            label5.TabIndex = 4;
            label5.Text = "Mã Số Sinh Viên";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Điểm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 215);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 2;
            label3.Text = "Lớp";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
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
            label1.Location = new Point(71, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Sinh Viên";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label6;
        private Label label7;
        private Label label8;
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
        private Button button1;
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
    }
}
