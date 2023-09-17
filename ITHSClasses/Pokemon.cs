using ITHSClasses.Enums;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHSClasses;

public class Pokemon
{
    private int _level;

    public string Name { get; private set; }
    public PokemonType Type { get; private set; }
    public int Health { get; set; }
    public PokemonStats Stats { get; set; }

    public string Emoji { get; private set; }
    public int Level
    { get { return _level; }
        set
        {
            if (value < 1)
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

    public void Attack(PokeAttack attack, Pokemon target)
    {
        switch (attack) 
        {
            case PokeAttack.QuickAtttack:
                Console.WriteLine($"{Name} used Quick attack on {target.Name}");
                target.Health -= 10;
                break;
            case PokeAttack.Splash:
                Console.WriteLine($"{Name} used Splash. It had no effect...");
                break;
            case PokeAttack.Scratch: 
                Console.WriteLine($"{Name} used scratch on {target.Name}");
                target.Health -= 10;
                break;
            case PokeAttack.Thunderbolt: 
                Console.WriteLine($"{Name} used thunderbolt on {target.Name}");
                target.Health -= 20;
                break;

        }
    }
}



public enum PokeAttack
{
    Scratch,
    Thunderbolt,
    QuickAtttack,
    Splash
}