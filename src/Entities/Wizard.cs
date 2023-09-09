using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abstraindo_rpg_poo.src.Enum;

namespace abstraindo_rpg_poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, EnumTypeHero heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com sua magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return $"{this.Name} lançou uma magia superefetiva com bonus de {Bonus}";    
            }
            else
            {
                return $"{this.Name} lançou magina com força fraca com bonus de ataque {Bonus}";
            }
        }
    }
}