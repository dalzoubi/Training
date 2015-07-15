using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Display(Name = "Automobile", Order = 1)]
        public int AutomobileId { get; set; }

        public virtual Automobile Automobile { get; set; }

        [MaxLength(255)]
        [Required]
        [Display(Name = "Email Address", Order = 2)]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }

        [MaxLength(5000)]
        [Display(Name = "Comments", Order = 3)]
        [DataType(DataType.Html)]
        public string Contents { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}