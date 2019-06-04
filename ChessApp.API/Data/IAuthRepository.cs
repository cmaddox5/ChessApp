using System.Threading.Tasks;
using ChessApp.API.Models;

namespace ChessApp.API.Data
{
    public interface IAuthRepository
    {
        Task<bool> UserExists(string email);
        Task<User> RegisterUser(User user, string password);
        Task<User> Login(string email, string password);
    }
}