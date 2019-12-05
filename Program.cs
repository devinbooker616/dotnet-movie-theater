using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace dotnet_movie_theater
{
    class Program
    {
        static Dictionary<string, Dictionary<string, Movies>> LoadMovies()
        {
            string films = File.ReadAllText(@"./movies.json");
            return JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Movies>>>(films);
        }

        static string GetMovie(Dictionary<string, Dictionary<string, Movies>> movies)
        {
            foreach (var movie in movies)
            {
                foreach (var film in movie.Value)
                {
                    Console.WriteLine(film.Value.Title);
                }
            }
            Console.Write("What movie would you like?: ");
            string choice = Console.ReadLine();
            foreach (var movie in movies)
            {
                foreach (var film in movie.Value)
                {
                    if (film.Value.Title == choice)
                    {
                        return choice;
                    }
                }
            }
            return "Movie not available";
        }
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Movies>> movies = LoadMovies();
            string choice = GetMovie(movies);
            Console.WriteLine("Hello World!");
        }
    }
}
