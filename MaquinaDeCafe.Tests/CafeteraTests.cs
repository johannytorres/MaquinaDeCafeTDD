using Xunit;

namespace MaquinaDeCafe.Tests
{
    public class CafeteraTests
    {
        [Fact]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.hasCafe(5);

            Assert.Equal(true, resultado);
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.hasCafe(11);

            Assert.Equal(false, resultado);
        }

        [Fact]
        public void DeberiaRestarCafeALaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.giveCafe(7);

            Assert.Equal(3, cafetera.getCantidadCafe());
        }
    }
}