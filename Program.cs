using System;
using System.Collections.Generic;

namespace pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();

            // Pokemon pikachu = new Pokemon("Pikachu", 25);
            // pokedex.pokedexRegistry.Add(pikachu);


            //Generar party de 6 Pokemon
            //List = se puede repetir elementos
            List<PokemonInParty> party = new List<PokemonInParty>();

            //Está mal! DRY = Don't Repeat Yourself
            // PokemonInParty pikachu1 = new PokemonInParty("Pikachu", 25, Gender.MALE);

            //Consultar Pokemon por nombre
            Pokemon pikachu = pokedex.FindPokemonByName("Pikachu");
            Pokemon notExistantPokemon = pokedex.FindPokemonByName("Agumon");

            System.Console.WriteLine(pikachu);
            System.Console.WriteLine(notExistantPokemon);

            PokemonInParty pikachu1 = new PokemonInParty(pikachu, Gender.MALE);
            PokemonInParty pikachu2 = new PokemonInParty(pikachu, Gender.FEMALE);
            PokemonInParty pikachu3 = new PokemonInParty(pikachu, Gender.FEMALE);
            PokemonInParty pikachu4 = new PokemonInParty(pikachu, Gender.MALE);
            PokemonInParty pikachu5 = new PokemonInParty(pikachu, Gender.FEMALE);
            PokemonInParty pikachu6 = new PokemonInParty(pikachu, Gender.MALE);

            party.Add(pikachu1);
            party.Add(pikachu2);
            party.Add(pikachu3);
            party.Add(pikachu4);
            party.Add(pikachu5);
            party.Add(pikachu6);

            System.Console.WriteLine(party.Count);

            //No funciona esta impresión
            // System.Console.WriteLine(party);

            foreach (var pokemon in party)
            {
                System.Console.WriteLine(pokemon);
            }


            //Print pokedex
            pokedex.PrintPokedex();


            PokemonTeam team = new PokemonTeam(pikachu1, pikachu2, pikachu3);
        }
    }
}
