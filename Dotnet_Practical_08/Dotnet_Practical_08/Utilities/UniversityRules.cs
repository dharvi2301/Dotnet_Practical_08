using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Practical_08.Utilities
{
    // Sealed Class
    /// <summary>
    /// A sealed utility class that provides university rules.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class UniversityRules
    {
        /// <summary>
        /// Displays the university rules for students and staff.
        /// </summary>
        public static void ShowRules()
        {
            Console.WriteLine("Rules: Attend 75% of lectures. Submit all assignments.");
        }
    }
}
