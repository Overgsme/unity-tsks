using Characrers;
using System;
using System.Runtime.Serialization;

namespace Enemies
{
     interface Enemy
    {
        string Name { get; }
        bool IsAttackable { get; }
        void Attack(Characrers.Character character);
        void GetDamage(int damage);

        event EventHandler Destroy;
    }
    class Slime : Enemy
    {
        public string Name { get => "Slime"; }
        public bool IsAttackable => true;

        public event EventHandler Destroy;

        public void Attack(Character character)
        {
            character.GetDamage(1);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("ougth...");
        }
    }
    class Ork : Enemy
    {
        public string Name { get => "Ork"; }
        public bool IsAttackable => true;

        public event EventHandler Destroy;

        public void Attack(Character character)
        {
            character.GetDamage(5);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("ougth...");
        }
    }
    class Skeleton : Enemy
    {
        public string Name { get => "Skeleton"; }
        public bool IsAttackable => true;

        public event EventHandler Destroy;

        public void Attack(Character character)
        {
            character.GetDamage(10);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("ougth...");
        }
    }
}
