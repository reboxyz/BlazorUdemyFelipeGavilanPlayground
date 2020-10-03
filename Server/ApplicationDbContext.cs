using Microsoft.EntityFrameworkCore;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BlazorMovies.Server
{
    public class ApplicationDbContext : IdentityDbContext  // DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<MoviesActors> MoviesActors { get; set; }
        public DbSet<MoviesGenres> MoviesGenres { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Note! Very important if we inherit from IdentityDbContext

            // *** START - Setup MoviesActors Composite Key and Many-to-many relationship
            modelBuilder.Entity<MoviesActors>().HasKey(ma => new { ma.MovieId, ma.PersonId});

            /* Note! Commented to avoid the foreign key error during deletion
            // First half of the relationship: Movie has many Actors
            modelBuilder.Entity<MoviesActors>()
                .HasOne(m => m.Movie)
                .WithMany(a => a.MoviesActors)
                .HasForeignKey(m => m.MovieId)
                .OnDelete(DeleteBehavior.Restrict);
                

            // Second half of the relationship: Actor has many Movies
            modelBuilder.Entity<MoviesActors>()
                .HasOne(a => a.Person)
                .WithMany(m => m.MoviesActors)
                .HasForeignKey(a => a.PersonId)
                .OnDelete(DeleteBehavior.Restrict);   
            */    
            // *** END -

            // *** START - Setup MoviesGenres Composite Key and Many-to-many relationship
            modelBuilder.Entity<MoviesGenres>().HasKey(mg => new { mg.MovieId, mg.GenreId});

            /* Note! Commented to avoid the foreign key error during deletion
            // First half of the relationship: Movie has many Genres
            modelBuilder.Entity<MoviesGenres>()
                .HasOne(m => m.Movie)
                .WithMany(g => g.MoviesGenres)
                .HasForeignKey(m => m.MovieId)
                .OnDelete(DeleteBehavior.Restrict);
                

            // Second half of the relationship: Genre has many Movies
            modelBuilder.Entity<MoviesGenres>()
                .HasOne(g => g.Genre)
                .WithMany(m => m.MoviesGenres)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
            */       

            // *** END -


            // Create Admin User Account
            /*  Note! This is needed to create a Migration script for Admin User Account to jump start the Apps
            //var roleAdminId = "b3cb30a9-2d9f-4f3f-9971-b44bbebd2c6d";
            var userAdminId = "bbed16ef-5ff6-4866-b5f6-609a6b2ff714";

            var hasher = new PasswordHasher<IdentityUser>();

            var userAdmin = new IdentityUser()
            {
                Id = userAdminId,
                Email = "reboxyz@gmail.com",
                UserName = "reboxyz@gmail.com",
                NormalizedEmail = "reboxyz@gmail.com",
                NormalizedUserName = "reboxyz@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
            };
            
            modelBuilder.Entity<IdentityUser>().HasData(userAdmin);

            // Add Role to User Admin
            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>() {
                    Id = 2,                             // Note! Change this ID Number accordingly
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Admin",
                    UserId = userAdminId
                });
            */

        }
    }
}