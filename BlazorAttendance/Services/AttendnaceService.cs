using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using BlazorAttendance.Models;
//using CloudKit;


namespace BlazorAttendance.Services
{
    public class AttendanceService : IAttendanceService
    {
        private SQLiteAsyncConnection _dbConnection;

        public AttendanceService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "Student.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Student>();
                await _dbConnection.CreateTableAsync<Attendance>();

            }
        }

        public async Task<int> UpdateStudent(Student studentModel)
        {
            return await _dbConnection.UpdateAsync(studentModel);
        }

        public async Task<List<Attendance>> GetAllRecords()
        {
            DateTime dt = DateTime.Today;
            return await _dbConnection.Table<Attendance>().Where(i => i.attDate.Equals(dt)).ToListAsync();
            

        }

        public async Task<List<RelationalTable>> GetRelationData(int id)
        {
            var student = await _dbConnection.QueryAsync<RelationalTable>($"Select * From Attendance a, Student b where a.StdID=b.Id and a.StdId={id}");
            return student.ToList();
        }
    
        public async Task<int> AddAttendance(Attendance AttendanceModel)
        {
            return await _dbConnection.InsertAsync(AttendanceModel);
        }

        public Task<int> UpdateAttendance(Attendance AttendanceModel)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAttendance(Attendance AttendanceModel)
        {
            return await _dbConnection.DeleteAsync(AttendanceModel);
        }

        public async Task<List<Attendance>> GetAttendanceByID(int StudentID)
        {
            var student = await _dbConnection.QueryAsync<Attendance>($"Select * From {nameof(Attendance)} where StdID={StudentID} ");
            return student.ToList();
        }
    }
}
