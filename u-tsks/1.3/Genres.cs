using System;
using System.Collections.Generic;
using System.Linq;

abstract class GameGenreImplementations
{
    private string _name;
    public string Name {
        get {
            return _name;
        }
        set {
            _name = value;
        }
    }
    public string Description;
    public abstract void Message();
    
}
class RPGImplementation :GameGenreImplementations
{
    public int PlayerLevelLimit;
    public string Currency;
    private List<string> CharactersClasses;
    private List<string> Quests;

    public RPGImplementation(string name, string description, int playerLevelLimit)
    {
        Name = name;
        PlayerLevelLimit = playerLevelLimit;
        CharactersClasses = new List<string>();
        Quests = new List<string>();
        Description = description;

    }

    public void AddCharacterClass(string cls)
    {
        CharactersClasses.Add(cls);
    }
    public void AddQuest(string Quest)
    {
        Quests.Add(Quest);
    }
    public override void Message()
    {
        Console.WriteLine("\nТип игры: RPG; Имя Игры: " + Name);
        Console.WriteLine(Description);
        Console.WriteLine("Лимит уровней: " + PlayerLevelLimit);
        Console.WriteLine("Квесты: ");
        Quests.Select((value, i) => new { i, value }).
            ToList().ForEach((e) => { Console.WriteLine(e.i + ": " + e.value); });
        Console.WriteLine("Классы: ");
        CharactersClasses.Select((value, i) => new { i, value }).
            ToList().ForEach((e) => { Console.WriteLine(e.i + ": " + e.value); });
    }
}
class ShooterImplementation : GameGenreImplementations
{

    public int TeamSize;
    private List<Gun> GunList;

    public ShooterImplementation(string name, string description,int teamSize)
    {
        Name = name;
        TeamSize = teamSize;
        GunList = new List<Gun>();
        Description = description;
    }
    public void AddGun(Gun gun)
    {
        GunList.Add(gun);
    }
    public override void Message()
    {
        Console.WriteLine("\nGame Type: Shooter; Name: " + Name);
        Console.WriteLine(Description);
        Console.WriteLine("Размер команды: "+TeamSize);
        Console.WriteLine("Оружие: ");
        GunList.Select((value, i) => new { i, value }).
            ToList().ForEach((e) => { Console.WriteLine(e.value.Name + ": \n" + "Магазин: "+e.value.WeaponShop+"; Цена: "+ e.value.price+";Отдача: "+e.value.Recoil); });
    }

    public struct Gun
    {
        public string Name;
        public int WeaponShop;
        public float Recoil;
        public int price;
    }
}
class MOBAImplementation : GameGenreImplementations
{
    public int TeamSize;
    private List<string> CharactersClasses;
    public int MaxLevel;
    public int AbilityCount;

    public MOBAImplementation(string name, string description, int teamSize, int maxLevel, int abilityCount)
    {
        TeamSize = teamSize;
        CharactersClasses = new List<string>();
        MaxLevel = maxLevel;
        AbilityCount = abilityCount;
        Name = name;
        Description = description;

    }

    public void AddClass(string name)
    {
        CharactersClasses.Add(name);
    }
    public override void Message()
    {
        Console.WriteLine("\nGame Type: MOBA; Name: " + Name);
        Console.WriteLine(Description);
        Console.WriteLine("Размер команды: " + TeamSize);
        Console.WriteLine("Максимальный уровень: " + MaxLevel);
        Console.WriteLine("Количество способностей:" + AbilityCount);
        CharactersClasses.Select((value, i) => new { i, value }).
            ToList().ForEach((e) => { Console.WriteLine(e.i + ": " + e.value); });
    }
}
class PuzzleImplementation : GameGenreImplementations
{
    public int MapCount;
    public int BaseWidth;
    public int BaseHeight;
    public int DifCount;

    public PuzzleImplementation(string name,string desc,int mapCount, int baseWidth, int baseHeight, int difCount)
    {
        Name = name;
        Description = desc;
        MapCount = mapCount;
        BaseWidth = baseWidth;
        BaseHeight = baseHeight;
        DifCount = difCount;
    }

    public override void Message()
    {
        Console.WriteLine("\nGame Type: Puzzle; Name: " + Name);
        Console.WriteLine(Description);
        Console.WriteLine("Число карт: " + MapCount);
        Console.WriteLine("Базовая ширина: " + BaseWidth);
        Console.WriteLine("Базовая высота: " + BaseHeight);
        Console.WriteLine("Чтсло Сложностей: " + DifCount);

    }
}
class StrategyImplementation : GameGenreImplementations
{
    public string Currency;
    public int DifCount;
    private List<string> Buildings;
    private List<string> UnitTypes;

    public StrategyImplementation(string name, string desc,string currency, int difCount)
    {
        Name = name;
        Description = desc;
        Currency = currency;
        DifCount = difCount;
        Buildings = new List<string>();
        UnitTypes = new List<string>();
    }

    public void AddBuilding(string b)
    {
        Buildings.Add(b);
    }
    public void AddUnit(string unit)
    {
        UnitTypes.Add(unit);
    }
    public override void Message()
    {
        Console.WriteLine("\nGame Type: Strategy; Name: " + Name);
        Console.WriteLine(Description);
        Console.WriteLine("Валюта: " + Currency);
        Console.WriteLine("Количество уровней сложности: " + DifCount);

        Console.WriteLine("Строения: ");
        Buildings.Select((value, i) => new { i, value }).
    ToList().ForEach((e) => { Console.WriteLine(e.i + ": " + e.value); });
        Console.WriteLine("\nЮниты: ");
        UnitTypes.Select((value, i) => new { i, value }).
    ToList().ForEach((e) => { Console.WriteLine(e.i + ": " + e.value); });

    }
}