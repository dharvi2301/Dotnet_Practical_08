using Dotnet_Practical_08.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dotnet_Practical_08.Models
{
    // Another Inheritance Example
    public class Professor : Person
    {
        public string Department { get; set; }

        public Professor(string name, int age, string address, string department): base(name, age, address)
        {
            Department = department;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Professor: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}
