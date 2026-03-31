using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Department
    {
        //Fields
        private Institution institution;
        private string name;

        //Constructor
        public Department(Institution institution, string name)
        {
            this.institution = institution;
            this.name = name;
        }

        //Encapsulation
        public string Name { get => name; set => name = value; }
        internal Institution Institution { get => institution; set => institution = value; }
    }
}
