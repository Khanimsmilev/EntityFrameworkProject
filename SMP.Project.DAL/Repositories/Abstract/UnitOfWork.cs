using SMP.Project.DAL.Context;
using SMP.Project.DAL.Repositories.Concrete;
using SMP.Project.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.DAL.Repositories.Abstract
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly SMDBcontext _context;
        public IRepository<User> Users { get; set; }
        public IRepository<Comment> Comments { get; set; }
        public IRepository<Post> Posts { get; set; }
        public IRepository<UserDetails> UserDetails { get; set; }

        public UnitOfWork(SMDBcontext context)
        {
            _context = context;
            Posts = new BaseRepository<Post>(_context);
            Comments = new BaseRepository<Comment>(_context);
            Users = new BaseRepository<User>(_context);
            UserDetails = new BaseRepository<UserDetails>(_context);

        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
