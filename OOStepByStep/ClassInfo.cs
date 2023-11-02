using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassInfo
    {
        private string classNo;
        private Teacher? teacher;
        private List<Student>? students;
        public ClassInfo(string classNo, Teacher teacher, List<Student> students)
        {
            this.classNo = classNo;
            this.teacher = teacher;
            this.students = students;
        }

        public string Join(Student newStudent)
        {
            this.students.Add(newStudent);
            string result = string.Empty;
            if (students != null)
            {
                foreach (Student student in students)
                {
                    result += student.Introduce() + $" Welcome {newStudent.Name()} join class {classNo}.\n";
                }
            }

            if (teacher != null)
            {
                result += teacher.Introduce() + $" Welcome {newStudent.Name()} join class {classNo}.";
            }

            return result;
        }
    }
}
