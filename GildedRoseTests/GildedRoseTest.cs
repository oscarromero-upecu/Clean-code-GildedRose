using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        private readonly Calidad _calidad;

        public GildedRoseTest(Calidad calidad)
        {
            _calidad = calidad;
        }

        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Nombre = "foo", DiasParaVenderlo = 0, Calidad = 0 } };
            _calidad.ActualizaCalidad();
            Assert.Equal("fixme", Items[0].Nombre);
        }
    }
}
