﻿using Enemies;
using System;

namespace Characrers
{
    public interface Character
        {
        int hp { get; set; }
        string Name { get; }
        bool IsAttackable { get; }
        void Attack(Enemies.Enemy enemy);
        void GetDamage(int damage);
    }
    public class WeakCharacter : Character
    {
        public bool IsAttackable => true;

        public string Name => "Jim";
        int _hp;
        public int hp { get => _hp; set => _hp = value; }

        public void Attack(Enemy enemy)
        {
            enemy.GetDamage(2);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("Ougth.. " + hp + -damage);
            hp -= damage;
        }
    }
    public class StrongCharacter : Character
    {
        public string Name => "Jerry";
        int _hp;
        public int hp { get => _hp; set => _hp = value; }
        public bool IsAttackable => true;

        public void Attack(Enemy enemy)
        {
            enemy.GetDamage(5);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("Ougth.. " + hp + -damage);
            hp -= damage;
        }
    }
    public class ImmortalCharacter : Character
    {
        public string Name => "Billy";
        int _hp;
        public int hp { get => _hp; set => _hp = value; }
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
