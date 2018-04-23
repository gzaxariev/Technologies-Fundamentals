using System.ComponentModel.DataAnnotations;
using CarWebSystem.Models;

namespace CarWebSystem.Data
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        [Range(1990, 2050)]
        public int Year { get; set; }


        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }


    }
}
