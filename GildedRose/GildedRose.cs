using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose : Calidad
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void ActualizaCalidad()
        {
            foreach (var item in Items)
            {
                item.ActualizaCalidad();
                item.ActuaizarDiasParaVenderlo();
            }
        }

    }
}
