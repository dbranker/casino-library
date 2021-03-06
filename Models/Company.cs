using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasinoLibrary.Models
{
    public class Company
    {
        public Guid CompanyID { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Employee> Admins { get; set; }


    }
}
