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

        [Fact]
        public void Should_return_introduction_when_given_a_student()
        {
            //Given
            string showMsg = "My name is Tom. I am 18 years old. I am a student.";
            string name = "Tom";
            int age = 18;

            //When
            Student student = new Student(name, age);
            string resultMsg = student.Introduce();

            //Then
            Assert.Equal(showMsg, resultMsg);
        }

        [Fact]
        public void Should_return_introduction_when_given_a_teacher()
        {
            //Given
            string showMsg = "My name is Amy. I am 30 years old. I am a teacher.";
            string name = "Amy";
            int age = 30;

            //When
            Teacher teacher = new Teacher(name, age);
            string resultMsg = teacher.Introduce();

            //Then
            Assert.Equal(showMsg, resultMsg);
        }
    }
}
