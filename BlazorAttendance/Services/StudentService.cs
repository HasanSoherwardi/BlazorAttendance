using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using BlazorAttendance.Models;


namespace BlazorAttendance.Services
{
    public class StudentService : IStudentService
    {
        private SQLiteAsyncConnection _dbConnection;

        public StudentService()
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

        public async Task<int> AddStudent(Student studentModel)
        {
            return await _dbConnection.InsertAsync(studentModel);
        }

        public async Task<int> DeleteStudent(Student studentModel)
        {
            return await _dbConnection.DeleteAsync(studentModel);
        }

        public async Task<List<Student>> GetAllStudent()
        {
            return await _dbConnection.Table<Student>().ToListAsync();
        }

        public async Task<Student> GetStudentByID(int StudentID)
        {
            var student = await _dbConnection.QueryAsync<Student>($"Select * From {nameof(Student)} where id={StudentID} ");
            return student.FirstOrDefault();
        }

        public async Task<int> UpdateStudent(Student studentModel)
        {
            return await _dbConnection.UpdateAsync(studentModel);
        }
    }
}
