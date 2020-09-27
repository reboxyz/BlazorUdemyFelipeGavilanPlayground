using AutoMapper;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Server.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            // Note! Ignore 'Picture' because updating Picture should explicitly perform 'deleting' and 'inserting' 
            CreateMap<Person, Person>() 
                .ForMember(dest => dest.Picture, opt => opt.Ignore());  

             // Note! Ignore 'Poster' because updating Poster should explicitly perform 'deleting' and 'inserting' 
            CreateMap<Movie, Movie>() 
                .ForMember(dest => dest.Poster, opt => opt.Ignore());  

        }
    }
}