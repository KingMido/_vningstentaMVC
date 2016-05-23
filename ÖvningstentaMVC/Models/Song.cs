namespace ÖvningstentaMVC.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public string Genre { get; set; }

        public Artist Id { get; set; }

    }
}