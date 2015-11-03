namespace MusicSystem.Web.Models
{
    using System;

    public class ArtistRequestModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}