using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentre
{
    class Request
    {
        public Request(int RequestId, int CourseId, string Text, string Status)
        {
            this.RequestId = RequestId;
            this.CourseId = CourseId;
            this.Text = Text;
            this.Status = Status;
        }

        private int RequestId;
        public int CourseId;
        public string Text;
        public DateTime RequestDate;
        public DateTime RequestTime;
        public string Status;
    }
}
