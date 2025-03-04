using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDemo.Data
{
    public partial class Course
    {
        public Course()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
