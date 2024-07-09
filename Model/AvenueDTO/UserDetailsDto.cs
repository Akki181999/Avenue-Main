using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Model.AvenueDTO
{
    public class UserDetailsDto
    {
        public int UserId { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Designation { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
    }
}