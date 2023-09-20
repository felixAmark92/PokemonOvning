using ITHSClasses;
using ITHSClasses.Enums;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var ash = new Trainer("Ash Ketchup");

ash.Catch(new Pokemon("Pickachu", PokeType.Eletric));
ash.Catch(new Pokemon("Charmander", PokeType.Fire));
ash.Catch(new Pokemon("Magicarp", PokeType.Water));
ash.Catch(new Pokemon("Bulbasaur", PokeType.Grass));
ash.Catch(new Pokemon("Squirtle", PokeType.Water));

foreach (Pokemon poke in ash.Pokemons)
{
    Console.WriteLine($"{ash.Name} catched {poke.Name}");
}

Console.WriteLine();


int length = ash.Pokemons.Count;
for (int i = 0; i < length; i++)
{

    Pokemon releasedPoke = ash.Release(ash.Pokemons[0]);
    Console.WriteLine("Realeased: " + releasedPoke.Name);

}
