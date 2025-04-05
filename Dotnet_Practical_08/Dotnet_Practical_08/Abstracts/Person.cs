using Dotnet_Practical_08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Practical_08.Abstracts
{
    // Abstract Class
    public abstract class Person:IUniversityMember
    {
        // Encapsulation
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = value ?? "Unknown";
        }

        public int Age
        {
            get => _age;
            set => _age = value > 0 ? value : 18;
        }

        public string Address { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public abstract void DisplayInfo();

    }
}
