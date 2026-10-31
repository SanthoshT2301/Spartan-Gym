using AutoMapper;
using SpartanGym_Core.DTO;
using SpartanGym_Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.Mapper
{
    public class Map:Profile
    {
        public Map()
        {
            CreateMap<UserDto, User>();
            CreateMap<CreateUser, User>();
        }
    }
}
