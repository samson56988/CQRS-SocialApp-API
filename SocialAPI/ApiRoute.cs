namespace SocialAPI
{
    public class ApiRoute
    {
        public const string BaseRoute = "api/v{version:apiVersion}/[controller]";

        public class UserProfiles
        {
            public const string IdRoute = "{id}";
        }

        public class Posts
        {
            public const string GetById = "{id}";
        }
    }
}
