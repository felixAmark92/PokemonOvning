using PokemonCommon.Enums;

namespace PokemonCommon.Attacks;

public abstract class Attack
{
    public double Damage { get; }
    public string Name { get; }
    public PokemonType Type { get; }

    protected Attack(double damage, string name, PokemonType type)
    {
        Damage = damage;
        Name = name;
        Type = type;
    }
}

