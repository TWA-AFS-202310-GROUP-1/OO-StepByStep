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

        public string WelcomeNewStudent(Student allstudent)
        {
            string finalmsg = teacher.Speak(classInfo);
            finalmsg += $" Welcome {allstudent.GiveName()} join class {allstudent.GiveClassInfo()}.";
            return finalmsg;
        }
    }
}
