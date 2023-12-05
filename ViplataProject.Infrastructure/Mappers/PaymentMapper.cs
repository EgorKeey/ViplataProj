using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.ViewModels;

namespace ViplataProject.Infrastructure.Mappers
{
    public static class PaymentMapper
    {
        public static PaymentViewModel Map(PaymentEntity entity)
        {
            var viewModel = new PaymentViewModel
            {
                ID = entity.ID,
                Rate = entity.Rate,
                Vacation = entity.Vacation,
                Bonus_For_Disability = entity.Bonus_For_Disability,
                Bonus_For_Done_Work = entity.Bonus_For_Done_Work,


            };
            return viewModel;
        }

        public static List<PaymentViewModel> Map(List<PaymentEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}
