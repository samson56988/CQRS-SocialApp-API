using AutoMapper;
using MediatR;
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
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
    {
        private readonly DataContext _dataContext;
        

        public CreateUserCommandHandler(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.CreateBasicInfor(request.FirstName, request.LastName, request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);

            _dataContext.UserProfiles.Add(userProfile);
            await _dataContext.SaveChangesAsync();

            return userProfile;
        }
    }
}
