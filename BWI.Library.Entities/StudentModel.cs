using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BWI.Library.Entities
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string RollNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisteredDate { get; set; } = DateTime.Now;
        public DateTime ExpiredDate { get; set; }

    }
}
