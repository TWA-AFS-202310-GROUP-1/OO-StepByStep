using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int classId;
        public Student(string name, int age) : base(name, age)
        {
            classId = 0;
        }

        public int ClassId
        {
            get { return classId; }
            set { classId = value; }
        }

        public override string IntroduceOneself()
        {
            string introduction = base.IntroduceOneself();
            if (classId == 0)
            {
                introduction += " I'm a student.";
            }
            else
            {
                introduction += $" I'm a student of class {classId}.";
            }

            return introduction;
        }
    }
}
