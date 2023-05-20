using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SocialAPI.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoute.BaseRoute)]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        [Route(ApiRoute.Posts.GetById)]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
    }
}
