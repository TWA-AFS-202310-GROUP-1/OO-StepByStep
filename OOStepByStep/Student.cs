using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public int ClassNumber { get; set; }
        public override string Introduce()
        {
            return $"{base.Introduce()} I am a student.";
        }

        public string Introduce(Student student)
        {
            return $"{base.Introduce()} I am a student of class {ClassNumber}.";
        }
    }
}
