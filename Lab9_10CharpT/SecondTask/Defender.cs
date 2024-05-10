using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.SecondTask
{
    internal class Defender
    {
        // Обробник події атаки
        public void OnAttack(object sender, AttackEventArgs e)
        {
            Console.WriteLine($"Defender takes {e.Damage} damage!");
            Console.WriteLine("Defender retaliates!");
            // Відповідь на атаку - контратака або інша дія
        }
    }
}
