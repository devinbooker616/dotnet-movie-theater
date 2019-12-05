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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
