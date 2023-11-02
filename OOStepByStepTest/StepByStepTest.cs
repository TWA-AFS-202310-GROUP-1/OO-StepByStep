namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StepByStepTest
    {
        [Theory]
        [InlineData("Tom", 21, "My name is Tom. I am 21 years old.")]
        public void Should_introduce_person_when_self_introduce_given_person(string personName, int age, string expectMsg)
        {
            Person person = new Person(personName, age);
            string msg = person.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }

        [Theory]
        [InlineData("Tom", 18, "My name is Tom. I am 18 years old. I am a student")]
        public void Should_introduce_student_when_self_introduce_given_student(string personName, int age, string expectMsg)
        {
            Student student = new Student(personName, age);
            string msg = student.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }

        [Theory]
        [InlineData("Amy", 30, "My name is Amy. I am 30 years old. I am a teacher")]
        public void Should_introduce_teacher_when_self_introduce_given_teacher(string personName, int age, string expectMsg)
        {
            Teacher teacher = new Teacher(personName, age);
            string msg = teacher.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }
    }
}
