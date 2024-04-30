using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Palmer_Justin
{
    class Game : IGenre
    {
        public string ESrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string titleParam)
        {
            ESrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {ESrb}!";
        }
    }
}
