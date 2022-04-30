namespace GildedRoseKata
{
    public class ItemAgeBrie : Item
    {
        public ItemAgeBrie(int DiasParaVenderlo, int Calidad)
        {
            Nombre = "Age Brie";
            DiasParaVenderlo = DiasParaVenderlo;
            Calidad = Calidad;

        }

        public override void ActualizaCalidad()
        {
            if (Calidad >= 50) return;
                Calidad += 1;
            if (DiasParaVenderlo < 0)
                Calidad += 1;
        }
    
    }
}
