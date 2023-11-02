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
        [InlineData("Tom", 18, "My name is Tom. I am 18 years old. I am a student.")]
        public void Should_introduce_student_when_self_introduce_given_student(string personName, int age, string expectMsg)
        {
            Student student = new Student(personName, age);
            string msg = student.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }

        [Theory]
        [InlineData("Amy", 30, "My name is Amy. I am 30 years old. I am a teacher.")]
        public void Should_introduce_teacher_when_self_introduce_given_teacher(string personName, int age, string expectMsg)
        {
            Teacher teacher = new Teacher(personName, age);
            string msg = teacher.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }

        [Theory]
        [InlineData("Tom", 18, 2, "My name is Tom. I am 18 years old. I am a student of class 2.")]
        public void Should_introduce_student_when_self_introduce_given_student_in_class(string personName, int age, int classNo, string expectMsg)
        {
            Student student = new Student(personName, age, classNo);
            string msg = student.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }

        [Theory]
        [InlineData("Amy", 30, 2, "My name is Amy. I am 30 years old. I am a teacher of class 2.")]
        public void Should_introduce_teacher_when_self_introduce_given_teacher_in_class(string personName, int age, int classNo, string expectMsg)
        {
            Teacher teacher = new Teacher(personName, age, classNo);
            string msg = teacher.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }

        [Theory]
        [InlineData("Tom", 18, "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.")]
        public void Should_teacher_welcome_when_no_student_in_class(string studentName, int studentAge, string expectMsg)
        {
            Teacher teacher = new Teacher("Amy", 30, 2);
            Class class2 = new Class(2, teacher);
            Student newComer = new Student(studentName, studentAge);
            string msg = class2.AddNewStudent(newComer);
            Assert.Equal(msg, expectMsg);
        }

        [Theory]
        [InlineData("Jim", 20, "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2." + "\n" +
            "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.")]
        public void Should_teacher_and_student_welcome_when_has_student_in_class(string studentName, int studentAge, string expectMsg)
        {
            Teacher teacher = new Teacher("Amy", 30, 2);
            Class class2 = new Class(2, teacher);
            Student exist = new Student("Tom", 18);
            string msg1 = class2.AddNewStudent(exist);

            Student newComer = new Student(studentName, studentAge);

            string msg = class2.AddNewStudent(newComer);
            Assert.Equal(msg, expectMsg);
        }
    }
}
