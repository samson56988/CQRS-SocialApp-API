using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Aggregates.UserProfileAggregate
{
    public class UserProfile
    {
        private UserProfile()
        {

        }

        public Guid UserProfileId { get; private set; }
        public string IdentityId { get; private set; }
        public BasicInfo BasicInfo { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        //factory method
        public static UserProfile CreateUserProfile(string IdentityId, BasicInfo basicInfo)
        {
            //To DO: add validation, error handling strategies, error notification strategies

            return new UserProfile
            {
                IdentityId = IdentityId,
                BasicInfo = basicInfo,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }

        //public methods

        public void UpdateBasicInfo(BasicInfo newInfo)
        {
            BasicInfo = newInfo;
            LastModified = DateTime.UtcNow;
        }

        
    }
}
