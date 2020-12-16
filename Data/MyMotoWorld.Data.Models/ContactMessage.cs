namespace MyMotoWorld.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;

    public class ContactMessage : BaseDeletableModel<int>
    {
        public ContactMessage()
        {
            this.UserMassages = new HashSet<UserMessage>();
        }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Message { get; set; }

        public string AnswerMassage { get; set; }

        [Required]
        public string Status { get; set; }

        public DateTime SendDate { get; set; }

        public DateTime? AnswerDate { get; set; }

        public virtual ICollection<UserMessage> UserMassages { get; set; }
    }
}
