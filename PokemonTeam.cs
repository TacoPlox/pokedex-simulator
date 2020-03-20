using System;
using System.Collections.Generic;

namespace pokedex
{
    public class PokemonTeam {
        HashSet<Pokemon> team = new HashSet<Pokemon>();

        //Constructor vacío
        public PokemonTeam(Pokemon p1, Pokemon p2, Pokemon p3) {
            bool isDuplicated = false;
            if (p1.id == p2.id) {
                //Esta repetido
                isDuplicated = true;
            } else if (p2.id == p3.id) {
                //Esta repetido
                isDuplicated = true;
            } else if (p1.id == p3.id) {
                //Esta repetido
                isDuplicated = true;
            }

            if (isDuplicated) {
                System.Console.WriteLine("Los Pokemon del equipo competitivo están repetidos!");
            }

            team.Add(p1);
            team.Add(p2);
            team.Add(p3);
        }
    }
}