using System;
using GameWorldLib.Models.Environment;
using GameWorldLib.Models.Items;

namespace GameWorldLib.Models.Characters
{
    public abstract class Creature
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public AttackItem AttackItem { get; set; }
        public DefenceItem DefenceItem { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Creature(string name, int hitPoints, int x, int y)
        {
            Name = name;
            Hitpoints = hitPoints;
            X = x;
            Y = y;
        }

        public void DoDamage(Creature enemy)
        {
            if (AttackItem != null)
            {
                int damage = AttackItem.Hit;
                enemy.ReceiveDamage(damage);
                Console.WriteLine($"{Name} attacked {enemy.Name} for {damage} damage");
            }
        }

        public void ReceiveDamage(int dmg)
        {
            if (DefenceItem != null)
            {
                dmg -= DefenceItem.ReduceHitpoints;
                dmg = Math.Max(dmg, 0); // Ensure damage doesn't go below 0
            }

            Hitpoints -= dmg;
            Console.WriteLine($"{Name} received {dmg} damage");

            if (Hitpoints <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Console.WriteLine($"{Name} is dead");
        }

        //public void Loot(WorldObj item)
        //{
        //    if (item is AttackItem attackItem)
        //    {
        //        AttackItem = attackItem;
        //        Console.WriteLine($"{Name} looted an attack item: {attackItem.Name}");
        //    }
        //    else if (item is DefenceItem defenceItem)
        //    {
        //        DefenceItem = defenceItem;
        //        Console.WriteLine($"{Name} looted a defence item: {defenceItem.Name}");
        //    }
        //}
    }
}
