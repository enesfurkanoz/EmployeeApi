using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IList<Employee> GetAll();
        IList<Employee> GetEmployeesByName(string name);

        Employee GetById(int id);

        void Add(Employee Employee);
        void Update(Employee Employee);
        void Delete(Employee Employee);

    }
}
