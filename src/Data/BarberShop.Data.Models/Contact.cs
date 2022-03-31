namespace BarberShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Contact 
    {
        public string Id { get; set; }  

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }    

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }    

        [Required]
        [MaxLength(500)]
        public string Message { get; set; }
    }
}
