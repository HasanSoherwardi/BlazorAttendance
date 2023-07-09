using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAttendance.Models
{
    public class RelationalTable
    {
        
        public int id { get; set; }
        public int StdID { get; set; }
        public string Name { get; set; }

        public string RollNo { get; set; }

        public string Mobile { get; set; }

        public byte[] myArray { get; set; }

        [DataType(DataType.Date)]
        public DateTime attDate { get; set; } = DateTime.Now;

        public string Stdattendence { get; set; }
    }
}
