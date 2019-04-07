using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAccounting
{
    class Subject
    {
        public string subject_name;
        public string teacher_name;
        public Subject(string subject_name, string teacher_name)
        {
            this.subject_name = subject_name;
            this.teacher_name = teacher_name;
        }
    }
}
