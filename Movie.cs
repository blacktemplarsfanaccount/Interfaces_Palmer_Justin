using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Palmer_Justin
{
    class Movie : IGenre
    {
        // The ESrb, title, Genre,
        public string ESrb { get; set; }
        public string Genre { get; set; } 
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            ESrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
        /// <summary>
        /// public void does not return a value playmovie, and prints to the console (Title Sonic the Hedgehod 2) is starting SSsssshhhhh!.
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhhh!");
        }
        /// <summary>
        /// public string accessible everywhere, return title is a(n) (genre) Adventure/Comedy movie, rated PG (Esrb) 
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {ESrb}!";
        }
    }
}
