using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int? classNo = null;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public override string SelfIntroduce()
        {
            if (classNo == null)
            {
                return base.SelfIntroduce() + " I am a student.";
            }

            return $"{base.SelfIntroduce()} I am a student of class {classNo.ToString()}.";
        }
    }
}
