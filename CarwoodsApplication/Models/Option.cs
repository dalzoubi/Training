using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Option
    {
        [Display(Name = "ID")]
        public int OptionId { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [MaxLength(5000)]
        public string Description { get; set; }
    }
}