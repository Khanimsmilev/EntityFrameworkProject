using Microsoft.EntityFrameworkCore;
using SMP.Project.DAL.Configurations;
using SMP.Project.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.DAL.Context
{
    public class SMDBcontext:DbContext
    {
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=WIN-BJ8C1NSBIA7;Initial Catalog=SMDbcon;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
