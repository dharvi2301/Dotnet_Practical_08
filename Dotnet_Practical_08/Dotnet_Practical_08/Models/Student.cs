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
    /// <summary>
    /// Represents a student in the university system. Inherits from Person class.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Gets or sets the unique student ID.
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// Gets or sets the list of courses the student is enrolled in.
        /// </summary>
        public List<string> EnrolledCourses { get; set; } = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with personal details and student ID.
        /// </summary>
        /// <param name="name">The name of the student.</param>
        /// <param name="age">The age of the student.</param>
        /// <param name="address">The address of the student.</param>
        /// <param name="studentId">The unique student ID.</param>
        public Student(string name, int age, string address, string studentId)
            : base(name, age, address)
        {
            StudentId = studentId;
        }

        /// <summary>
        /// Displays the student's personal and academic information.
        /// Overrides the abstract method from the Person base class.
        /// </summary>
        // Method Overriding
        public override void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}, Address: {Address}, ID: {StudentId}");
        }

        // Method Overloading
        /// <summary>
        /// Enrolls the student in a single course.
        /// </summary>
        /// <param name="course">The name of the course to enroll in.</param>
        /// <exception cref="CourseEnrollmentException">Thrown when the course name is null or empty.</exception>
        public void EnrollCourse(string course)
        {
            if (string.IsNullOrWhiteSpace(course))
                throw new CourseEnrollmentException("Course name cannot be empty.");

            EnrolledCourses.Add(course);
        }

        /// <summary>
        /// Enrolls the student in multiple courses.
        /// </summary>
        /// <param name="courses">A list of course names to enroll in.</param>
        /// <exception cref="CourseEnrollmentException">Thrown when the course list is null or empty.</exception>
        public void EnrollCourse(List<string> courses)
        {
            if (courses == null || courses.Count == 0)
                throw new CourseEnrollmentException("Course list cannot be empty.");

            EnrolledCourses.AddRange(courses);
        }

    }
}
