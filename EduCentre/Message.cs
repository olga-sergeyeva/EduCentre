using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentre
{
    class Message
    {
        public Message(int MessageId, int Sender, int Receiver, string Text, string Status)
        {
            this.MessageId = MessageId;
            this.Sender = Sender;
            this.Reciever = Receiver;
            this.Text = Text;
            this.Status = Status;
        }

        private int MessageId;
        public int Sender;
        public int Reciever;
        public string Text;
       // public DateTime MessageDate;
        //public DateTime MessageTime;
        public string Status;
    }
}
