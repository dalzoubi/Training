using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Country
    {
        [Display(Name = "ID")]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Country Code")]
        public string CountryCode { get; set; }
    }
}