using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementAdmission.Models
{
    public class StudentAdmissionDetailsModel
    {


        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
