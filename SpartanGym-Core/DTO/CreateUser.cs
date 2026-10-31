using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.DTO
{
    public class CreateUser
    {
        public int RoleId {  get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Password { get; set; }
        public int SubscriptionId { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public double Weight { get; set; }
        public DateTime Created { get; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
