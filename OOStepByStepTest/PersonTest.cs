using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    // tests for different kinds of person, including Person, Student and Teacher
    public class PersonTest
    {
        [Fact]
        public void Should_return_correct_introduction_sentence_when_introduce_oneself_given_a_person()
        {
            // given

            Person person = new Person("Kevin", 28);

            // when
            string result = person.IntroduceOneself();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old.", result);
        }

        [Fact]
        public void Should_return_correct_introduction_sentence_when_introduce_oneself_given_a_student()
        {
            // given

            Student student = new Student("Kevin", 28);
            Student student2 = new Student("Bob", 16);
            student2.ClassId = 2;

            // when
            string result = student.IntroduceOneself();
            string result2 = student2.IntroduceOneself();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old. I'm a student.", result);
            Assert.Equal("My name is Bob. I'm 16 years old. I'm a student of class 2.", result2);
        }

        [Fact]
        public void Should_return_correct_introduction_sentence_when_introduce_oneself_given_a_teacher()
        {
            // given

            Teacher teacher = new Teacher("Kevin", 28);
            Teacher teacher2 = new Teacher("Bob", 16);
            teacher2.ClassId = 2;

            // when
            string result = teacher.IntroduceOneself();
            string result2 = teacher2.IntroduceOneself();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old. I'm a teacher.", result);
            Assert.Equal("My name is Bob. I'm 16 years old. I'm a teacher of class 2.", result2);
        }
    }
}
