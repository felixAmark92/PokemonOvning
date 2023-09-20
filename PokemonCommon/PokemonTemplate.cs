using PokemonCommon.Enums;

namespace PokemonCommon;

public class PokemonTemplate
{
    public readonly string Name;
    public readonly PokemonStats BaseStats;
    public readonly string Emoji;
    public readonly PokemonType Type;
    public readonly PokemonType SecondaryType;


    public PokemonTemplate(string name, PokemonStats baseStats, string emoji, PokemonType type)
    {
        Name = name;
        BaseStats = baseStats;
        Emoji = emoji;
        Type = type;
        SecondaryType = type;
    }
    public PokemonTemplate(string name, PokemonStats baseStats, string emoji, PokemonType type, PokemonType secondaryType)
    {
        Name = name;
        BaseStats = baseStats;
        Emoji = emoji;
        Type = type;
        SecondaryType = secondaryType;
    }

    public static readonly PokemonTemplate Bulbasaur = new PokemonTemplate("bulbasaur", new PokemonStats(45, 49, 49, 45, 65), "🐢", PokemonType.Grass);
    public static readonly PokemonTemplate Charmander = new PokemonTemplate("charmander", new PokemonStats(39, 52, 43, 65, 50), "🦖🔥", PokemonType.Fire);
    public static readonly PokemonTemplate Squirtle = new PokemonTemplate("squirtle", new PokemonStats(44, 48, 65, 43, 50), "🐳", PokemonType.Water);
}
