using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSupport.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Text { get; set; }
        public int ChatId { get; set; }
        public virtual Chat chat {get; set;}
    }
}
