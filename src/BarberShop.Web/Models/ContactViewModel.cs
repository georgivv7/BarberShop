using BarberShop.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Web.Models
{
    public class ContactViewModel 
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        
        [Required(ErrorMessage = GlobalConstants.EmailAddressError)]
        [EmailAddress]
        public string EmailAddress { get; set; } 
        
        [Required(ErrorMessage = GlobalConstants.FeedbackMessageError)]
        [MaxLength(500)]
        public string Message { get; set; }

    }
}
