using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.Model
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public string PlanName {  get; set; }
        public int DurationInMonths {  get; set; }
        public double Price {  get; set; }
    }
}
