using Domain.Models;
using EFCoreSampleProject_ClassLibrary.Data;
using EFCoreSampleProject_ClassLibrary.Interfaces.Work;

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
            students_list.ReadOnly = true;
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
            if (!Check())
            {
                MessageBox.Show("Fill places correclty");
                return;
            }
            if (studentId != -1)
            {
                MessageBox.Show("Student exists in the database");
                return;
            }

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
        private void update_btn(object sender, EventArgs e)
        {
            if (studentId == -1)
            {
                MessageBox.Show("Student not selected");
                return;
            }
            if (!Check())
            {
                MessageBox.Show("Fill places correctly");
                return;
            }

            var student = work.Students.Get(studentId);
            student.Name = name_txb.Text;
            student.Surname = surname_txb.Text;
            student.GPU = Convert.ToDouble(gpu_txb.Text);

            work.SaveChanges();

            SetList();
            Reset();
        }
        private void remove_btn(object sender, EventArgs e)
        {
            if (studentId == -1)
            {
                MessageBox.Show("Student not selected");
                return;
            }

            work.Students.Remove(studentId);
            work.SaveChanges();

            SetList();
            Reset();
        }

        private void getTopStudents_btn(object sender, EventArgs e)
        {
            students_list.DataSource = work.Students.GetTopTenStudents().ToList();
        }
        private void students_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentId = Convert.ToInt32(students_list.CurrentRow.Cells[0].Value);
            name_txb.Text = students_list.CurrentRow.Cells[1].Value.ToString();
            surname_txb.Text = students_list.CurrentRow.Cells[2].Value.ToString();
            gpu_txb.Text = students_list.CurrentRow.Cells[3].Value.ToString();
        }  
        private void getAllStudents_btn(object sender, EventArgs e)
        {
            SetList();
        }
    }
}