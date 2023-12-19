using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Mappers
{
    public static class EmployeeMapper
    {
        public static EmployeeViewModel Map(EmployeeEntity entity)
        {
            var viewModel = new EmployeeViewModel
            {
                ID = entity.ID,
                Second_Name = entity.Second_Name,
                Name = entity.Name,
                Patronymic = entity.Patronymic,
                Date_Of_Birth = entity.Date_Of_Birth,
                Gender = entity.Gender == "м"? "мужской" : "женский",
                disability = entity.disability,
                expirience = entity.expirience,
                UserId = entity.UserId,
                JobId = entity.JobId,
                CompanyId = entity.CompanyId,
            };
            return viewModel;
        }

        public static List<EmployeeViewModel> Map(List<EmployeeEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }

}

