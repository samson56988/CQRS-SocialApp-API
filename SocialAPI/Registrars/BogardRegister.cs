using MediatR;
using Social.Application.UserProfiles.Queries;

namespace SocialAPI.Registrars
{
    public class BogardRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfiles));
            builder.Services.AddMediatR(typeof(GetAllUserProfiles));
        }
    }
}
