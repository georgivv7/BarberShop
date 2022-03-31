namespace BarberShop.Data.Models
{
    using BarberShop.Data.Common.Models;
    using BarberShop.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Service : BaseModel<string>
    {
        public string ImageUrl { get; set; }    
        public HairAndBeardStyles Name { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        
        public decimal Price { get; set; }
    }
}
