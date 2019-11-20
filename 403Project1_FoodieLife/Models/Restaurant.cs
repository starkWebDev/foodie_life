using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1_FoodieLife.Models
{
    public class Restaurant
    {
        [Required]
        public int restID { get; set; }

        [Required(ErrorMessage = "Please enter a restaurant name.")]
        [MaxLength(50, ErrorMessage = "50 character limit.")]
        [Display(Name = "Restaurant Name")]
        public string restName { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        [Display(Name = "Restaurant Category")]
        public string restCategory { get; set; }
    }
}