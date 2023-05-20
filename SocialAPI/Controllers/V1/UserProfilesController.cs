using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialAPI.Contracts.UserProfile.Requests;

namespace SocialAPI.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoute.BaseRoute)]
    [ApiController]
    public class UserProfilesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public UserProfilesController(IMediator mediator,IMapper mapper)
        {
           _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllProfiles()
        {
            return (IActionResult)Task.FromResult(Ok());
        }

        [HttpPost]
        public IActionResult CreateUserProfile([FromBody]UserProfileCreate profile)
        {
            return (IActionResult)Task.FromResult(Ok());
        }
    }
}
