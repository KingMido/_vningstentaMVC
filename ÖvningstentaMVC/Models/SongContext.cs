using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ÖvningstentaMVC.Models
{
    class SongContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public SongContext() : base("SongEntity")
        {
            Database.SetInitializer<SongContext>(new SongInitilizer());
        }
    }
}
