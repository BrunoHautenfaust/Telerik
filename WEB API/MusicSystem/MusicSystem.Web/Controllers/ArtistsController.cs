namespace MusicSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using MusicSystem.Models;
    using MusicSystem.Web.Models;

    public class ArtistsController : ApiController
    {
        MusicSystemDbContext db = new MusicSystemDbContext();

        public IHttpActionResult Get()
        {
            return this.Ok(this.db.Artists.ToList());
        }

        public IHttpActionResult Post(Artist a)
        {
            
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            
            /*
            artistToAdd = new Artist
            {
                Name = "Tom Jones",
                DateOfBirth = new DateTime(1940, 6, 7)
            };
            */
            
            var artistToAdd = new Artist
            {
                Name = a.Name,
                Country = a.Country,
                DateOfBirth = a.DateOfBirth
            };

            this.db.Artists.Add(artistToAdd);
            this.db.SaveChanges();

            return this.Ok(a);
        }

        public IHttpActionResult Put()
        {
            var artistToUpdate = this.db.Artists.Single(a => a.Name == "Tom Jones");

            artistToUpdate.Country = "USA";
            this.db.SaveChanges();

            return this.Ok(artistToUpdate);
        }

        public IHttpActionResult Delete()
        {
            var artistToDelete = this.db.Artists.Single(a => a.Name == "Tom Jones");

            this.db.Artists.Remove(artistToDelete);
            this.db.SaveChanges();

            return this.Ok(artistToDelete);
        }
    }
}