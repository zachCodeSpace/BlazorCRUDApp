namespace BlazorCRUDApp.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Guid = Guid.NewGuid(),
                Name = "Employee 1"
            }
        };
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
