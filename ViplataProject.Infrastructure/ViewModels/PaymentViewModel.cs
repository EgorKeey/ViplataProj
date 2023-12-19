using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViplataProject.Infrastructure.ViewModels
{
    public class PaymentViewModel
    {
        public long ID { get; set; }
        public long EmployeeId { get; set; }
        public string Rate { get; set; }
        public decimal Vacation { get; set; }
        public decimal? Bonus_For_Disability { get; set; }
        public decimal? Bonus_For_Done_Work { get; set; }
    }
}
