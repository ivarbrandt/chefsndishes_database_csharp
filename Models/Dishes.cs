using System;
using System.ComponentModel.DataAnnotations;

namespace chefsndishes.Models
{
    public class Dish
    {
        [Key]
        public int DishID { get; set; }

        [Required]
        [Display(Name = "Name of Dish")]
        public string Name { get; set; }

        [Display(Name = "Chef")]
        public string Chef { get; set; }

        [Required]
        [Display(Name = "Tastiness")]
        public int Tastiness { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "# of Calories")]
        public int Calories { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Chef")]
        public int ChefID { get; set; }

        public Chef Creator {get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}