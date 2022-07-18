using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class PaymentModel
    {
        public int ID { get; set; } 
        public int EmployeeID { get; set; }
        public string PaymentType { get; set; }
        public int Rate { get; set; }
    }
}
