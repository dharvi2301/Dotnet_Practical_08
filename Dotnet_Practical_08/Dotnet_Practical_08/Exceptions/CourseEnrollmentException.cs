using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Practical_08.Exceptions
{
    public class CourseEnrollmentException : Exception
    {
        public CourseEnrollmentException(string message) : base(message) { }
    }
}
