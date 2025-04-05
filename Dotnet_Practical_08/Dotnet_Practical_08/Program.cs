using Dotnet_Practical_08.Exceptions;
using Dotnet_Practical_08.Models;
using Dotnet_Practical_08.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Practical_08
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student("Alice", 20, "New York", "S1001");
                student.DisplayInfo();

                // ✅ Valid enrollments
                student.EnrollCourse("Math");
                student.EnrollCourse(new List<string> { "Physics", "Chemistry" });

                // ✅ Print enrolled courses safely
                if (student.EnrolledCourses != null && student.EnrolledCourses.Count > 0)
                {
                    Console.WriteLine("Courses enrolled:");
                    student.EnrolledCourses.ForEach(course => Console.WriteLine($"- {course}"));
                }
                else
                {
                    Console.WriteLine("No courses enrolled.");
                }

                Console.WriteLine();

                Professor prof = new Professor("Dr. Smith", 45, "Boston", "Computer Science");
                prof.DisplayInfo();

                Console.WriteLine();

                UniversityRules.ShowRules();
            }
            catch (CourseEnrollmentException ex)
            {
                Console.WriteLine($"Enrollment Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.ReadLine();
        }
    
    }
}
