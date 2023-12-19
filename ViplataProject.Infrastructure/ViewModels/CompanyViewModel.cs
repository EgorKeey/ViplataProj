using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViplataProject.Infrastructure.ViewModels
{
    public class CompanyViewModel
    {
        public long ID { get; set; }
        public long Name_Company { get; set; }
        public string Physical_Address { get; set; }
        public string Legal_Address { get; set; }
    }
}
