using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Automobile
    {
        [Display(Name = "ID")]
        public int AutomobileId { get; set; }

        [Required]
        public int MakerId { get; set; }

        public virtual Maker Maker { get; set; }

        [MaxLength(255)]
        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [MaxLength(5000)]
        public string Description { get; set; }
        
        public virtual List<Option> Options { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal MsrpPrice { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}
