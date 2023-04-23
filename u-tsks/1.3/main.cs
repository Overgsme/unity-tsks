using System;
using System.Collections.Generic;

public static class Program
{
    public static void Main()
    {
        List<GameGenreImplementations> gameImps = new List<GameGenreImplementations>();
        RPGImplementation RPG = new RPGImplementation("Awesome RPG", "...", 60);
        RPG.AddQuest("Kill 3 slimes");
        RPG.AddQuest("Kill 10 slimes");
        RPG.AddQuest("Kill 100 slimes");
        RPG.AddQuest("Kill 1000 slimes");

        RPG.AddCharacterClass("Ranger");
        RPG.AddCharacterClass("Swordsman");
        RPG.AddCharacterClass("Shaman");
        RPG.AddCharacterClass("Cleric");

        ShooterImplementation shooter = new ShooterImplementation("Counter spike", "Пиу, пиу", 5);
        shooter.AddGun(new ShooterImplementation.Gun
        {
            Name = "AK-47",
            WeaponShop = 30,
            Recoil = 0.05f
        });
        shooter.AddGun(new ShooterImplementation.Gun
        {
            Name = "AK-72",
            WeaponShop = 30,
            Recoil = 0.03f
        });

        MOBAImplementation MOBA = new MOBAImplementation("DOKA2",
            "Возможности:\n"+
            "-Возможность вытаскивать кишки\n" +
            "- Можно убивать зомби\n" +
            "- Можно быть зомби\n" +
            "- Можно убивать людей самым изощренным способом\n" +
            "- Можно придумать свою определенную местность\n" +
            "- Можно трейд делать\n" +
            "- Специальное оружие для вытаскивания кишков в течении 10 минут\n",
            4,
            21,
            4);
        MOBA.AddClass("Paladin");
        MOBA.AddClass("Zombie");
        MOBA.AddClass("Zombie Killer");

        PuzzleImplementation puzzle = new PuzzleImplementation("world puzzle", "Собери по кусочкам", 100, 10, 10, 10);

        StrategyImplementation strategy = new StrategyImplementation("Sivilization","...","Монеты",6);

        strategy.AddUnit("Worker");
        strategy.AddUnit("Warior");
        strategy.AddUnit("Ranger");
        strategy.AddUnit("Сavalry");

        strategy.AddBuilding("Plain");
        strategy.AddBuilding("Monument");
        strategy.AddBuilding("Aqueduct");

        gameImps.Add(RPG);
        gameImps.Add(shooter);
        gameImps.Add(MOBA);
        gameImps.Add(strategy);
        gameImps.Add(puzzle);

        gameImps.ForEach((gi) => gi.Message());

        Console.ReadKey();
    }
}
