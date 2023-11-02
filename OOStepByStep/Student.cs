using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int classinfo;
        public Student() : base("Tom", 18)
        {
        }

        public Student(int classInfo) : base("Tom", 18)
        {
            this.classinfo = classInfo;
        }

        public override string Speak()
        {
            return base.Speak() + " I am a student.";
        }

        public string Speak(int classInfo)
        {
            return base.Speak() + $" I am a student of class {classInfo}.";
        }
    }
}
