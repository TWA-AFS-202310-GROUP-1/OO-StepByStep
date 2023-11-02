namespace OOStepByStepTest
{
    using OOStepByStep;
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
    }
}
