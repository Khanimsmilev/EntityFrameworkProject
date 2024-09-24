using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMP.Project.DAL.Context;
using SMP.Project.Models.Concrete;

namespace SMP.Project.DAL.Repositories.Concrete
{
    public class PostRepository : BaseRepository<Post>
    {
        public PostRepository(SMDBcontext dbContext) : base(dbContext)
        {
        }
    }
}
