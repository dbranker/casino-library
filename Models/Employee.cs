using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CasinoLibrary.Models
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string FirstName { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string LastName { get; set; }
        [MaxLength(320)]
        [Column(TypeName = "Varchar(320)")]
        public string Email { get; set; }
        public bool isActive { get; set; }
        public bool isOwner { get; set; }

    }
}
