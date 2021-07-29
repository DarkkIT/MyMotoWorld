namespace MyMotoWorld.Services.Data.Votes
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;

    public class VotesService : IVotesService
    {
        private readonly IRepository<Vote> voteRepository;

        public VotesService(IRepository<Vote> voteRepository)
        {
            this.voteRepository = voteRepository;
        }

        public int GetAverageVotes(int motorBikeId)
        {
            int avarageVotes = Convert.ToInt32(this.voteRepository.All().Where(x => x.MotorBikeId == motorBikeId).Average(x => x.Value));

            return avarageVotes;
        }

        public async Task SetVoteAsync(int motorBikeId, string userId, byte value)
        {
            var vote = this.voteRepository.All().FirstOrDefault(x => x.MotorBikeId == motorBikeId && x.UserId == userId);

            if (vote == null)
            {
                vote = new Vote
                {
                    MotorBikeId = motorBikeId,
                    UserId = userId,
                };

                await this.voteRepository.AddAsync(vote);
            }

            vote.Value = value;
            await this.voteRepository.SaveChangesAsync();
        }
    }
}
