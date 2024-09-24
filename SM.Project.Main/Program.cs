using SMP.Project.Models;
using SMP.Project.DAL;
using SMP.Project.DAL.Repositories.Concrete;
using SMP.Project.Models.Concrete;
using System.Configuration;
using System.Data;
using SMP.Project.DAL.Context;
using SMP.Project.DAL.Repositories.Abstract;

public class Program
{
    public static void Main(string[] args)
    {

        using (var unitOfWork = new UnitOfWork(new SMDBcontext()))
        {

            var userDetails = new UserDetails
            {
                Name = "Zahra",
                Surname = "Alirzayeva",
                Birthday = new DateTime(2002, 8, 14),
                Roles = Role.User
            };

            unitOfWork.UserDetails.Add(userDetails);
            unitOfWork.Complete();

            var user = new User
            {
                UserDetails = userDetails,
                Posts = new List<Post>()
            };

            var post1 = new Post
            {
                Text = "My Post",
                LikeCount = 107,
                User = user,
                //Comments = string.Empty,
                CommentList = new List<Comment>()
            };

            unitOfWork.Users.Add(user);
            unitOfWork.Posts.Add(post1);
            unitOfWork.Complete();

            var comment1 = new Comment
            {
                Text = "Good job, Great, Awesome!",
                LikeCount = 5,
                Posts = new List<Post> { post1 },
                in_Comment = new List<Comment>()
            };

            post1.CommentList.Add(comment1);
            unitOfWork.Comments.Add(comment1);
            unitOfWork.Complete();



        }
    }

}
