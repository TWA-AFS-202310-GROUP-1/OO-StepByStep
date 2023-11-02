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
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + $" I am a {identity}.";
        }
    }
}
