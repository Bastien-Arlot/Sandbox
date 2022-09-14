namespace StackOverFlowPost
{

    public class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("first post for all my friends", "first post", DateTime.Now);
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Vote);
            post.VoteUp();
            Console.WriteLine(post.Vote);
        }
    }
}