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
    /// <summary>
    /// Represents a professor in the university system. Inherits from the abstract Person class.
    /// </summary>
    public class Professor : Person
    {
        /// <summary>
        /// Gets or sets the department to which the professor belongs.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Professor"/> class with personal and departmental details.
        /// </summary>
        /// <param name="name">The name of the professor.</param>
        /// <param name="age">The age of the professor.</param>
        /// <param name="address">The address of the professor.</param>
        /// <param name="department">The department of the professor.</param>
        public Professor(string name, int age, string address, string department): base(name, age, address)
        {
            Department = department;
        }

        /// <summary>
        /// Displays the professor's personal and departmental information.
        /// Overrides the abstract DisplayInfo method from the Person class.
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Professor: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}
