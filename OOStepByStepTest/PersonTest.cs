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

            // when
            string result = student.IntroduceOneself();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old. I'm a student.", result);
        }
    }
}
