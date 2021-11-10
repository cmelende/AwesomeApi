using AutoMapper;
using Domain.Entities;

namespace AwesomeApi.ViewModels.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}