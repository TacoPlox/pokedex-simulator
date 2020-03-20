using System;

namespace pokedex
{

    public enum Gender {
        MALE,
        FEMALE
    }

    class PokemonInParty : Pokemon
    {
        Gender gender;

        public PokemonInParty(string name, int id, Gender gender) : base(name, id) {
            this.gender = gender;
        }

        public PokemonInParty(Pokemon pokemon, Gender gender) : base(pokemon.name, pokemon.id) {
            this.gender = gender;
        }

        //Sobreescribir el método ToString, para que los PokemonInParty se impriman correctamente
        public override string ToString() {
            //Pikachu - MALE
            return $"{this.name} - {this.gender}";
        }
    }
}
