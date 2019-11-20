using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1_FoodieLife.Models
{
    public class Visit
    {
        [Required]
        public int visitCode { get; set; }

        [Required(ErrorMessage = "Please choose a restaurant.")]
        [Display(Name = "Restaurant")]
        public string restName { get; set; }

        [Required(ErrorMessage = "Please rate your visit.")]
        [Display(Name = "Rating")]
        [Range(1,5)]
        public int visitRate { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        [Display(Name = "Location")]
        public string restLocation { get; set; }

        [Required]
        [Display(Name = "What did you order?")]
        public string order { get; set; }

        [Display(Name = "Comments")]
        public string comments { get; set; }
    }
}