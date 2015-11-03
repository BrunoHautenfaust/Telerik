namespace MusicSystem.Web.Controllers
{
    using MusicSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;

    public class AlbumsController : ApiController
    {
        MusicSystemDbContext db = new MusicSystemDbContext();

        public IHttpActionResult Get()
        {
            return this.Ok(this.db.Albums.ToList());
        }

        public IHttpActionResult Post()
        {
            var albumToAdd = new Album
            {
                Title = "Album",
                Year = 1999
            };

            this.db.Albums.Add(albumToAdd);
            this.db.SaveChanges();

            return this.Ok(albumToAdd);
        }

        public IHttpActionResult Put()
        {
            var albumToUpdate = this.db.Albums.Single(a => a.Title == "Album");

            albumToUpdate.Producer = "Some Producer";
            this.db.SaveChanges();

            return this.Ok(albumToUpdate);
        }

        public IHttpActionResult Delete()
        {
            var albumToDelete = this.db.Albums.Single(a => a.Title == "Album");

            this.db.Albums.Remove(albumToDelete);
            this.db.SaveChanges();

            return this.Ok(albumToDelete);
        }
    }
}