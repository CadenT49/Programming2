using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Courses
    {
        //Fields
        private Department department;
        private string code;
        private string name;
        private string description;
        private int credits;
        private int fees;

        //Constructor
        public Courses(Department department, string code, string name, string description, int credits, int fees)
        {
            this.department = department;
            this.code = code;
            this.name = name;
            this.description = description;
            this.credits = credits;
            this.fees = fees;
        }

        //Encapsulation
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Credits { get => credits; set => credits = value; }
        public int Fees { get => fees; set => fees = value; }
        internal Department Department { get => department; set => department = value; }
    }
}
