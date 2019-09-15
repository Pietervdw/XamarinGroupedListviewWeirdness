using System;
using System.Collections.ObjectModel;

namespace ListviewWeirdness.Models
{
    public class MovieItemGroup: ObservableCollection<MovieItem>
    {
        public DateTime ReleaseDate { get; set; }

        public string DateLong
        {
            get
            {
                return ReleaseDate.ToString("D");
            }
        }
    }
}