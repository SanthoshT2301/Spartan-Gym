using SpartanGym_Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;


namespace SpartanGym_Business.Interface.User
{
    //GetAllUser
    //GetUserByID
    //GetUserNotPaid
    //AddNewUser
    //UpdateUserInformation

    public interface IUserService
    {
        public Task<List<UserDto>> GetAllUser();
        public Task<UserDto> GetUserById(int id);
        public Task<List<UserDto>> GetUserNotPaid();
        public Task AddNewUser(UserDto NewUser);
        public Task UpdateUserInformation(UserDto UpdateUser);
    }
}
