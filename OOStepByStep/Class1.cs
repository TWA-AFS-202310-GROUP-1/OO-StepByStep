namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }

    public class Student : Person
    {
        private Clazz clazz {  get; set; }
        public override string Introduce()
        {
            return base.Introduce() + " I am a student";
        }
        
    }

    public class Teacher : Person
    {
        private Clazz clazz { get; set; }
        public override string Introduce()
        {
            return base.Introduce() + " I am a teacher";
        }
    }

    public class Clazz
    {
        private int clazzNumber { get; set; }
    }

}
