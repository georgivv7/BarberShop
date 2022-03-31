namespace BarberShop.Data.Models
{
    using BarberShop.Data.Common.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Barber : BaseModel<string>
    {
        public Barber()
        {
            this.Appointments = new HashSet<Appointment>();    
        }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public int YearsOfExperience { get; set; }  

        [Required]
        [MaxLength(255)]
        public string Biography { get; set; }     
        public string ImageUrl { get; set; }        
        
        public ICollection<Appointment> Appointments { get; set; }                          
    }
}
