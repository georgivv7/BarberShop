namespace BarberShop.Data.Models
{
    using Common.Models;

    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;

    public class BarberShopUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public BarberShopUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Appointments = new HashSet<Appointment>();
        }
        public string Address { get; set; } 
        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }    
    }
}
