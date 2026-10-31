using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.Model
{
    public class Fee
    {
        public int FeeId {  get; set; }
        public int userId {  get; set; }
        public int StatusId {  get; set; }
        public DateTime DateOfPayment { get; set; }
        public int SubscriptionId {  get; set; }
    }
}
