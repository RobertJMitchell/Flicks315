using Flicks315.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flicks315.Models
{
    public class DetailsVm
    {
        public string Greeting { get; set; }

        public Movie Movie { get; set; }

        public List<Actor> Actors { get; set; }

        public List<Movie> Movies { get; set; }
    }

}
