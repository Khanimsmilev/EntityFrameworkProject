using SMP.Project.Abstract;
using SMP.Project.DAL.Context;
using SMP.Project.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.DAL.Repositories.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly SMDBcontext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(SMDBcontext dbContext)
        {
            _context = new SMDBcontext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            entity.CreatedDate = DateTime.Now;
        }

        public void Delete(int Id)
        {
            var entity = _dbSet.FirstOrDefault(e => e.Id == Id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
            }
            else
                throw new NullReferenceException();
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.Where(t => t.IsDeleted == false).ToList();
        }

        public T GetById(int Id)
        {
            return _dbSet.FirstOrDefault(t => t.Id == Id && t.IsDeleted == false);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(int Id)
        {
            throw new Exception();
        }
    }
}
