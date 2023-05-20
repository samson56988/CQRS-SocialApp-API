using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Aggregates.PostAggregate
{
    public class PostInteraction
    {
        private PostInteraction()
        {

        }
        public Guid InteractionId { get; set; }
        public Guid PostId { get; set; }
        public InteractionType InteractionType { get; set; }

        //Factories
        public static PostInteraction CreatePostInteraction(Guid postId,InteractionType type)
        {
            return new PostInteraction
            {
                PostId = postId,
                InteractionType = type,

            };
        }

    }
}
