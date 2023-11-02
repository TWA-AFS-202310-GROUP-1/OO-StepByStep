using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classId;
        public Teacher(string name, int age) : base(name, age)
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
                introduction += " I'm a teacher.";
            }
            else
            {
                introduction += $" I'm a teacher of class {classId}.";
            }

            return introduction;
        }
    }
}
