namespace OOStepByStep
{
    using System;
    public class Person
    {
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public string Name { get; set; }

        public virtual string SelfIntroduce()
        {
            return $"My name is {this.Name}. I am {this.age} years old.";
        }
    }
}
