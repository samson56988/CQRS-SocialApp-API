using MediatR;
using Social.Domain.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.UserProfiles.Queries
{
    public class GetUserProfileById:IRequest<UserProfile>
    {
        public Guid UserprofileId { get; set; }
    }
}
