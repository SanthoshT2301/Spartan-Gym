using System;
using System.Collections.Generic;
using System.Text;
using SpartanGym_Core.DTO;

namespace SpartanGym_Business.Interface.Attendance
{
    public interface IAttendanceService
    {
        //GetAttendanceByUser
        //GetMyAttendance
        //AddAttendance
        //GetAttendanceByUserId

        public Task<List<AttendanceDto>> GetAttendanceByUser();
        public Task<List<AttendanceDto>> GetMyAttendance();
        public Task<bool> AddAttendance(int userId);
        public Task<List<AttendanceDto>> GetAttendanceByUserId(int userId);
    }
}
