using Characrers;
using System;
using System.Runtime.Serialization;

namespace Enemies
{
     public interface Enemy
    {
        int hp { get; set; }
        string Name { get; }
        bool IsAttackable { get; }
        void Attack(Characrers.Character character);
        void GetDamage(int damage);

        event EventHandler Destroy;
    }
    public class Slime : Enemy
    {
        int _hp;
        public int hp { get => _hp; set => _hp = value; }
        public string Name { get => "Slime"; }
        public bool IsAttackable => true;

        public event EventHandler Destroy;

        public void Attack(Character character)
        {
            character.GetDamage(1);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("ougth..." + hp + -damage);
            hp -= damage;
            if (hp <= 0) Destroy.Invoke(this, new EventArgs());
        }
    }
    public class Ork : Enemy
    {
        int _hp;
        public int hp { get => _hp; set => _hp = value; }
        public string Name { get => "Ork"; }
        public bool IsAttackable => true;

        public event EventHandler Destroy;

        public void Attack(Character character)
        {
            character.GetDamage(5);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("ougth..." + hp + -damage);
            hp -= damage;
            if(hp <=0)Destroy.Invoke(this, new EventArgs());
        }
    }
    public class Skeleton : Enemy
    {
        int _hp;
        public int hp { get => _hp; set => _hp = value; }
        public string Name { get => "Skeleton"; }
        public bool IsAttackable => true;

        public event EventHandler Destroy;

        public void Attack(Character character)
        {
            character.GetDamage(10);
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine("ougth... "+hp+-damage);
            hp -= damage;
            if (hp <= 0) Destroy.Invoke(this, new EventArgs());
        }
    }
}
