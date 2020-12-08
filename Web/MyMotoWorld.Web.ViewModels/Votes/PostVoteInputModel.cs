namespace MyMotoWorld.Web.ViewModels.Votes
{
    using System.ComponentModel.DataAnnotations;

    public class PostVoteInputModel
    {
        public int MotorBikeId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}
