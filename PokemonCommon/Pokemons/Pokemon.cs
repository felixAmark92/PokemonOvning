using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons;

public class Pokemon
{
    private int _level;
    public string Name { get; protected set; }
    public PokemonType Type { get; protected set; }
    public int Health { get; set; }
    public PokemonStats Stats { get; set; }

    public string Emoji { get; protected set; }
    public int Level
    {
        get => _level;
        set
        {
            if (value <= 0)
            {
                throw new Exception("Value cant be less than 1");
            }
            _level = value;
        }
    }

    public Pokemon(PokemonTemplate template, int level)
    {
        Level = level;
        Name = template.Name;
        Type = template.Type;
        Emoji = template.Emoji;
        Stats = new PokemonStats(template.BaseStats, level);
        Health = Stats.HealthPoints;
    }
    public virtual void Attack()
    {
        Console.WriteLine($"{Name} used quickattack");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"{Name} ate {food}");
    }
}

