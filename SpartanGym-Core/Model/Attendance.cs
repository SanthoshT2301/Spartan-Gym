using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Core.Model
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int UserId {  get; set; }
        public DateOnly AttenDate {  get; set; }
        public TimeOnly AttenTime {  get; set; }
    }
}
