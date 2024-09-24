using SMP.Project.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.Models.Concrete
{
    public class Comment : BaseEntity
    {
        public string? Text { get; set; }
        /*public int UserId { get; set; }
        public User? User { get; set; }*/
        public ICollection<Comment>? in_Comment { get; set; }
        public int LikeCount { get; set; }
        public ICollection<Post>? Posts { get; set; } = new List<Post>();
    }
}
