using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TeacherAccounting
{
    [DataContract]
    class Subject
    {
        [DataMember]
        public string subject_name;
        [DataMember]
        public int total_hour_need;
        public Subject(string subject_name, int total_hour_need)
        {
            this.subject_name = subject_name;
            this.total_hour_need = total_hour_need;
        }
    }
}
