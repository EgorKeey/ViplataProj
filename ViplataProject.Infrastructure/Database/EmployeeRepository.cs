using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;
using ViplataProject.Infrastructure.Mappers;

namespace ViplataProject.Infrastructure.Database
{
    public class EmployeeRepository
    {
        public List<EmployeeViewModel> GetList()
        {
            using (var context = new Contxt())
            {
                var items = context.Employee.ToList();
                return EmployeeMapper.Map(items);
            }
        }
        public EmployeeViewModel GetById(long id)
        {
            using (var context = new Contxt())
            {
                var item = context.Employee.FirstOrDefault(x => x.ID == id);
                return EmployeeMapper.Map(item);
            }
        }
    }
}
