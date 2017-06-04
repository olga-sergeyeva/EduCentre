using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentre
{
    class Course
    {
        public int CourseId;
        public string CourseName;
        public string CourseType;
        public int Duration;
        public DateTime StartDate;
        public DateTime EndDate;
        public List<Teacher> Teachers;
        public List<Group> Groups;
        public List<Class> Classes;
    }
}
