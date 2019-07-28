using AutoMapper;
using ChatSupport.Models;
using ChatSupport.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSupport.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Chat, ChatViewModel>();
            CreateMap<ChatViewModel, Chat>();
        }
    }
}
