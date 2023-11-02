using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student() : base("Tom", 18)
        {
        }

        public override string Speak()
        {
            return base.Speak() + " I am a student.";
        }
    }
}
