using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    // tests for different kinds of person, including Person, Student and Teacher
    public class PersonWithClassTest
    {
        [Fact]
        public void Should_return_correct_introduction_sentence_when_introduce_oneself_given_a_student_with_class_number()
        {
            // given

            Student student = new Student("Kevin", 28);
            student.ClassId = 2;

            // when
            string result = student.IntroduceOneself();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old. I'm a student of class 2.", result);
        }

        [Fact]
        public void Should_return_correct_introduction_sentence_when_introduce_oneself_given_a_teacher_with_class_number()
        {
            // given

            Teacher teacher = new Teacher("Kevin", 28);
            teacher.ClassId = 2;

            // when
            string result = teacher.IntroduceOneself();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old. I'm a teacher of class 2.", result);
        }
    }
}
