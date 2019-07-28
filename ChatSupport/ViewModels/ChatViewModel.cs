using ChatSupport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSupport.ViewModels
{
    public class ChatViewModel
    {
        [ScaffoldColumn(false)]
        public int ChatId { get; set; }
        [Display(Description = "Customer")]
        public string ClientUserName { get; set; }
    }
}
