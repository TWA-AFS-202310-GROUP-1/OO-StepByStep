using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classInfo;
        public Teacher() : base("Amy", 30)
        {
        }

        public Teacher(int classInfo) : base("Amy", 30)
        {
            this.classInfo = classInfo;
        }

        public int GiveClassInfo()
        {
            return classInfo;
        }

        public override string Speak()
        {
             return base.Speak() + " I am a teacher.";
        }

        public string Speak(int classInfo)
        {
            return base.Speak() + $" I am a teacher of class {classInfo}.";
        }
    }
}
