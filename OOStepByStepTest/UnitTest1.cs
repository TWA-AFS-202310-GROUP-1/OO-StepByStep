namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_introduction_when_given_person()
        {
            Person person = new Person();
            string personMsg = person.Speak();
            Assert.Equal("My name is Tom. I am 21 years old", personMsg);
        }
    }
}
