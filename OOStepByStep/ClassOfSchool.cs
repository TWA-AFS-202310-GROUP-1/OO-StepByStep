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
            students.Add(newStudent);
        }
    }
}
