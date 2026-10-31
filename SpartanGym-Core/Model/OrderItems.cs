using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.Model
{
    public class OrderItems
    {
        public int OrderItemId {  get; set; }
        public int OrderId {  get; set; }
        public int SupplementId {  get; set; }
        public int Quantity {  get; set; }
        public double UnitPrice {  get; set; }
    }
}
