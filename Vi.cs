using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_AlexandraNoriega
{
    public class Vi: Character
    {
        private const string NAME = "Vi";
        private const int DAMAGE = 70;
        private const int HEALTH = 120;
        private const int STAMINA = 60;

        public Vi() : base(NAME, DAMAGE, HEALTH, STAMINA)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"´{name} punches with her gauntles, dealing {damage} damage");
        }
    }
}
