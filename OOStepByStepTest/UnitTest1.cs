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

        [Fact]
        public void Should_return_teacher_introduction_include_classInfo_when_given_teacher()
        {
            Teacher teacher = new Teacher();

            string teacherMsg = teacher.Speak(2);
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", teacherMsg);
        }

        [Fact]
        public void Should_return_student_introduction_include_classInfo_when_given_student()
        {
            Student student = new Student();
            string studentMsg = student.Speak(2);
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", studentMsg);
        }

        [Fact]
        public void Should_return_teacher_introduction_include_welcome_when_not_given_new_student()
        {
            Teacher teacher = new Teacher();
            Student allstudent = new Student(2);
            Class updateclass = new Class(teacher, 2);

            string teacherMsg = updateclass.WelcomeStudent(allstudent);

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.", teacherMsg);
        }

        [Fact]
        public void Should_return_student_introduction_include_welcome_when_given_new_student()
        {
            Teacher teacher = new Teacher();
            Student allstudent = new Student(2);
            Student newstudent = new Student("Jim", 2);
            Class updateclass = new Class(teacher, 2);

            string teacherMsg = updateclass.WelcomeNewStudent(allstudent, newstudent);

            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.", teacherMsg);
        }
    }
}
