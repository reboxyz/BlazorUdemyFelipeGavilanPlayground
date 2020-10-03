using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorMovies.Shared.Entities
{
    public class Person 
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }

        // Many-to-many relationship between Movie and Actors    
        public List<MoviesActors> MoviesActors { get; set; } = new List<MoviesActors>();
        [NotMapped]
        public string Character { get; set; }

    }
}