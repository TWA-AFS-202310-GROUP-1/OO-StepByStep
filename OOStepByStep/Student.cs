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
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNo) : base(name, age)
        {
            this.ClassNo = classNo;
        }

        public int? ClassNo { get; set; } = null;

        public override string SelfIntroduce()
        {
            if (ClassNo == null)
            {
                return base.SelfIntroduce() + " I am a student.";
            }

            return $"{base.SelfIntroduce()} I am a student of class {ClassNo.ToString()}.";
        }
    }
}
