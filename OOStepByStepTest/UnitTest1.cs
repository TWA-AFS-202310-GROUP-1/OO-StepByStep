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
            Assert.Equal("My name is Tom. I am 21 years old.", personMsg);
        }

        [Fact]
        public void Should_return_teacher_introduction_when_given_teacher()
        {
            Teacher teacher = new Teacher();
            string teacherMsg = teacher.Speak();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", teacherMsg);
        }

        [Fact]
        public void Should_return_student_introduction_when_given_student()
        {
            Student student = new Student();
            string studentMsg = student.Speak();
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", studentMsg);
        }
    }
}
