using ITHSClasses;
using ITHSClasses.Enums;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var ash = new Trainer("Ash Ketchup");

//ash.Catch(new Pokemon("Pickachu", PokemonType.Eletric, "🐹"));
//ash.Catch(new Pokemon("Charmander", PokemonType.Fire, "🦖🔥"));
//ash.Catch(new Pokemon("Magicarp", PokemonType.Water, "🐠"));


ash.Catch(new Pokemon(template: PokemonTemplate.Bulbasaur, level: 5));
ash.Catch(new Pokemon(template: PokemonTemplate.Charmander, level: 7));
ash.Catch(new Pokemon(template: PokemonTemplate.Squirtle, level: 5));


foreach (Pokemon poke in ash.Pokemons)
{
    Console.WriteLine($"{ash.Name} catched {poke.Name} {poke.Emoji}");
    Console.WriteLine("Health: " + poke.Stats.HealthPoints);
    Console.WriteLine("Attack: " + poke.Stats.Attack);
    Console.WriteLine("Defence: " + poke.Stats.Defence);
    Console.WriteLine("Speed: " + poke.Stats.Speed);
    Console.WriteLine("Special: " + poke.Stats.Special);
    Console.WriteLine();
}

Console.WriteLine();


int length = ash.Pokemons.Count;
for (int i = 0; i < length; i++)
{

    Pokemon releasedPoke = ash.Release(ash.Pokemons[0]);
    Console.WriteLine("Realeased: " + releasedPoke.Name + " " + releasedPoke.Emoji);

}
Console.WriteLine(Battle.GetDamageModifier(PokemonType.Fighter, PokemonType.Normal));
