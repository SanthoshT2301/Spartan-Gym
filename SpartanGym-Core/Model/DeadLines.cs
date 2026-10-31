using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.Model
{
    public class DeadLines
    {
        public int DeadLineId { get; set; }
        public int UserId {  get; set; }
        public int SubscriptionId {  get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
