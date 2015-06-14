using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    class Pill : Bonus
    {
        public const int DefaultHealthEffect = 0;
        public const int DefaultDefenseEffect = 0;
        public const int DefaultAttackEffect = 100;
        public const int DefaultTimeout = 1;

        public Pill(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            Timeout = DefaultTimeout;
            Countdown = Timeout;
            HasTimedOut = false;
        }
    }
}
