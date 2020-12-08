namespace MyMotoWorld.Services.Data.Votes
{
    using System.Threading.Tasks;

    public interface IVoteService
    {
        Task SetVoteAsync(int motorBikeId, string userId, byte value);

        double GetAvarageVotes(int motorBikeId);
    }
}
