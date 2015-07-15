using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Maker
    {
        public int MakerId { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Maker")]
        public string Title { get; set; }

        [MaxLength(5000)]
        public string Description { get; set; }

        [Required]
        public int CountryId { get; set; }
        
        public virtual Country Country { get; set; }
    }
}