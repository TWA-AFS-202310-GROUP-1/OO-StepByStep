using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    // tests for different kinds of person, including Person, Student and Teacher
    public class ClassTest
    {
        [Fact]
        public void Should_return_teacher_of_the_class_when_ShowTeacher_given_a_ClassOfSchool()
        {
            // given
            ClassOfSchool class2 = new ClassOfSchool(2);
            Teacher teacher = new Teacher("Bob", 16);
            teacher.ClassId = 2;
            class2.TeacherOfClass = teacher;

            // when
            string result = class2.ShowTeacher().IntroduceOneself();

            // then
            Assert.Equal("My name is Bob. I'm 16 years old. I'm a teacher of class 2.", result);
        }

        [Fact]
        public void Should_return_students_of_the_class_when_ShowStudent_given_a_ClassOfSchool()
        {
            // given
            ClassOfSchool class2 = new ClassOfSchool(2);

            Student newStudent1 = new Student("Kevin", 28);
            class2.Join(newStudent1);

            Student newStudent2 = new Student("Bob", 27);
            class2.Join(newStudent2);

            // when
            string result = class2.ShowStudents();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old. I'm a student of class 2.\n" +
                "My name is Bob. I'm 27 years old. I'm a student of class 2.\n", result);
        }

        [Fact]
        public void Should_return_correct_welcome_sentence_when_WelcomeNewStudent_given_a_ClassOfSchool()
        {
            // given
            ClassOfSchool class2 = new ClassOfSchool(2);
            Teacher teacher = new Teacher("Bob", 36);
            teacher.ClassId = 2;
            class2.TeacherOfClass = teacher;

            Student student1 = new Student("Kevin", 18);
            class2.Join(student1);

            Student student2 = new Student("Tom", 17);
            class2.Join(student2);

            Student newStudent = new Student("Alice", 15);

            // when
            string result = class2.WelcomeNewStudent(newStudent, "Alice");

            // then
            Assert.Equal(
                "My name is Bob. I'm 36 years old. I'm a teacher of class 2. Welcome Alice join class 2.\n" +
                "My name is Kevin. I'm 18 years old. I'm a student of class 2. Welcome Alice join class 2.\n" +
                "My name is Tom. I'm 17 years old. I'm a student of class 2. Welcome Alice join class 2.\n", result);
        }
    }
}
