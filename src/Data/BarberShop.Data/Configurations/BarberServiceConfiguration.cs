using BarberShop.Data.Models;
using BarberShop.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BarberShop.Data.Configurations
{
    public class BarberServiceConfiguration : IEntityTypeConfiguration<Service>
    {

        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(s => s.Price)
                .HasPrecision(4, 2);

            builder.HasData(

                new Service()
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = "Get comfortable in a classic barber chair and relax while your barber achieves your desired look. All cuts include a straight razor nape shave.",
                    Name = HairAndBeardStyles.Haircut,
                    ImageUrl = "/images/haircut.jpg",
                    Price = 29m
                },
               new Service()
               {
                   Id = Guid.NewGuid().ToString(),
                   Description = "Get comfortable in a classic barber chair and relax while your barber achieves your desired look. All cuts include a straight razor nape shave.",
                   Name = HairAndBeardStyles.SkinFade,
                   ImageUrl = "/images/skin-fade.jpg",
                   Price = 29m
               },
                new Service()
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = "Let our barbers apply their artistry to help you create the perfectly shaped beard and hair.",
                    Name = HairAndBeardStyles.HaircutAndBeardTrim,
                    ImageUrl = "/images/hairandtrimming.jpg",
                    Price = 44m
                },
                new Service()
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = "Experience a traditional hot towel shave with a straight razor and warm shaving cream that will leave your face smooth and supple.",
                    Name = HairAndBeardStyles.HeadShave,
                    ImageUrl = "/images/headshave.jpg",
                    Price = 35m
                },
                new Service()
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = "Experience a traditional hot towel shave with a straight razor and warm shaving cream that will leave your face smooth and supple.",
                    Name = HairAndBeardStyles.FaceShave,
                    ImageUrl = "/images/face-shave.jpg",
                    Price = 29m
                },
                new Service()
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = "Let our barbers apply their artistry to help you create the perfectly shaped beard or mustache style you envision.",
                    Name = HairAndBeardStyles.BeardTrim,
                    ImageUrl = "/images/trim.jpg",
                    Price = 15m
                },
                new Service()
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = "Let our barbers apply their artistry to help you create the perfectly shaped beard or mustache style you envision.",
                    Name = HairAndBeardStyles.BeardStyling,
                    ImageUrl = "/images/beard-styling.jpg",
                    Price = 13m
                });

        }
    }
}
