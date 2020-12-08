namespace MyMotoWorld.Web.ViewModels.Admins
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Http;

    public class AddNewsInputModel
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime NewsDate => DateTime.UtcNow;

        [Required]
        public string ImageName { get; set; }

        [Required]
        public IFormFile Image { get; set; }
    }
}
