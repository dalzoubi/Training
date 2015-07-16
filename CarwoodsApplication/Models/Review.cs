using System;
using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Review
    {
        [Display(Name = "ID")]
        public int ReviewId { get; set; }

        public int AutomobileId { get; set; }

        public virtual Automobile Automobile { get; set; }

        [MaxLength(255)]
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }

        [MaxLength(5000)]
        [Display(Name = "Comments")]
        [DataType(DataType.Html)]
        public string Contents { get; set; }

        [Display(Name = "Review Date")]
        [DataType(DataType.DateTime)]
        public DateTime ReviewDate { get; set; }
    }
}