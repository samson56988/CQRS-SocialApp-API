using AutoMapper;
using Social.Application.UserProfiles.Commands;
using Social.Domain.Aggregates.UserProfileAggregate;
using SocialAPI.Contracts.UserProfile.Requests;
using SocialAPI.Contracts.UserProfile.Responses;

namespace SocialAPI.MappingProfiles
{
    public class UserProfileMappings:Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateUpdate, CreateUserCommand>();
            CreateMap<UserProfileCreateUpdate, UpdateUserProfileBasicInfoCommand>();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
        }
    }
}
