using MediatR;
using Microsoft.EntityFrameworkCore;
using Social.Application.UserProfiles.Queries;
using Social.DataAccess;
using Social.Domain.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.UserProfiles.QueryHandlers
{
    internal class GetUserProfileByIdHandler : IRequestHandler<GetUserProfileById, UserProfile>
    {
        public readonly DataContext _dataContext;

        public GetUserProfileByIdHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<UserProfile> Handle(GetUserProfileById request, CancellationToken cancellationToken)
        {
            return await _dataContext.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserprofileId);
        }
    }
}
