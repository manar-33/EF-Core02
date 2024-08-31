using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public List<Stud_Course> StudentCourses { get; set; }
        public List<Course_Inst> CourseInstructors { get; set; }
    }
}
