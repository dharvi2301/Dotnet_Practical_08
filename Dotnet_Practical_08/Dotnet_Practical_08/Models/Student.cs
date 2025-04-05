using Dotnet_Practical_08.Abstracts;
using Dotnet_Practical_08.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dotnet_Practical_08.Models
{
    // Inheritance + Method Overriding
    public class Student : Person
    {
        public string StudentId { get; set; }
        public List<string> EnrolledCourses { get; set; } = new List<string>();

        public Student(string name, int age, string address, string studentId)
            : base(name, age, address)
        {
            StudentId = studentId;
        }

        // Method Overriding
        public override void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}, Address: {Address}, ID: {StudentId}");
        }

        // Method Overloading
        public void EnrollCourse(string course)
        {
            if (string.IsNullOrWhiteSpace(course))
                throw new CourseEnrollmentException("Course name cannot be empty.");

            EnrolledCourses.Add(course);
        }

        public void EnrollCourse(List<string> courses)
        {
            if (courses == null || courses.Count == 0)
                throw new CourseEnrollmentException("Course list cannot be empty.");

            EnrolledCourses.AddRange(courses);
        }

    }
}
