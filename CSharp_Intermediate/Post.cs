using System;

namespace CSharp_Intermediate
{
    public class Post
    {
        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreatedDateTime = DateTime.Now;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; }

        private int _upVoteCount;
        private int _downVoteCount;

        public void PrintPost()
        {
            Console.WriteLine($"Title: {Title} Description: {Description}");
        }
        
        public void UpVote()
        {
            _upVoteCount++;
        }

        public void DownVote()
        {
            _downVoteCount++;
        }

        public int UpVoteCount()
        {
            return _upVoteCount;
        }

        public int DownVoteCount()
        {
            return _downVoteCount;
        }

        public int TotalVoteCount()
        {
            return _upVoteCount - _downVoteCount;
        }

    }
}