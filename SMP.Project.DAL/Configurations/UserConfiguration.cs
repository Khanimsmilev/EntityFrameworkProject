using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SMP.Project.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            /*            builder.HasOne(u => u.UserDetails)
                            .WithOne(ud => ud.User)
                            .HasForeignKey<UserDetails>(ud => ud.Id);*/
            /*builder.HasMany(u => u.Comments)
                .WithOne(c => c.User);*/
            /*            builder.HasMany(u => u.Posts)
                            .WithOne(c => c.User)
                            .HasForeignKey(c=>c.UserId);*/
            builder
               .HasOne(x => x.UserDetails)
               .WithOne()
               .HasForeignKey<User>(x => x.UserDetailsId);
        }
    }
}
