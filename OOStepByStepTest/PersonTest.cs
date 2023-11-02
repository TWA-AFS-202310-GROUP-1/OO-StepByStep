using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_introduction_sentence_when_introduce_oneself_given_a_person()
        {
            // given
            Person person = new Person("Kevin", 28);

            // when
            string result = person.IntroduceOneself();

            // then
            Assert.Equal("My name is Kevin. I'm 28 years old.", result);
        }
    }
}
