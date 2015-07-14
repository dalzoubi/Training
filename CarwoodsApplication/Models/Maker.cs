using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Maker
    {
        public int MakerId { get; set; }

        [Required]
        public string Title { get; set; }

        public int CountryId { get; set; }
        
        public virtual Country Country { get; set; }
    }

    public class Country
    {
        public int CountryId { get; set; }

        public string Title { get; set; }

        public string CountryCode { get; set; }
    }
}