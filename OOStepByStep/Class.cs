using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public int ClassNumber { get; set; }
    }
}
