using Flicks315.Data.Model;
using Flicks315.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flicks315.Models
{
    public class IndexVm
    {
        public string Greeting { get; set; }
        public List<Movie> MyMovies { get; set; }
    }
}
