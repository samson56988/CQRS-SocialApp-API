using SocialAPI.Options;

namespace SocialAPI.Registrars
{
    public class SwaggerRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
