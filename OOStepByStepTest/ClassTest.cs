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
            ClassOfSchool class2 = new ClassOfSchool();
            Teacher teacher = new Teacher("Bob", 16);
            teacher.ClassId = 2;
            class2.TeacherOfClass = teacher;

            // when
            string result = class2.ShowTeacher().IntroduceOneself();

            // then
            Assert.Equal("My name is Bob. I'm 16 years old. I'm a teacher of class 2.", result);
        }
    }
}
