using System.Threading.Tasks;
using ChessApp.API.Models;

namespace ChessApp.API.Data
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);
    }
}