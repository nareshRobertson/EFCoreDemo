using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDemo.Data
{
    public partial class Student
    {
        public Student()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
