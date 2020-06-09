using System;
using System.Threading;

namespace CSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var post = new Post("Hello", "World");
            post.PrintPost();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            Console.Write("You have " + post.UpVoteCount() + " up votes & ");
            Console.Write("You have " + post.DownVoteCount() + " down votes");

        }
    }
}
