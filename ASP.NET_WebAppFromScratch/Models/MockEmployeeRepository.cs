using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_WebAppFromScratch.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
       

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name ="Awais", Department = Dept.HR, Email = "mawas__7@gmail.com"},
                new Employee(){Id = 2, Name ="Asim", Department = Dept.IT, Email = "asim__7@gmail.com"},
                new Employee(){Id = 3, Name ="Mustensar", Department = Dept.IT, Email = "mustensar__7@gmail.com"},
                new Employee(){Id = 4, Name ="Ayesha", Department = Dept.HR, Email = "ayesha__7@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}