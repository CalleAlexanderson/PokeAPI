using System;
using RestSharp;
using System.Text.Json;

namespace PokeAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the name of a pokemon");
            // Pokemon pokemon = new Pokemon();
            string input = "";
            input = Console.ReadLine();
            Pokemon pokemon = Pokemon.PokeFabrik(input);
            System.Console.WriteLine($"{pokemon.GetName()}s height is: {pokemon.GetHeight()}, and weight is: {pokemon.GetWeight()}");
            System.Console.WriteLine();
            Console.ReadLine();

        }
    }
}
