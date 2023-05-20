namespace SocialAPI.Registrars
{
    public interface IWebApplicationRegister:IRegister
    {
        public void RegisterPiplineComponents(WebApplication application);
    }
}
