using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarWebSystem.Models.Cars
{
    public class AddCarFormModel
    {
       

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        [Range(1990, 2018, ErrorMessage = "Year must be between 1990 and 2018")]
        public int Year { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public decimal Price { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        public string ImageUrl { get; set; }

       

    }
}
