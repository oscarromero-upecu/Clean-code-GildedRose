namespace GildedRoseKata
{
    public class ItemBackstagePasses : Item
    {
        public ItemBackstagePasses(int DiasParaVenderlo, int Calidad)
        {
            Nombre = "Backstage passes to a TAFKAL80ETC concert";
            DiasParaVenderlo = DiasParaVenderlo;
            Calidad = Calidad;

        }

        public override void ActualizaCalidad()
        {
            if (DiasParaVenderlo < 0)
            {
                Calidad = 0;
            }
            else if (Calidad < 50) 
            Calidad += 1;
            if (DiasParaVenderlo < 11)
                Calidad += 1;
            if (DiasParaVenderlo < 6)
                Calidad += 1;
            
        }
    }
}
