using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentre
{
    class Class
    {
        public Class(int ClassId, int CourseId, int GroupId, int TeacherId, string ClassName, DateTime ClassDate, DateTime ClassTime, int Classroom)
        {
            this.ClassId = ClassId;
            this.CourseId = CourseId;
            this.GroupId = GroupId;
            this.TeacherId = TeacherId;
            this.ClassName = ClassName;
            this.Classroom = Classroom;
        }
        public readonly int ClassId;
        public int CourseId;
        public int GroupId;
        public int TeacherId;
        public string ClassName;
        public DateTime ClassDate;
        public DateTime ClassTime;
        public int Classroom;
    }
}
