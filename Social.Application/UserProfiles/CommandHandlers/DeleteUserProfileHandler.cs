using MediatR;
using Microsoft.EntityFrameworkCore;
using Social.Application.UserProfiles.Commands;
using Social.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.UserProfiles.CommandHandlers
{
    internal class DeleteUserProfileHandler : IRequestHandler<DeleteUserProfile>
    {
        private readonly DataContext _dataContext;

        public DeleteUserProfileHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(DeleteUserProfile request, CancellationToken cancellationToken)
        {
            var userProfile = await _dataContext.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserProfileId);


            _dataContext.UserProfiles.Remove(userProfile);
            await _dataContext.SaveChangesAsync();
            return new Unit();
        }
    }
}
