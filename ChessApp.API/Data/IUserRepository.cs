using System.Collections.Generic;
using System.Threading.Tasks;
using ChessApp.API.Models;

namespace ChessApp.API.Data
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);
        Task<IEnumerable<User>> GetUsers();
    }
}