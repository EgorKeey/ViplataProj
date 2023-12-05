using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViplataProject.Infrastructure.ViewModels
{
    public class EmployeeViewModel
    {
        public long ID { get; set; }
        public string Second_Name { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public string disability { get; set; }
        public string expirience { get; set; }
        public long UserId { get; set; }
        public long JobId { get; set; }
        public long CompanyId { get; set; }
    }
}
