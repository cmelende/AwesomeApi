using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AwesomeApi.ViewModels;
using Domain.Entities;
using Domain.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserViewModelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public UserViewModelController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return _unitOfWork
                .Users
                .GetAll()
                .Select(user => _mapper.Map<UserViewModel>(user));
        }
    }
}