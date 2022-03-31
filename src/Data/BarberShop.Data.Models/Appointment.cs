using BarberShop.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Data.Models
{
    public class Appointment : BaseModel<string>
    {
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public DateTime BookedFor { get; set; }

        [Required]
        public DateTime BookedOn { get; set; }  
        public Service BarberService { get; set; }        

        public string BarberId { get; set; }      
        public Barber Barber { get; set; }

        public string UserId { get; set; }
        public BarberShopUser User { get; set; }    

    }
}