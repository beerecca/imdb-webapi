using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using IMDB.Repositories;

namespace IMDB.Controllers
{
    [EnableCors(origins: "http://staticimdb.azurewebsites.net,http://localhost:9000,http://static.imdb", headers: "*", methods: "*")]
    public class GenresController : ApiController
    {
        private readonly GenreRepository _genreRepository = new GenreRepository();

        // GET api/Genres
        public List<string> GetGenreNames()
        {
            return _genreRepository.GetGenreNames();
        }

    }
}