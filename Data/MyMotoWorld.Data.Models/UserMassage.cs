namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;

    public class UserMassage : BaseDeletableModel<int>
    {
        public int ContactMassageId { get; set; }

        public virtual ContactMassage ContactMassage { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
