using Xunit;

namespace MaquinaDeCafe.Tests
{
    public class AzucareroTests
    {
        Azucarero azuquero;

        public AzucareroTests()
        {
            azuquero = new Azucarero(10);
        }

        [Fact]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
        {
            Assert.Equal(true, azuquero.hasAzucar(5));
            Assert.Equal(true, azuquero.hasAzucar(10));
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoHaySuficienteAzucar()
        {
            Assert.Equal(false, azuquero.hasAzucar(15));
        }

        [Fact]
        public void DeberiaRestarAzucarAlAzucarero()
        {
            azuquero.giveAzucar(5);
            Assert.Equal(5, azuquero.getCantidadAzucar());

            azuquero.giveAzucar(2);
            Assert.Equal(3, azuquero.getCantidadAzucar());
        }
    }
}