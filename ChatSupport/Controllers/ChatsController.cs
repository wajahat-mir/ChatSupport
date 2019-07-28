using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChatSupport.Models;
using ChatSupport.Repositories;
using ChatSupport.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ChatSupport.Controllers
{
    public class ChatsController : Controller
    {
        private readonly IChatRepository _chatRepository;
        private readonly IMapper _mapper;

        public ChatsController(IChatRepository chatRepository, IMapper mapper)
        {
            _chatRepository = chatRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var chats = await _chatRepository.GetAllOpenChats();
            var chatsViewModel = _mapper.Map<IEnumerable<ChatViewModel>>(chats);

            return View(chatsViewModel);
        }

    }
}