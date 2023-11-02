using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name()
        {
            return this.name;
        }

        public virtual string Introduce()
        {
            return $"My name is {this.name}. I am {this.age} years old.";
        }
    }
}
