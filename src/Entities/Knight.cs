using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abstraindo_rpg_poo.src.Enum;

namespace abstraindo_rpg_poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, EnumTypeHero heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}