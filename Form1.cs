using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace studentProgram
{
    public partial class Form1 : Form
    {
        StudentManager studentManager=new StudentManager();
        List<Student> studentlist;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void ClearTextBox()
        {
            tbxStudentFirstName.Clear();
            tbxStudentLastName.Clear();
            tbxStudentNumber.Clear();
            tbxSearchStudent.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwOgrenciler.DataSource = studentManager.GetAllLine();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student addingStudent = new Student
            {
                StudentNumber = tbxStudentNumber.Text,
                StudentFirstName = tbxStudentFirstName.Text,
                StudentLastName = tbxStudentLastName.Text,

            };
            studentManager.Adding(addingStudent);
            MessageBox.Show("Added successfully.");
            ClearTextBox();
            studentlist = studentManager.GetAllLine();
            dgwOgrenciler.DataSource = studentlist;
            

        }

        private void lblStudentLastName_Click(object sender, EventArgs e)
        {
            
        }
        private void dgwOgrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwOgrenciler.CurrentCell.RowIndex != null)
            {
                tbxSearchStudent.Text = dgwOgrenciler.CurrentRow.Cells[2].Value.ToString();
                tbxStudentNumber.Text = dgwOgrenciler.CurrentRow.Cells[0].Value.ToString();
                tbxStudentFirstName.Text = dgwOgrenciler.CurrentRow.Cells[1].Value.ToString();
                tbxStudentLastName.Text = dgwOgrenciler.CurrentRow.Cells[2].Value.ToString();
            }

        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            studentManager.Deleting(tbxSearchStudent.Text);
            MessageBox.Show("Student successfully deleted...");
            studentlist= studentManager.GetAllLine().ToList();
            dgwOgrenciler.DataSource=studentlist;
            ClearTextBox();
        }

        private void tbxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            studentlist=studentManager.GetAllLine();
            var FiltredData = studentlist.Where(x => x.StudentFirstName.Contains(tbxSearchStudent.Text, StringComparison.OrdinalIgnoreCase)
            || x.StudentLastName.Contains(tbxSearchStudent.Text, StringComparison.OrdinalIgnoreCase)
            ||x.StudentNumber.Contains(tbxSearchStudent.Text)).Take(30).ToList();
            dgwOgrenciler.DataSource=FiltredData;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student updateStudent = new Student
            {
                StudentNumber = tbxStudentNumber.Text,
                StudentFirstName = tbxStudentFirstName.Text,
                StudentLastName = tbxStudentLastName.Text
            };
            studentManager.Update(updateStudent);
            MessageBox.Show("Student successfully updated.");
            dgwOgrenciler.DataSource = studentManager.GetAllLine();
            ClearTextBox();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

   
}
