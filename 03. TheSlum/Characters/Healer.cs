using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Healer : Character, IHeal
    {
        public const int DefaultHealthPoints = 75;
        public const int DefaultHealingPoints = 60;
        public const int DefaultDefensehPoints = 50;
        public const int DefaultRange = 6;
        public int HealingPoints { get; set; }

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensehPoints, team, DefaultRange)
        {
            HealingPoints = DefaultHealingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(t => t != this && t.Team == this.Team).OrderBy(t => t.HealthPoints).FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return string.Format(
                "Name: {0}, Team: {2}, Health: {1}, Defense: {3}, Healing: {4}",
                this.Id,
                this.HealthPoints,
                this.Team,
                this.DefensePoints,
                this.HealingPoints);
        }
    }
}
