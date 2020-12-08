namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Services.Data.Votes;
    using MyMotoWorld.Web.ViewModels.Votes;

    [ApiController]
    [Route("api/[controller]")]
    public class VotesController : BaseController
    {
        private readonly IVoteService voteService;

        public VotesController(IVoteService voteService)
        {
            this.voteService = voteService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<PostVoteViewModel>> Post(PostVoteInputModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.voteService.SetVoteAsync(input.MotorBikeId, userId, input.Value);
            var avarageVotes = this.voteService.GetAvarageVotes(input.MotorBikeId);

            return new PostVoteViewModel { AvarageVote = avarageVotes };
        }
    }
}
