using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAttendance.Models
{
    public class Attendance
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public int StdID { get; set; }

        public string Name { get; set; }

        public string RollNo { get; set; }

        public string Mobile { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime attDate { get; set; } = DateTime.Today;
        
        public string Stdattendence { get; set; }
    }
}
