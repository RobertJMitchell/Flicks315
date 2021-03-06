﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flicks315.Data.Model;

namespace Flicks315.Data
{
    public class FlicksDbContext : DbContext
    {
        public FlicksDbContext() : base("FlicksMovie") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

    }
}
