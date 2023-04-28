using Enemies;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Program
{
    public static void Main()
    {
        List<Enemy> enemies = new List<Enemy>();
        enemies.Add(new Skeleton());
        enemies.Add(new Ork());
        enemies.Add(new Slime());
        Random r = new Random();
        enemies.ForEach((e) => e.hp = r.Next(20,100));

        PoisonEffect effect = new PoisonEffect(enemies);

        while (effect.damage != 0) effect.Tick();

        Dictionary<string,Enemy> enemyMap = new Dictionary<string,Enemy>();
        List<string> nameLst = new List<string> { "Tom", "Nick", "Jimmy", "Alfred", "Dima" };
        enemies.ForEach(e =>
        {
            int n = r.Next(0, nameLst.Count);
            enemyMap.Add(nameLst[n], e);
            nameLst.RemoveAt(n);
        });
        foreach (KeyValuePair<string, Enemy> entry in enemyMap)
        {
            Console.WriteLine(entry.Key + " is " + entry.Value.Name);
        }
        Console.ReadKey();
    }
    public class PoisonEffect
    {
        List<Enemy> enemies;
        public int damage = 5;
        public PoisonEffect(List<Enemy> enemies)
        {
            this.enemies = enemies;
            this.enemies.ForEach(e => e.Destroy+=OnEnemyDestroyed);
        }
        void OnEnemyDestroyed(object s,EventArgs e)
        {
            Console.WriteLine(((Enemy)s).Name+" destroyed");
            damage = 0;
        }
        public void Tick()
        {
            enemies.ForEach(e => { if (damage != 0) e.GetDamage(damage); });
        }
    }
}