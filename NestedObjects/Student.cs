using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The legeal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legeal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The assigned school email adress
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// The student's phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The student's advisor
        /// </summary>
        public Advisor SignedAdvisor { get; set; }
    }
}
