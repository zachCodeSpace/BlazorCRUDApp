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
            string sql = "SELECT * FROM dbo.Employees WHERE Deleted = 0";

            return _db.LoadData<EmployeeModel, dynamic>(sql, new { });

        }
        
        public Task<List<ActivityModel>> GetActivities()
        {
            string sql = "  SELECT CONCAT(e.FirstName, ' ', e.LastName) as [Name], a.ID, ActivityType, [Action] FROM dbo.EmployeeActivity a left join dbo.Employees e on a.EmployeeID = e.ID";

            return _db.LoadData<ActivityModel, dynamic>(sql, new { });
        }
        public Task InsertEmployee(EmployeeModel employee)
        {
            string sql = @"INSERT INTO dbo.Employees (FirstName, LastName, EmailAddress)
                            values (@FirstName, @LastName, @EmailAddress)";

            return _db.SaveData(sql, employee);
        }

        public Task UpdateEmployee(EmployeeModel employee)
        {
            string sql = @"UPDATE dbo.Employees 
                           SET 
                           FirstName = @FirstName,
                           LastName = @LastName,
                           EmailAddress = @EmailAddress,
                           IsAdmin = @IsAdmin,
                           Title = @Title,
                           Deleted = @Deleted
                           WHERE ID = @ID";

            return _db.SaveData(sql, employee);
        }

        public Task<List<PaymentModel>> GetAllPayment()
        {
            string sql = "SELECT * FROM dbo.Payment";

            return _db.LoadData<PaymentModel, dynamic>(sql, new { });
        }
    }
}
