using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatSupport.Models
{
    public class Chat
    {
        public int ChatId { get; set; }
        public string ClientUserName { get; set; }
        public ChatStatus chatStatus { get; set; }
        public virtual ICollection<Message> messages { get; set; }
    }

    public enum ChatStatus
    {
        Opened = 0,
        Chatting = 1,
        Complete = 2
    }
}
