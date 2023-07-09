using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorAttendance.Models;

namespace BlazorAttendance.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudent();
        Task<Student> GetStudentByID(int StudentID);
        Task<int> AddStudent(Student studentModel);
        Task<int> UpdateStudent(Student studentModel);
        Task<int> DeleteStudent(Student studentModel);
    }
}
