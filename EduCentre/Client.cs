using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentre
{
    class Client
    {
        public Client(int ClientId, string LastName, string FirstName, string SecondName, string PhoneNumber, string Email)
        {
            this.ClientId = ClientId;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }

        public readonly int ClientId;
        public string LastName;
        public string FirstName;
        public string SecondName;
        public string PhoneNumber;
        public string Email;
    }
}
