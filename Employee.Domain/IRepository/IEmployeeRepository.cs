using Employee.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.IRepository
{
    public  interface IEmployeeRepository : IRepository<Employees>
    {
    }
}
