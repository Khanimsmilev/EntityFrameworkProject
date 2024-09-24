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
    public class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder.HasKey(ud => ud.Id);
            builder.Property(ud => ud.Name)
                .HasMaxLength(20);
            builder.Property(ud => ud.Surname)
                .HasMaxLength(20);

            builder.HasOne<User>()
                .WithOne(x => x.UserDetails)
                .HasForeignKey<User>(x => x.UserDetailsId);
        }
    }
}
