using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.Mappers;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Database
{
    public class RoleRepository
    {
        public List<RoleViewModel> GetList()
        {
            using (var context = new Contxt())
            {
                var items = context.Role.ToList();
                return RoleMapper.Map(items);
            }
        }
        public RoleViewModel GetById(long id)
        {
            using (var context = new Contxt())
            {
                var item = context.Role.FirstOrDefault(x => x.ID == id);
                return RoleMapper.Map(item);
            }
        }
    }
}
