using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Enemy
    {
        public string Name { get; set; } = String.Empty;
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }

        public Enemy(string name,int attack,int defense,int magic)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
            this.Magic = magic;
        }
    }
}