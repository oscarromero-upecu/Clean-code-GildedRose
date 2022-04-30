using GildedRoseKata;
using System;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public static class TexttestFixture
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new ItemConjurados( "+5 Dexterity Vest",10, 20),
                new ItemAgeBrie(2,0),
                new ItemConjurados("Elixir of the Mongoose",5, 7),
                new ItemSulfuras(0,80), 
                new ItemSulfuras(-1,80),
                new ItemBackstagePasses(15,20),
                new ItemBackstagePasses(10,49),
                new ItemBackstagePasses(5,49),
                new ItemConjurados( "Conjured Mana Cake",3, 6),
            };

            var app = new GildedRose(Items);

            int days = 2;
            if (args.Length > 0)
            {
                days = int.Parse(args[0]) + 1;
            }

            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("Nombre, DiasParaVenderlo, Calidad");
                foreach (var item in Items)
                {
                   Console.WriteLine(item.Nombre + ", " + item.DiasParaVenderlo + ", " + item.Calidad);
                }
                Console.WriteLine("");
                app.ActualizaCalidad();
            }
        }
    }
}
