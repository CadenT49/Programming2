using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private List<Institution> institutions;
        private List<Department> departments;
        private List<Courses> courses;

        public Form1()
        {
            InitializeComponent();

            institutions = Seeder.SeedInstitutions();
            departments = Seeder.SeedDepartments();
            courses = Seeder.SeedCourses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
