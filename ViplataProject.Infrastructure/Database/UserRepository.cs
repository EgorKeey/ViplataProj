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
            using (var context = new Context())
            {
                var items = context.Users.ToList();
                return UserMapper.Map(items);
            }
        }
        public UserViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Users.FirstOrDefault(x => x.ID == id);
                return UserMapper.Map(item);
            }
        }
    }
}
