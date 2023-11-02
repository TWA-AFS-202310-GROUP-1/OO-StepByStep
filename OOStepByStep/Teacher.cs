using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public int ClassNumber { get; set; }
        public override string Introduce()
        {
            return $"{base.Introduce()} I am a teacher.";
        }

        public string Introduce(Teacher teacher)
        {
            return $"{base.Introduce()} I am a teacher of class {ClassNumber}.";
        }
    }
}
