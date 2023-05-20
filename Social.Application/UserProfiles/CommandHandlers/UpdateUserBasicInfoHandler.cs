using MediatR;
using Microsoft.EntityFrameworkCore;
using Social.Application.UserProfiles.Commands;
using Social.DataAccess;
using Social.Domain.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.UserProfiles.CommandHandlers
{
    internal class UpdateUserBasicInfoHandler : IRequestHandler<UpdateUserProfileBasicInfoCommand>
    {
        private readonly DataContext _dataContext;

        public UpdateUserBasicInfoHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(UpdateUserProfileBasicInfoCommand request, CancellationToken cancellationToken)
        {
            var userProfile = await _dataContext.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId);

            var basicInfo = BasicInfo.CreateBasicInfor(request.FirstName, request.LastName, request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            userProfile.UpdateBasicInfo(basicInfo);

            _dataContext.UserProfiles.Update(userProfile);
            await _dataContext.SaveChangesAsync();

            return new Unit();
        }
    }
}
