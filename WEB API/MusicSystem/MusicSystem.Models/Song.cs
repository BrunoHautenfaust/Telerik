namespace MusicSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public Genre Genre { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
