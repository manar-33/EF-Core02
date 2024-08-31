using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Entities
{
    internal class Stud_Course
    {
        public int Student_Id { get; set; }
        public int Course_Id { get; set; }
        public List<Student>Students { get; set; }
        public List<Course>Courses { get; set; }
        public int Grade { get; set; }
    }
}
