using System.Threading.Tasks;
using ChessApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChessApp.API.Data
{
    public class UserRepository : IUserRepository
    {
        public DataContext _context { get; set; }

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}