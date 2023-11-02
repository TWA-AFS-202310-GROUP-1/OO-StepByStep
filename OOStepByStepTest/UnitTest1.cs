namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_correct_introduction_when_introduce()
        {
            // given
            var person = new Person { Name = "Tom", Age = 21 };

            // when
            string introduction = person.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }

        [Fact]
        public void Should_return_correct_introduction_with_type_when_introduce()
        {
            // given
            var student = new Student { Name = "Tom", Age = 18 };

            // when
            string introduction = student.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduction);
        }
    }
}
