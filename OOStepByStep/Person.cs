namespace OOStepByStep
{
    using System;
    using System.Runtime.CompilerServices;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string IntroduceOneself()
        {
            return $"My name is {name}. I'm {age} years old.";
        }

        public string GetName()
        {
            return name ;
        }
    }
}
