using System;
using PokemonApp.Models.Pokemon;

namespace PokemonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int hp = 11;
            int atk = 12, def = 14, spec_atk = 23, spec_def = 22, speed = 19;
            PokemonStatFamily normal_psf = new PokemonStatFamily(hp, atk, def, spec_atk, spec_def, speed);
            Console.WriteLine(normal_psf);
            Console.ReadKey(true);
        }
    }
}