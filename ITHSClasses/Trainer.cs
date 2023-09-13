using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHSClasses;

internal class Trainer
{
    public string Name { get; private set; } 
    public List<Pokemon> Pokemons { get; private set; }

    public Trainer(string name)
    {
        Name = name;
        Pokemons = new List<Pokemon>();
    }


    public void Catch(Pokemon poke)
    {
        Pokemons.Add(poke);
    }

    public Pokemon Release(Pokemon pokemon)
    {
        Pokemons.Remove(pokemon);
        return pokemon;
    }


}
