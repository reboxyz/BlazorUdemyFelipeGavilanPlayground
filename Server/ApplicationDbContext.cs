using Microsoft.EntityFrameworkCore;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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

        }
    }
}