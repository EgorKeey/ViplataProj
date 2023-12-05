using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Mappers
{
    public static class JobMapper
    {
        public static JobViewModel Map(JobEntity entity)
        {
            var viewModel = new JobViewModel
            {
                ID = entity.ID,
                Title = entity.Title,
                Work_Day = entity.Work_Day,


            };
            return viewModel;
        }

        public static List<JobViewModel> Map(List<JobEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}
