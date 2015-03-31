using Flicks315.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flicks315.Data
{
    public static class Seeder
    {
        public static void Seed(FlicksDbContext db)
        {
            db.Movies.AddOrUpdate(
                m => new { m.MovieId, m.Title, m.Rating, m.Description },
                new Movie() { MovieId = 2, Title = "MadMax Beyond Thunderdome", Rating="PG-13", Description="Lorum Ipsum" },
                new Movie() { MovieId = 3, Title="Bambi", Rating="R", Description="Thumper. Goddamn Thumper"},
                new Movie() { MovieId = 4, Title="Whiplash", Rating="G", Description="Motivational Tool"}
                );

            db.Actors.AddOrUpdate(
                a => new { a.ActorId, a.Name, a.Awards, a.MovieId },
                new Actor() { ActorId=1, Name="Tina Turner", Awards=5, MovieId = 2},
                new Actor() { ActorId=2, Name="Mel Gibson", Awards = 1, MovieId = 2 },
                new Actor() { ActorId=3, Name="Thumper", Awards=9, MovieId = 3},
                new Actor() { ActorId=4, Name="Miles Simms", Awards=3, MovieId=4}

                );
        }

        
    }
}
