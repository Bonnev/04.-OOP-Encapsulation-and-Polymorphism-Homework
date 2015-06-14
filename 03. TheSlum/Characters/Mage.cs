using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Mage : Character, IAttack
    {
        public const int DefaultHealthPoints = 150;
        public const int DefaultAttackPoints = 300;
        public const int DefaultDefensehPoints = 50;
        public const int DefaultRange = 5;
        public int AttackPoints { get; set; }

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensehPoints, team, DefaultRange)
        {
            AttackPoints = DefaultAttackPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(t => t != this && t.IsAlive && t.Team != this.Team);
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

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            return string.Format(
                "Name: {0}, Team: {2}, Health: {1}, Defense: {3}, Attack: {4}",
                this.Id,
                this.HealthPoints,
                this.Team,
                this.DefensePoints,
                this.AttackPoints);
        }
    }
}
