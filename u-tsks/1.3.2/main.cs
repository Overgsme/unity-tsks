

using System;
using System.Collections.Generic;

public static class Program
{
    public static void Main()
    {
        List<Enemies.Enemy> enemies = new List<Enemies.Enemy>();
        List<Characrers.Character> characrers = new List<Characrers.Character>();

        enemies.Add(new Enemies.Slime());
        characrers.Add(new Characrers.WeakCharacter());
        
        enemies.Add(new Enemies.Ork());
        characrers.Add(new Characrers.StrongCharacter());

        enemies.Add(new Enemies.Skeleton());
        characrers.Add(new Characrers.ImmortalCharacter());

        for (int i = 0; i < enemies.Count; i++)
        {
            Console.WriteLine(enemies[i].Name + " spawned!");
            Console.WriteLine(characrers[i].Name + " spawned!");

        }
        for (int i = 0; i < enemies.Count; i++) {
            enemies[i].Attack(characrers[i]);
        }
        for (int i = 0; i < characrers.Count; i++)
        {
            characrers[i].Attack(enemies[i]);
        }

        Console.ReadKey();
    }
}
