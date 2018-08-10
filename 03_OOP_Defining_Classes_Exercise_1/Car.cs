using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Exercise_1
{
    public class Car
    {
        //Constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        } 

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
