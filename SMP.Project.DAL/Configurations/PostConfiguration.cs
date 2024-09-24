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
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            //builder.HasKey(P => P.Id);
            builder.Property(x => x.Text)
                .HasMaxLength(100);
            builder.Property(x => x.CommentList)
                .HasMaxLength(250);
            builder.Property(X => X.LikeCount)
                .HasDefaultValue(0);

            builder.HasMany(p => p.CommentList)
                .WithMany(p => p.Posts);
            builder
            .HasOne(x => x.User)
            .WithMany(x => x.Posts)
            .HasForeignKey(x => x.UserId);
        }
    }
}
