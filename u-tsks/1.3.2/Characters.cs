using Enemies;
using System;

namespace Characrers
{
    interface Character
        {
        string Name { get; }
        bool IsAttackable { get; }
        void Attack(Enemies.Enemy enemy);
        void GetDamage(int damage);
    }
    class WeakCharacter : Character
    {
        public bool IsAttackable => true;

        public string Name => "Jim";

        public void Attack(Enemy enemy)
        {
            enemy.GetDamage(2);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("Ougth.. "+-damage);
        }
    }
    class StrongCharacter : Character
    {
        public string Name => "Jerry";

        public bool IsAttackable => true;

        public void Attack(Enemy enemy)
        {
            enemy.GetDamage(5);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("Ougth.. "+-damage);
        }
    }
    class ImmortalCharacter : Character
    {
        public string Name => "Billy";
        public bool IsAttackable => false;

        public void Attack(Enemy enemy)
        {
            enemy.GetDamage(15);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("HaHa.. -0");
        }
    }

}
