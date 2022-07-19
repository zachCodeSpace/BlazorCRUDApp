using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string FirstName { get;set; }
        public string LastName { get;set; } 
        public string EmailAddress { get;set; }
        public bool isEditing { get;set; }
        public bool Deleted { get;set; }
        public bool IsAdmin { get;set; }
        public string Title { get;set; }
    }
}
