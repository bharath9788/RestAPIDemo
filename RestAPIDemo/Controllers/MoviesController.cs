using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIDemo.Model;

namespace RestAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>()
        {
            new Movie { Title = "1stMovie", Id = 1 , Language = "French"},
            new Movie { Title = "2ndMovie", Id = 2 , Language = "French"},
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movies;
        }


        [HttpPost]
        public void Post([FromBody] Movie newMovie)
        {
            _movies.Add(newMovie);
        }

        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] Movie toUpdateMovie)
        {
            _movies[id] = toUpdateMovie;
        }
 
    }
}
