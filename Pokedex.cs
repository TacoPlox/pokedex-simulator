using System;
using System.Collections.Generic;

namespace pokedex
{
    class Pokedex
    {
        //No se repiten = HashSet
        public HashSet<Pokemon> pokedexRegistry = new HashSet<Pokemon>();

        //Constructor vacío
        public Pokedex() {
            //Crear pokemon
            Pokemon pikachu = new Pokemon("Pikachu", 25);
            Pokemon raichu = new Pokemon("Raichu", 26);

            //Agregar al registro del Pokedex
            pokedexRegistry.Add(pikachu);
            pokedexRegistry.Add(raichu);
        }

        public Pokemon FindPokemonByName(string name) {

            
            foreach (var pokemon in pokedexRegistry)
            {
                if (name == pokemon.name) {
                    //Resultado de búsqueda encontrado!

                    //Devolver variable y finaliza método
                    return pokemon;
                }
            }

            //No se encontró un Pokemon para esa búsqueda
            return new Pokemon("MissingNo.", 0);
        }

        public Pokemon FindPokemonById(int id) {

            
            foreach (var pokemon in pokedexRegistry)
            {
                if (id == pokemon.id) {
                    //Resultado de búsqueda encontrado!

                    //Devolver variable y finaliza método
                    return pokemon;
                }
            }

            //No se encontró un Pokemon para esa búsqueda
            return new Pokemon("MissingNo.", 0);
        }

        public void PrintPokedex() {
            System.Console.WriteLine("Pokedex Entries:");
            foreach (var pokemon in pokedexRegistry)
            {
                //pokemon
                System.Console.WriteLine(pokemon);
            }
        }
    }
}
