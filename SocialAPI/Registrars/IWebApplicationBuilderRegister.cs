namespace SocialAPI.Registrars
{
    public interface IWebApplicationBuilderRegister:IRegister
    {
       void RegisterServices(WebApplicationBuilder builder);
    }
}
