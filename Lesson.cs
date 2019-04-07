using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAccounting
{
    class Lesson
    {
        public string lesson_name;
        public string teacher_name;
        public Lesson(string lesson_name, string teacher_name)
        {
            this.lesson_name = lesson_name;
            this.teacher_name = teacher_name;
        }
    }
}
