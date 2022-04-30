namespace GildedRoseKata
{
    public class ItemSulfuras : Item
    {
        public ItemSulfuras(int DiasParaVenderlo, int Calidad)
        {
            Nombre = "Sulfuras, Hand of Ragnaros";
            DiasParaVenderlo = DiasParaVenderlo;
            Calidad = Calidad;

        }
        public override void ActualizaCalidad()
        {
            if (Calidad <50)
            {
                Calidad += 1;
            }
        }
        public override void ActuaizarDiasParaVenderlo()
        {
            return;
        }
      
    }
}