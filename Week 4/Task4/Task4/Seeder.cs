using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Seeder
    {
        private static List<Institution> institutions = new List<Institution>();
        private static List<Department> departments = new List<Department>();
        private static List<Courses> courses = new List<Courses>();

        public static List<Institution> SeedInstitutions()
        {
            institutions.Add(new Institution("Otago Polytechnic", "Otago", "New Zealand"));
            // TODO: add two more institutions
            return institutions;
        }

        public static List<Department> SeedDepartments()
        {
            departments.Add(new Department(institutions[0], "Information Technology"));
            // TODO: add two more departments
            return departments;
        }

        public static List<Courses> SeedCourses()
        {
            courses.Add(new Courses(departments[0], "ID511001", "Programming 2", "Advanced programming concepts", 15, 3500));
            // TODO: add two more courses
            return courses;
        }
    }
}
