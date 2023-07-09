using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorAttendance.Models;

namespace BlazorAttendance.Services
{
    public interface IAttendanceService
    {
        Task<List<Attendance>> GetAllRecords();
        Task<List<RelationalTable>> GetRelationData(int id);
        Task<List<Attendance>> GetAttendanceByID(int StudentID);
        Task<int> AddAttendance(Attendance AttendanceModel);
        Task<int> UpdateAttendance(Attendance AttendanceModel);
        Task<int> DeleteAttendance(Attendance AttendanceModel);
    }
}
