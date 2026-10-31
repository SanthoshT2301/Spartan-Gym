using AutoMapper;
using SpartanGym_Business.Interface.User;
using SpartanGym_Core.DTO;
using SpartanGym_Core.Mapper;
using SpartanGym_Core.Model;
using SpartanGym_Data;
using SpartanGym_Data.UserData;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Business.Implementation.Users
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UserData _data;
        public UserService(IMapper mapper)
        {
           
            _mapper = mapper;
        }

        public async Task AddNewUser(CreateUser NewUser)
        {
            var user=_mapper.Map<User>(NewUser);
            _data.AddNewData(user);
           
            throw new NotImplementedException();
        }

        public Task<List<UserDto>> GetAllUser()
        {
            throw new NotImplementedException();
        }
        public Task<UserDto> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDto>> GetUserNotPaid()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserInformation(UserDto UpdateUser)
        {
            throw new NotImplementedException();
        }
    }
}
