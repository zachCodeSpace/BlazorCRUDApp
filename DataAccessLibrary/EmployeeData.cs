using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class EmployeeData : IEmployeeData
    {
        private readonly ISQLDataAccess _db;

        public EmployeeData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<EmployeeModel>> GetEmployees()
        {
            string sql = "SELECT * FROM dbo.Employees";

            return _db.LoadData<EmployeeModel, dynamic>(sql, new { });

        }

        public Task InsertEmployee(EmployeeModel employee)
        {
            string sql = @"INSERT INTO dbo.Employees (FirstName, LastName, EmailAddress)
                            values (@FirstName, @LastName, @EmailAddress)";

            return _db.SaveData(sql, employee);
        }
    }
}
