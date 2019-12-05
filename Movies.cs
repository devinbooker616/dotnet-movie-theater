using System.Collections.Generic;

namespace dotnet_movie_theater
{
    class Movies
    {
        public string Title { get; set; }

        public string Rating { get; set; }

        public string Genre { get; set; }

        public string Runtime { get; set; }

        public List<string> Showtime { get; set; }

        public Movies(string title, string rating, string genre, string runtime, List<string> showtime)
        {
            Title = title;
            Rating = rating;
            Genre = genre;
            Runtime = runtime;
            Showtime = showtime;
        }
    }
}