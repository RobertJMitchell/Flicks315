using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flicks315.Data.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }

       
    }


}
