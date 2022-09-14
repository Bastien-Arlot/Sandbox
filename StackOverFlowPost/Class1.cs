using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPost
{
    public class Post
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public int Vote { get; set; }

        public DateTime DateCreation { get; set; }
        public Post(string description, string title, DateTime dateCreation)
        {
            Description = description;
            Title = title;
            DateCreation = dateCreation;
        }

        public void VoteUp()
        {
            this.Vote += 1;
        }

        public void VoteDown()
        {
            if (this.Vote > 0)
            {
                this.Vote -= 1;
            }
            else
            {
                throw new ArgumentException("Vote can't be negative");
            }
        }
    }
}
