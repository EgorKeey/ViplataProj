using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Mappers
{
    public static class RoleMapper
    {
        public static RoleViewModel Map(RoleEntity entity)
        {
            var viewModel = new RoleViewModel
            {
                ID = entity.ID,
                Name_Role = entity.Name_Role,
                
            };
            return viewModel;
        }

        public static List<RoleViewModel> Map(List<RoleEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}
