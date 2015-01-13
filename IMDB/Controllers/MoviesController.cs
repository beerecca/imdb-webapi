using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using IMDB.Models;
using IMDB.Repositories;

namespace IMDB.Controllers
{
    [EnableCors(origins: "http://staticimdb.azurewebsites.net,http://localhost:9000,http://static.imdb", headers: "*", methods: "*")]
    public class MoviesController : ApiController
    {
        private readonly MovieRepository _movieRepository = new MovieRepository();

        // GET api/Movies
        public List<Movie> GetMovies()
        {
            return _movieRepository.GetMovies();
        }

        // GET api/Movies/5
        public Movie GetMovies(int id)
        {
            return _movieRepository.GetById(id);
        }

    }
}