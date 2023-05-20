using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        private PostComment()
        {

        }

        public Guid CommentId { get; private set; }
        public Guid PostId { get; private set; }
        public string Text { get; private set; }
        public Guid UserProfileId { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }

        //Factories
        public static PostComment CreatePostComment(Guid postId, string Text, Guid userProfileId)
        {
            return new PostComment
            {
               PostId = postId,
               Text = Text,
               UserProfileId = userProfileId,
               CreatedDate = DateTime.Now,
               LastModified = DateTime.Now,
            };
        }

        //public methods
        public void UpdateCommentText(string newText)
        {
            Text = newText;
            LastModified = DateTime.UtcNow;
        }
       

    }
}
