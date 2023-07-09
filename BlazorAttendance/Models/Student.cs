using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlazorAttendance.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Roll No is Required")]
        public string RollNo { get; set; }

        [Required(ErrorMessage = "Mobile No is Required")]
        [RegularExpression("^[789]\\d{9}", ErrorMessage = "Invalid Mobile No")]
        public string Mobile { get; set; }

        public byte[] myArray { get; set; }
    }
}
