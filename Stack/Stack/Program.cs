using System;

namespace Stack
{


    class MainClass
    {
        public static void Main(string[] args)
        {
            var post = new Post("First Post", "This is the first post");
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            post.VoteUp();
            post.VoteUp();
            post.VoteUp();
            post.VoteUp();
            post.VoteUp();
            post.VoteDown();
            post.VoteUp();
            Console.WriteLine("Votes: {0}", post.GetVote());
            Console.WriteLine("This post has {0} Up-Votes and {1} Down-Votes", post.VoteUp(), post.VoteDown());

        }
    }
}
