using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.DTO
{
    public class UserDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; } 
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public int SubscriptionId { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public double Weight { get; set; }
        public DateTime Created { get; } 
        public bool IsActive { get; set; }
    }
}
