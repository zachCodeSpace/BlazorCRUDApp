using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IEmployeeData
    {
        Task<List<EmployeeModel>> GetEmployees();
        Task InsertEmployee(EmployeeModel employee);
    }
}