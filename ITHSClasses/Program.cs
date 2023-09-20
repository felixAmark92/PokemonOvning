using PokemonCommon.Pokemons;
using PokemonCommon.Characters;
using System.Text;
using PokemonCommon;

Console.OutputEncoding = Encoding.UTF8;

var ash = new Trainer("Ash Ketchup");

ash.Catch(new Pokemon(PokemonTemplate.Charmander, 5));
ash.Catch(new Pokemon(PokemonTemplate.Squirtle, 5));
ash.Catch(new Pokemon(PokemonTemplate.Bulbasaur, 5));

Console.WriteLine();

foreach (Pokemon pokemon in ash.Pokemons)
{
    pokemon.Attack();
    pokemon.Eat("berry");
    Console.WriteLine();
}

Console.WriteLine();

while (ash.Pokemons.Count > 0)
{
    Pokemon releasedPoke = ash.Release(ash.Pokemons[0]);
    Console.WriteLine("Released: " + releasedPoke.Name);
}
