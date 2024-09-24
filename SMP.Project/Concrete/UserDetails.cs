using SMP.Project.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.Models.Concrete
{
    public class UserDetails : BaseEntity
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Role? Roles { get; set; }
        //public User? User { get; set; }
       
    }
}
