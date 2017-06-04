using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentre
{
    class Group
    {
        public Group(int GroupId, int CourseId, string GroupName, List<Client> Clients)
        {
            this.GroupId = GroupId;
            this.CourseId = CourseId;
            this.GroupName = GroupName;
            this.Clients = new List<Client>();
        }

        public int GroupId;
        public int CourseId;
        public string GroupName;
        public List<Client> Clients;
    }
}
