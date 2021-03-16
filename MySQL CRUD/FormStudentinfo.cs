using System;
using System.Windows.Forms;

namespace MySQL_CRUD
{
    public partial class FormStudentinfo : Form
    {
        public FormStudentinfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID, Name, Reg, Class, Section FROM student_table", dataGridView);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent(this);
            form.ShowDialog();
        }

        private void FormStudentinfo_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
