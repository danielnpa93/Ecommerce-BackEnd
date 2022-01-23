using BCrypt.Net;
using ECommerce.API.Models.Dtos;
using ECommerce.API.Models.Entities;
using ECommerce.API.Repository.Interfaces;
using ECommerce.API.Utils;
using System;
using System.Threading.Tasks;

namespace ECommerce.API.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _repository;

        public UserServices(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseEnvelope<UserDTO>> CreateUser(CreateUserDTO user)
        {
            var obj = await _repository.GetUserByName(user.Username);

            if(obj != null)
            {
                return ResponseEnvelope<UserDTO>.CreateFailure(null, "Username já utilizado");
            }

            var newUser = await _repository.CreateUser(new User 
            {   Id = Guid.NewGuid(),
                Password = BCrypt.Net.BCrypt.HashPassword(user.Password), 
                Username = user.Username 
            });

            return ResponseEnvelope<UserDTO>.CreateSucess(new UserDTO { Username= newUser.Username,Id= newUser.Id.ToString()});

        }
    }
}
