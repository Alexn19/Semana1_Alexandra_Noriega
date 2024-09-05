using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_AlexandraNoriega
{
    public class Jinx : Character
    {
        private const string NAME = "Jinx";
        private const int DAMAGE = 50;
        private const int HEALTH = 100;
        private const int STAMINA = 80;

        public Jinx() : base(NAME, DAMAGE, HEALTH, STAMINA)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"´{name} throws a rocket, dealing {damage} damage");
        }
    }
}
