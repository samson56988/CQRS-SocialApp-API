using Microsoft.EntityFrameworkCore;
using Social.DataAccess;

namespace SocialAPI.Registrars
{
    public class DbRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
