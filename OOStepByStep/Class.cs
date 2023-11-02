using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private Teacher teacher;
        private List<Student> students = new ();
        private int classInfo;
        public Class(Teacher teacher, int classInfo)
        {
            this.teacher = teacher;
            this.classInfo = classInfo;
        }

        public string WelcomeStudent(Student allstudent)
        {
            string finalmsg = teacher.Speak(classInfo);
            finalmsg += $" Welcome {allstudent.GiveName()} join class {allstudent.GiveClassInfo()}.";
            return finalmsg;
        }

        public string WelcomeNewStudent(Student allstudent, Student newstudent)
        {
            students.Add(allstudent);
            students.Add(newstudent);

            string finalmsg = students[0].Speak(classInfo);
            finalmsg += $" Welcome {students[1].GiveName()} join class {students[1].GiveClassInfo()}.";
            return finalmsg;
        }
    }
}
