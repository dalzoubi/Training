using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarwoodsApplication.Models
{
    public class Automobile
    {
        public int AutomobileId { get; set; }

        public int MakerId { get; set; }

        public virtual Maker Maker { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }
        
        public virtual List<Option> Options { get; set; }

        [DataType(DataType.Currency)]
        public decimal MsrpPrice { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}
