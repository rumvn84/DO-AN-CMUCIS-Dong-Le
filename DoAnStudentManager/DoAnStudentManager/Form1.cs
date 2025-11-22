using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnStudentManager
{
    public class Student
    {
        public string MSSV { get; set; } = "";
        public string Tên { get; set; } = "";
        public int Lớp { get; set; } = 0;

        public Student()
        {
            MSSV = "";
            Tên  = "";
            Lớp = 0;
        }
    }

    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            students.Add(new Student { MSSV = "SV01", Tên  = "Nguyen Van A", Lớp   = 3  });
            students.Add(new Student { MSSV = "SV02", Tên  = "Tran Thi B", Lớp  = 4  });
            LoadStudents ();
        }
        private void LoadStudents()
        {
            dataGridView1.Rows.Clear();

           
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "MSSV";
                dataGridView1.Columns[1].Name = "Tên";
                dataGridView1.Columns[2].Name = "Lớp";

                dataGridView1.Rows.Clear();


                foreach (var s in students)
                {
                    dataGridView1.Rows.Add(s.MSSV, s.Tên, s.Lớp);
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên muốn xóa!");
                return;
            }

            string? MSSV =
                dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();

            var studentToRemove =
                students.FirstOrDefault(s => s.MSSV == MSSV);

            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                LoadStudents();
                MessageBox.Show("Xóa thành công!");
            }
        }
    }


}
