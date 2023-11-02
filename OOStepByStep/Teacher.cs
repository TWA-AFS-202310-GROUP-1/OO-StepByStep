using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int? classNo = null;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public override string SelfIntroduce()
        {
            if (classNo == null)
            {
                return base.SelfIntroduce() + " I am a teacher.";
            }

            return $"{base.SelfIntroduce()} I am a teacher of class {classNo.ToString()}.";
        }
    }
}
