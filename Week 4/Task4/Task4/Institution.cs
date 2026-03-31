using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Institution
    {
        //Fields
        private string name;
        private string region;
        private string country;
        //Constructor
        public Institution(string name, string region, string country)
        {
            this.name = name;
            this.region = region;
            this.country = country;
        }
        //Encapsulation
        public string Name { get => name; set => name = value; }
        public string Region { get => region; set => region = value; }
        public string Country { get => country; set => country = value; }


        //Methods
        public string DisplayInfo() => $"Name: {Name} Region: {Region} Country: {Country}";

    }
}
