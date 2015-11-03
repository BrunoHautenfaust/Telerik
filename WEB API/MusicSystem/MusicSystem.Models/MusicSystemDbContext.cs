namespace MusicSystem.Models
{
    using System.Data.Entity;

    public class MusicSystemDbContext : DbContext
    {
        public MusicSystemDbContext()
            :base("MusicSystem")
        {
        }

        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }

    }
}
