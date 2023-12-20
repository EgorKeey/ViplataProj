using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViplataProject.Infrastructure.ViewModels
{
    public class RoleViewModel
    {
        public long ID { get; set; }
        public string Name_Role { get; set; }
    }
}
