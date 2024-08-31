using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Entities
{
    internal class Course_Inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public double Evaluate { get; set; }
    }
}
