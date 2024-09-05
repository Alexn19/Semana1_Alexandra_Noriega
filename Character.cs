using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_AlexandraNoriega
{
    public abstract class Character
    {
        public string name;
        public int damage;
        public int health;
        public int stamina;
        public Character(string name, int damage, int health, int stamina)
        {
            this.name = name;
            this.damage = damage;
            this.health = health;
            this.stamina = stamina;
        }

        public abstract void Attack();

        public void TakeDamage(int damage)
        {
            health = health - damage;
        }
    }
}
