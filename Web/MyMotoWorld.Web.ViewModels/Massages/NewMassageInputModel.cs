namespace MyMotoWorld.Web.ViewModels.Massages
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Services.Mapping;

    public class NewMassageInputModel : IMapTo<ContactMassage>
    {
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
        public string Massage { get; set; }
    }
}
