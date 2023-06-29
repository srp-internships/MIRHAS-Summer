using EFCoreSampleProject_ClassLibrary.Data;
using EFCoreSampleProject_ClassLibrary.Interfaces.Work;
using EFCoreSampleProject_ClassLibrary.Models;

namespace EFCoreSampleProject
{
    public partial class Form1 : Form
    {
        UnitOfWork work;
        int studentId = -1;
        public Form1()
        {
            InitializeComponent();
            work = new UnitOfWork(new ProjectContext());
            SetList();
        }

        void SetList()
        {
            students_list.DataSource = work.Students.GetAll().ToList();
        }
        private bool Check()
        {
            bool isNotEmpty = name_txb.Text != string.Empty && surname_txb.Text != string.Empty && gpu_txb.Text != string.Empty;
            try
            {
                Convert.ToDouble(gpu_txb.Text);
                return isNotEmpty;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void Reset()
        {
            name_txb.Text = string.Empty;
            surname_txb.Text = string.Empty;
            gpu_txb.Text = string.Empty;
            studentId = -1;
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            if (Check())
            {

                work.Students.Add(new Student
                {
                    Name = name_txb.Text,
                    Surname = surname_txb.Text,
                    GPU = Convert.ToDouble(gpu_txb.Text)
                });
                work.SaveChanges();
                SetList();
                Reset();
            }
            else MessageBox.Show("Fill places correclty");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (studentId != -1 && Check())
            {
                var student = work.Students.Get(studentId);
                student.Name = name_txb.Text;
                student.Surname = surname_txb.Text;
                student.GPU = Convert.ToDouble(gpu_txb.Text);
                work.SaveChanges();
                SetList();
                Reset();
            }
            else MessageBox.Show("Fill places correctly");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            work.Students.Remove(studentId);
            work.SaveChanges();
            SetList();
            Reset();
        }

        private void students_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentId = Convert.ToInt32(students_list.CurrentRow.Cells[0].Value);
            name_txb.Text = students_list.CurrentRow.Cells[1].Value.ToString();
            surname_txb.Text = students_list.CurrentRow.Cells[2].Value.ToString();
            gpu_txb.Text = students_list.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students_list.DataSource = work.Students.GetTopTenStudents().ToList();
        }
    }
}