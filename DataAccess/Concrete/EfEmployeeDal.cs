using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, EmployeesAppContext>, IEmployeeDal
    {
        public List<Employee> GetEmployeesByName(string name)
        {
            using(EmployeesAppContext context=new EmployeesAppContext())
            {
                var result = context.Set<Employee>().Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name));

                return result.ToList();

            }
        }
    }
}
