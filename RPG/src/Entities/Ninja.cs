using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " Jutsu Clones das Sombraaaaaaasss";
        }
    }
}