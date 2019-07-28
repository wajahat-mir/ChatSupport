using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatSupport.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ChatSupport.Controllers
{
    public class ChatNowController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ChatNowController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int ChatId)
        {
            ApplicationUser usr = await _userManager.GetUserAsync(HttpContext.User);

            return View(usr);
        }
    }
}