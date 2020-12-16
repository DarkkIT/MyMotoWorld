namespace MyMotoWorld.Web.ViewModels.Cart
{
    using System.ComponentModel.DataAnnotations;

    public class CartInputModel
    {
        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Number { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        public string Address => this.Country + " " + this.City + " " + this.Street + " " + this.Number;

        public decimal TotalPrice { get; set; }
    }
}
