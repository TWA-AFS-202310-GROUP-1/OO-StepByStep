using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher() : base("Amy", 30)
        {
        }

        public override string Speak()
        {
            return base.Speak() + " I am a teacher.";
        }
    }
}
