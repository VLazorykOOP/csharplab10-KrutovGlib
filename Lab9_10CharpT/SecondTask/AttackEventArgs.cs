using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.SecondTask
{
    internal class AttackEventArgs : EventArgs
    {
        public int Damage { get; }

        public AttackEventArgs(int damage)
        {
            Damage = damage;
        }
    }
}
