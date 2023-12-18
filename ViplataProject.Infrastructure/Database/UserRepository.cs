using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.Mappers;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Database
{
    public class UserRepository
    {
        public List<UserViewModel> GetList()
        {
            using (var context = new Contxt())
            {
                var items = context.User.ToList();
                return UserMapper.Map(items);
            }
        }
        public UserViewModel GetById(long id)
        {
            using (var context = new Contxt())
            {
                var item = context.User.FirstOrDefault(x => x.ID == id);
                return UserMapper.Map(item);
            }
        }
    }
}
