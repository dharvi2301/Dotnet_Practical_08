using Dotnet_Practical_08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Practical_08.Abstracts
{
    // Abstract Class
    /// <summary>
    /// Abstract base class representing a person in the university system.
    /// Implements the IUniversityMember interface.
    /// </summary>
    public abstract class Person:IUniversityMember
    {
        // Encapsulation
        // Encapsulation using private fields
        private string _name;
        private int _age;

        /// <summary>
        /// Gets or sets the name of the person.
        /// Defaults to "Unknown" if null.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value ?? "Unknown";
        }

        /// <summary>
        /// Gets or sets the age of the person.
        /// Defaults to 18 if value is less than or equal to zero.
        /// </summary>
        public int Age
        {
            get => _age;
            set => _age = value > 0 ? value : 18;
        }

        /// <summary>
        /// Gets or sets the address of the person.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with basic personal details.
        /// </summary>
        /// <param name="name">The name of the person.</param>
        /// <param name="age">The age of the person.</param>
        /// <param name="address">The address of the person.</param>
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        /// <summary>
        /// Abstract method to display personal information.
        /// Must be overridden by derived classes.
        /// </summary>
        public abstract void DisplayInfo();

    }
}
