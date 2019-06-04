using System.Threading.Tasks;
using AutoMapper;
using ChessApp.API.Data;
using ChessApp.API.Dtos;
using ChessApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChessApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IUserRepository _repo { get; set; }
        public IMapper _mapper { get; set; }

        public UsersController(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);

            return Ok(user);
        }
    }
}