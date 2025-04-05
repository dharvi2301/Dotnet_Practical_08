using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Practical_08.Exceptions
{
    /// <summary>
    /// Custom exception class used to handle course enrollment-related errors.
    /// Inherits from the base <see cref="Exception"/> class.
    /// </summary>
    public class CourseEnrollmentException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CourseEnrollmentException"/> class with a specific error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public CourseEnrollmentException(string message) : base(message) { }
    }
}
