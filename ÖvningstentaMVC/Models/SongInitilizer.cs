using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ÖvningstentaMVC.Models
{
    class SongInitilizer : DropCreateDatabaseAlways<SongContext>
    {
        protected override void Seed(SongContext context)
        {
            var artists = new List<Artist>()
            {
                new Artist()
                {
                    Id = 1,
                    Name = "rammstien",
                    Age = 40,
                    Band = "rammstien",



                },
                            new Artist()
                {
                                 Id =2,
                    Name = "john",
                    Age = 42,
                    Band = "rammstien",


                },
                                        new Artist()
                {
                                             Id =3,
                    Name = "adam",
                    Age = 39,
                    Band = "rammstien",


                }

            };
            foreach (var artist in artists)
            {
                context.Artists.Add(artist);
            }
            context.SaveChanges();

            var songs = new List<Song>();
            songs.Add(new Song() { SongId = 1, Title = "tum hi ho ", Duration = 2.2, Genre = "indian" });
            songs.Add(new Song() { SongId = 2, Title = "tum hi bo ", Duration = 2.2, Genre = "indian" });
            songs.Add(new Song() { SongId = 3, Title = "tum hi to ", Duration = 2.2, Genre = "indian" });

            foreach (var song in songs)
            {
                context.Songs.Add(song);
            }
            context.SaveChanges();

        }
    }
}
