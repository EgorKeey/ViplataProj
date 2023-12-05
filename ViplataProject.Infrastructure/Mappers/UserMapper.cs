using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel Map(UserEntity entity)
        {
            var viewModel = new UserViewModel
            {
                ID = entity.ID,
                Login = entity.Login,
                Password = entity.Password,
                RoleId = entity.RoleId,


            };
            return viewModel;
        }

        public static List<UserViewModel> Map(List<UserEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}
