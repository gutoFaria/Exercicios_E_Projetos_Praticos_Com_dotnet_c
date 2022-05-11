using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " Lançou uma magia";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
                return this.Name + " Lançou uma magia forte:ataque de " + bonus;
            else
                return this.Name + " Lançou uma magia fraca " + bonus;
            
        }
        
    }
}