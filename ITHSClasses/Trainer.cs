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
    private List<Pokemon> PokemonComputer { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Pokemons = new List<Pokemon>();
        PokemonComputer = new List<Pokemon>();
    }

    public void Catch(Pokemon poke)
    {
        if (Pokemons.Count >= 6)
        {
            Console.WriteLine($"Your 6 slots are already taken, {poke.Name} was sent to PokéPrison");
            PokemonComputer.Add(poke);
        }
        else
        {
            Console.WriteLine($"{Name} catched {poke.Name}");
            Pokemons.Add(poke);
        }
    }


    public Pokemon Release(Pokemon pokemon)
    {
        Pokemons.Remove(pokemon);
        return pokemon;
    }

    public  void BattleTrainer(Trainer trainer)
    {


    }
}
