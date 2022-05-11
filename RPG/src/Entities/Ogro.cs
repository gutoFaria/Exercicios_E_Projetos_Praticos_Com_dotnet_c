using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Ogro : Enemy
    {
        public Ogro(string name, int attack, int defense, int magic) : base(name, attack, defense, magic)
        {
        }

        public override string ToString()
        {
            return this.Name + " Ataque de " + this.Attack + "  Defesa de " + this.Defense;
        }
    }
}