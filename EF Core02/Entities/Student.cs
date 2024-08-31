using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Entities
{
    internal class Student
    {
        //[Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Required]
        //[StringLength(15, MinimumLength = 3)]
        public string FName { get; set; }
        //[Required]
        //[StringLength(15, MinimumLength = 3)]
        public string LName { get; set; }
        //[StringLength(60, MinimumLength = 10)]
        public string Address { get; set; }
        //[Range(18, 60)]
        //[Required]
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Stud_Course> StudentCourses { get; set; }
    }
}
