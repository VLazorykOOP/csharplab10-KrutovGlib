using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.SecondTask
{
    internal class Attacker
    {
        // Подія атаки
        public event EventHandler<AttackEventArgs> Attack;

        // Метод для виклику події атаки
        public void PerformAttack()
        {
            Console.WriteLine("Attacker attacks!");
            Attack?.Invoke(this, new AttackEventArgs(10)); // Наприклад, 10 - це шкода від атаки
        }
    }
}
