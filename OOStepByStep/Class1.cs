namespace OOStepByStep
{
    using System;
    using System.Xml.Linq;

    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}
