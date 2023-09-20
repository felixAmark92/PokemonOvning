using ITHSClasses;

var ash = new Trainer("Ash Ketchup");

ash.Catch(new Pokemon("Pickachu", PokeType.Eletric));
ash.Catch(new Pokemon("Charmander", PokeType.Fire));
ash.Catch(new Pokemon("Magicarp", PokeType.Water));
ash.Catch(new Pokemon("Bulbasaur", PokeType.Grass));
ash.Catch(new Pokemon("Squirtle", PokeType.Water));
ash.Catch(new Pokemon("Ratata", PokeType.Normal));
ash.Catch(new Pokemon("Metapod", PokeType.Grass));

//foreach (Pokemon poke in ash.Pokemons)
//{
//    Console.WriteLine($"{ash.Name} catched {poke.Name}");
//}

Console.WriteLine();

Pokemon releasedPoke;
while(ash.Pokemons.Count > 0)
{ 
    releasedPoke = ash.Release(ash.Pokemons[0]);
    Console.WriteLine("Realeased: " + releasedPoke.Name);
}