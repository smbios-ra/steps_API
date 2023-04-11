﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using steps_API.Model;

namespace steps_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApiUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Name = "Passengers",
                    Description = "Journey to the new Home",
                    Rating = "4.9",
                    ImageUrl = "https://w7.pngwing.com/pngs/871/688/png-transparent-passengers-assassin-s-creed-michael-fassbender-film-blu-ray-disc-chris-pratt-celebrities-film-michael-fassbender-thumbnail.png",
                    isFavorite = true
                }, new Movie
                {
                    Id = 2,
                    Name = "Interstellar",
                    Description = "Find a way to live",
                    Rating = "3.8",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfdJURHn9A-EtlfLlRMXu2x-rSd8rsqqgGLaOacH43&s",
                    isFavorite = true
                }, new Movie
                {
                    Id = 3,
                    Name = "Shutter Island",
                    Description = "Psycology",
                    Rating = "3.4",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcToDLALDCFh1VRbnHmsGHK12L85Acth6b1pSugviiY&s",
                    isFavorite = true
                });
                
        }
    }
}