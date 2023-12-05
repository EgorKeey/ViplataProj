using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Mappers
{
    public static class CompanyMapper
    {
        public static CompanyViewModel Map(CompanyEntity entity)
        {
            var viewModel = new CompanyViewModel
            {
                ID = entity.ID,
                Name_Company = entity.Name_Company,
                Legal_Address = entity.Legal_Address,
                Physical_Address = entity.Physical_Address,


            };
            return viewModel;
        }

        public static List<CompanyViewModel> Map(List<CompanyEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}
