namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Collections.Generic;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_introduction_when_given_a_person()
        {
            //Given
            string showMsg = "My name is Tom. I am 21 years old.";
            string name = "Tom";
            int age = 21;

            //When
            Person person = new Person(name, age);
            string resultMsg = person.Introduce();

            //Then
            Assert.Equal(showMsg, resultMsg);
        }

        [Fact]
        public void Should_return_introduction_when_given_a_student()
        {
            //Given
            string showMsg = "My name is Tom. I am 18 years old. I am a student.";
            string name = "Tom";
            int age = 18;

            //When
            Student student = new Student(name, age);
            string resultMsg = student.Introduce();

            //Then
            Assert.Equal(showMsg, resultMsg);
        }

        [Fact]
        public void Should_return_introduction_when_given_a_teacher()
        {
            //Given
            string showMsg = "My name is Amy. I am 30 years old. I am a teacher.";
            string name = "Amy";
            int age = 30;

            //When
            Teacher teacher = new Teacher(name, age);
            string resultMsg = teacher.Introduce();

            //Then
            Assert.Equal(showMsg, resultMsg);
        }

        [Fact]
        public void Should_return_introduction_when_given_a_student_with_classInfo()
        {
            //Given
            string showMsg = "My name is Tom. I am 18 years old. I am a student of class 2.";
            string name = "Tom";
            int age = 18;
            string classNo = "2";

            //When
            Student student = new Student(name, age, classNo);
            string resultMsg = student.Introduce();

            //Then
            Assert.Equal(showMsg, resultMsg);
        }

        [Fact]
        public void Should_return_introduction_when_given_a_teacher_with_classInfo()
        {
            //Given
            string showMsg = "My name is Amy. I am 30 years old. I am a teacher of class 2.";
            string name = "Amy";
            int age = 30;
            string classNo = "2";

            //When
            Teacher teacher = new Teacher(name, age, classNo);
            string resultMsg = teacher.Introduce();

            //Then
            Assert.Equal(showMsg, resultMsg);
        }

        [Fact]
        public void Should_return_welcome_information_when_a_new_student_join_the_class()
        {
            //Given
            string showMsg = "My name is Rachel. I am 17 years old. I am a student of class 2. Welcome Chandler join class 2.\nMy name is Monica. I am 18 years old. I am a student of class 2. Welcome Chandler join class 2.\nMy name is Joey. I am 19 years old. I am a student of class 2. Welcome Chandler join class 2.\nMy name is Pheobe. I am 20 years old. I am a student of class 2. Welcome Chandler join class 2.\nMy name is Ross. I am 21 years old. I am a student of class 2. Welcome Chandler join class 2.\nMy name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Chandler join class 2.";

            //When
            Teacher teacher = new Teacher("Amy", 30, "2");
            List<Student> students = new List<Student>(/*new Student[]*/)
            {
                new Student("Rachel", 17, "2"),
                new Student("Monica", 18, "2"),
                new Student("Joey", 19, "2"),
                new Student("Pheobe", 20, "2"),
                new Student("Ross", 21, "2"),
            };
            string classNo = "2";
            ClassInfo class2 = new ClassInfo(classNo, teacher, students);
            Student newStudent = new Student("Chandler", 20, "2");

            string resultMsg = class2.Join(newStudent);

            //Then
            Assert.Equal(showMsg, resultMsg);
        }

    }
}
