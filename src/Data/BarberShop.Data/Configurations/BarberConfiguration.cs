namespace BarberShop.Data.Configurations
{
    using BarberShop.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    public class BarberConfiguration : IEntityTypeConfiguration<Barber>
    {
        public void Configure(EntityTypeBuilder<Barber> barber)
        {

            barber
                .HasMany(b => b.Appointments)
                .WithOne(b => b.Barber)
                .HasForeignKey(b => b.BarberId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            barber.HasData(
                new Barber
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Nate",
                    LastName = "Diaz",
                    YearsOfExperience = 13,
                    Biography = "Nate takes great pride in helping his clients look and feel their best by delivering the precision fades and clean, classic cuts he's known for.",
                    ImageUrl = "images/barber1.jpg"
                },
                new Barber
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Andrew",
                    LastName = "Robertson",
                    YearsOfExperience = 9,
                    Biography = "Honest and kind, Andrew is a barber with true talent and grit. He has been barbering since 2014, working at Acme Barbershop and Squire Barbershop before joining his friends at Assembly.",
                    ImageUrl = "images/barber2.jpg"
                },
                new Barber
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Bryan",
                    LastName = "Ruiz",
                    YearsOfExperience = 11,
                    Biography = "Jovial and almost always cracking a joke, Bryan is a highly skilled barber who loves his craft and his clients. His clients see him to crack a smile as much as they do to get a solid haircut.",
                    ImageUrl = "images/barber3.jpg"
                },
                new Barber
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Chris",
                    LastName = "Evans",
                    YearsOfExperience = 10,
                    Biography = "A transplant from New Mexico, Chris carries a passion for traditionalism that’s apparent in his barbering. He brings classic techniques to modern haircuts.",
                    ImageUrl = "images/barber4.jpg"
                });

        }
    }
}
