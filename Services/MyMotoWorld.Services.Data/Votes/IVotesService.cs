namespace MyMotoWorld.Services.Data.Votes
{
    using System.Threading.Tasks;

    public interface IVotesService
    {
        Task SetVoteAsync(int motorBikeId, string userId, byte value);

        double GetAverageVotes(int motorBikeId);
    }
}
