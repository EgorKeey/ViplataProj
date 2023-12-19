using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.Mappers;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Database
{
    public class JobRepository
    {
        public List<JobViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Job.ToList();
                return JobMapper.Map(items);
            }
        }
        public JobViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Job.FirstOrDefault(x => x.ID == id);
                return JobMapper.Map(item);
            }
        }
    }
}
