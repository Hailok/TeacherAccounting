using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAccounting
{
    class Teacher
    {
        public string teacher_name;
        public string subject_name;
        public Teacher(string teacher_name, string subject_name)
        {
            this.teacher_name = teacher_name;
            this.subject_name = subject_name;
        }
    }
}
