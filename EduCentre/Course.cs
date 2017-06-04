using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentre
{
    class Course
    {
        public Course(int CourseId, string CourseName, string CourseType, int Duration, double Price, List<Teacher> Teachers, List<Group> Groups, List<Class> Classes)
        {
            this.CourseId = CourseId;
            this.CourseName = CourseName;
            this.CourseType = CourseType;
            this.Duration = Duration;
            this.Price = Price;
            this.Teachers = new List<Teacher>();
            this.Groups = new List<Group>();
            this.Classes = new List<Class>();
        }
        public int CourseId;
        public string CourseName;
        public string CourseType;
        public int Duration;
        public double Price;
        public DateTime StartDate;
        public DateTime EndDate;
        public List<Teacher> Teachers;
        public List<Group> Groups;
        public List<Class> Classes;
    }
}
