using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassOfSchool
    {
        private Teacher teacherOfClass;
        private List<Student> students = new List<Student>();
        private int classId;

        public ClassOfSchool(int id)
        {
            classId = id;
        }

        public Teacher TeacherOfClass
        {
            get
            {
                return teacherOfClass;
            }
            set
            {
                teacherOfClass = value;
            }
        }

        public string ShowStudents()
        {
            string introductions = string.Empty;
            foreach (Student student in students)
            {
                introductions += student.IntroduceOneself();
                introductions += "\n";
            }

            return introductions;
        }

        public Teacher ShowTeacher()
        {
            return TeacherOfClass;
        }

        public void Join(Student newStudent)
        {
            newStudent.ClassId = classId;
            students.Add(newStudent);
        }

        public string WelcomeNewStudent(Student newStudent, string name)
        {
            string result = string.Empty;

            result += teacherOfClass.IntroduceOneself();
            result += $" Welcome {name} join class {classId}.";
            result += "\n";

            foreach (Student student in students)
            {
                result += student.IntroduceOneself();
                result += $" Welcome {name} join class {classId}.";
                result += "\n";
            }

            Join(newStudent);

            return result;
        }
    }
}
