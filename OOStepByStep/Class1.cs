namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;


    public class Person
    {
        public string name { get; set; }
        private int age { get; set; }
        protected Clazz clazz { get;  set; }

        public Person(string name, int age, Clazz clazz = null)
        {
            this.name = name;
            this.age = age;
            this.clazz = clazz;
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }

    public class Student : Person
    {
        

        public Student(string name, int age, Clazz? clazz = null)
            : base(name, age, clazz)
        {
            
        }

        

        public override string Introduce()
        {
            string introduction = base.Introduce();
            introduction += clazz != null ? $" I am a student of class {clazz.classNumber.Value}." : " I am a student.";
            return introduction;
        }

        public string Introduce(Student newStudent)
        {
            string introduction = this.Introduce();
            introduction += $" Welcome {newStudent.name} join class {clazz.classNumber}.";
            return introduction;

        }



        public string Join(Clazz clazz)
        {
            this.clazz = clazz;
            return clazz.AddStudent(this);
        }



    }

    public class Teacher : Person
    {

        public Teacher(string name, int age, Clazz? clazz = null)
            : base(name, age, clazz)
        {
            
        }

        public override string Introduce()
        {
            string introduction = base.Introduce();
            introduction += clazz != null ? $" I am a teacher of class {clazz?.classNumber.Value}." : " I am a teacher.";
            return introduction;
        }
        public string Introduce(Student newStudent)
        {
            string introduction = this.Introduce();
            introduction += $" Welcome {newStudent.name} join class {clazz.classNumber}.";
            return introduction;
        }
    }

    public class Clazz
    {
        public int? classNumber { get; private set; }
        internal int? classNumberDouble { get => classNumber; set=>classNumber= value; }
        private Teacher teacher { get; set; }
        private List<Student> students { get; set; } = new List<Student>();

        public Clazz(int? classNumber = null) 
        {
            this.classNumber = classNumber;
        }
        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }
        public string AddStudent(Student student)
        {
            string result = "";
            result += teacher.Introduce(student)+"\n";
            students.ForEach(s => result+=s.Introduce(student)+"\n");
            students.Add(student);
            return result;
        }
    }


}
