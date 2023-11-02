using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private int? classNo = null;
        private Teacher? teacher = null;
        private List<Student> students = new List<Student>();

        public Class(int classNo, Teacher teacher)
        {
            this.classNo = classNo;
            this.teacher = teacher;
        }

        public string AddNewStudent(Student student)
        {
            student.ClassNo = classNo;
            string teacherWelcome = this.teacher.SelfIntroduce() + " Welcome " + student.Name + " join class " + student.ClassNo + ".";

            List<string> studentsWelcomeList = new ();

            if (students.Count > 0)
            {
                foreach (var s in students)
                {
                    studentsWelcomeList.Add(s.SelfIntroduce() + " Welcome " + student.Name + " join class " + student.ClassNo + ".");
                }
            }

            string studentsWelcome = string.Join("\n", studentsWelcomeList);
            this.students.Add(student);

            return students.Count == 1 ? teacherWelcome : teacherWelcome + "\n" + studentsWelcome;
        }
    }
}
