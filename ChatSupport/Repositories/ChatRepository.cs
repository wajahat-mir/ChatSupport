using ChatSupport.Data;
using ChatSupport.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSupport.Repositories
{
    public interface IChatRepository
    {
        Task<IEnumerable<Chat>> GetAllOpenChats();
        Task<Chat> FindChat(int id);
        Task<bool> UpdateChatStatus(int id, ChatStatus chatStatus);
    }
    public class ChatRepository : IChatRepository
    {
        private ApplicationDbContext _db;

        public ChatRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Chat>> GetAllOpenChats()
        {
            var chats = await _db.Chats.Where(c => c.chatStatus == ChatStatus.Opened).ToListAsync();
            return chats;
        }

        public async Task<Chat> FindChat(int id)
        {
            var chat = await _db.Chats.FindAsync(id);
            return chat;
        }

        public async Task<bool> UpdateChatStatus(int id, ChatStatus chatStatus)
        {
            var chat = await FindChat(id);
            chat.chatStatus = chatStatus;
            _db.Entry(chat).State = EntityState.Modified;
            int retValue = await _db.SaveChangesAsync();

            if (retValue > 0)
                return true;
            return false;
        }

    }
}
