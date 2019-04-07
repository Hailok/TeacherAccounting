using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TeacherAccounting
{
    [DataContract]
    class Teacher
    {
        [DataMember]
        public string teacher_name;
        [DataMember]
        public int total_hour_allowed;
        public Teacher(string teacher_name, int total_hour_allowed)
        {
            this.teacher_name = teacher_name;
            this.total_hour_allowed = total_hour_allowed;
        }
    }
}
