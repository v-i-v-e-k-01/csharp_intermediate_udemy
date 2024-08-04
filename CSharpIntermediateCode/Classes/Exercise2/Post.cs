using System;

namespace Exercise2
{
    public class Post
    {
        readonly private string _title;
        private int _voteCount;
        readonly private DateTime _dateTime;

        public Post(string title)
        {
            _title = title;
            _voteCount = 0;
            _dateTime = DateTime.Now;
        }

        public string Description
        {
            get;
            set;
        }

        public void UpVote()
        {
            _voteCount++;
        }

        public void DownVote()
        {
            _voteCount--;
        }

        public int GetVoteCount()
        {
            return _voteCount;
        }

        public DateTime GetDateTime()
        {
            return _dateTime;
        }

        public string GetTitle()
        {
            return _title;
        }

    }
}
