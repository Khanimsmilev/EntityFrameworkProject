using SMP.Project.Models;
using SMP.Project.DAL;
using SMP.Project.DAL.Repositories.Concrete;
using SMP.Project.Models.Concrete;

public class Program
{
    public static void Main (string[] args)
    {
        UserDetailsRepository userDetailsRepository = new UserDetailsRepository();
        UserRepository userRepository = new UserRepository();
        PostRepository postRepository = new PostRepository();
        CommentRepository commentRepository = new CommentRepository();

        UserDetails user_1 = new UserDetails()
        {
            Name = "Zehra",
            Surname = "Alirzayeva",
            Birthday = DateTime.Now,
            Roles = Role.Admin
        };

        User user1 = new User()
        {
            UserDetailsId = 1
        };

        Post post1 = new Post()
        {
            Text = "Step It Academy",
            Comments = new List<Comment>(),
            UserId = 1,
        };

        Comment comment1 = new Comment()
        {
            Text = "Reply",
            Comments = new List<Comment>()

        };

        post1.Comments.Add(new Comment {Text = "Duzeldi?"});
        comment1.Comments.Add(new Comment { Text = "Duzeldi!" });

        userDetailsRepository.Add(user_1);
        userRepository.Add(user1);
        postRepository.Add(post1);
        commentRepository.Add(comment1);

        userDetailsRepository.SaveChanges();
        userRepository.SaveChanges();
        postRepository.SaveChanges();
        commentRepository.SaveChanges();
    }

}