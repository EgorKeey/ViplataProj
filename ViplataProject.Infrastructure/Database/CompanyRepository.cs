using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;
using ViplataProject.Infrastructure.Mappers;

namespace ViplataProject.Infrastructure.Database
{
    public class CompanyRepository
    {
        public List<CompanyViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Companies.ToList();
                return CompanyMapper.Map(items);
            }
        }
        public CompanyViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Companies.FirstOrDefault(x => x.ID == id);
                return CompanyMapper.Map(item);
            }
        }


    }

}
