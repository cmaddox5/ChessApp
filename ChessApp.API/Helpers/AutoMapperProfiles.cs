using AutoMapper;
using ChessApp.API.Dtos;
using ChessApp.API.Models;

namespace ChessApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterUserDto, User>();
            CreateMap<User, UserDetailsDto>();
        }
    }
}