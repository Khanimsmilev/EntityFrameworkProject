using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMP.Project.DAL.Context;
using SMP.Project.Models.Concrete;

namespace SMP.Project.DAL.Repositories.Concrete
{
    public class UserDetailsRepository : BaseRepository<UserDetails>
    {
        public UserDetailsRepository(SMDBcontext dbContext) : base(dbContext)
        {
        }
    }
}
