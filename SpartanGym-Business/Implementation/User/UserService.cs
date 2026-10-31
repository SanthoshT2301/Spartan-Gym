using SpartanGym_Business.Interface.User;
using SpartanGym_Core.DTO;
using SpartanGym_Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Business.Implementation.User
{
    public class UserService : IUserService
    {

       

        public Task AddNewUser(UserDto NewUser)
        {
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
