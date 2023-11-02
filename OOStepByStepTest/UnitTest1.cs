namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Introduce_Should_Return_Correct_Introduction()
        {
            // Arrange
            Person person = new Person("Tom", 21);

            // Act
            string introduction = person.Introduce();

            // Assert
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }
    }
}
