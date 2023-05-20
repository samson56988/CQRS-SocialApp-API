using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Social.Application.UserProfiles.Commands;
using Social.Application.UserProfiles.Queries;
using SocialAPI.Contracts.UserProfile.Requests;
using SocialAPI.Contracts.UserProfile.Responses;

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
        public async Task<IActionResult> GetAllProfiles()
        {
            var query = new GetAllUserProfiles();
            var response = await _mediator.Send(query);
            var profiles = _mapper.Map<List<UserProfileResponse>>(response);

            return Ok(profiles);

        }

        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody]UserProfileCreateUpdate profile)
        {
            var command = _mapper.Map<CreateUserCommand>(profile);
            var response = await _mediator.Send(command);
            var userProfile = _mapper.Map<UserProfileResponse>(response);

            return CreatedAtAction(nameof(GetUserProfileById), new {id = response.UserProfileId}, userProfile);
        }

        [Route(ApiRoute.UserProfiles.IdRoute)]
        [HttpGet]
        public async Task<IActionResult> GetUserProfileById(string id)
        {
            var query = new GetUserProfileById { UserprofileId = Guid.Parse(id) };
            var response = await _mediator.Send(query);
            var userProfile = _mapper.Map<UserProfileResponse>(response);
            return Ok();
        }

        [HttpPatch]
        [Route(ApiRoute.UserProfiles.IdRoute)]
        public async Task<IActionResult> UpdateUserProfile(string id, UserProfileCreateUpdate userProfile)
        {
            var command = _mapper.Map<UpdateUserProfileBasicInfoCommand>(userProfile);
            command.UserProfileId = Guid.Parse(id);
            var response = await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route(ApiRoute.UserProfiles.IdRoute)]
        public async Task<IActionResult> DeleteUserProfile(string id)
        {
            var command = new DeleteUserProfile() { UserProfileId = Guid.Parse(id) };
            var response = await _mediator.Send(command);

            return NoContent();

         }



    }
}
