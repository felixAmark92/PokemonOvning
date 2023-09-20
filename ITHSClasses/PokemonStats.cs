using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ITHSClasses;

public class PokemonStats
{
    private readonly PokemonStats _baseStats;
    private readonly PokemonStats _individualValues;

    public int HealthPoints { get; private set; }
    public int Attack { get; private set; }
    public int Defence { get; private set; }
    public int Speed { get; private set; }
    public int Special { get; private set; }

    public PokemonStats(PokemonStats baseStats, int level)
    {
        _baseStats = baseStats;
        _individualValues = new PokemonStats();
        CalculateStats(level);
    }

    /// <summary>
    /// Use only for creating BaseStats
    /// </summary>
    public PokemonStats(int healthPoints, int attack, int defence, int speed, int special)
    {
        HealthPoints = healthPoints;
        Attack = attack;
        Defence = defence;
        Speed = speed;
        Special = special;
        _baseStats = this;
        _individualValues = this;
    }

    private PokemonStats()
    {
        var rand = new Random();
        HealthPoints = rand.Next(0, 16);
        Attack = rand.Next(0, 16);
        Defence = rand.Next(0, 16);
        Speed = rand.Next(0, 16);
        Special = rand.Next(0, 16);
        _baseStats = this;
        _individualValues = this;
    }

    public void CalculateStats(int level)
    {
        CalclulateHealthPoints(level);
        Attack = CalculateStat(_baseStats.Attack, _individualValues.Attack, level);
        Defence = CalculateStat(_baseStats.Defence, _individualValues.Defence, level);
        Speed = CalculateStat(_baseStats.Speed, _individualValues.Speed, level);
        Special = CalculateStat(_baseStats.Special, _individualValues.Special, level);
    }

    private void CalclulateHealthPoints(int level)
    {
        HealthPoints = Calculate(_baseStats.HealthPoints, _individualValues.HealthPoints, level) + level + 10;
    }
    private int CalculateStat(int baseStat, int individualValue, int level) => Calculate(baseStat, individualValue, level) + 5;
    private int Calculate(int baseStat, int individualValue, int level) => (baseStat + individualValue) * 2 * level / 100;

}
