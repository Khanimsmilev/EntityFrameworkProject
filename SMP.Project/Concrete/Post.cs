using SMP.Project.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP.Project.Models.Concrete
{
    public class Post : BaseEntity
    {
        public string? Text { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Comment>? CommentList { get; set; }
        public int LikeCount { get; set; } 
        //public string? Comment { get; set; }


    }
}
