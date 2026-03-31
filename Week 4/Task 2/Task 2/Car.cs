using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Car
    {
        //fields
        private string make;
        private string model;
        private int year;
        //Constructor
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        //Encapsulation
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        //methods
        public string DisplayInfo() => $"Make: {Make} Model: {Model} Year: {Year}";
        //public string Make;
        //public string Model;
        //public int Year;

        //public Car(string Make, string Model, int Year)
        //{
        //    this.Make = Make;
        //    this.Model = Model;
        //    this.Year = Year;
        //}
    }
}
