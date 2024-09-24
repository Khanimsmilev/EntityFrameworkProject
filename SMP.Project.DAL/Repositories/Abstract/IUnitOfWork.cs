using SMP.Project.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.DAL.Repositories.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Post> Posts { get; }
        IRepository<Comment> Comments { get; }
        IRepository<User> Users { get; }
        IRepository<UserDetails> UserDetails { get; }
        int Complete();
    }
}
