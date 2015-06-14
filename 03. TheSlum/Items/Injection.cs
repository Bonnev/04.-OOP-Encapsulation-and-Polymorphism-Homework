using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    class Injection : Bonus
    {
        public const int DefaultHealthEffect = 200;
        public const int DefaultDefenseEffect = 0;
        public const int DefaultAttackEffect = 0;
        public const int DefaultTimeout = 3;
        
        public Injection(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            Timeout = DefaultTimeout;
            Countdown = Timeout;
            HasTimedOut = false;
        }
    }
}
