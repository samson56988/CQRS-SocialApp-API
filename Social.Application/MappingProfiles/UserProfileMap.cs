using AutoMapper;
using Social.Application.UserProfiles.Commands;
using Social.Domain.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.MappingProfiles
{
    public class UserProfileMap:Profile
    {
        public UserProfileMap()
        {
            CreateMap<CreateUserCommand, BasicInfo>();
        }
    }
}
