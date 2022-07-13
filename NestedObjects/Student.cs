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
        /// The date of birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// The student's preferred phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The advisor who is assigned to the student
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
