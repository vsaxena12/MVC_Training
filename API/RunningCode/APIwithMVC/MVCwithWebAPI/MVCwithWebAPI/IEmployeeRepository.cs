using MVCwithWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCwithWebAPI
{
    public interface IEmployeeRepository
    {
        Task Add(Employee employee);
        Task Update(Employee employee);
        Task Delete(string id);
        Task<Employee> GetEmployee(string id);
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
