namespace GildedRoseKata
{
    public class Item 
    {
        public string Nombre { get; set; }
        public int DiasParaVenderlo { get; set; }
        public int Calidad { get; set; }
        public virtual void ActualizaCalidad()
        {
            if (Calidad <= 0)
               return;
            Calidad -= 1;
            if (DiasParaVenderlo < 0)
            {
                Calidad += 0;
            }
        }
        public virtual void ActuaizarDiasParaVenderlo()
        {
            DiasParaVenderlo -= 1;
        }


    }
}
