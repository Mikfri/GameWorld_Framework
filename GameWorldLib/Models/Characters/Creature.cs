using System;
using GameWorldLib.Models.Environment;
using GameWorldLib.Models.Items;
using GameWorldLib.Models.PowerUps;
using GameWorldLib.TraceAndLogg;

namespace GameWorldLib.Models.Characters
{
    public abstract class Creature : ICreature
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int CurrentHitpoints { get; set; }
        public bool Dead { get; set; } = false;

        public int XCordinate { get; set; }
        public int YCordinate { get; set; }

        public AttackItem AttackItem { get; set; }
        public DefenceItem DefenceItem { get; set; }
        public FoodItem FoodItem { get; set; }

        public Creature(string name, int hitPoints, int xCord, int yCord)
        {
            Name = name;
            Hitpoints = hitPoints;
            XCordinate = xCord;
            YCordinate = yCord;
        }

        public void DoDamage(Creature enemy)
        {
            if (AttackItem != null)
            {
                int damage = AttackItem.Power;
                enemy.ReceiveDamage(damage);
                GameLog.Log($"{Name} attacked {enemy.Name} for {damage} damage");
            }
        }

        public void ReceiveDamage(int dmg)
        {
            if (DefenceItem != null)
            {
                dmg -= DefenceItem.Power;
                dmg = Math.Max(dmg, 0); // Ensure damage doesn't go below 0
            }

            CurrentHitpoints -= dmg; // Subtract damage from CurrentHitpoints instead of Hitpoints
            GameLog.Log($"{Name} received {dmg} damage");

            if (CurrentHitpoints <= 0) // Check if CurrentHitpoints is less than or equal to 0
            {
                Dead = true;
            }
        }

        public void Loot(WorldObj item)
        {
            if (item is AttackItem attackItem)
            {
                AttackItem = attackItem;
            }
            else if (item is DefenceItem defenceItem)
            {
                DefenceItem = defenceItem;
            }
        }
    }
}
