using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _EmployeeDal;

        public EmployeeManager(IEmployeeDal EmployeeDal)
        {
            _EmployeeDal = EmployeeDal;
        }
        public void Add(Employee Employee)
        {
            _EmployeeDal.Add(Employee);
        }

        public void Delete(Employee Employee)
        {
            _EmployeeDal.Delete(Employee);
        }

        public IList<Employee> GetAll()
        {
            return _EmployeeDal.GetAll();
        }

        public Employee GetById(int id)
        {
            return _EmployeeDal.Get(u=>u.EmployeeId==id);
        }

        public IList<Employee> GetEmployeesByName(string name)
        {
            return _EmployeeDal.GetEmployeesByName(name);
        }

        public void Update(Employee Employee)
        {
            _EmployeeDal.Update(Employee);
        }
    }
}
