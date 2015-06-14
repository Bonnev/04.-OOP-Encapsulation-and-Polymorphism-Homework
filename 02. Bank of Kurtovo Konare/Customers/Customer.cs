using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    abstract class Customer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException();
                name = value;
            }
        }

        protected Customer(string name)
        {
            Name = name;
        }
    }
}
