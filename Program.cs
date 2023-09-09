using System;
using abstraindo_rpg_poo.src.Entities;
using abstraindo_rpg_poo.src.Enum;

namespace abstraindo_rpg_poo;
public class Program
{
    static void Main(string[] args)
    {
        Knight arus = new("Arus", 10, EnumTypeHero.Guerreiro);
        Console.WriteLine(arus);
        Console.WriteLine(arus.Attack());

        Wizard wizard = new("Jenica", 22, EnumTypeHero.Mago); 
        Console.WriteLine(wizard);
        Console.WriteLine(wizard.Attack());
        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(10));
    }
}