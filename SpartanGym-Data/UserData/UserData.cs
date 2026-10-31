using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Extensions.Logging;
using SpartanGym_Core.Model;

namespace SpartanGym_Data.UserData
{
    public class UserData
    {
        private readonly AppDBContext _context;
        public UserData(AppDBContext context)
        {
            _context = context;
        }

        public bool AddNewData(User AddUser)
        {
            try
            {
                _context.Users.Add(AddUser);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
            
           
        }
    }
}
