using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.Mappers;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Database
{
    public class PaymentRepository
    {
            public List<PaymentViewModel> GetList()
            {
                using (var context = new Context())
                {
                    var items = context.Payments.ToList();
                    return PaymentMapper.Map(items);
                }
            }
            public PaymentViewModel GetById(long id)
            {
                using (var context = new Context())
                {
                    var item = context.Payments.FirstOrDefault(x => x.ID == id);
                    return PaymentMapper.Map(item);
                }
            }
        
    }
}
