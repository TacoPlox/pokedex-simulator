using System;

namespace pokedex
{
    public class Pokemon
    {
        public string name;

        public int id;

        public Pokemon(string name, int id) {
            this.name = name;
            this.id = id;
        }

        //Sobreescribir el método ToString, para que los Pokemon se impriman correctamente
        public override string ToString() {
            // return this.name;
            //No. 25 - Pikachu
            return $"No. {this.id} - {this.name}";
        }
    }
}
