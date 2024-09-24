using SMP.Project.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.Models.Concrete
{
    public class User : BaseEntity
    {
        public int UserDetailsId { get; set; }
        public UserDetails? UserDetails { get; set; }
        public ICollection<Post>? Posts { get; set; }
        //public ICollection<Comment>? Comments { get; set; }

    }
}
