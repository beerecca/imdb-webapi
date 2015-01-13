using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IMDB.Models
{
    public class Genre : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}