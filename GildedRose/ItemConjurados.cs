using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class ItemConjurados: Item
    {
        public ItemConjurados(string Nombre,int DiasParaVenderlo, int Calidad)
        {
            DiasParaVenderlo = DiasParaVenderlo;
            Calidad = Calidad;

        }
        public override void ActualizaCalidad()
        {
            if (Nombre == "+5 Dexterity Vest" ||
                Nombre == "Elixir of the Mongoose" ||
                Nombre== "Conjured Mana Cake" &&
                Calidad <= 50)
                Calidad -= 2;


        }
        public override void ActuaizarDiasParaVenderlo()
        {
            return;
        }
    }
}
