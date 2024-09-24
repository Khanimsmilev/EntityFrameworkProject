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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            //builder.HasKey(c => c.Id);

            builder.Property(x => x.Text)
                    .HasMaxLength(100);
            builder.Property(x => x.LikeCount)
                    .HasDefaultValue(0);
            builder.Property(x => x.in_Comment)
                .HasMaxLength(250);

            builder.HasMany(c => c.Posts)
                .WithMany(p => p.CommentList);
        }
    }
}
