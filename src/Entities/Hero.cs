using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abstraindo_rpg_poo.src.Enum;

namespace abstraindo_rpg_poo.src.Entities
{
    public abstract class Hero
    {
        public Hero() {}

        public Hero(string name, int level, EnumTypeHero heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public EnumTypeHero HeroType { get; set; }

        public override string ToString()
        {
            return $"Nome : {this.Name} | Level: {this.Level} | Tipo Herói: {this.HeroType}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada";
        }
    }

}