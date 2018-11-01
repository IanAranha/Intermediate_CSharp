using System;

namespace Stack
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        private int _upVoteCount = 0;
        private int _downVoteCount = 0;
        private int _voteCount;
        public Post()
        {
            CreatedAt = DateTime.Now;
        }

        public Post(string title, string description) : this()
        {
            this.Title = title;
            this.Description = description;
        }

        public int VoteUp()
        {
            return _upVoteCount += 1;
        }

        public int VoteDown()
        {
            return _downVoteCount += 1;
        }

        public int GetVote()
        {
            _voteCount = _upVoteCount - _downVoteCount;
            return _voteCount;
        }

    }
}
