using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string identity = "student";
        private string classNo = null;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, string classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public override string Introduce()
        {
            if (this.classNo == null)
            {
                return base.Introduce() + $" I am a {identity}.";
            }
            else
            {
                return base.Introduce() + $" I am a {identity} of class {classNo}.";
            }
        }
    }
}
