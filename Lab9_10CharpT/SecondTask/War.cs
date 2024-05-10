using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.SecondTask
{
    internal class War
    {
        public void Fight()
        {
            Attacker attacker = new Attacker();
            Defender defender = new Defender();

            // Підписка на подію атаки
            attacker.Attack += defender.OnAttack;

            // Симуляція бойової дії
            attacker.PerformAttack();

            Console.ReadLine();
        }
    }
}
