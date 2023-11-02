namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;


    public class Person
    {
        private string name { get; set; }
        private int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }

    public class Student : Person
    {
        private int? classNumber;

        public Student(string name, int age, int? classNumber = null)
            : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string Introduce()
        {
            string introduction = base.Introduce();
            introduction += classNumber.HasValue ? $" I am a student of class {classNumber.Value}." : " I am a student.";
            return introduction;
        }

        
    }

    public class Teacher : Person
    {
        private int? classNumber;

        public Teacher(string name, int age, int? classNumber = null)
            : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string Introduce()
        {
            string introduction = base.Introduce();
            introduction += classNumber.HasValue ? $" I am a teacher of class {classNumber.Value}." : " I am a teacher.";
            return introduction;
        }
    }


}
