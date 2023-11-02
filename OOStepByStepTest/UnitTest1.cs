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
            var student = new Student("Tom", 18, new Clazz(2));
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", student.Introduce());
        }

        [Fact]
        public void Teacher_WithClassNumber_Introduction_IsCorrect()
        {
            var teacher = new Teacher("Amy", 30, new Clazz(2));
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", teacher.Introduce());
        }

        [Fact]
        public void All_clazz_members_introduce_when_a_new_student_come_in()
        {
            Clazz clazz = new Clazz(2);
            var student = new Student("Tom", 18, clazz);
            var teacher = new Teacher("Amy", 30, clazz);
            clazz.AddTeacher(teacher);
            clazz.AddStudent(student);
            var newStudent = new Student("Jim", 18);

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.\n" +
                "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.\n"
                , newStudent.Join(clazz));

        }

       
      

    }
}
