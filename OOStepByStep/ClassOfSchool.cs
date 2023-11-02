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
        private List<Student> students;

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

        public List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public Teacher ShowTeacher()
        {
            return teacherOfClass;
        }

        public void Join(Student newStudent)
        {
            return;
        }
    }
}
