namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Person_Introduction_IsCorrect()
        {
            var person = new Person { Name = "Tom", Age = 21 };
            Assert.Equal("My name is Tom. I am 21 years old.", person.Introduce());
        }

        [Fact]
        public void Student_Introduction_IsCorrect()
        {
            var student = new Student { Name = "Tom", Age = 21 };
            Assert.Equal("My name is Tom. I am 21 years old. I am a student", student.Introduce());
        }
    }
}
