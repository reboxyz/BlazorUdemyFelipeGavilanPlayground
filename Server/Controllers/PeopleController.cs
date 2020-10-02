using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using BlazorMovies.Server.Helpers;
using BlazorMovies.Shared.DTO;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class PeopleController : ControllerBase
    {
        private string containerName = "people";

        private readonly ApplicationDbContext _context;
        private readonly IFileStorageService _fileStorageService;
        private readonly IMapper _mapper;

       
        public PeopleController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Person person)
        {
            if (!string.IsNullOrEmpty(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture); // From Base64 to byte[]
                person.Picture = await _fileStorageService.SaveFile(personPicture, "jpg", containerName);
            }

            _context.People.Add(person);
            await _context.SaveChangesAsync();
            return Ok(person.Id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Person person)
        {
            var personDB = await _context.People.FirstOrDefaultAsync(x => x.Id == person.Id);
            if (personDB == null)
            {
                return NotFound();
            }

            personDB = _mapper.Map(person, personDB); // source -> destination

            if (!string.IsNullOrWhiteSpace(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                // Note! EditFile is effectively doing Delete and Insert
                personDB.Picture = await _fileStorageService.EditFile(personPicture, "jpg", containerName, personDB.Picture);
            }
             
            await _context.SaveChangesAsync();
            return NoContent(); 
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeople([FromQuery]PaginationDTO paginationDTO)
        {
            var queryable = _context.People.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage); 
            var people = await queryable.Paginate<Person>(paginationDTO).ToListAsync();
            return Ok(people);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var person = await _context.People.FirstOrDefaultAsync(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<List<Person>>> FilterByName(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return new List<Person>();  // Empty
            }
            return await _context.People.Where(x => x.Name.ToLower().Contains(searchText.ToLower()))
                .OrderBy(x => x.Name)       // Ascending
                .Take(5)
                .ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePerson(int id)
        {
            var person = await _context.People.FirstOrDefaultAsync(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}