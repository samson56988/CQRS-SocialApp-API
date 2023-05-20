using Social.Domain.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Aggregates.PostAggregate
{
    public class Post
    {

        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInteraction> _interaction = new List<PostInteraction>();

        private Post()
        {
            
        }

        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public string TextContent { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<PostInteraction> Interaction { get { return _interaction; } }
        public IEnumerable<PostComment> Comments { get { return _comments; } }


        //Factories
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            return new Post
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
            };
        }

        //public methods
        public void UpdatePostText(string newText)
        {
            TextContent = newText;
            LastModified = DateTime.Now;
        }

        public void AddPostComment(PostComment newComment)
        {
            _comments.Add(newComment);
        }

        public void RemoveComment(PostComment toRemove)
        {
            _comments.Remove(toRemove);
        }

        public void AddInteraction(PostInteraction newInteraction)
        {
            _interaction.Add(newInteraction);
        }

        public void RemoveInteraction(PostInteraction postInteraction)
        {
            _interaction.Remove(postInteraction);
        }




    }
}
