namespace MusicSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using MusicSystem.Models;

    public class SongsController : ApiController
    {
        MusicSystemDbContext db = new MusicSystemDbContext();

        public IHttpActionResult Get()
        {
            return this.Ok(this.db.Songs.ToList());
        }

        public IHttpActionResult Post()
        {
            var songToAdd = new Song
            {
                Title = "She's a Lady",
                Year = 1971
            };

            this.db.Songs.Add(songToAdd);
            this.db.SaveChanges();

            return this.Ok(songToAdd);
        }

        public IHttpActionResult Put()
        {
            var songToUpdate = this.db.Songs.Single(a => a.Title == "She's a Lady");

            songToUpdate.Genre = Genre.Pop;
            this.db.SaveChanges();

            return this.Ok(songToUpdate);
        }

        public IHttpActionResult Delete()
        {
            var songToDelete = this.db.Songs.Single(a => a.Title == "She's a Lady");

            this.db.Songs.Remove(songToDelete);
            this.db.SaveChanges();

            return this.Ok(songToDelete);
        }
    }
}