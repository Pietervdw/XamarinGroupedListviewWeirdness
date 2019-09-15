using System;

namespace ListviewWeirdness.Models
{
    public class MovieItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Poster { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}