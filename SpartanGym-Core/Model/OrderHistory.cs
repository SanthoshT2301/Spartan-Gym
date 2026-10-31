using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.Model
{
    public class OrderHistory
    {
        public int OrderHistoryid {  get; set; }
        public int OrderId { get; set; }
        public int OrderStatusId {  get; set; }
        public DateTime ChangedOn {  get; set; }

    }
}
