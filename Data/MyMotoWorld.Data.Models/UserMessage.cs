namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;

    public class UserMessage : BaseDeletableModel<int>
    {
        public int ContactMassageId { get; set; }

        public virtual ContactMessage ContactMassage { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
