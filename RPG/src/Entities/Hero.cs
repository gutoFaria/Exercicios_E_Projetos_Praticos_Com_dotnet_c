using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; } = String.Empty;
        public int Level { get; set; }
        public string HeroType { get; set; } = String.Empty;

        public Hero(string name,int level,string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public void HeroPrint()
        {
            Console.WriteLine("Name Hero: "+ this.Name+"    "+"Level: "+this.Level+"      "+"Hero type: "+this.HeroType);
        }

        //método virtual para sobreescrever
        public virtual string Attack()
        {
            return this.Name + "Atacou com sua espada";
        }

        public override string ToString()
        {
            return $"Name:{this.Name}  Level:{this.Level}   Hero Type:{this.HeroType}";
        }


    }
}