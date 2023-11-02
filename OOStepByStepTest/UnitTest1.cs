namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Person_Introduction_IsCorrect()
        {
            var person = new Person("Tom", 21);
            Assert.Equal("My name is Tom. I am 21 years old.", person.Introduce());
        }

        [Fact]
        public void Student_IntroductionWithoutClassNumber_IsCorrect()
        {
            var student = new Student("Tom", 18);
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", student.Introduce());
        }

        [Fact]
        public void Teacher_IntroductionWithoutClassNumber_IsCorrect()
        {
            var teacher = new Teacher("Amy", 30);
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", teacher.Introduce());
        }

        [Fact]
        public void Student_WithClassNumber_Introduction_IsCorrect()
        {
            var student = new Student("Tom", 18, 2);
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", student.Introduce());
        }

        [Fact]
        public void Teacher_WithClassNumber_Introduction_IsCorrect()
        {
            var teacher = new Teacher("Amy", 30, 2);
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", teacher.Introduce());
        }

       
      

    }
}
